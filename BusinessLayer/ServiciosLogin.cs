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
    public class ServiciosLogin
    {
        private LoginRepository repository;
        public ServiciosLogin(SqlConnection connection)
        {

            repository = new LoginRepository(connection);
        }

        public bool Add(Login item)
        {
            return repository.Add(item);
        }

        public bool Edit(Login item)
        {
            return repository.Edit(item);
        }

        public bool Delete(int id)
        {
            return repository.Delete(id);
        }

        public Login GetById(int id)
        {
            return repository.GetByID(id);
        }

        public DataTable GetAll()
        {
            return repository.GetAll();

        }
    }
}
