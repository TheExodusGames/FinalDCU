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
    public class ServicioMedicos
    {
        private MedicosRepository repository;
        public ServicioMedicos(SqlConnection connection)
        {
            repository = new MedicosRepository(connection);
        }

        public bool Add(Medico item)
        {
            return repository.Add(item);
        }

        public bool Edit(Medico item)
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

        public Medico GetById(int id)
        {
            return repository.GetByID(id);
        }

        public DataTable GetAll()
        {
            return repository.GetAll();

        }
    }
}
