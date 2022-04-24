using Database;
using Database.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
namespace BusinessLayer
{
    public class ServicioTipoUsers
    {
        private TipoUserRepository _repository;

        public ServicioTipoUsers(SqlConnection connection)
        {
            _repository = new TipoUserRepository(connection);
        }

        public List<TipoUsuario> GetList()
        {
            return _repository.GetList();
        }
    }
}
