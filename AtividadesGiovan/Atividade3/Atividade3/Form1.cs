using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade3
{   
    public partial class Form1 : Form
    {
        string nome;

        int ano, resultadoSoma;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            nome = txtInsiraNome.Text;

            ano = Convert.ToInt32(txtAnoNascimento.Text);

            resultadoSoma = 2019 - ano;

            MessageBox.Show(nome + " tem " + resultadoSoma);
        }
    }
}
