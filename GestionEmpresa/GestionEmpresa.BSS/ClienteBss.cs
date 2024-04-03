using GestionEmpresa.DAL;
using GestionEmpresa.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmpresa.BSS
{
    public class ClienteBss
    {
        ClienteDal dal = new ClienteDal();
        public DataTable ListarClientesBss()
        {
            return dal.ListarClientesDal();
        }

        public void InsertarClienteBss(Cliente cliente)
        {
            dal.InsertarClienteDal(cliente);
        }

        public Cliente ObtenerClienteIdBss(int id)
        {
            return dal.ObtenerClienteId(id);
        }

        public void EditarClienteBss(Cliente cliente)
        {
            dal.EditarClienteDal(cliente);
        }

        public void EliminarClienteBss(int id)
        {
            dal.EliminarClienteDal(id);
        }
    }
}
