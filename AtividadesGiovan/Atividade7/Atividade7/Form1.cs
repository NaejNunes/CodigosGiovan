﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade7
{
    public partial class Form1 : Form
    {
        int[] numeros = new int[6];

        int recebeRandom;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerarNumeros_Click(object sender, EventArgs e)
        {
            /*for (int i = 0; i < 5; i++)
            {
                MessageBox.Show(i.ToString());
            }*/
            Random recebeRandom = new Random();
            for (int i = 0; i < 6; i++) 
            {
                //MessageBox.Show("teste");
                

                numeros[i] = recebeRandom.Next(0, 60);

                lblNumeros.Text += i.ToString() + " = " + Convert.ToString(numeros[i]) + "\n";
            }
        }
    }
}
