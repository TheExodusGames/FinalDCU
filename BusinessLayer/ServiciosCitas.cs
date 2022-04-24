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
    public class ServiciosCitas
    {

        private CitasRepository repository;
        public ServiciosCitas(SqlConnection connection)
        {
            repository = new CitasRepository(connection);
        }

        public bool Add(Cita item)
        {
            return repository.Add(item);
        }

        public bool Edit(Cita item)
        {
            return repository.Edit(item);
        }

        public bool Delete(int id)
        {
            return repository.Delete(id);
        }

        public Cita GetById(int id)
        {
            return repository.GetByID(id);
        }

        public DataTable GetAll()
        {
            return repository.GetAll();

        }

        public int EstadodeCita(int id)
        {
            return repository.EstadodeCita(id);
        }
    }
}
