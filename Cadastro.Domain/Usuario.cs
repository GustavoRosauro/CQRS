namespace Cadastro.Domain
{
    public class Usuario
    {
        public string Nome { get; private set; }
        public string Ambiente { get; private set; }

        private IEnumerable<string> _ambientes = new List<string>()
        {
            "desenvolvimento",
            "teste"
        };
        public Usuario(string nome, string ambiente)
        {
            if (string.IsNullOrEmpty(nome.Trim()))
                throw new ArgumentException("Nome não informado");
            if (string.IsNullOrEmpty(ambiente.Trim()))
                throw new ArgumentException("Ambiente não informado");
            Nome = nome;
            Ambiente = ambiente;
        }
        public bool ValidarAmbiente()
        {
            return _ambientes.Contains(Ambiente.ToLower());
        }
    }
}