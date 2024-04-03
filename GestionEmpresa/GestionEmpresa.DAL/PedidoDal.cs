using GestionEmpresa.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GestionEmpresa.DAL
{
    public class PedidoDal
    {
        public DataTable ListarPedidosDal()
        {
            string consulta = "SELECT PEDIDO.IDPEDIDO, CLIENTE.NOMBRE +' '+ CLIENTE.APELLIDO AS NOMBRE, " +
                                     "PEDIDO.FECHA, PEDIDO.TOTAL " +
                              "FROM CLIENTE INNER JOIN " +
                                                 "PEDIDO ON CLIENTE.IDCLIENTE = PEDIDO.IDCLIENTE";

            return Conexion.EjecutarDataTabla(consulta, "Consulta");
        }

        public DataTable ListarPedidosXClienteDal(int id)
        {
            string consulta = "SELECT PEDIDO.IDPEDIDO, PEDIDO.FECHA, PEDIDO.TOTAL, PEDIDO.ESTADO " +
                              "FROM CLIENTE INNER JOIN " +
                                        "PEDIDO ON CLIENTE.IDCLIENTE = PEDIDO.IDCLIENTE " +
                              "WHERE CLIENTE.IDCLIENTE = " + id;

            return Conexion.EjecutarDataTabla(consulta, "Consulta");
        }

        public DataTable ListarTotalPedidosXClienteDal(int id)
        {
            string consulta = "SELECT CLIENTE.NOMBRE + ' ' + CLIENTE.APELLIDO AS NOMBRE, " +
                                     "COUNT(PEDIDO.IDPEDIDO) AS CANTIDAD_PEDIDOS , SUM(PEDIDO.TOTAL) AS MONTO_TOTAL " +
                              "FROM CLIENTE INNER JOIN " +
                                                    "PEDIDO ON CLIENTE.IDCLIENTE = PEDIDO.IDCLIENTE " +
                              "WHERE CLIENTE.IDCLIENTE = " + id +
                              "GROUP BY CLIENTE.NOMBRE + ' ' + CLIENTE.APELLIDO";

            return Conexion.EjecutarDataTabla(consulta, "Consulta");
        }

        public void InsertarPedidoDal(Pedido pedido)
        {
            string consulta = "insert into pedido values(" + pedido.IdCliente + "," +
                                                         "'" + pedido.Fecha + "'," +
                                                         "" + pedido.Total + "," +
                                                         "'" + pedido.Estado + "')";
            Conexion.Ejecutar(consulta);

        }

        public Pedido ObtenerPedidoId(int id)
        {
            string consulta = "select * from pedido where idPedido = " + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "asdas");
            Pedido pedido = new Pedido();
            if (tabla.Rows.Count > 0)
            {
                pedido.IdPedido = Convert.ToInt32(tabla.Rows[0]["idPedido"]);
                pedido.IdCliente = Convert.ToInt32(tabla.Rows[0]["idCliente"]);
                pedido.Fecha = Convert.ToDateTime(tabla.Rows[0]["fecha"]);
                pedido.Total = Convert.ToDecimal(tabla.Rows[0]["total"]);
                pedido.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return pedido;
        }

        public void EditarPedidoDal(Pedido pedido)
        {
            string consulta = "update pedido set idCliente =" + pedido.IdCliente + "," +
                                                 "fecha ='" + pedido.Fecha + "'," +
                                                 "total =" + pedido.Total + "," +
                                                 "estado ='" + pedido.Estado + "'" +
                                    "where idPedido=" + pedido.IdPedido ;

            Conexion.Ejecutar(consulta);
        }

        public void EliminarPedidoDal(int id)
        {
            string consulta = "delete from pedido where idPedido =" + id;
            Conexion.Ejecutar(consulta);
        }
    }
}
