using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadesGiovan
{
    public partial class Atividade2 : Form
    {
        string nome;

        public Atividade2()
        {
            InitializeComponent();
        }

        private void txtInsirirNome_TextChanged(object sender, EventArgs e)
        {
            nome = txtInsirirNome.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Boa Noite " + nome);
        }
    }
}
