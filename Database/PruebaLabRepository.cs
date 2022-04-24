using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Database.Modelos;
using System.Data;

namespace Database
{
    public class PruebaLabRepository
    {
        private SqlConnection _connection;
        public PruebaLabRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public bool Add(PruebasLab item)
        {

            SqlCommand command = new SqlCommand("insert into [Pruebas de Laboratorio](Nombre) values(@nombre)", _connection);
            command.Parameters.AddWithValue("@nombre", item.Nombre);

            return executeDml(command);

        }

        public bool Edit(PruebasLab item)
        {
            SqlCommand command = new SqlCommand("update [Pruebas de Laboratorio] set Nombre=@nombre where id=@id", _connection);
            command.Parameters.AddWithValue("@nombre", item.Nombre);
            command.Parameters.AddWithValue("@id", item.id);

            return executeDml(command);
        }

        public bool Delete(int id)
        {
            SqlCommand command = new SqlCommand("delete [Pruebas de Laboratorio] where id = @id", _connection);
            command.Parameters.AddWithValue("@id", id);

            return executeDml(command);
        }

        public PruebasLab GetByID(int id)
        {
            try
            {
                _connection.Open();

                SqlCommand command = new SqlCommand("Select Id, Nombre from [Pruebas de Laboratorio] where Id = @id", _connection);



                command.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = command.ExecuteReader();

                PruebasLab data = new PruebasLab();

                while (reader.Read())
                {
                    data.id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    data.Nombre = reader.IsDBNull(1) ? "" : reader.GetString(1);
                }

                reader.Close();
                reader.Dispose();

                _connection.Close();

                return data;
            }
            catch (Exception e)
            {
                return null;
            }

        }

        public DataTable GetAll()
        {
            SqlDataAdapter query = new SqlDataAdapter("Select Id, Nombre from [Pruebas de Laboratorio]", _connection);
            return LoadData(query);
        }

        private DataTable LoadData(SqlDataAdapter query)
        {
            try
            {
                DataTable data = new DataTable();

                _connection.Open();

                query.Fill(data);

                _connection.Close();

                return data;

            }
            catch (Exception e)
            {
                return null;
            }
        }

        private bool executeDml(SqlCommand query)
        {
            try
            {

                _connection.Open();
                query.ExecuteNonQuery();
                _connection.Close();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}