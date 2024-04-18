using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comparendos
{
    public partial class Tienda : Form
    {
        public Tienda()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Tienda_Load(object sender, EventArgs e)
        {
            inicializarVariables();
            mostrarValores();   
        }

        private void cnbTienda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        int cantidad, valorCompra, precio1 = 5000, precio2 = 15000, precio3 = 12500;
        int ventasTienda1, ventasTienda2, ventasTienda3, ventasArticulo1, ventasArticulo2, ventasArticulo3, ventasTotales;

        private void inicializarVariables()
        {
            cantidad = 0; valorCompra = 0;
            ventasTienda1 = 0; ventasTienda2 = 0; ventasTienda3 = 0;
            ventasArticulo1 = 0; ventasArticulo2 = 0; ventasArticulo3 = 0;
            ventasTotales = 0;
        }

        private void mostrarValores()
        {
            txtTienda1.Text=ventasTienda1.ToString();
            txtTienda2.Text=ventasTienda2.ToString();   
            txtTienda3.Text=ventasTienda3.ToString();
            txtArt1.Text=ventasArticulo1.ToString();
            txtArt2.Text=ventasArticulo2.ToString();
            txtArt3.Text=ventasArticulo3.ToString();
            txtVentasTotales.Text=ventasTotales.ToString();
            txtValorCompra.Text=valorCompra.ToString(); 

        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            cantidad = int.Parse(txtCantidad.Text);
            switch (cnbArticulo.SelectedIndex) {
            case 0:
                    valorCompra = cantidad * precio1;
                    ventasArticulo1 += valorCompra;
                    break;
                    case 1:
                    valorCompra= cantidad * precio2;
                    ventasArticulo2 += valorCompra;
                    break;
                    case 2:
                    valorCompra=cantidad * precio3; 
                    ventasArticulo3 += valorCompra;
                    break;
            }
            switch(cnbTienda.SelectedIndex)
            {
                case 0:
                    ventasTienda1 += valorCompra;
                    break;
                    case 1:
                    ventasTienda2 += valorCompra;
                    break;
                    case 2:
                    ventasTienda3 += valorCompra;   
                    break;
            }
            ventasTotales = ventasTienda1 + ventasTienda2 + ventasTienda3;
            mostrarValores();
        }
    }
}
