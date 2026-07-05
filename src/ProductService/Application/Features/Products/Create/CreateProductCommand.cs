using Application.Abstractions;

namespace Application.Features.Products.Create
{
    public class CreateProductCommand : ICommand
    {
        public string Name { get; set; }
        public string SKU { get; set; }
        public decimal Price { get; set; }
        public string Currency { get; set; }
    }
}
