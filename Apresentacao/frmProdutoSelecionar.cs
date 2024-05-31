using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Apresentacao;
using Negocios;
using ObjetoTransferencia;

namespace Presentation
{
    public partial class frmProdutoSelecionar : Form
    {
        public frmProdutoSelecionar()
        {
            InitializeComponent();

            //Não gerar linhas automaticamente
            dgvPrincipal.AutoGenerateColumns = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            ProdutoNegocios produtoNegocios = new ProdutoNegocios();

            ProdutoCollection produtoColecao = new ProdutoCollection();

            string texto = txtPesquisa.Text;

            if (texto == "")
            {
                produtoColecao = produtoNegocios.ConsultarTodos();
            }
            else
            {
                // Verifica se o texto é um número inteiro
                if (int.TryParse(texto, out _))
                {
                    produtoColecao = produtoNegocios.ConsultarPorId(int.Parse(texto));
                }
                else
                {
                    produtoColecao = produtoNegocios.ConsultarPorNome(txtPesquisa.Text);
                }
            }

            dgvPrincipal.DataSource = null;
            dgvPrincipal.DataSource = produtoColecao;

            dgvPrincipal.Update();
            dgvPrincipal.Refresh();
        }

        private void btnFechar1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum produto selecionado.");

                return;
            }
            else
            {
                if (MessageBox.Show("Deseja excluir o produto selecionado?", "Produtos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Produto produtoSelecionado = new Produto();
                    //Coleta o cliente selecionado no DataGridView sempre será apenas um
                    produtoSelecionado = (dgvPrincipal.SelectedRows[0].DataBoundItem as Produto);

                    ProdutoNegocios produtoNegocios = new ProdutoNegocios();
                    string retorno = produtoNegocios.Excluir(produtoSelecionado);

                    //Verifica se excluiu com sucesso
                    //Se o retorno for número é porque deu certo, senão é mensagem de erro
                    try
                    {
                        //int idProduto = Convert.ToInt32(retorno);
                        MessageBox.Show("Produto excluído com sucesso!!", "Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        AtualizarGrid();

                    }
                    catch
                    {
                        MessageBox.Show("Não foi possível excluir produto. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void btnInserir1_Click(object sender, EventArgs e)
        {
            frmProdutoCadastrar frm = new frmProdutoCadastrar(AcaoNaTela.INSERIR, null);
            DialogResult dialog = frm.ShowDialog();
            //Atualiza o Grid quando for OK na tela de cadastro
            if (dialog == DialogResult.Yes)
            {
                AtualizarGrid();
            }
        }

        private void btnAlterar1_Click(object sender, EventArgs e)
        {
            if (dgvPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum produto selecionado.", "Produtos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            else
            {
                Produto produtoSelecionado = new Produto();
                //Coleta o produto selecionado no DataGridView sempre será apenas um
                produtoSelecionado = (dgvPrincipal.SelectedRows[0].DataBoundItem as Produto);

                frmProdutoCadastrar frm = new frmProdutoCadastrar(AcaoNaTela.ALTERAR, produtoSelecionado);
                DialogResult dialog = frm.ShowDialog();

                if (dialog == DialogResult.Yes)
                {
                    AtualizarGrid();
                }
            }
        }

        private void btnConsultar1_Click(object sender, EventArgs e)
        {
            if (dgvPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum produto selecionado.");

                return;
            }
            else
            {
                Produto produtoSelecionado = new Produto();
                //Coleta o produto selecionado no DataGridView sempre será apenas um
                produtoSelecionado = (dgvPrincipal.SelectedRows[0].DataBoundItem as Produto);

                frmProdutoCadastrar frm = new frmProdutoCadastrar(AcaoNaTela.CONSULTAR, produtoSelecionado);
                frm.ShowDialog();
            }
        }

        private void frmProdutoSelecionar_Load(object sender, EventArgs e)
        {
            ProdutoNegocios produtoNegocios = new ProdutoNegocios();

            ProdutoCollection produtoColecao = new ProdutoCollection();
            produtoColecao = produtoNegocios.ConsultarTodos();

            dgvPrincipal.DataSource = null;
            dgvPrincipal.DataSource = produtoColecao;

            dgvPrincipal.Update();
            dgvPrincipal.Refresh();

        }

    }
}
