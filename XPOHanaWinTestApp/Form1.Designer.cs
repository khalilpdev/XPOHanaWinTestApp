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
            this.txtSenhaBanco = new System.Windows.Forms.TextBox();
            this.txtUsuarioBanco = new System.Windows.Forms.TextBox();
            this.txtSchema = new System.Windows.Forms.TextBox();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnExecutarSelectAny = new System.Windows.Forms.Button();
            this.btnSelectFirst = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSenhaBanco
            // 
            this.txtSenhaBanco.Location = new System.Drawing.Point(143, 153);
            this.txtSenhaBanco.Name = "txtSenhaBanco";
            this.txtSenhaBanco.PasswordChar = '*';
            this.txtSenhaBanco.Size = new System.Drawing.Size(176, 20);
            this.txtSenhaBanco.TabIndex = 30;
            this.txtSenhaBanco.Text = "sap@123";
            // 
            // txtUsuarioBanco
            // 
            this.txtUsuarioBanco.Location = new System.Drawing.Point(143, 125);
            this.txtUsuarioBanco.Name = "txtUsuarioBanco";
            this.txtUsuarioBanco.Size = new System.Drawing.Size(176, 20);
            this.txtUsuarioBanco.TabIndex = 29;
            this.txtUsuarioBanco.Text = "sa";
            // 
            // txtSchema
            // 
            this.txtSchema.Location = new System.Drawing.Point(143, 92);
            this.txtSchema.Name = "txtSchema";
            this.txtSchema.Size = new System.Drawing.Size(176, 20);
            this.txtSchema.TabIndex = 28;
            this.txtSchema.Text = "SYSTEM";
            // 
            // txtPorta
            // 
            this.txtPorta.Location = new System.Drawing.Point(143, 64);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(176, 20);
            this.txtPorta.TabIndex = 27;
            this.txtPorta.Text = "39017";
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(143, 38);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(176, 20);
            this.txtServidor.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Database Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Database User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Schema";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Server";
            // 
            // btnConectar
            // 
            this.btnConectar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnConectar.Location = new System.Drawing.Point(23, 206);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 18;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnExecutarSelectAny
            // 
            this.btnExecutarSelectAny.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExecutarSelectAny.Location = new System.Drawing.Point(363, 57);
            this.btnExecutarSelectAny.Name = "btnExecutarSelectAny";
            this.btnExecutarSelectAny.Size = new System.Drawing.Size(104, 23);
            this.btnExecutarSelectAny.TabIndex = 31;
            this.btnExecutarSelectAny.Text = "Select Any";
            this.btnExecutarSelectAny.UseVisualStyleBackColor = true;
            this.btnExecutarSelectAny.Click += new System.EventHandler(this.btnExecutarSelectAny_Click);
            // 
            // btnSelectFirst
            // 
            this.btnSelectFirst.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSelectFirst.Location = new System.Drawing.Point(528, 57);
            this.btnSelectFirst.Name = "btnSelectFirst";
            this.btnSelectFirst.Size = new System.Drawing.Size(104, 23);
            this.btnSelectFirst.TabIndex = 34;
            this.btnSelectFirst.Text = "Select First";
            this.btnSelectFirst.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(456, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 20);
            this.textBox1.TabIndex = 36;
            this.textBox1.Text = "sys.objects";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Tabela";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(363, 92);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(269, 81);
            this.txtResult.TabIndex = 37;
            this.txtResult.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 241);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSelectFirst);
            this.Controls.Add(this.btnExecutarSelectAny);
            this.Controls.Add(this.txtSenhaBanco);
            this.Controls.Add(this.txtUsuarioBanco);
            this.Controls.Add(this.txtSchema);
            this.Controls.Add(this.txtPorta);
            this.Controls.Add(this.txtServidor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConectar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XPO SAP HANA Test Connector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSenhaBanco;
        private System.Windows.Forms.TextBox txtUsuarioBanco;
        private System.Windows.Forms.TextBox txtSchema;
        private System.Windows.Forms.TextBox txtPorta;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnExecutarSelectAny;
        private System.Windows.Forms.Button btnSelectFirst;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtResult;
    }
}

