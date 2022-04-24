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
    public class CitasRepository
    {
        private SqlConnection _connection;
        public CitasRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public bool Add(Cita item)
        {

            SqlCommand command = new SqlCommand("insert into Citas(Id_Pacientes, Id_Medico, FechayHora, Causa, Estado) values(@idpacientes,@idmedicos,@fechayhora,@causa,@estado)", _connection);
            command.Parameters.AddWithValue("@idpacientes", item.Id_Pacientes);
            command.Parameters.AddWithValue("@idmedicos", item.Id_Medico);
            command.Parameters.AddWithValue("@fechayhora", item.FechayHora);
            command.Parameters.AddWithValue("@causa", item.Causa);
            command.Parameters.AddWithValue("@estado", item.Estado);

            return executeDml(command);

        }

        public bool Edit(Cita item)
        {
            SqlCommand command = new SqlCommand("update Citas set Estado=@estado where id=@id", _connection);
            command.Parameters.AddWithValue("@estado", item.Estado);
            command.Parameters.AddWithValue("@id", item.id);

            return executeDml(command);
        }

        public bool Delete(int id)
        {
            SqlCommand command = new SqlCommand("delete Citas where id = @id", _connection);
            command.Parameters.AddWithValue("@id", id);

            return executeDml(command);
        }


        public Cita GetByID(int id)
        {

                _connection.Open();

                SqlCommand command = new SqlCommand("Select Id, Id_Pacientes, Id_Medico, FechayHora, Causa, Estado from Citas where id = @id", _connection);



                command.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = command.ExecuteReader();

                Cita data = new Cita();

                while (reader.Read())
                {
                    data.id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    data.Id_Pacientes = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
                    data.Id_Medico = reader.IsDBNull(2) ? 0 : reader.GetInt32(2);
                    data.FechayHora = reader.IsDBNull(3) ? DateTime.Now : reader.GetDateTime(3);
                    data.Estado = reader.IsDBNull(4) ? "" : reader.GetString(4);
                }

                reader.Close();
                reader.Dispose();

                _connection.Close();

                return data;
            }



        public DataTable GetAll()
        {
            SqlDataAdapter query = new SqlDataAdapter("Select Id, Id_Pacientes, Id_Medico, FechayHora, Causa, Estado from Citas", _connection);
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

        public int EstadodeCita(int id)
        {
            int EstadodeCitaa = 0;
                _connection.Open();
                SqlCommand cmd = new SqlCommand("Select Id, Estado from Citas where id=@id", _connection);
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                    if (dt.Rows[0][1].ToString() == "1")
                    {
                         EstadodeCitaa = 1;
                    }
                    else if (dt.Rows[0][1].ToString() == "2")
                    {
                        EstadodeCitaa = 2;
                    }
                    else if (dt.Rows[0][1].ToString() == "2")
                    {
                        EstadodeCitaa = 3;
                    }
            _connection.Close();
            return EstadodeCitaa;

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
