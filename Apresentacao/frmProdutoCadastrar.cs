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
    public partial class frmProdutoCadastrar : Form
    {
        AcaoNaTela _acaoSelecionado;

        public frmProdutoCadastrar(AcaoNaTela acaoNaTela, Produto produto)
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

                PreencherDados(produto);

            }
            else if (acaoNaTela == AcaoNaTela.CONSULTAR)
            {
                this.Text = "Consultar Cliente";

                PreencherDados(produto);

                txtNome.ReadOnly = true;
                txtNome.TabStop = false;

                txtDescricao.ReadOnly = true;
                txtDescricao.TabStop = false;

                txtPreco.ReadOnly = true;
                txtPreco.TabStop = false;

                txtEstoque.ReadOnly = true;
                txtEstoque.TabStop = false;

                btnSalvar.Visible = false;
                btnCancelar.Text = "Fechar";
                btnCancelar.Focus();
            }
        }

        /// <summary>
        /// Preenchimento dos Dados
        /// </summary>
        /// <param name="produto"></param>
        private void PreencherDados(Produto produto)
        {
            txtCodigo.Text = produto.IdProduto.ToString();
            txtNome.Text = produto.Nome;
            txtDescricao.Text = produto.Descricao;
            txtPreco.Text = produto.Preco;
            txtEstoque.Text = produto.Estoque;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Verificar se é inserção ou alteração
            if (_acaoSelecionado == AcaoNaTela.INSERIR)
            {
                Produto produto = new Produto();

                produto.Nome = txtNome.Text;
                produto.Descricao = txtDescricao.Text;
                produto.Preco = txtPreco.Text;
                produto.Estoque = txtEstoque.Text;

                ProdutoNegocios negocios = new ProdutoNegocios();
                string retorno = negocios.Inserir(produto);

                //Tenta converter para inteiro
                try
                {
                    int idProduto = Convert.ToInt32(retorno);

                    MessageBox.Show("Produto inserido com sucesso. Codigo: " + idProduto.ToString(), "Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Fecha a janela e avisa a tela anterior com o Grid o estado que foi concebido
                    this.DialogResult = DialogResult.Yes;

                }
                catch
                {
                    MessageBox.Show("Não foi possível incluir produto. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }

            }
            else if (_acaoSelecionado == AcaoNaTela.ALTERAR)
            {
                Produto produto = new Produto();

                produto.IdProduto = Convert.ToInt32(txtCodigo.Text);
                produto.Nome = txtNome.Text;
                produto.Descricao = txtDescricao.Text;
                produto.Preco = txtPreco.Text;
                produto.Estoque = txtEstoque.Text;

                ProdutoNegocios negocios = new ProdutoNegocios();
                string retorno = negocios.Atualizar(produto);

                try
                {
                    //int idProduto = Convert.ToInt32(retorno);
                    MessageBox.Show("Produto alterado com sucesso!!", "Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Suporte para a tela com o Grid
                    this.DialogResult = DialogResult.Yes;
                }
                catch
                {
                    MessageBox.Show("Erro ao alterar o produto. Detalhes - " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void frmProdutoCadastrar_Load(object sender, EventArgs e)
        {

        }

    }
}
