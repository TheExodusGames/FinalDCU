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
    public class ServicioResultadosLab
    {
        private ResultLabRepository repository;
        public ServicioResultadosLab(SqlConnection connection)
        {
            repository = new ResultLabRepository(connection);
        }

        public bool Add(ResultadoPrueba item)
        {
            return repository.Add(item);
        }

        public bool Edit(ResultadoPrueba item)
        {
            return repository.Edit(item);
        }

        public bool Delete(int id)
        {
            return repository.Delete(id);
        }

        public ResultadoPrueba GetById(int id)
        {
            return repository.GetByID(id);
        }

        public DataTable GetAll()
        {
            return repository.GetAll();

        }

        public int estadodeResultados(int id)
        {
            return repository.estadodeResultados(id);
        }
    }
}
