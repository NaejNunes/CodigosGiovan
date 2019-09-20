using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade8
{
    public partial class Form1 : Form
    {
        Int32[] numero = new Int32[4];
        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (numero[0] == 1)
            {
                numero[1] = Convert.ToInt32(txtNumeros.Text); //Menor
                numero[2] = Convert.ToInt32(txtNumeros.Text); //Maior

                label2.Text = numero[2].ToString();
                label3.Text = numero[1].ToString();
            }

            numero[3] = Convert.ToInt32(txtNumeros.Text);
           
            //Analize maior
            if (numero[2] < numero[3])
                numero[2] = numero[3];

            if (numero[1] > numero[3])
                numero[1] = numero[3];

            label2.Text = numero[2].ToString();
            label3.Text = numero[1].ToString();

            numero[0]++;
        }

        //load
        private void Form1_Load(object sender, EventArgs e)
        {
            numero[0] = 1;
        }
    }
}
