using Presentation;
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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void menuSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair da aplicação?","Empresa X", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();     
            }
        }

        private void menuClientes_Click(object sender, EventArgs e)
        {
            frmClienteSelecionar frm = new frmClienteSelecionar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuProdutos_Click(object sender, EventArgs e)
        {
            frmProdutoSelecionar frm = new frmProdutoSelecionar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuVendas_Click(object sender, EventArgs e)
        {
            frmVendasSelecionar frm = new frmVendasSelecionar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void mnuVendas_Click_1(object sender, EventArgs e)
        {
            frmVendasSelecionar frm = new frmVendasSelecionar();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
