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
    public class LoginRepository
    {
        private SqlConnection _connection;
        public LoginRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public bool Add(Login item)
        {

            SqlCommand command = new SqlCommand("insert into Usuarios(Nombre, Apellido, Correo, Usuario, Clave, TipoUsuario) values(@nombre,@apellido,@correo,@user,@clave,@tipousuario)", _connection);
            command.Parameters.AddWithValue("@nombre", item.Nombre);
            command.Parameters.AddWithValue("@apellido", item.Apellido);
            command.Parameters.AddWithValue("@correo", item.Correo);
            command.Parameters.AddWithValue("@user", item.User);
            command.Parameters.AddWithValue("@clave", item.Clave);
            command.Parameters.AddWithValue("@tipousuario", item.TipoUsuario);

            return executeDml(command);

        }

        public bool Edit(Login item)
        {
            SqlCommand command = new SqlCommand("update Usuarios set Nombre=@nombre, Apellido=@apellido, Correo=@correo, Usuario=@user, Clave=@clave, TipoUsuario=@tipousuario where id=@id", _connection);
            command.Parameters.AddWithValue("@nombre", item.Nombre);
            command.Parameters.AddWithValue("@apellido", item.Apellido);
            command.Parameters.AddWithValue("@correo", item.Correo);
            command.Parameters.AddWithValue("@user", item.User);
            command.Parameters.AddWithValue("@clave", item.Clave);
            command.Parameters.AddWithValue("@tipousuario", item.TipoUsuario);
            command.Parameters.AddWithValue("@id", item.id);

            return executeDml(command);
        }

        public bool Delete(int id)
        {
            SqlCommand command = new SqlCommand("delete Usuarios where id = @id", _connection);
            command.Parameters.AddWithValue("@id", id);

            return executeDml(command);
        }

        public Login GetByID(int id)
        {
            try
            {
                _connection.Open();

                SqlCommand command = new SqlCommand("Select c.Id,c.Nombre,c.Apellido,c.Correo, c.Usuario,c.Clave, ct.Name as TipoContacto from Usuarios c join UserType ct on c.TipoUsuario = ct.Id where c.Id = @id", _connection);



                command.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = command.ExecuteReader();

                Login data = new Login();

                while (reader.Read())
                {
                    data.id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    data.Nombre = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    data.Apellido = reader.IsDBNull(2) ? "" : reader.GetString(2);
                    data.Correo = reader.IsDBNull(3) ? "" : reader.GetString(3);
                    data.User = reader.IsDBNull(4) ? "" : reader.GetString(4);
                    data.Clave = reader.IsDBNull(5) ? "" : reader.GetString(5);
                    data.TipoUsuario = reader.IsDBNull(6) ? "" : reader.GetString(6);
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

        /*
        public bool Existe(string Nick)
        {
            try
            {
                _connection.Open();
                SqlCommand command = new SqlCommand("Select Usuario from Usuarios where Usuario = @usuarios", _connection);
                command.Parameters.AddWithValue("@usuarios", Nick);
                command.CommandType = CommandType.Text;
                SqlDataAdapter reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    return true;
                }
                else
                {
                    _connection.Close();
                    return false;
                }
            }catch(Exception e)
            {
                return false;
            }
            }
        }
        */

        public DataTable GetAll()
        {
            SqlDataAdapter query = new SqlDataAdapter("Select c.Id,c.Nombre,c.Apellido,c.Correo, c.Usuario,c.Clave, ct.Name as TipoContacto from Usuarios c join UserType ct on c.TipoUsuario = ct.Id", _connection);
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
