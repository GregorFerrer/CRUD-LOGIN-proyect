﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngresoTienda
{

    public partial class Form1 : Form
    {
        Query qr = new Query();

        public Form1()
        {
            InitializeComponent();
            textBox1.Text = ("11111");
            textBox2.Text = ("carlsen");

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            qr.IniciarSesion(textBox1.Text, textBox2.Text);
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
