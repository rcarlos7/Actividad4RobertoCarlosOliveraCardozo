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

namespace GestionEmpresa.VISTA.PedidoVistas
{
    public partial class InformeListarVista : Form
    {
        public InformeListarVista()
        {
            InitializeComponent();
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

        private void button4_Click(object sender, EventArgs e)
        {
            ClienteListarVista fr = new ClienteListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Cliente cliente = bsscliente.ObtenerClienteIdBss(IdClienteSeleccionado);
                textBox2.Text = cliente.Nombre + " " + cliente.Apellido;
            }
        }

        PedidoBss bsspedido = new PedidoBss();
        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = bsspedido.ListarPedidosXClienteBss(IdClienteSeleccionado);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = bsspedido.ListarTotalPedidosXClienteBss(IdClienteSeleccionado);
        }
    }
}
