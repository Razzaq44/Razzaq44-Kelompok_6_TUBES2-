﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransferrUang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            long JumlahSaldo, NoRekTujuan;

            JumlahSaldo = long.Parse(textBox1.Text);
            NoRekTujuan = long.Parse(textBox2.Text);
            MessageBox.Show("Jumlah Saldo:" + JumlahSaldo + "\nNo Rek Tujuan:" + NoRekTujuan);
        }
    }
}
