using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Database.Modelos;
using Database;
using System.Data;

namespace BusinessLayer
{
    public class ServicioPacientes
    {
        private PacientesRepository repository;
        public ServicioPacientes(SqlConnection connection)
        {
            repository = new PacientesRepository(connection);
        }

        public bool Add(Paciente item)
        {
            return repository.Add(item);
        }

        public bool Edit(Paciente item)
        {
            return repository.Edit(item);
        }

        public bool Delete(int id)
        {
            return repository.Delete(id);
        }

        public bool SavePhoto(int id, string destination)
        {
            return repository.SavePhoto(id, destination);
        }

        public int GetLastId()
        {
            return repository.GetLastId();
        }

        public Paciente GetById(int id)
        {
            return repository.GetByID(id);
        }

        public DataTable GetAll()
        {
            return repository.GetAll();

        }
    }
}
