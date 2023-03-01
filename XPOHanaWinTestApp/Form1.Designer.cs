namespace XPOHanaWinTestApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSenhaSap = new System.Windows.Forms.TextBox();
            this.txtUsuarioSap = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSenhaBanco = new System.Windows.Forms.TextBox();
            this.txtUsuarioBanco = new System.Windows.Forms.TextBox();
            this.txtCompanyDb = new System.Windows.Forms.TextBox();
            this.txtServidorLicenca = new System.Windows.Forms.TextBox();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboVersaoSql = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSenhaSap
            // 
            this.txtSenhaSap.Location = new System.Drawing.Point(143, 231);
            this.txtSenhaSap.Name = "txtSenhaSap";
            this.txtSenhaSap.PasswordChar = '*';
            this.txtSenhaSap.Size = new System.Drawing.Size(176, 20);
            this.txtSenhaSap.TabIndex = 34;
            this.txtSenhaSap.Text = "mana";
            // 
            // txtUsuarioSap
            // 
            this.txtUsuarioSap.Location = new System.Drawing.Point(143, 203);
            this.txtUsuarioSap.Name = "txtUsuarioSap";
            this.txtUsuarioSap.Size = new System.Drawing.Size(176, 20);
            this.txtUsuarioSap.TabIndex = 33;
            this.txtUsuarioSap.Text = "manager";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Senha SAP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Usuario SAP\r\n";
            // 
            // txtSenhaBanco
            // 
            this.txtSenhaBanco.Location = new System.Drawing.Point(143, 177);
            this.txtSenhaBanco.Name = "txtSenhaBanco";
            this.txtSenhaBanco.PasswordChar = '*';
            this.txtSenhaBanco.Size = new System.Drawing.Size(176, 20);
            this.txtSenhaBanco.TabIndex = 30;
            this.txtSenhaBanco.Text = "sap@123";
            // 
            // txtUsuarioBanco
            // 
            this.txtUsuarioBanco.Location = new System.Drawing.Point(143, 149);
            this.txtUsuarioBanco.Name = "txtUsuarioBanco";
            this.txtUsuarioBanco.Size = new System.Drawing.Size(176, 20);
            this.txtUsuarioBanco.TabIndex = 29;
            this.txtUsuarioBanco.Text = "sa";
            // 
            // txtCompanyDb
            // 
            this.txtCompanyDb.Location = new System.Drawing.Point(143, 92);
            this.txtCompanyDb.Name = "txtCompanyDb";
            this.txtCompanyDb.Size = new System.Drawing.Size(176, 20);
            this.txtCompanyDb.TabIndex = 28;
            this.txtCompanyDb.Text = "DEMOBR";
            // 
            // txtServidorLicenca
            // 
            this.txtServidorLicenca.Location = new System.Drawing.Point(143, 64);
            this.txtServidorLicenca.Name = "txtServidorLicenca";
            this.txtServidorLicenca.Size = new System.Drawing.Size(176, 20);
            this.txtServidorLicenca.TabIndex = 27;
            this.txtServidorLicenca.Text = "LEANDROKHALIL:30000";
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(143, 38);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(176, 20);
            this.txtServidor.TabIndex = 26;
            this.txtServidor.Text = "LEANDROKHALIL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Versão do SQL";
            // 
            // cboVersaoSql
            // 
            this.cboVersaoSql.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVersaoSql.FormattingEnabled = true;
            this.cboVersaoSql.Items.AddRange(new object[] {
            "2005",
            "2008",
            "2012",
            "2014",
            "2016",
            "2017",
            "2019",
            "HANA"});
            this.cboVersaoSql.Location = new System.Drawing.Point(143, 120);
            this.cboVersaoSql.Name = "cboVersaoSql";
            this.cboVersaoSql.Size = new System.Drawing.Size(176, 21);
            this.cboVersaoSql.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Senha Banco";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Usuario Banco";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Banco SAP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Servidor de Licença";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Servidor";
            // 
            // btnConectar
            // 
            this.btnConectar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnConectar.Location = new System.Drawing.Point(23, 284);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 18;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 328);
            this.Controls.Add(this.txtSenhaSap);
            this.Controls.Add(this.txtUsuarioSap);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSenhaBanco);
            this.Controls.Add(this.txtUsuarioBanco);
            this.Controls.Add(this.txtCompanyDb);
            this.Controls.Add(this.txtServidorLicenca);
            this.Controls.Add(this.txtServidor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboVersaoSql);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConectar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XPO HANA Test Connector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSenhaSap;
        private System.Windows.Forms.TextBox txtUsuarioSap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSenhaBanco;
        private System.Windows.Forms.TextBox txtUsuarioBanco;
        private System.Windows.Forms.TextBox txtCompanyDb;
        private System.Windows.Forms.TextBox txtServidorLicenca;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboVersaoSql;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConectar;
    }
}

