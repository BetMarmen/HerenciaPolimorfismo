using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjVentaHeredada
{
    public partial class frmContado : Form
    {
        //Inicializació´n del arreglo de produvtos
        static string[] productos =
        {
            "Lavadora",
            "Refrigeradora",
            "Licuadora",
            "Extractora",
            "Radiograbadora",
            "DVD",
            "BlueRay"
        };
        //variable acumuladora de totales
        double tsubtotal = 0;
        public frmContado()
        {
            InitializeComponent();
        }

        private void frmContado_Load(object sender, EventArgs e)
        {
            cboProducto.DataSource = productos;
            MostrarFecha();
            MostrarHora();
            lblMonto.Text = "0.00";

        }

        private void MostrarHora()
        {
            lblHora.Text = DateTime.Now.ToShortTimeString();

        }

        private void MostrarFecha()
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

       

        private void btnAdquirir_Click(object sender, EventArgs e)
        {
            //Objeto de la clase Contado
            Contado objC = new Contado();
            //datos del Cliente
            objC.Cliente = txtCliente.Text;
            objC.RUC = txtRuc.Text;
            objC.fecha=DateTime.Parse(lblFecha.Text);
            objC.Hora= DateTime.Parse(lblHora.Text);
            //datos del producto
            objC.Producto = cboProducto.Text;
            objC.Cantidad= int.Parse(txtCantidad.Text);
            //Imprimiendo en la lista
            ListViewItem fila = new ListViewItem(objC.GetN().ToString());
            fila.SubItems.Add(objC.Producto);
            fila.SubItems.Add(objC.Cantidad.ToString());
            fila.SubItems.Add(objC.AsignaPrecio().ToString("C"));
            fila.SubItems.Add(objC.CalculaSubtotal().ToString());
            lvDetalle.Items.Add(fila);
            Listado(objC);
        }

        private void Listado(Contado objC)
        {
            tsubtotal+=objC.CalculaSubtotal();
            lstrResumen.Items.Clear();
            lstrResumen.Items.Add("**RESUMEN DE VENTA**");
            lstrResumen.Items.Add("---------------------------------");
            lstrResumen.Items.Add($"CLIENTE:{objC.Cliente}");
            lstrResumen.Items.Add($"RUC:{objC.RUC}");
            lstrResumen.Items.Add($"FECHA:{objC.fecha}");
            lstrResumen.Items.Add($"HORA:{objC.Hora}");
            lstrResumen.Items.Add("---------------------------------");
            lstrResumen.Items.Add($"SUBTOTAL:{tsubtotal.ToString("C")}");
            double descuento = objC.CalculaDescuento(tsubtotal);
            double neto= objC.CalculaNeto(tsubtotal,descuento);
            lstrResumen.Items.Add($"DESCUENTO:{descuento.ToString("C")}");
            lstrResumen.Items.Add($"NETO:{neto.ToString("C")}");
            lblMonto.Text=neto.ToString("C");

        }
    }
}
