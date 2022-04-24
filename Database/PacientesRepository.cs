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
    public class PacientesRepository
    {
        private SqlConnection _connection;
        public PacientesRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public bool Add(Paciente item)
        {

            SqlCommand command = new SqlCommand("insert into Pacientes(Nombre, Apellido, Telefono, Direccion, Cedula, FechaNacimiento, Fumador, Alergias) values(@nombre,@apellido,@tel,@direccion,@cedula,@fechanac,@fumador,@alergias)", _connection);
            command.Parameters.AddWithValue("@nombre", item.Nombre);
            command.Parameters.AddWithValue("@apellido", item.Apellido);
            command.Parameters.AddWithValue("@tel", item.Telefono);
            command.Parameters.AddWithValue("@direccion", item.Direccion);
            command.Parameters.AddWithValue("@cedula", item.Cedula);
            command.Parameters.AddWithValue("@fechanac", item.FechaNacimiento);
            command.Parameters.AddWithValue("@fumador", item.Fumador);
            command.Parameters.AddWithValue("@alergias", item.Alergias);

            return executeDml(command);

        }

        public bool Edit(Paciente item)
        {
            SqlCommand command = new SqlCommand("update Pacientes set Nombre=@nombre, Apellido=@apellido, Telefono=@tel, Direccion=@direccion, Cedula=@cedula, FechaNacimiento=@fechanac, Fumador=@fumador, Alergias=@alergias where id=@id", _connection);
            command.Parameters.AddWithValue("@nombre", item.Nombre);
            command.Parameters.AddWithValue("@apellido", item.Apellido);
            command.Parameters.AddWithValue("@tel", item.Telefono);
            command.Parameters.AddWithValue("@direccion", item.Direccion);
            command.Parameters.AddWithValue("@cedula", item.Cedula);
            command.Parameters.AddWithValue("@fechanac", item.FechaNacimiento);
            command.Parameters.AddWithValue("@fumador", item.Fumador);
            command.Parameters.AddWithValue("@alergias", item.Alergias);
            command.Parameters.AddWithValue("@id", item.id);

            return executeDml(command);
        }

        public bool Delete(int id)
        {
            SqlCommand command = new SqlCommand("delete Pacientes where id = @id", _connection);
            command.Parameters.AddWithValue("@id", id);

            return executeDml(command);
        }

        public int GetLastId()
        {
            int lastId = 0;

            _connection.Open();

            SqlCommand command = new SqlCommand("select max(Id) as Id from Pacientes", _connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
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
            SqlCommand command = new SqlCommand("update Pacientes set Foto=@photo where id=@id", _connection);
            command.Parameters.AddWithValue("@photo", destination);
            command.Parameters.AddWithValue("@id", id);

            return executeDml(command);
        }
        public Paciente GetByID(int id)
        {

                _connection.Open();

                SqlCommand command = new SqlCommand("Select Id, Nombre, Apellido, Telefono, Direccion, Cedula, FechaNacimiento, Fumador, Alergias, Foto from Pacientes where Id = @id", _connection);



                command.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = command.ExecuteReader();

                Paciente data = new Paciente();

                while (reader.Read())
                {
                    data.id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    data.Nombre = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    data.Apellido = reader.IsDBNull(2) ? "" : reader.GetString(2);
                    data.Telefono = reader.IsDBNull(3) ? "" : reader.GetString(3);
                    data.Direccion = reader.IsDBNull(4) ? "" : reader.GetString(4);
                    data.Cedula = reader.IsDBNull(5) ? "" : reader.GetString(5);
                    data.FechaNacimiento = reader.IsDBNull(6) ? DateTime.Now : reader.GetDateTime(6);
                    data.Fumador = reader.IsDBNull(7) ? false : reader.GetBoolean(7);
                    data.Alergias = reader.IsDBNull(8) ? "" : reader.GetString(8);
                    data.Foto = reader.IsDBNull(9) ? "" : reader.GetString(9);
                }

                reader.Close();
                reader.Dispose();

                _connection.Close();

                return data;
            }

        public DataTable GetAll()
        {
            SqlDataAdapter query = new SqlDataAdapter("Select Id, Nombre, Apellido, Telefono, Direccion, Cedula, FechaNacimiento, Fumador, Alergias, Foto from Pacientes", _connection);
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
