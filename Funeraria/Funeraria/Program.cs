﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Winform.Funeraria.UI;

static class Program
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        frmLogin ofrmLogin = new frmLogin();
        ofrmLogin.ShowDialog();
        if (ofrmLogin.DialogResult == DialogResult.OK)
           Application.Run(new frmPrincipal());
        //frmPrincipal ofrmPrincipal = new frmPrincipal();
        //ofrmPrincipal.ShowDialog();

    }

}


