using Apresentacao;
using Negocios;
using ObjetoTransferencia;
using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class frmClienteCadastrar : Form
    {
        AcaoNaTela _acaoSelecionado;

        public frmClienteCadastrar(AcaoNaTela acaoNaTela,Cliente cliente)
        {
            InitializeComponent();

            //Coletando a ação selecionada pelo usuário
            this._acaoSelecionado = acaoNaTela;

            if (acaoNaTela == AcaoNaTela.INSERIR)
            {
                this.Text = "Inserir Cliente";
            }
            else if (acaoNaTela == AcaoNaTela.ALTERAR)
            {
                this.Text = "Alterar Cliente";
                
                PreencherDados(cliente);
            }
            else if (acaoNaTela == AcaoNaTela.CONSULTAR)
            {
                this.Text = "Consultar Cliente";
                
                PreencherDados(cliente);

                txtNome.ReadOnly = true;
                txtNome.TabStop = false;

                txtCpf.ReadOnly = true;
                txtCpf.TabStop = false;

                txtTelefone.ReadOnly = true;
                txtTelefone.TabStop = false;

                txtEndereco.ReadOnly = true;
                txtEndereco.TabStop = false;

                txtEmail.ReadOnly = true;
                txtEmail.TabStop = false;

                btnSalvar.Visible = false;
                btnCancelar.Text = "Fechar";
                btnCancelar.Focus();
            }

        }

        private void PreencherDados(Cliente cliente)
        {
            txtCodigo.Text = cliente.IdCliente.ToString();
            txtNome.Text = cliente.Nome;
            txtCpf.Text = cliente.Cpf;
            txtTelefone.Text = cliente.Telefone;
            txtEndereco.Text = cliente.Endereco;
            txtEmail.Text = cliente.Email;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Verificar se é inserção ou alteração
            if (_acaoSelecionado == AcaoNaTela.INSERIR)
            {
                Cliente cliente = new Cliente();
                
                cliente.Nome = txtNome.Text;
                cliente.Cpf = txtCpf.Text;
                cliente.Telefone = txtTelefone.Text;
                cliente.Endereco = txtEndereco.Text;
                cliente.Email = txtEmail.Text;

                ClienteNegocios negocios = new ClienteNegocios();
                string retorno = negocios.Inserir(cliente);

                //Tenta converter para inteiro
                try
                {
                    int idCliente = Convert.ToInt32(retorno);

                    MessageBox.Show("Cliente inserido com sucesso. Codigo: " + idCliente.ToString(), "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Fecha a janela e avisa a tela anterior com o Grid o estado que foi concebido
                    this.DialogResult = DialogResult.Yes;

                }catch
                {
                    MessageBox.Show("Não foi possível incluir cliente. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }

            }
            else if (_acaoSelecionado == AcaoNaTela.ALTERAR)
            {
                Cliente cliente = new Cliente();

                cliente.IdCliente = Convert.ToInt32(txtCodigo.Text);
                cliente.Nome = txtNome.Text;
                cliente.Cpf = txtCpf.Text;
                cliente.Telefone = txtTelefone.Text;
                cliente.Endereco = txtEndereco.Text;
                cliente.Email = txtEmail.Text;

                ClienteNegocios negocios = new ClienteNegocios();
                string retorno = negocios.Atualizar(cliente);

                try
                {
                    //int idCliente = Convert.ToInt32(retorno);
                    MessageBox.Show("Cliente alterado com sucesso!!", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Suporte para a tela com o Grid
                    this.DialogResult = DialogResult.Yes;
                }catch
                {
                    MessageBox.Show("Erro ao alterar o cliente. Detalhes - " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void frmClienteCadastrar_Load(object sender, EventArgs e)
        {

        }
    }
}
