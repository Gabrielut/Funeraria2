﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTN.Winform.Funeraria.UI.Reportes
{
    public partial class frmReportePaquete : Form
    {
        public frmReportePaquete()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}