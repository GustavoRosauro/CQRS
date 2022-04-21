using Cadastro.Domain;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Infraestructure
{
    public class UsuarioRepository:IUsuarioRepository
    {
        private readonly MySqlConnection _conn;
        private readonly MySqlTransaction? _trans;
        public UsuarioRepository(MySqlConnection conn, MySqlTransaction? trans)
        {
            _conn = conn;
            _trans = trans;
        }
        public void InserirUsuario(Usuario usuario)
        {
            var usuarioDto = new UsuarioDTO()
            {
                Nome = usuario.Nome,
                Ambiente = usuario.Ambiente
            };
            string sqlInsert = "insert into usuario (nome,ambiente) values (@nome,@ambiente)";
            using (var command = new MySqlCommand(sqlInsert, _conn,_trans))
            {
                command.Parameters.Add(new MySqlParameter("@nome",usuarioDto.Nome));
                command.Parameters.Add(new MySqlParameter("@ambiente",usuarioDto.Ambiente));
                command.ExecuteNonQuery();
            }
        }
    }
}
