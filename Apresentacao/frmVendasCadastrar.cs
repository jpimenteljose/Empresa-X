using Negocios;
using ObjetoTransferencia;
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
    public partial class frmVendasCadastrar : Form
    {
        AcaoNaTela _acaoSelecionado;

        public frmVendasCadastrar(AcaoNaTela acaoNaTela, Vendas vendas)
        {
            InitializeComponent();

            //Coletando a ação selecionada pelo usuário
            this._acaoSelecionado = acaoNaTela;

            if (acaoNaTela == AcaoNaTela.INSERIR)
            {
                this.Text = "Inserir Venda";
            }
            else if (acaoNaTela == AcaoNaTela.ALTERAR)
            {
                this.Text = "Alterar Venda";

                PreencherDados(vendas);
            }
            else if (acaoNaTela == AcaoNaTela.CONSULTAR)
            {
                this.Text = "Consultar Venda";

                PreencherDados(vendas);

                txtCliente.ReadOnly = true;
                txtCliente.TabStop = false;

                txtProduto.ReadOnly = true;
                txtProduto.TabStop = false;

                txtQuantidade.ReadOnly = true;
                txtQuantidade.TabStop = false;

                dgvVenda.Enabled = false;
                btnSalvar.Visible = false;
                btnIncluir.Enabled = false;
                btnCancelar.Text = "Fechar";
                btnCancelar.Focus();
            }
        }

        private void PreencherDados(Vendas venda)
        {
            txtCodigo.Text = venda.IdVenda.ToString();
            txtCliente.Text = venda.IdCliente.ToString();
            lblClienteNome.Text = venda.Cliente.ToString();
            txtProduto.Text = venda.IdProduto.ToString();
            lblProdutoDescricao.Text = venda.Produto.ToString();
            txtQuantidade.Text = venda.Quantidade.ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Verificar se é inserção ou alteração
            if (_acaoSelecionado == AcaoNaTela.INSERIR)
            {
                Vendas venda = new Vendas();

                venda.Cliente = txtCliente.Text;
                venda.Produto = txtProduto.Text;
                venda.Quantidade = int.Parse(txtQuantidade.Text);

                VendasNegocios negocios = new VendasNegocios();
                string retorno = negocios.Inserir(venda);

                //Tenta converter para inteiro
                try
                {
                    int idVenda = Convert.ToInt32(retorno);

                    MessageBox.Show("Venda inserida com sucesso. Codigo: " + idVenda.ToString(), "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Fecha a janela e avisa a tela anterior com o Grid o estado que foi concebido
                    this.DialogResult = DialogResult.Yes;

                }
                catch
                {
                    MessageBox.Show("Não foi possível incluir venda. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }

            }
            else if (_acaoSelecionado == AcaoNaTela.ALTERAR)
            {
                Vendas venda = new Vendas();

                venda.IdVenda = Convert.ToInt32(txtCodigo.Text);
                venda.Cliente = txtCliente.Text;
                venda.Produto = txtProduto.Text;
                venda.Quantidade = Convert.ToInt32(txtQuantidade.Text);

                VendasNegocios negocios = new VendasNegocios();
                string retorno = negocios.Atualizar(venda);

                try
                {
                    int idVenda = Convert.ToInt32(retorno);
                    MessageBox.Show("Venda alterada com sucesso!!", "Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Suporte para a tela com o Grid
                    this.DialogResult = DialogResult.Yes;
                }
                catch
                {
                    MessageBox.Show("Erro ao alterar venda. Detalhes - " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void txtCliente_LostFocus(object sender, EventArgs e)
        {
            try
            {
                lblClienteNome.Text = "";

                if (txtCliente.Text != "")
                {
                    ClienteNegocios clienteNegocios = new ClienteNegocios();
                    string texto = txtCliente.Text;

                    var nomeCliente = clienteNegocios.ConsultarNome(int.Parse(texto)).ToString();

                    if (nomeCliente != "")
                    {
                        lblClienteNome.ForeColor = Color.Black;
                        lblClienteNome.Text = nomeCliente;
                    }
                    else
                    {
                        MessageBox.Show("Cliente não encontrato.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCliente.Clear();
                        txtCliente.Focus();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar venda. Detalhes - " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.No;
            }
        }

        private void txtProduto_LostFocus(object sender, EventArgs e)
        {
            try
            {
                lblProdutoDescricao.Text = "";

                if (txtProduto.Text != "")
                {
                    ProdutoNegocios produtoNegocios = new ProdutoNegocios();
                    string texto = txtProduto.Text;

                    var descricaoProduto = produtoNegocios.ConsultarDerscricao(int.Parse(texto)).ToString();

                    if (descricaoProduto != "")
                    {
                        lblProdutoDescricao.ForeColor = Color.Black;
                        lblProdutoDescricao.Text = descricaoProduto;
                    }
                    else
                    {
                        MessageBox.Show("Produto não encontrato.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtProduto.Clear();
                        txtProduto.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar venda. Detalhes - " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.No;
            }
        }

        private void txtQuantidade_LostFocus(object sender, EventArgs e)
        {
            try
            {
                lblQuantidadeMensagem.Text = "";

                if (txtQuantidade.Text != "")
                {
                    ProdutoNegocios produtoNegocios = new ProdutoNegocios();
                    string idProduto = txtProduto.Text;
                    string quantidade = txtQuantidade.Text;

                    var estoqueProduto = produtoNegocios.ConsultarEstoquePorId(int.Parse(idProduto));

                    if (int.Parse(estoqueProduto) < int.Parse(quantidade))
                    {
                        MessageBox.Show("Quantidade do produto no estoque: " + estoqueProduto, "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        txtQuantidade.Clear();
                        txtQuantidade.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar venda. Detalhes - " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.No;
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtProduto.Text == "")
            {
                MessageBox.Show("Informe o Código do Produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProduto.Focus();
                return;
            }
            if (txtCliente.Text == "")
            {
                MessageBox.Show("Informe o Código do Cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCliente.Focus();
                return;
            }
            if (txtQuantidade.Text == "")
            {
                MessageBox.Show("Informe a Quantidade do Produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantidade.Focus();
                return;

            }

            string idCliente = txtCliente.Text;
            string cliente =lblClienteNome.Text;
            string idProduto = txtProduto.Text;
            string produto = lblProdutoDescricao.Text;
            string quantidade = txtQuantidade.Text;

            this.dgvVenda.Rows.Add(idCliente, cliente, idProduto, produto, quantidade);

            this.txtCliente.Clear();
            this.lblClienteNome.Text = "";
            this.txtProduto.Clear();
            lblProdutoDescricao.Text = "";
            this.txtQuantidade.Clear();

            this.txtCliente.Focus();
        }

        private void frmVendasCadastrar_Load(object sender, EventArgs e)
        {
            dgvVenda.Rows.Clear();
        }
    }
}
