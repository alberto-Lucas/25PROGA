namespace AppCadastros
{
    partial class frmCadProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadProduto));
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mskCodBarras = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbUnidade = new System.Windows.Forms.ComboBox();
            this.cbbGrupo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrateleira = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtCancelar = new System.Windows.Forms.Button();
            this.errErro = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(12, 25);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(294, 20);
            this.txtDescricao.TabIndex = 1;
            this.txtDescricao.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescricao_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código de Barras:";
            // 
            // mskCodBarras
            // 
            this.mskCodBarras.Location = new System.Drawing.Point(344, 25);
            this.mskCodBarras.Mask = "9999999999999";
            this.mskCodBarras.Name = "mskCodBarras";
            this.mskCodBarras.Size = new System.Drawing.Size(100, 20);
            this.mskCodBarras.TabIndex = 3;
            this.mskCodBarras.Validating += new System.ComponentModel.CancelEventHandler(this.mskCodBarras_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Unidade:";
            // 
            // cbbUnidade
            // 
            this.cbbUnidade.FormattingEnabled = true;
            this.cbbUnidade.Items.AddRange(new object[] {
            "UN",
            "PC",
            "KG",
            "ML",
            "LT"});
            this.cbbUnidade.Location = new System.Drawing.Point(12, 90);
            this.cbbUnidade.Name = "cbbUnidade";
            this.cbbUnidade.Size = new System.Drawing.Size(58, 21);
            this.cbbUnidade.TabIndex = 5;
            this.cbbUnidade.Validating += new System.ComponentModel.CancelEventHandler(this.cbbUnidade_Validating);
            // 
            // cbbGrupo
            // 
            this.cbbGrupo.FormattingEnabled = true;
            this.cbbGrupo.Items.AddRange(new object[] {
            "BEBIDAS",
            "IOGURTES",
            "FARINHAS",
            "CONGELADOS"});
            this.cbbGrupo.Location = new System.Drawing.Point(100, 90);
            this.cbbGrupo.Name = "cbbGrupo";
            this.cbbGrupo.Size = new System.Drawing.Size(118, 21);
            this.cbbGrupo.TabIndex = 7;
            this.cbbGrupo.Validating += new System.ComponentModel.CancelEventHandler(this.cbbGrupo_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Grupo:";
            // 
            // txtPrateleira
            // 
            this.txtPrateleira.Location = new System.Drawing.Point(252, 90);
            this.txtPrateleira.Name = "txtPrateleira";
            this.txtPrateleira.Size = new System.Drawing.Size(54, 20);
            this.txtPrateleira.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Plateleira:";
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Location = new System.Drawing.Point(344, 90);
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(100, 20);
            this.txtPrecoVenda.TabIndex = 11;
            this.txtPrecoVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecoVenda_KeyPress);
            this.txtPrecoVenda.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrecoVenda_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(344, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Preço de Venda:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(288, 147);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtCancelar
            // 
            this.txtCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCancelar.Location = new System.Drawing.Point(369, 147);
            this.txtCancelar.Name = "txtCancelar";
            this.txtCancelar.Size = new System.Drawing.Size(75, 23);
            this.txtCancelar.TabIndex = 13;
            this.txtCancelar.Text = "Cancelar";
            this.txtCancelar.UseVisualStyleBackColor = true;
            this.txtCancelar.Click += new System.EventHandler(this.txtCancelar_Click);
            // 
            // errErro
            // 
            this.errErro.ContainerControl = this;
            this.errErro.Icon = ((System.Drawing.Icon)(resources.GetObject("errErro.Icon")));
            // 
            // frmCadProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(481, 182);
            this.Controls.Add(this.txtCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtPrecoVenda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrateleira);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbGrupo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbUnidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mskCodBarras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadProduto";
            this.Text = "Cadastro de Produto";
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskCodBarras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbUnidade;
        private System.Windows.Forms.ComboBox cbbGrupo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrateleira;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecoVenda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button txtCancelar;
        private System.Windows.Forms.ErrorProvider errErro;
    }
}