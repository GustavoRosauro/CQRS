using Cadastro.Contracts;
using Cadastro.Domain;
using Cadastro.Infraestructure;

namespace Cadastro.Command
{
    public class SalvarUsuarioCommand:Command
    {
        private readonly IUnidadeTrabalho? _unidade;
        public SalvarUsuarioCommand(IUnidadeTrabalho? unidade)
        { 
            _unidade = unidade; 
        }
        public override void Handle(object objeto)
        {
            var usuarioContract = (UsuarioContract)objeto;
            var usuario = new Usuario(usuarioContract.Nome,usuarioContract.Ambiente);
            _unidade.AbrirConexao();
            _unidade.AbrirTransacao();
            if (usuario.ValidarAmbiente())
                _unidade.UsuarioRepository.InserirUsuario(usuario);
            else
                throw new ArgumentException("Ambiente não é cadastrado");
            _unidade.Commit();
        }
    }
}