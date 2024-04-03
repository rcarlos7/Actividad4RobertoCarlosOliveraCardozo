using GestionEmpresa.BSS;
using GestionEmpresa.MODELOS;
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
    public partial class PedidoEditarVista : Form
    {
        int idx = 0;
        int idc = 0;
        Pedido pedido = new Pedido();
        PedidoBss bss = new PedidoBss();
        Cliente cliente = new Cliente();
        ClienteBss bsscliente = new ClienteBss();
        public PedidoEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void PedidoEditarVista_Load(object sender, EventArgs e)
        {
            pedido = bss.ObtenerPedidoIdBss(idx);
            idc = pedido.IdCliente;
            cliente = bsscliente.ObtenerClienteIdBss(idc);

            label5.Text = cliente.Nombre + ' ' + cliente.Apellido;
            dateTimePicker1.Value = pedido.Fecha;
            textBox2.Text = Convert.ToString(pedido.Total);
            textBox3.Text = pedido.Estado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pedido.IdCliente = idc;
            pedido.Fecha = dateTimePicker1.Value;
            pedido.Total = Convert.ToDecimal(textBox2.Text);
            pedido.Estado = textBox3.Text;

            bss.EditarPedidoBss(pedido);
            MessageBox.Show("Datos Actualizados");
        }
    }
}
