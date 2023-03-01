﻿using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using System;
using System.Windows.Forms;

namespace XPOHanaWinTestApp
{
    public partial class Form1 : Form
    {
        private static Session _session;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_session == null)
                {
                    Connect();
                    btnConectar.Enabled = false;
                }
                else
                    btnConectar.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Connect()
        {
            var sqlConn = HanaConnectionProvider.GetConnectionString(
                txtServidor.Text.Trim(), 
                Convert.ToInt32(txtPorta.Text.Trim()),
                txtUsuarioBanco.Text.Trim(),
                txtSenhaBanco.Text.Trim(),
                txtSchema.Text.Trim());

            _session = new Session(XpoDefault.GetDataLayer(sqlConn, AutoCreateOption.SchemaAlreadyExists));
        }

        private void btnExecutarSelectAny_Click(object sender, EventArgs e)
        {

        }
    }
}
