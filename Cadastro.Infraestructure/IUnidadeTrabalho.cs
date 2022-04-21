using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Infraestructure
{
    public interface IUnidadeTrabalho
    {
        void AbrirConexao();
        IUsuarioRepository UsuarioRepository { get; }
        void FecharConexao();
        void AbrirTransacao();
        void Commit();
    }
}
