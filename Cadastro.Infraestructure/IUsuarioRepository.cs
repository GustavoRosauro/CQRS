using Cadastro.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Infraestructure
{
    public interface IUsuarioRepository
    {
        void InserirUsuario(Usuario usuario);
    }
}
