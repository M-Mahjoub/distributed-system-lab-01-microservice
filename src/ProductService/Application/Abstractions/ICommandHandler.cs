using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstractions
{
    public interface ICommandHandler<TCommand> 
        where TCommand : ICommand
    {
        Task Handle(TCommand command); 
    }
}
