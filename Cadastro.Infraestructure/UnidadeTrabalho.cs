using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Infraestructure
{
    public class UnidadeTrabalho : IUnidadeTrabalho
    {
        private readonly string _conn;
        private MySqlConnection _mysqlConn;
        private MySqlTransaction? _trans;
        private IUsuarioRepository? _usuarioRepository;
        public UnidadeTrabalho(string conn)
        {
            _conn = conn;
            _mysqlConn = new MySqlConnection(_conn);            
        }

        public IUsuarioRepository UsuarioRepository
        {
            get 
            {
                _usuarioRepository = new UsuarioRepository(_mysqlConn,_trans);
                return _usuarioRepository;
            }
        }

        public void AbrirConexao()
        {
            _mysqlConn.Open();
        }

        public void AbrirTransacao()
        {
            _trans = _mysqlConn.BeginTransaction();
        }

        public void Commit()
        {
            _trans.Commit();
        }

        public void FecharConexao()
        {
            _mysqlConn.Close();
        }
    }
}
