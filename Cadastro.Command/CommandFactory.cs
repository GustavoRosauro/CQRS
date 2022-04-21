using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Command
{
    public class CommandFactory : ICommandFactory
    {
        public void Process(Command command, object objeto)
        {
            command.Handle(objeto);
        }
    }
}
