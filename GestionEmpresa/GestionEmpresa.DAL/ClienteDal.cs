using GestionEmpresa.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmpresa.DAL
{
    public class ClienteDal
    {
        public DataTable ListarClientesDal()
        {
            string consulta = "select * from cliente";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }

        public void InsertarClienteDal(Cliente cliente)
        {
            string consulta = "insert into cliente values('" + cliente.Nombre + "'," +
                                                         "'" + cliente.Apellido + "'," +
                                                         "'" + cliente.CorreoElectronico + "'," +
                                                         "'" + cliente.Telefono + "'," +
                                                         "'" + cliente.Direccion + "')";
            Conexion.Ejecutar(consulta);

        }

        public Cliente ObtenerClienteId(int id)
        {
            string consulta = "select * from cliente where idcliente = " + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "asdas");
            Cliente cliente = new Cliente();
            if (tabla.Rows.Count > 0)
            {
                cliente.IdCliente = Convert.ToInt32(tabla.Rows[0]["idCliente"]);
                cliente.Nombre = tabla.Rows[0]["nombre"].ToString();
                cliente.Apellido = tabla.Rows[0]["apellido"].ToString();
                cliente.CorreoElectronico = tabla.Rows[0]["correoElectronico"].ToString();
                cliente.Telefono = tabla.Rows[0]["telefono"].ToString();
                cliente.Direccion = tabla.Rows[0]["direccion"].ToString();
            }
            return cliente;
        }

        public void EditarClienteDal(Cliente cliente)
        {
            string consulta = "update cliente set nombre ='" + cliente.Nombre + "'," +
                                                 "apellido ='" + cliente.Apellido + "'," +
                                                 "correoElectronico ='" + cliente.CorreoElectronico + "'," +
                                                 "telefono ='" + cliente.Telefono + "'," +
                                                 "direccion ='" + cliente.Direccion + "' " +
                                    "where idcliente =" + cliente.IdCliente;

            Conexion.Ejecutar(consulta);
        }

        public void EliminarClienteDal(int id)
        {
            string consulta = "delete from cliente where idcliente =" + id;
            Conexion.Ejecutar(consulta);
        }
    }
}
