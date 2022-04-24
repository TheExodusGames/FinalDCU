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
    public class MedicosRepository
    {
        private SqlConnection _connection;
        public MedicosRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public bool Add(Medico item)
        {

            SqlCommand command = new SqlCommand("insert into Medicos(Nombre, Apellido, Correo, Telefono, Cedula) values(@nombre,@apellido,@correo,@tel,@cedula)", _connection);
            command.Parameters.AddWithValue("@nombre", item.Nombre);
            command.Parameters.AddWithValue("@apellido", item.Apellido);
            command.Parameters.AddWithValue("@correo", item.Correo);
            command.Parameters.AddWithValue("@tel", item.Telefono);
            command.Parameters.AddWithValue("@cedula", item.Cedula);

            return executeDml(command);

        }

        public bool Edit(Medico item)
        {
            SqlCommand command = new SqlCommand("update Medicos set Nombre=@nombre, Apellido=@apellido, Correo=@correo, Telefono=@tel, Cedula=@cedula where id=@id", _connection);
            command.Parameters.AddWithValue("@nombre", item.Nombre);
            command.Parameters.AddWithValue("@apellido", item.Apellido);
            command.Parameters.AddWithValue("@correo", item.Correo);
            command.Parameters.AddWithValue("@tel", item.Telefono);
            command.Parameters.AddWithValue("@cedula", item.Cedula);
            command.Parameters.AddWithValue("@id", item.id);

            return executeDml(command);
        }

        public bool Delete(int id)
        {
            SqlCommand command = new SqlCommand("delete Medicos where id = @id", _connection);
            command.Parameters.AddWithValue("@id", id);

            return executeDml(command);
        }

        public int GetLastId()
        {
            int lastId = 0;

            _connection.Open();

            SqlCommand command = new SqlCommand("select max(Id) as Id from Medicos", _connection);

            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                lastId = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
            }

            reader.Close();
            reader.Dispose();

            _connection.Close();

            return lastId;
        }

        public bool SavePhoto(int id, string destination)
        {
            SqlCommand command = new SqlCommand("update Medicos set Foto=@photo where id=@id", _connection);
            command.Parameters.AddWithValue("@photo", destination);
            command.Parameters.AddWithValue("@id", id);

            return executeDml(command);
        }
        public Medico GetByID(int id)
        {
            try
            {
                _connection.Open();

                SqlCommand command = new SqlCommand("Select Id, Nombre, Apellido, Correo, Telefono, Cedula, Foto from Medicos where id = @id", _connection);



                command.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = command.ExecuteReader();

                Medico data = new Medico();

                while (reader.Read())
                {
                    data.id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    data.Nombre = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    data.Apellido = reader.IsDBNull(2) ? "" : reader.GetString(2);
                    data.Correo = reader.IsDBNull(3) ? "" : reader.GetString(3);
                    data.Telefono = reader.IsDBNull(4) ? "" : reader.GetString(4);
                    data.Cedula = reader.IsDBNull(5) ? "" : reader.GetString(5);
                    data.Foto = reader.IsDBNull(6) ? "" : reader.GetString(6);
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
            SqlDataAdapter query = new SqlDataAdapter("Select Id, Nombre, Apellido, Correo, Telefono, Cedula, Foto from Medicos", _connection);
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
