namespace TesteCriptografia
{
    partial class FormPrincipal
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
            this.grpConfiguracoes = new System.Windows.Forms.GroupBox();
            this.txtChave2 = new System.Windows.Forms.TextBox();
            this.txtChave1 = new System.Windows.Forms.TextBox();
            this.txtVetorInicializacao = new System.Windows.Forms.TextBox();
            this.lblVetorInicializacao = new System.Windows.Forms.Label();
            this.txtChave = new System.Windows.Forms.TextBox();
            this.lblChave = new System.Windows.Forms.Label();
            this.grpEncriptacao = new System.Windows.Forms.GroupBox();
            this.dtLiberacao = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtExpiracao = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResultadoEncriptacao = new System.Windows.Forms.TextBox();
            this.lblResultadoEncriptacao = new System.Windows.Forms.Label();
            this.BtnEncriptar = new System.Windows.Forms.Button();
            this.grpDecriptacao = new System.Windows.Forms.GroupBox();
            this.txtResultadoDecriptacao = new System.Windows.Forms.TextBox();
            this.lblResultadoDecriptacao = new System.Windows.Forms.Label();
            this.BtnDecriptar = new System.Windows.Forms.Button();
            this.txtTextoADecriptar = new System.Windows.Forms.TextBox();
            this.lblTextoADecriptar = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.lblTextoAEncriptar = new System.Windows.Forms.Label();
            this.CboTextoAEncriptar = new System.Windows.Forms.ComboBox();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.grpConfiguracoes.SuspendLayout();
            this.grpEncriptacao.SuspendLayout();
            this.grpDecriptacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpConfiguracoes
            // 
            this.grpConfiguracoes.Controls.Add(this.txtChave2);
            this.grpConfiguracoes.Controls.Add(this.txtChave1);
            this.grpConfiguracoes.Controls.Add(this.txtVetorInicializacao);
            this.grpConfiguracoes.Controls.Add(this.lblVetorInicializacao);
            this.grpConfiguracoes.Controls.Add(this.txtChave);
            this.grpConfiguracoes.Controls.Add(this.lblChave);
            this.grpConfiguracoes.Location = new System.Drawing.Point(13, 57);
            this.grpConfiguracoes.Name = "grpConfiguracoes";
            this.grpConfiguracoes.Size = new System.Drawing.Size(577, 146);
            this.grpConfiguracoes.TabIndex = 0;
            this.grpConfiguracoes.TabStop = false;
            this.grpConfiguracoes.Text = "Configurações da Chave";
            // 
            // txtChave2
            // 
            this.txtChave2.Location = new System.Drawing.Point(127, 114);
            this.txtChave2.Name = "txtChave2";
            this.txtChave2.ReadOnly = true;
            this.txtChave2.Size = new System.Drawing.Size(431, 20);
            this.txtChave2.TabIndex = 5;
            // 
            // txtChave1
            // 
            this.txtChave1.Location = new System.Drawing.Point(127, 55);
            this.txtChave1.Name = "txtChave1";
            this.txtChave1.ReadOnly = true;
            this.txtChave1.Size = new System.Drawing.Size(431, 20);
            this.txtChave1.TabIndex = 4;
            // 
            // txtVetorInicializacao
            // 
            this.txtVetorInicializacao.Location = new System.Drawing.Point(127, 86);
            this.txtVetorInicializacao.MaxLength = 16;
            this.txtVetorInicializacao.Name = "txtVetorInicializacao";
            this.txtVetorInicializacao.Size = new System.Drawing.Size(431, 20);
            this.txtVetorInicializacao.TabIndex = 3;
            // 
            // lblVetorInicializacao
            // 
            this.lblVetorInicializacao.AutoSize = true;
            this.lblVetorInicializacao.Location = new System.Drawing.Point(13, 89);
            this.lblVetorInicializacao.Name = "lblVetorInicializacao";
            this.lblVetorInicializacao.Size = new System.Drawing.Size(111, 13);
            this.lblVetorInicializacao.TabIndex = 2;
            this.lblVetorInicializacao.Text = "Vetor de Inicialização:";
            // 
            // txtChave
            // 
            this.txtChave.Location = new System.Drawing.Point(127, 28);
            this.txtChave.MaxLength = 32;
            this.txtChave.Name = "txtChave";
            this.txtChave.Size = new System.Drawing.Size(431, 20);
            this.txtChave.TabIndex = 1;
            // 
            // lblChave
            // 
            this.lblChave.AutoSize = true;
            this.lblChave.Location = new System.Drawing.Point(13, 31);
            this.lblChave.Name = "lblChave";
            this.lblChave.Size = new System.Drawing.Size(80, 13);
            this.lblChave.TabIndex = 0;
            this.lblChave.Text = "Chave primária:";
            // 
            // grpEncriptacao
            // 
            this.grpEncriptacao.Controls.Add(this.dtLiberacao);
            this.grpEncriptacao.Controls.Add(this.label2);
            this.grpEncriptacao.Controls.Add(this.dtExpiracao);
            this.grpEncriptacao.Controls.Add(this.label1);
            this.grpEncriptacao.Controls.Add(this.txtResultadoEncriptacao);
            this.grpEncriptacao.Controls.Add(this.lblResultadoEncriptacao);
            this.grpEncriptacao.Controls.Add(this.BtnEncriptar);
            this.grpEncriptacao.Location = new System.Drawing.Point(13, 210);
            this.grpEncriptacao.Name = "grpEncriptacao";
            this.grpEncriptacao.Size = new System.Drawing.Size(577, 161);
            this.grpEncriptacao.TabIndex = 1;
            this.grpEncriptacao.TabStop = false;
            this.grpEncriptacao.Text = "Encriptação da Licença";
            // 
            // dtLiberacao
            // 
            this.dtLiberacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtLiberacao.Location = new System.Drawing.Point(127, 27);
            this.dtLiberacao.Name = "dtLiberacao";
            this.dtLiberacao.Size = new System.Drawing.Size(142, 20);
            this.dtLiberacao.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Data Liberação:";
            // 
            // dtExpiracao
            // 
            this.dtExpiracao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtExpiracao.Location = new System.Drawing.Point(127, 58);
            this.dtExpiracao.Name = "dtExpiracao";
            this.dtExpiracao.Size = new System.Drawing.Size(142, 20);
            this.dtExpiracao.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data Expiração:";
            // 
            // txtResultadoEncriptacao
            // 
            this.txtResultadoEncriptacao.Location = new System.Drawing.Point(127, 97);
            this.txtResultadoEncriptacao.Multiline = true;
            this.txtResultadoEncriptacao.Name = "txtResultadoEncriptacao";
            this.txtResultadoEncriptacao.ReadOnly = true;
            this.txtResultadoEncriptacao.Size = new System.Drawing.Size(431, 53);
            this.txtResultadoEncriptacao.TabIndex = 4;
            // 
            // lblResultadoEncriptacao
            // 
            this.lblResultadoEncriptacao.AutoSize = true;
            this.lblResultadoEncriptacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoEncriptacao.Location = new System.Drawing.Point(13, 97);
            this.lblResultadoEncriptacao.Name = "lblResultadoEncriptacao";
            this.lblResultadoEncriptacao.Size = new System.Drawing.Size(84, 13);
            this.lblResultadoEncriptacao.TabIndex = 3;
            this.lblResultadoEncriptacao.Text = "Licença final:";
            // 
            // BtnEncriptar
            // 
            this.BtnEncriptar.Location = new System.Drawing.Point(10, 127);
            this.BtnEncriptar.Name = "BtnEncriptar";
            this.BtnEncriptar.Size = new System.Drawing.Size(87, 23);
            this.BtnEncriptar.TabIndex = 2;
            this.BtnEncriptar.Text = "&Gerar Licença";
            this.BtnEncriptar.UseVisualStyleBackColor = true;
            this.BtnEncriptar.Click += new System.EventHandler(this.BtnEncriptar_Click);
            // 
            // grpDecriptacao
            // 
            this.grpDecriptacao.Controls.Add(this.txtResultadoDecriptacao);
            this.grpDecriptacao.Controls.Add(this.lblResultadoDecriptacao);
            this.grpDecriptacao.Controls.Add(this.BtnDecriptar);
            this.grpDecriptacao.Controls.Add(this.txtTextoADecriptar);
            this.grpDecriptacao.Controls.Add(this.lblTextoADecriptar);
            this.grpDecriptacao.Location = new System.Drawing.Point(13, 383);
            this.grpDecriptacao.Name = "grpDecriptacao";
            this.grpDecriptacao.Size = new System.Drawing.Size(577, 140);
            this.grpDecriptacao.TabIndex = 2;
            this.grpDecriptacao.TabStop = false;
            this.grpDecriptacao.Text = "Decriptação da Licença";
            // 
            // txtResultadoDecriptacao
            // 
            this.txtResultadoDecriptacao.Location = new System.Drawing.Point(127, 72);
            this.txtResultadoDecriptacao.Multiline = true;
            this.txtResultadoDecriptacao.Name = "txtResultadoDecriptacao";
            this.txtResultadoDecriptacao.ReadOnly = true;
            this.txtResultadoDecriptacao.Size = new System.Drawing.Size(431, 59);
            this.txtResultadoDecriptacao.TabIndex = 4;
            // 
            // lblResultadoDecriptacao
            // 
            this.lblResultadoDecriptacao.AutoSize = true;
            this.lblResultadoDecriptacao.Location = new System.Drawing.Point(13, 75);
            this.lblResultadoDecriptacao.Name = "lblResultadoDecriptacao";
            this.lblResultadoDecriptacao.Size = new System.Drawing.Size(58, 13);
            this.lblResultadoDecriptacao.TabIndex = 3;
            this.lblResultadoDecriptacao.Text = "Resultado:";
            // 
            // BtnDecriptar
            // 
            this.BtnDecriptar.Location = new System.Drawing.Point(10, 108);
            this.BtnDecriptar.Name = "BtnDecriptar";
            this.BtnDecriptar.Size = new System.Drawing.Size(75, 23);
            this.BtnDecriptar.TabIndex = 2;
            this.BtnDecriptar.Text = "&Decriptar";
            this.BtnDecriptar.UseVisualStyleBackColor = true;
            this.BtnDecriptar.Click += new System.EventHandler(this.BtnDecriptar_Click);
            // 
            // txtTextoADecriptar
            // 
            this.txtTextoADecriptar.Location = new System.Drawing.Point(153, 38);
            this.txtTextoADecriptar.Name = "txtTextoADecriptar";
            this.txtTextoADecriptar.Size = new System.Drawing.Size(405, 20);
            this.txtTextoADecriptar.TabIndex = 1;
            // 
            // lblTextoADecriptar
            // 
            this.lblTextoADecriptar.AutoSize = true;
            this.lblTextoADecriptar.Location = new System.Drawing.Point(13, 38);
            this.lblTextoADecriptar.Name = "lblTextoADecriptar";
            this.lblTextoADecriptar.Size = new System.Drawing.Size(134, 13);
            this.lblTextoADecriptar.TabIndex = 0;
            this.lblTextoADecriptar.Text = "Licença para  decriptação:";
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(515, 535);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 3;
            this.BtnSair.Text = "&Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // lblTextoAEncriptar
            // 
            this.lblTextoAEncriptar.AutoSize = true;
            this.lblTextoAEncriptar.Location = new System.Drawing.Point(26, 19);
            this.lblTextoAEncriptar.Name = "lblTextoAEncriptar";
            this.lblTextoAEncriptar.Size = new System.Drawing.Size(72, 13);
            this.lblTextoAEncriptar.TabIndex = 4;
            this.lblTextoAEncriptar.Text = "Licença para:";
            // 
            // CboTextoAEncriptar
            // 
            this.CboTextoAEncriptar.FormattingEnabled = true;
            this.CboTextoAEncriptar.Location = new System.Drawing.Point(140, 19);
            this.CboTextoAEncriptar.Name = "CboTextoAEncriptar";
            this.CboTextoAEncriptar.Size = new System.Drawing.Size(431, 21);
            this.CboTextoAEncriptar.TabIndex = 6;
            this.CboTextoAEncriptar.Text = "Selecione um cliente...";
            this.CboTextoAEncriptar.SelectedIndexChanged += new System.EventHandler(this.CboTextoAEncriptar_SelectedIndexChanged);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(425, 535);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 7;
            this.BtnSalvar.Text = "&Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 570);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.CboTextoAEncriptar);
            this.Controls.Add(this.lblTextoAEncriptar);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.grpDecriptacao);
            this.Controls.Add(this.grpEncriptacao);
            this.Controls.Add(this.grpConfiguracoes);
            this.Name = "FormPrincipal";
            this.Text = "GEFID - Licençiamento";
            this.grpConfiguracoes.ResumeLayout(false);
            this.grpConfiguracoes.PerformLayout();
            this.grpEncriptacao.ResumeLayout(false);
            this.grpEncriptacao.PerformLayout();
            this.grpDecriptacao.ResumeLayout(false);
            this.grpDecriptacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConfiguracoes;
        private System.Windows.Forms.TextBox txtVetorInicializacao;
        private System.Windows.Forms.Label lblVetorInicializacao;
        private System.Windows.Forms.TextBox txtChave;
        private System.Windows.Forms.Label lblChave;
        private System.Windows.Forms.GroupBox grpEncriptacao;
        private System.Windows.Forms.TextBox txtResultadoEncriptacao;
        private System.Windows.Forms.Label lblResultadoEncriptacao;
        private System.Windows.Forms.Button BtnEncriptar;
        private System.Windows.Forms.GroupBox grpDecriptacao;
        private System.Windows.Forms.TextBox txtResultadoDecriptacao;
        private System.Windows.Forms.Label lblResultadoDecriptacao;
        private System.Windows.Forms.Button BtnDecriptar;
        private System.Windows.Forms.TextBox txtTextoADecriptar;
        private System.Windows.Forms.Label lblTextoADecriptar;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtExpiracao;
        private System.Windows.Forms.DateTimePicker dtLiberacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChave1;
        private System.Windows.Forms.TextBox txtChave2;
        private System.Windows.Forms.Label lblTextoAEncriptar;
        private System.Windows.Forms.ComboBox CboTextoAEncriptar;
        private System.Windows.Forms.Button BtnSalvar;
    }
}

