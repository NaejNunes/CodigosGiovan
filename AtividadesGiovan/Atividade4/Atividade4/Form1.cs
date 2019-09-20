using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade4
{
    public partial class Form1 : Form
    {
        int numero1, numero2, resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToInt32(txtPrimeiroNumero.Text);
            numero2 = Convert.ToInt32(txtSegundoNumero.Text);

            resultado = numero1 + numero2;

            MessageBox.Show(numero1 + " + " + numero2 + "= " + resultado);
        }
    }
}
