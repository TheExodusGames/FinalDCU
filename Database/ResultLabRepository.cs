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
    public class ResultLabRepository
    {
        private SqlConnection _connection;
        public ResultLabRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public bool Add(ResultadoPrueba item)
        {

            SqlCommand command = new SqlCommand("insert into [Resultados de Laboratorio](Id_Paciente, Id_Cita, Id_PruebaLab, Id_Medico, EstadoPrueba) values(@idpacientes,@idcita,@idpruebalab,@idmedico,@estadoresult )", _connection);
            command.Parameters.AddWithValue("@idpacientes", item.Id_Pacientes);
            command.Parameters.AddWithValue("@idcita", item.Id_Cita);
            command.Parameters.AddWithValue("@idpruebalab", item.Id_PruebaLab);
            command.Parameters.AddWithValue("@idmedico", item.Id_Medico);
            command.Parameters.AddWithValue("@estadoresult", item.Estadoresult);    

            return executeDml(command);

        }

        public bool Edit(ResultadoPrueba item)
        {
            SqlCommand command = new SqlCommand("update [Resultados de Laboratorio] set ResultadosPrueba=@resultados where id = @id", _connection);
            command.Parameters.AddWithValue("@resultados", item.Resultados);
            command.Parameters.AddWithValue("@id", item.id);

            return executeDml(command);
        }

        public bool Delete(int id)
        {
            SqlCommand command = new SqlCommand("delete [Resultados de Laboratorio] where id = @id", _connection);
            command.Parameters.AddWithValue("@id", id);

            return executeDml(command);
        }


        public ResultadoPrueba GetByID(int id)
        {
            try
            {
                _connection.Open();

                SqlCommand command = new SqlCommand("Select Id, Id_Paciente, Id_Cita, Id_PruebaLab, Id_Medico, ResultadosPrueba, EstadoPrueba from [Resultados de Laboratorio] where id = @id", _connection);



                command.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = command.ExecuteReader();

                ResultadoPrueba data = new ResultadoPrueba();

                while (reader.Read())
                {
                    data.id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    data.Id_Pacientes = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
                    data.Id_Cita = reader.IsDBNull(2) ? 0 : reader.GetInt32(2);
                    data.Id_PruebaLab = reader.IsDBNull(3) ? 0 : reader.GetInt32(3);
                    data.Id_Medico = reader.IsDBNull(4) ? 0 : reader.GetInt32(4);
                    data.Resultados = reader.IsDBNull(5) ? "" : reader.GetString(5);
                    data.Estadoresult = reader.IsDBNull(6) ? "" : reader.GetString(6);
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
            SqlDataAdapter query = new SqlDataAdapter("Select Id, Id_PruebaLab, ResultadosPrueba, EstadoPrueba from [Resultados de Laboratorio]", _connection);

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

        public int estadodeResultados(int id)
        {
            int estadodeResultadoss = 0;
            _connection.Open();
            SqlCommand cmd = new SqlCommand("Select Id, Estado from [Resultados de Laboratorio] where id=@id", _connection);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][1].ToString() == "1")
            {
                estadodeResultadoss = 1;
            }
            else if (dt.Rows[0][1].ToString() == "2")
            {
                estadodeResultadoss = 2;
            }
            else if (dt.Rows[0][1].ToString() == "2")
            {
                estadodeResultadoss = 3;
            }
            _connection.Close();
            return estadodeResultadoss;

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
