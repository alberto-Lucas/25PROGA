namespace AppCadastros
{
    partial class frmCadCliente
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCPF = new System.Windows.Forms.Button();
            this.lblCPF = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(223, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.Validating += new System.ComponentModel.CancelEventHandler(this.txtNome_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Nascimento:";
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(262, 25);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(102, 20);
            this.dtpDataNascimento.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CPF:";
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(12, 86);
            this.mskCPF.Mask = "999.999.999-99";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(100, 20);
            this.mskCPF.TabIndex = 5;
            this.mskCPF.Validating += new System.ComponentModel.CancelEventHandler(this.mskCPF_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "RG:";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(144, 86);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(100, 20);
            this.txtRG.TabIndex = 7;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(300, 128);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(219, 128);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "txtNome";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "dtpDataNascimento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "mskCPF";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(141, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "txtRG";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(216, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "btnSalvar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(300, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "btnCancelar";
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // btnCPF
            // 
            this.btnCPF.Location = new System.Drawing.Point(12, 146);
            this.btnCPF.Name = "btnCPF";
            this.btnCPF.Size = new System.Drawing.Size(75, 23);
            this.btnCPF.TabIndex = 16;
            this.btnCPF.Text = "CPF";
            this.btnCPF.UseVisualStyleBackColor = true;
            this.btnCPF.Click += new System.EventHandler(this.btnCPF_Click);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(12, 128);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(41, 13);
            this.lblCPF.TabIndex = 17;
            this.lblCPF.Text = "label11";
            // 
            // frmCadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(387, 173);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.btnCPF);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mskCPF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDataNascimento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "frmCadCliente";
            this.Text = "frmCadCliente";
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Button btnCPF;
    }
}