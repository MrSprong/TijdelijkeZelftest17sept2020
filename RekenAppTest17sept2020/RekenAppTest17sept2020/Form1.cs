﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RekenAppTest17sept2020
{
    public partial class Form1 : Form
    {
        string textTspr = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoTspr_Click(object sender, EventArgs e)
        {
            textTspr = Convert.ToString(txbTextTspr.Text);
            MessageBox.Show(textTspr);
        }
    }
}
