using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SistemaLegado
{
    public class DataBase : IDataBase
    {
        public Usuario ObterUsuario(int id)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "servidor.database.servidordaminhapp.net";
            builder.UserID = "lazaro";
            builder.Password = "12345678";
            builder.InitialCatalog = "db_producao";

            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT TOP 1 * ");
                sb.Append("FROM Usuario ");
                sb.Append($"Where Id = {id};");
                String sql = sb.ToString();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return new Usuario
                            {
                                Id = reader.GetInt32(0),
                                Nome = reader.GetString(1)
                            };
                        }
                    }
                }
            }

            return null;
        }

        public void Salvar(ICheckin checkin, Unidade unidade, Usuario usuario)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "servidor.database.servidordaminhapp.net";
            builder.UserID = "lazaro";
            builder.Password = "12345678";
            builder.InitialCatalog = "db_producao";

            using (SqlConnection con = new SqlConnection(builder.ToString()))
            {
                con.Open();
                string sql = "INSERT INTO checkin VALUES(@unidade,@usuario)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@unidade", SqlDbType.Int).Value = unidade.Id;
                cmd.Parameters.Add("@usuario", SqlDbType.Int).Value = usuario.Id;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }
    }
}