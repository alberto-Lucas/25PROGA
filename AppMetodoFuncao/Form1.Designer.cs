namespace AppMetodoFuncao
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbModelo = new System.Windows.Forms.ComboBox();
            this.btnIF = new System.Windows.Forms.Button();
            this.btnSWITCH = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnMetodo = new System.Windows.Forms.Button();
            this.btnFuncao = new System.Windows.Forms.Button();
            this.btnFOR = new System.Windows.Forms.Button();
            this.tbnWhile = new System.Windows.Forms.Button();
            this.btnDoWhile = new System.Windows.Forms.Button();
            this.lstItens = new System.Windows.Forms.ListBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValorInteiro = new System.Windows.Forms.TextBox();
            this.btnSoNumero = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe um modelo de carro:";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(12, 25);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(121, 20);
            this.txtModelo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selecione um modelo de carro:";
            // 
            // cbbModelo
            // 
            this.cbbModelo.FormattingEnabled = true;
            this.cbbModelo.Items.AddRange(new object[] {
            "SKYLINE",
            "UNO(COM ESCADA)",
            "SUPRA",
            "MONZA"});
            this.cbbModelo.Location = new System.Drawing.Point(12, 82);
            this.cbbModelo.Name = "cbbModelo";
            this.cbbModelo.Size = new System.Drawing.Size(121, 21);
            this.cbbModelo.TabIndex = 3;
            // 
            // btnIF
            // 
            this.btnIF.Location = new System.Drawing.Point(139, 23);
            this.btnIF.Name = "btnIF";
            this.btnIF.Size = new System.Drawing.Size(75, 23);
            this.btnIF.TabIndex = 4;
            this.btnIF.Text = "IF";
            this.btnIF.UseVisualStyleBackColor = true;
            this.btnIF.Click += new System.EventHandler(this.btnIF_Click);
            // 
            // btnSWITCH
            // 
            this.btnSWITCH.Location = new System.Drawing.Point(139, 80);
            this.btnSWITCH.Name = "btnSWITCH";
            this.btnSWITCH.Size = new System.Drawing.Size(75, 23);
            this.btnSWITCH.TabIndex = 5;
            this.btnSWITCH.Text = "SWITCH";
            this.btnSWITCH.UseVisualStyleBackColor = true;
            this.btnSWITCH.Click += new System.EventHandler(this.btnSWITCH_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Informe o seu Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(287, 26);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 7;
            // 
            // btnMetodo
            // 
            this.btnMetodo.Location = new System.Drawing.Point(287, 52);
            this.btnMetodo.Name = "btnMetodo";
            this.btnMetodo.Size = new System.Drawing.Size(75, 23);
            this.btnMetodo.TabIndex = 8;
            this.btnMetodo.Text = "METODO";
            this.btnMetodo.UseVisualStyleBackColor = true;
            this.btnMetodo.Click += new System.EventHandler(this.btnMetodo_Click);
            // 
            // btnFuncao
            // 
            this.btnFuncao.Location = new System.Drawing.Point(287, 82);
            this.btnFuncao.Name = "btnFuncao";
            this.btnFuncao.Size = new System.Drawing.Size(75, 23);
            this.btnFuncao.TabIndex = 9;
            this.btnFuncao.Text = "FUNCAO";
            this.btnFuncao.UseVisualStyleBackColor = true;
            this.btnFuncao.Click += new System.EventHandler(this.btnFuncao_Click);
            // 
            // btnFOR
            // 
            this.btnFOR.Location = new System.Drawing.Point(409, 9);
            this.btnFOR.Name = "btnFOR";
            this.btnFOR.Size = new System.Drawing.Size(75, 23);
            this.btnFOR.TabIndex = 10;
            this.btnFOR.Text = "FOR";
            this.btnFOR.UseVisualStyleBackColor = true;
            this.btnFOR.Click += new System.EventHandler(this.btnFOR_Click);
            // 
            // tbnWhile
            // 
            this.tbnWhile.Location = new System.Drawing.Point(409, 38);
            this.tbnWhile.Name = "tbnWhile";
            this.tbnWhile.Size = new System.Drawing.Size(75, 23);
            this.tbnWhile.TabIndex = 11;
            this.tbnWhile.Text = "WHILE";
            this.tbnWhile.UseVisualStyleBackColor = true;
            this.tbnWhile.Click += new System.EventHandler(this.tbnWhile_Click);
            // 
            // btnDoWhile
            // 
            this.btnDoWhile.Location = new System.Drawing.Point(409, 68);
            this.btnDoWhile.Name = "btnDoWhile";
            this.btnDoWhile.Size = new System.Drawing.Size(75, 23);
            this.btnDoWhile.TabIndex = 12;
            this.btnDoWhile.Text = "DO WHILE";
            this.btnDoWhile.UseVisualStyleBackColor = true;
            this.btnDoWhile.Click += new System.EventHandler(this.btnDoWhile_Click);
            // 
            // lstItens
            // 
            this.lstItens.FormattingEnabled = true;
            this.lstItens.Location = new System.Drawing.Point(490, 14);
            this.lstItens.Name = "lstItens";
            this.lstItens.Size = new System.Drawing.Size(120, 95);
            this.lstItens.TabIndex = 13;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(409, 97);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Valor Inteiro:";
            // 
            // txtValorInteiro
            // 
            this.txtValorInteiro.Location = new System.Drawing.Point(12, 131);
            this.txtValorInteiro.Name = "txtValorInteiro";
            this.txtValorInteiro.Size = new System.Drawing.Size(100, 20);
            this.txtValorInteiro.TabIndex = 16;
            // 
            // btnSoNumero
            // 
            this.btnSoNumero.Location = new System.Drawing.Point(12, 157);
            this.btnSoNumero.Name = "btnSoNumero";
            this.btnSoNumero.Size = new System.Drawing.Size(100, 23);
            this.btnSoNumero.TabIndex = 17;
            this.btnSoNumero.Text = "SÓ NUMERO";
            this.btnSoNumero.UseVisualStyleBackColor = true;
            this.btnSoNumero.Click += new System.EventHandler(this.btnSoNumero_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(12, 183);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(35, 13);
            this.lblResultado.TabIndex = 18;
            this.lblResultado.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(650, 207);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnSoNumero);
            this.Controls.Add(this.txtValorInteiro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lstItens);
            this.Controls.Add(this.btnDoWhile);
            this.Controls.Add(this.tbnWhile);
            this.Controls.Add(this.btnFOR);
            this.Controls.Add(this.btnFuncao);
            this.Controls.Add(this.btnMetodo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSWITCH);
            this.Controls.Add(this.btnIF);
            this.Controls.Add(this.cbbModelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbModelo;
        private System.Windows.Forms.Button btnIF;
        private System.Windows.Forms.Button btnSWITCH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnMetodo;
        private System.Windows.Forms.Button btnFuncao;
        private System.Windows.Forms.Button btnFOR;
        private System.Windows.Forms.Button tbnWhile;
        private System.Windows.Forms.Button btnDoWhile;
        private System.Windows.Forms.ListBox lstItens;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValorInteiro;
        private System.Windows.Forms.Button btnSoNumero;
        private System.Windows.Forms.Label lblResultado;
    }
}

