using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int n1, n2, resultado;

            n1 = Convert.ToInt32(txtN1.Text);
            n2 = Convert.ToInt32(txtN2.Text);

            resultado = n1 + n2;

            txtResultado.Text = "" + resultado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1, n2, resultado;

            n1 = Convert.ToInt32(txtN1.Text);
            n2 = Convert.ToInt32(txtN2.Text);
            resultado = n1 - n2;

            txtResultado.Text = "" + resultado;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n1, n2, resultado;

            n1 = Convert.ToInt32(txtN1.Text);
            n2 = Convert.ToInt32(txtN2.Text);
            resultado = n1 * n2;

            txtResultado.Text = "" + resultado;
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            int n1, n2, resultado;

            n1 = Convert.ToInt32(txtN1.Text);
            n2 = Convert.ToInt32(txtN2.Text);

            resultado = n1 / n2;

            txtResultado.Text = "" + resultado;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtN1.Clear();
            txtN2.Clear();
            txtResultado.Clear();
        }

        private void btnAleatorio_Click(object sender, EventArgs e)
        {

            txtResultado.Clear();

            Random aleaterio = new Random();
            int numero1, numero2;

            numero1 = aleaterio.Next(1, 11);
            numero2 = aleaterio.Next(1, 11);

            txtN1.Text = Convert.ToString(numero1);
            txtN2.Text = Convert.ToString(numero2);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
