using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade5
{
    public partial class Form1 : Form
    {
        int numero, resultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChecar_Click(object sender, EventArgs e)
        {
            numero = Convert.ToInt32(txtNumero.Text);

            if (numero % 2 == 1)
            {
                MessageBox.Show(numero + " é IMPAR");
            }
            else
            {
                MessageBox.Show(numero + " é PAR");
            }
        }
    }
}
