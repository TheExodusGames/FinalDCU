using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Database.Modelos;
namespace Database
{
    public class TipoUserRepository
    {
        private SqlConnection _connection;
        public TipoUserRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public List<TipoUsuario> GetList()
        {
            try
            {
                List<TipoUsuario> list = new List<TipoUsuario>();
                _connection.Open();

                SqlCommand command = new SqlCommand("Select Id,Name from UserType", _connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new TipoUsuario
                    {
                        Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                        Name = reader.IsDBNull(1) ? "" : reader.GetString(1),
                    });
                }

                reader.Close();
                reader.Dispose();

                _connection.Close();

                return list;

            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
