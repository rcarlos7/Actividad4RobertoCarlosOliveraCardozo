using GestionEmpresa.BSS;
using GestionEmpresa.MODELOS;
using GestionEmpresa.VISTA.ClienteVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionEmpresa.VISTA.PedidoVistas
{
    public partial class PedidoInsertarVista : Form
    {
        public PedidoInsertarVista()
        {
            InitializeComponent();
        }

        PedidoBss bss = new PedidoBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            pedido.IdCliente = IdClienteSeleccionado;
            pedido.Fecha = dateTimePicker1.Value;
            pedido.Total = Convert.ToDecimal(textBox2.Text);
            pedido.Estado = textBox3.Text;

            bss.InsertarPedidoBss(pedido);
            MessageBox.Show("Se guardo correctamente el Pedido");
        }

        public static int IdClienteSeleccionado = 0;
        ClienteBss bsscliente = new ClienteBss();
        private void button3_Click(object sender, EventArgs e)
        {
            ClienteListarVista fr = new ClienteListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Cliente cliente = bsscliente.ObtenerClienteIdBss(IdClienteSeleccionado);
                textBox1.Text = cliente.Nombre + " " + cliente.Apellido;
            }
        }
    }
}
