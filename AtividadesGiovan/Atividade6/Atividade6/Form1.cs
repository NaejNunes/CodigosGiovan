using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade6
{
    public partial class Form1 : Form
    {
        public int[] numeros = new int[3];
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            numeros[1] = Convert.ToInt16(txtNumero1.Text);
            numeros[2] = Convert.ToInt16(txtNumero2.Text);

            numeros[0] = numeros[1] + numeros[2];

            MessageBox.Show(numeros[1] + " + " + numeros[2] + "= " + numeros[0]);
        }
    }
}
