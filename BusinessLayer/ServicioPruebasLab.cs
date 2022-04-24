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
    public class ServicioPruebasLab
    {
        private PruebaLabRepository repository;
        public ServicioPruebasLab(SqlConnection connection)
        {

            repository = new PruebaLabRepository(connection);
        }

        public bool Add(PruebasLab item)
        {
            return repository.Add(item);
        }

        public bool Edit(PruebasLab item)
        {
            return repository.Edit(item);
        }

        public bool Delete(int id)
        {
            return repository.Delete(id);
        }

        public PruebasLab GetById(int id)
        {
            return repository.GetByID(id);
        }

        public DataTable GetAll()
        {
            return repository.GetAll();

        }
    }
}
