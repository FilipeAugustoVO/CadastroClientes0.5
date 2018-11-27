using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroClientes
{
    public partial class CadastroClientes : Form
    {
        public CadastroClientes()
        {
            InitializeComponent();
            txtCadastroPessoaFisica.Visible = true;
            txtCadastroPessoaJuridica.Visible = false;
        }

        private void CadastroClientes_Load(object sender, EventArgs e)
        {
            try
            {
                txtCadastroPessoaFisica.Text = Properties.Settings.Default.TextoPessoasFisicas;
                txtCadastroPessoaJuridica.Text = Properties.Settings.Default.TextoPessoasJuridicas;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }                             

        private void btnPessoaFisica_Click(object sender, EventArgs e)
        {
            txtCadastroPessoaFisica.Visible = true;
            txtCadastroPessoaJuridica.Visible = false;
            lblDocumento1.Text = "RG";
            lblDocumento2.Text = "CPF";
        }

        private void btnPessoaJuridica_Click(object sender, EventArgs e)
        {
            txtCadastroPessoaFisica.Visible = false;
            txtCadastroPessoaJuridica.Visible = true;
            lblDocumento1.Text = "CNPJ";
            lblDocumento2.Text = "IE";
        }

        private void Limpar()
        {
            txtNome.Clear();
            txtEndereco.Clear();
            txtDocumento1.Clear();
            txtDocumento2.Clear();
        }

        private void LimparTudo()
        {
            txtNome.Clear();
            txtEndereco.Clear();
            txtDocumento1.Clear();
            txtDocumento2.Clear();
            txtCadastroPessoaFisica.Clear();
            txtCadastroPessoaJuridica.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            {
                if (txtCadastroPessoaFisica.Visible)
                {
                    PessoaFisica novaPessoaFisica = new PessoaFisica(); //instanciando a classe PessoaFisica

                    novaPessoaFisica.Nome = txtNome.Text;
                    novaPessoaFisica.Endereco = txtEndereco.Text;
                    novaPessoaFisica.RG = txtDocumento1.Text;
                    novaPessoaFisica.CPF = txtDocumento2.Text;

                    txtCadastroPessoaFisica.AppendText(novaPessoaFisica.Nome + "\t" + "\t" + novaPessoaFisica.Endereco + "\t" + novaPessoaFisica.RG + "\t" + novaPessoaFisica.CPF + "\n");
                    Limpar();
                }
                else

                if (txtCadastroPessoaJuridica.Visible)
                {
                    PessoaJuridica novaPessoaJuridica = new PessoaJuridica(); //instanciando a classe PessoaJuridica

                    novaPessoaJuridica.Nome = txtNome.Text;
                    novaPessoaJuridica.Endereco = txtEndereco.Text;
                    novaPessoaJuridica.CNPJ = txtDocumento1.Text;
                    novaPessoaJuridica.IE = txtDocumento2.Text;

                    txtCadastroPessoaJuridica.AppendText(novaPessoaJuridica.Nome + "\t" + "\t" + novaPessoaJuridica.Endereco + "\t" + novaPessoaJuridica.CNPJ + "\t" + novaPessoaJuridica.IE + "\n");
                    Limpar();
                }
            }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Properties.Settings.Default.TextoPessoasFisicas = txtCadastroPessoaFisica.Text;
                Properties.Settings.Default.TextoPessoasJuridicas = txtCadastroPessoaJuridica.Text;
                Properties.Settings.Default.Save();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparTudo();
        }
    }
}

