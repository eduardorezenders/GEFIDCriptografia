using System;
using System.Data;
using System.Windows.Forms;
using Criptografia;
using CRIPTOGRAFIA.Models;

namespace TesteCriptografia
{
    public partial class FormPrincipal : Form
    {
        private int idcliente;
        private int idlicenca;
        private string texto;
        private string[] item;
        private string resultado;

        public FormPrincipal()
        {           
            InitializeComponent();
            grpConfiguracoes.Enabled = false;
            grpEncriptacao.Enabled = false;
            grpDecriptacao.Enabled = false;
            BtnSalvar.Enabled = false;

            if (CarregaClientes()==false) {
                MessageBox.Show("Não exeistem Clientes para gerar licença!!");
            }
        }

        private bool CarregaClientes()
        {
            LimpaFormulario();
            DataTable dados = DalHelper.GetClientes();
            if (dados.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                CboTextoAEncriptar.DataSource = dados;
                CboTextoAEncriptar.ValueMember = "IdCliente";
                CboTextoAEncriptar.DisplayMember = "RazaoSocial";
                return true;
            }
        }

        private void BtnEncriptar_Click(object sender, EventArgs e)
        {
            try
            {
                string vChave =
                    CriptografiaHelper.Encriptar(
                        txtChave.Text,
                        txtVetorInicializacao.Text,
                        CboTextoAEncriptar.Text) + "-" + CriptografiaHelper.Encriptar(
                        txtChave.Text,
                        txtVetorInicializacao.Text,
                        dtExpiracao.Text) + "-" + CriptografiaHelper.Encriptar(
                        txtChave.Text,
                        txtVetorInicializacao.Text,
                        dtLiberacao.Text) + "-" + CriptografiaHelper.Encriptar(
                        txtChave.Text,
                        txtVetorInicializacao.Text,
                        "N1ContactCenter");

                txtChave1.Text = MD5Hash.CalculaHash(txtChave.Text).ToString();
                txtChave2.Text = MD5Hash.CalculaHash(txtVetorInicializacao.Text).ToString();

                txtResultadoEncriptacao.Text = vChave;
                BtnSalvar.Enabled = true;
            }
            catch (Exception ex)
            {
                txtResultadoEncriptacao.Text = "Erro: " + ex.Message;
            }
        }

        private void BtnDecriptar_Click(object sender, EventArgs e)
        {
            texto = txtTextoADecriptar.Text;
            item = texto.Split('-');
            txtResultadoDecriptacao.Text = CriptografiaHelper.Decriptar(txtChave.Text, txtVetorInicializacao.Text, item[0]) + "-" + CriptografiaHelper.Decriptar(txtChave.Text, txtVetorInicializacao.Text, item[1]) + "-" + CriptografiaHelper.Decriptar(txtChave.Text, txtVetorInicializacao.Text, item[2]);
        }

        private string Decriptar(string texto)
        {
            try
            {
                resultado = CriptografiaHelper.Decriptar(txtChave.Text, txtVetorInicializacao.Text, texto);
            }
            catch (Exception ex)
            {
                txtResultadoDecriptacao.Text = "Erro: " + ex.Message;
            }
            return resultado;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LimpaFormulario()
        {
            foreach (object c in grpConfiguracoes.Controls)
            {
                if (c is TextBox) { ((TextBox)c).Text = string.Empty; }
            }
            foreach (object c in grpEncriptacao.Controls)
            {
                if (c is TextBox) { ((TextBox)c).Text = string.Empty; }
            }
            foreach (object c in grpDecriptacao.Controls)
            {
                if (c is TextBox) { ((TextBox)c).Text = string.Empty; }
            }
        }

        private void CboTextoAEncriptar_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpConfiguracoes.Enabled = true;
            grpEncriptacao.Enabled = true;
            grpDecriptacao.Enabled = true;
            BtnSalvar.Enabled = false;

            Licenca licenca = new Licenca();
            idcliente = Convert.ToInt32(((DataRowView)CboTextoAEncriptar.SelectedItem)["IdCliente"]);
            licenca = DalHelper.GetLicenca(idcliente);
            if (licenca.IdLicenca == 0) {
                LimpaFormulario();
                BtnSalvar.Text = "Incluir";
                txtChave.Text = "n1cc@n1contactcenter2020";
                txtVetorInicializacao.Text = "n1cc@n1contactce";
                dtExpiracao.Text = DateTime.Now.ToShortDateString();
                dtLiberacao.Text = DateTime.Now.ToShortDateString();
            } else
            {
                BtnSalvar.Text = "Alterar";
                PreencherDados(licenca);
            }
        }

        private void PreencherDados(Licenca licenca)
        {
            txtResultadoDecriptacao.Text = "";
            txtChave.Text = licenca.Chave1;
            txtVetorInicializacao.Text = licenca.Chave2;
            txtResultadoEncriptacao.Text = licenca.Chave;
            txtTextoADecriptar.Text = licenca.Chave;
            texto = txtResultadoEncriptacao.Text;
            item = texto.Split('-');
            dtExpiracao.Text = Decriptar(item[1]);
            dtLiberacao.Text = Decriptar(item[2]);
            idlicenca = licenca.IdLicenca;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (BtnSalvar.Text.Equals("Incluir"))
            {
                try
                {
                    Licenca licenca = new Licenca
                    {
                        IdCliente = idcliente,
                        Chave = txtResultadoEncriptacao.Text,
                        Chave1 = txtChave.Text,
                        Chave2 = txtVetorInicializacao.Text
                    };
                    DalHelper.Add(licenca);
                    CarregaClientes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }

            if (BtnSalvar.Text.Equals("Alterar"))
            {
                try
                {
                    Licenca licenca = new Licenca
                    {
                        IdLicenca = idlicenca,
                        IdCliente = idcliente,
                        Chave = txtResultadoEncriptacao.Text,
                        Chave1 = txtChave.Text,
                        Chave2 = txtVetorInicializacao.Text
                    };
                    DalHelper.Update(licenca);
                    CarregaClientes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }
    }
}
