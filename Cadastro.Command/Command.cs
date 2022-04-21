using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Command
{
    public abstract class Command
    {
        public virtual void Handle(object objeto)
        { }
    }
}
