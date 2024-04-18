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
    public partial class Comparendos : Form
    {
        public Comparendos()
        {
            InitializeComponent();
        }

        string placa;
        int velocidad;
        int multa;
        int cantInf1, cantInf2, cantInf3, cantInf4;
        int totalInf1, totalInf2, totalInf3, totalInf4;
        int promInf1, promInf2, promInf3, promInf4;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void inicializarVariables()
        {
            cantInf1 = 0; cantInf2 = 0; cantInf3 = 0; cantInf4 = 0;
            totalInf1 = 0; totalInf2 = 0; totalInf3 = 0; totalInf4 = 0;
            promInf1 = 0; promInf2 = 0; promInf3 = 0; promInf4 = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void mostrarValores()
        {
            txtInfra1.Text = cantInf1.ToString();
            txtInfra2.Text = cantInf2.ToString();
            txtInfra3.Text = cantInf3.ToString();
            txtInfra4.Text = cantInf4.ToString();
            txtProm1.Text=promInf1.ToString();
            txtProm2.Text=promInf2.ToString();
            txtProm3.Text=promInf3.ToString();
            txtProm4.Text=promInf4.ToString();
            txtTotal1.Text=totalInf1.ToString();
            txtTotal2.Text=totalInf2.ToString();
            txtTotal3.Text=totalInf3.ToString();
            txtTotal4.Text=totalInf4.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inicializarVariables();
            mostrarValores();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            placa=txtPlaca.Text;
            velocidad=int.Parse(txtVelocidad.Text);
            if (velocidad > 80)
            {
                multa = (velocidad - 80) * 2000;
                dgbMultas.Rows.Add(placa,velocidad,"80 km/h",multa);

                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        cantInf1 ++;
                        totalInf1=totalInf1 + multa;
                        promInf1 = totalInf1 / cantInf1;
                        break;

                        case 1:
                        cantInf2 ++;
                        totalInf2=totalInf2 + multa;
                        promInf2=totalInf2 / cantInf2;
                        break;
                        case 2:
                        cantInf3 ++;
                        totalInf3=totalInf3 + multa;
                        promInf3 = totalInf3 / cantInf3;
                        break;
                        case 3:
                        cantInf4 ++;
                        totalInf4=totalInf4 + multa;
                        promInf4 = totalInf4 / cantInf4;
                        break;

                }
                mostrarValores();
            }
            else
            {
                MessageBox.Show("La velocidad no genera multas");
            }

        }
    }
}
