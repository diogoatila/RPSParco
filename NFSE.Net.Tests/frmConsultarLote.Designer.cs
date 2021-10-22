
namespace NFSE.Net.Tests
{
    partial class frmConsultarLote
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lblErros = new System.Windows.Forms.Label();
            this.lblSucesso = new System.Windows.Forms.Label();
            this.gbConfigPrestador = new System.Windows.Forms.GroupBox();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnPararConsulta = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.gbOperacao = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.rbDevolucao = new System.Windows.Forms.RadioButton();
            this.rbComDeducao = new System.Windows.Forms.RadioButton();
            this.rbNaoConsultados = new System.Windows.Forms.RadioButton();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblMunIBGE = new System.Windows.Forms.Label();
            this.txtInscMunicipal = new System.Windows.Forms.TextBox();
            this.lblInscMunicipal = new System.Windows.Forms.Label();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.gbConfigPrestador.SuspendLayout();
            this.gbOperacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(726, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(605, 337);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(726, 423);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(606, 277);
            this.dataGridView2.TabIndex = 2;
            // 
            // lblErros
            // 
            this.lblErros.AutoSize = true;
            this.lblErros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErros.Location = new System.Drawing.Point(721, 9);
            this.lblErros.Name = "lblErros";
            this.lblErros.Size = new System.Drawing.Size(64, 25);
            this.lblErros.TabIndex = 3;
            this.lblErros.Text = "Erros:";
            // 
            // lblSucesso
            // 
            this.lblSucesso.AutoSize = true;
            this.lblSucesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucesso.Location = new System.Drawing.Point(721, 395);
            this.lblSucesso.Name = "lblSucesso";
            this.lblSucesso.Size = new System.Drawing.Size(219, 25);
            this.lblSucesso.TabIndex = 4;
            this.lblSucesso.Text = "Enviados com sucesso:";
            // 
            // gbConfigPrestador
            // 
            this.gbConfigPrestador.Controls.Add(this.gbStatus);
            this.gbConfigPrestador.Controls.Add(this.btnSair);
            this.gbConfigPrestador.Controls.Add(this.btnPararConsulta);
            this.gbConfigPrestador.Controls.Add(this.btnOk);
            this.gbConfigPrestador.Controls.Add(this.gbOperacao);
            this.gbConfigPrestador.Controls.Add(this.txtRazaoSocial);
            this.gbConfigPrestador.Controls.Add(this.textBox1);
            this.gbConfigPrestador.Controls.Add(this.lblMunIBGE);
            this.gbConfigPrestador.Controls.Add(this.txtInscMunicipal);
            this.gbConfigPrestador.Controls.Add(this.lblInscMunicipal);
            this.gbConfigPrestador.Controls.Add(this.txtCNPJ);
            this.gbConfigPrestador.Controls.Add(this.lblCNPJ);
            this.gbConfigPrestador.Controls.Add(this.lblRazaoSocial);
            this.gbConfigPrestador.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConfigPrestador.Location = new System.Drawing.Point(12, 12);
            this.gbConfigPrestador.Name = "gbConfigPrestador";
            this.gbConfigPrestador.Size = new System.Drawing.Size(694, 688);
            this.gbConfigPrestador.TabIndex = 5;
            this.gbConfigPrestador.TabStop = false;
            this.gbConfigPrestador.Text = "Configuração do Prestador";
            this.gbConfigPrestador.Enter += new System.EventHandler(this.gbConfigPrestador_Enter);
            // 
            // gbStatus
            // 
            this.gbStatus.Location = new System.Drawing.Point(19, 411);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(648, 180);
            this.gbStatus.TabIndex = 46;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(473, 619);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(194, 54);
            this.btnSair.TabIndex = 45;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnPararConsulta
            // 
            this.btnPararConsulta.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPararConsulta.Location = new System.Drawing.Point(248, 619);
            this.btnPararConsulta.Name = "btnPararConsulta";
            this.btnPararConsulta.Size = new System.Drawing.Size(194, 54);
            this.btnPararConsulta.TabIndex = 44;
            this.btnPararConsulta.Text = "Parar Consulta";
            this.btnPararConsulta.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(19, 619);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(194, 54);
            this.btnOk.TabIndex = 43;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // gbOperacao
            // 
            this.gbOperacao.Controls.Add(this.progressBar1);
            this.gbOperacao.Controls.Add(this.rbDevolucao);
            this.gbOperacao.Controls.Add(this.rbComDeducao);
            this.gbOperacao.Controls.Add(this.rbNaoConsultados);
            this.gbOperacao.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOperacao.Location = new System.Drawing.Point(19, 248);
            this.gbOperacao.Name = "gbOperacao";
            this.gbOperacao.Size = new System.Drawing.Size(650, 147);
            this.gbOperacao.TabIndex = 42;
            this.gbOperacao.TabStop = false;
            this.gbOperacao.Text = "Número do Lote:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(19, 88);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(595, 33);
            this.progressBar1.TabIndex = 4;
            // 
            // rbDevolucao
            // 
            this.rbDevolucao.AutoSize = true;
            this.rbDevolucao.Location = new System.Drawing.Point(447, 44);
            this.rbDevolucao.Name = "rbDevolucao";
            this.rbDevolucao.Size = new System.Drawing.Size(167, 29);
            this.rbDevolucao.TabIndex = 3;
            this.rbDevolucao.TabStop = true;
            this.rbDevolucao.Text = "Informar Lote";
            this.rbDevolucao.UseVisualStyleBackColor = true;
            // 
            // rbComDeducao
            // 
            this.rbComDeducao.AutoSize = true;
            this.rbComDeducao.Location = new System.Drawing.Point(264, 44);
            this.rbComDeducao.Name = "rbComDeducao";
            this.rbComDeducao.Size = new System.Drawing.Size(148, 29);
            this.rbComDeducao.TabIndex = 2;
            this.rbComDeducao.TabStop = true;
            this.rbComDeducao.Text = "Ultimo Lote";
            this.rbComDeducao.UseVisualStyleBackColor = true;
            // 
            // rbNaoConsultados
            // 
            this.rbNaoConsultados.AutoSize = true;
            this.rbNaoConsultados.Location = new System.Drawing.Point(19, 44);
            this.rbNaoConsultados.Name = "rbNaoConsultados";
            this.rbNaoConsultados.Size = new System.Drawing.Size(204, 29);
            this.rbNaoConsultados.TabIndex = 0;
            this.rbNaoConsultados.TabStop = true;
            this.rbNaoConsultados.Text = "Não Consultados";
            this.rbNaoConsultados.UseVisualStyleBackColor = true;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtRazaoSocial.Location = new System.Drawing.Point(191, 49);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(476, 33);
            this.txtRazaoSocial.TabIndex = 21;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.Location = new System.Drawing.Point(305, 190);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(364, 33);
            this.textBox1.TabIndex = 36;
            // 
            // lblMunIBGE
            // 
            this.lblMunIBGE.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMunIBGE.Location = new System.Drawing.Point(46, 192);
            this.lblMunIBGE.Name = "lblMunIBGE";
            this.lblMunIBGE.Size = new System.Drawing.Size(280, 37);
            this.lblMunIBGE.TabIndex = 35;
            this.lblMunIBGE.Text = "Município (Padrão IBGE):";
            this.lblMunIBGE.Click += new System.EventHandler(this.lblMunIBGE_Click);
            // 
            // txtInscMunicipal
            // 
            this.txtInscMunicipal.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtInscMunicipal.Location = new System.Drawing.Point(248, 145);
            this.txtInscMunicipal.Name = "txtInscMunicipal";
            this.txtInscMunicipal.Size = new System.Drawing.Size(421, 33);
            this.txtInscMunicipal.TabIndex = 26;
            // 
            // lblInscMunicipal
            // 
            this.lblInscMunicipal.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInscMunicipal.Location = new System.Drawing.Point(46, 145);
            this.lblInscMunicipal.Name = "lblInscMunicipal";
            this.lblInscMunicipal.Size = new System.Drawing.Size(207, 26);
            this.lblInscMunicipal.TabIndex = 25;
            this.lblInscMunicipal.Text = "Inscrição Municipal:";
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtCNPJ.Location = new System.Drawing.Point(171, 98);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(498, 33);
            this.txtCNPJ.TabIndex = 24;
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNPJ.Location = new System.Drawing.Point(46, 99);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(142, 33);
            this.lblCNPJ.TabIndex = 23;
            this.lblCNPJ.Text = "CPF/CNPJ:";
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazaoSocial.Location = new System.Drawing.Point(46, 49);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(152, 26);
            this.lblRazaoSocial.TabIndex = 22;
            this.lblRazaoSocial.Text = "Razão Social:";
            // 
            // frmConsultarLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 712);
            this.Controls.Add(this.gbConfigPrestador);
            this.Controls.Add(this.lblSucesso);
            this.Controls.Add(this.lblErros);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmConsultarLote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ConsultarLote";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.gbConfigPrestador.ResumeLayout(false);
            this.gbConfigPrestador.PerformLayout();
            this.gbOperacao.ResumeLayout(false);
            this.gbOperacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblErros;
        private System.Windows.Forms.Label lblSucesso;
        private System.Windows.Forms.GroupBox gbConfigPrestador;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblMunIBGE;
        private System.Windows.Forms.TextBox txtInscMunicipal;
        private System.Windows.Forms.Label lblInscMunicipal;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.Label lblRazaoSocial;
        private System.Windows.Forms.GroupBox gbOperacao;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RadioButton rbDevolucao;
        private System.Windows.Forms.RadioButton rbComDeducao;
        private System.Windows.Forms.RadioButton rbNaoConsultados;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnPararConsulta;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox gbStatus;
    }
}