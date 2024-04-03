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
    public class PedidoBss
    {
        PedidoDal dal = new PedidoDal();
        public DataTable ListarPedidosBss()
        {
            return dal.ListarPedidosDal();
        }

        public DataTable ListarPedidosXClienteBss(int id)
        {
            return dal.ListarPedidosXClienteDal(id);
        }

        public DataTable ListarTotalPedidosXClienteBss(int id)
        {
            return dal.ListarTotalPedidosXClienteDal(id);
        }

        public void InsertarPedidoBss(Pedido pedido)
        {
            dal.InsertarPedidoDal(pedido);
        }

        public Pedido ObtenerPedidoIdBss(int id)
        {
            return dal.ObtenerPedidoId(id);
        }

        public void EditarPedidoBss(Pedido pedido)
        {
            dal.EditarPedidoDal(pedido);
        }

        public void EliminarPedidoBss(int id)
        {
            dal.EliminarPedidoDal(id);
        }
    }
}
