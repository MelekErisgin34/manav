﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            lstListe.Items.Add(txtMeyve.Text);
            txtMeyve.Text = " ";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            lstListe.Items.Clear();
        }

        private void btnSeçilenisil_Click(object sender, EventArgs e)
        {
            lstListe.Items.Remove(lstListe.SelectedItem);
        }
    }
}
