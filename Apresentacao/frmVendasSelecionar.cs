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

namespace Apresentacao
{
    public partial class frmVendasSelecionar : Form
    {
        public frmVendasSelecionar()
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
            VendasNegocios vendasNegocios = new VendasNegocios();

            VendasCollection vendasColecao = new VendasCollection();

            string texto = txtPesquisa.Text;

            if (texto == "")
            {
                vendasColecao = vendasNegocios.ConsultarTodas();
            }
            else
            { 
                    if (int.TryParse(texto, out _))
                {
                    vendasColecao = vendasNegocios.ConsultarPorId(int.Parse(texto));
                }
            }
            
            dgvPrincipal.DataSource = null;
            dgvPrincipal.DataSource = vendasColecao;

            dgvPrincipal.Update();
            dgvPrincipal.Refresh();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma venda selecionada.");

                return;
            }
            else
            {
                if (MessageBox.Show("Deseja excluir a venda selecionada?", "Vendas", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Vendas vendaSelecionada = new Vendas();
                    //Coleta a venda selecionada no DataGridView sempre será apenas um
                    vendaSelecionada = (dgvPrincipal.SelectedRows[0].DataBoundItem as Vendas);

                    VendasNegocios vendaNegocios = new VendasNegocios();
                    string retorno = vendaNegocios.Excluir(vendaSelecionada);

                    //Verifica se excluiu com sucesso
                    //Se o retorno for número é porque deu certo, senão é mensagem de erro
                    try
                    {
                        //int idVenda = Convert.ToInt32(retorno);
                        MessageBox.Show("Venda excluída com sucesso!!", "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        AtualizarGrid();

                    }
                    catch
                    {
                        MessageBox.Show("Não foi possível excluir venda. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            frmVendasCadastrar frm = new frmVendasCadastrar(AcaoNaTela.INSERIR, null);
            DialogResult dialog = frm.ShowDialog();
            //Atualiza o Grid quando for OK na tela de cadastro
            if (dialog == DialogResult.Yes)
            {
                AtualizarGrid();
            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma venda selecionada.", "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            else
            {
                Vendas vendaSelecionada = new Vendas();
                //Coleta a venda selecionado no DataGridView sempre será apenas um
                vendaSelecionada = (dgvPrincipal.SelectedRows[0].DataBoundItem as Vendas);

                frmVendasCadastrar frm = new frmVendasCadastrar(AcaoNaTela.ALTERAR, vendaSelecionada);
                DialogResult dialog = frm.ShowDialog();

                if (dialog == DialogResult.Yes)
                {
                    AtualizarGrid();
                }
            }

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (dgvPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma venda selecionada.");

                return;
            }
            else
            {
                Vendas vendaSelecionada = new Vendas();
                //Coleta a venda selecionado no DataGridView sempre será apenas um
                vendaSelecionada = (dgvPrincipal.SelectedRows[0].DataBoundItem as Vendas);

                frmVendasCadastrar frm = new frmVendasCadastrar(AcaoNaTela.CONSULTAR, vendaSelecionada);
                frm.ShowDialog();
            }

        }

        private void frmVendasSelecionar_Load(object sender, EventArgs e)
        {
            VendasNegocios vendasNegocios = new VendasNegocios();

            VendasCollection vendasColecao = new VendasCollection();
            vendasColecao = vendasNegocios.ConsultarTodas();

            dgvPrincipal.DataSource = null;
            dgvPrincipal.DataSource = vendasColecao;

            dgvPrincipal.Update();
            dgvPrincipal.Refresh();
        }

        private void frmVendasSelecionar_Load_1(object sender, EventArgs e)
        {
            VendasNegocios vendasNegocios = new VendasNegocios();

            VendasCollection vendasColecao = new VendasCollection();
            vendasColecao = vendasNegocios.ConsultarTodas();

            dgvPrincipal.DataSource = null;
            dgvPrincipal.DataSource = vendasColecao;

            dgvPrincipal.Update();
            dgvPrincipal.Refresh();
        }
    }
}
