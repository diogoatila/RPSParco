using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NFSE.Net.Tests
{
    public partial class frmGravarEmpresa : Form
    {
        public frmGravarEmpresa()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'desenvolvimentoDataSet.tb_conta_demonstrativo_resultado' table. You can move, or remove it, as needed.
            

          //  this.reportViewer1.RefreshReport();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lblInscMunicipal_Click(object sender, EventArgs e)
        {

        }

        private void lblTipoRPS_Click(object sender, EventArgs e)
        {

        }

        private void chkAliquota_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblSimples_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
                      this.Close();
        }

     

        private void btnGravarEmpresa_Click(object sender, EventArgs e)
        {
            bool criptografado = false;

            var empresa = new Core.Empresa();
            empresa.Nome = txtRazaoSocial.Text;
            empresa.CNPJ = txtCNPJ.Text;
            empresa.InscricaoMunicipal = txtInscMunicipal.Text;
            empresa.CertificadoArquivo = @"C:\Users\ThinkPad\Documents\Certificados\certificado.txt";
            if (criptografado)
                empresa.CertificadoSenha = Certificado.Criptografia.criptografaSenha("123456");
            else
                empresa.CertificadoSenha = "123456";

            empresa.tpAmb = 2;
            empresa.tpEmis = 1;
            empresa.CodigoMunicipio = Convert.ToInt32(txtMunTributacao.Text);
            
        
        Empresas.SalvarNovaEmpresa(empresa, txtCNPJ.Text, txtRazaoSocial.Text);
        }
   
    }
}

