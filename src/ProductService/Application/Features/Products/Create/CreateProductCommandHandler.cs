using Application.Abstractions;
using Application.Abstractions.Repositories;
using Domain.Aggregates.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Products.Create
{
    public class CreateProductCommandHandler : ICommandHandler<CreateProductCommand>
    {
        private IProductRepository _productRepository { get; set; }
        private IDomainEventDispatcher _domainEventDispatcher { get; set; }
        private IUnitOfWork _unitOfWork { get; set; }

        public CreateProductCommandHandler(IProductRepository _productRepository,
            IDomainEventDispatcher _domainEventDispatcher,
            IUnitOfWork unitOfWork)
        {
            this._productRepository = _productRepository;
            this._unitOfWork = unitOfWork;
            this._domainEventDispatcher = _domainEventDispatcher;
        }
        public async Task Handle(CreateProductCommand command)
        {
            var product = new Product(command.Name, command.SKU, command.Currency, command.Price);
            await _productRepository.AddAsync(product);
            await _unitOfWork.CommitAsync();

            await _domainEventDispatcher.DispatchAsync(product.DomainEvents);

        }
    }
}
