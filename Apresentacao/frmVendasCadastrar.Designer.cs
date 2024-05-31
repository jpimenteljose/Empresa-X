namespace Apresentacao
{
    partial class frmVendasCadastrar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblClienteNome = new System.Windows.Forms.Label();
            this.lblProdutoDescricao = new System.Windows.Forms.Label();
            this.lblQuantidadeMensagem = new System.Windows.Forms.Label();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.dgvVenda = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(509, 286);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 40;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(428, 286);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 39;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(459, 77);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(67, 20);
            this.txtQuantidade.TabIndex = 36;
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuantidade.TextChanged += new System.EventHandler(this.txtQuantidade_LostFocus);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(459, 57);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(63, 17);
            this.lblQuantidade.TabIndex = 35;
            this.lblQuantidade.Text = "Quantidade";
            this.lblQuantidade.UseCompatibleTextRendering = true;
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(231, 77);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(51, 20);
            this.txtProduto.TabIndex = 34;
            this.txtProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtProduto.TextChanged += new System.EventHandler(this.txtProduto_LostFocus);
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(228, 57);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(44, 13);
            this.lblProduto.TabIndex = 33;
            this.lblProduto.Text = "Produto";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(15, 77);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(51, 20);
            this.txtCliente.TabIndex = 32;
            this.txtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_LostFocus);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(63, 12);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(61, 20);
            this.txtCodigo.TabIndex = 31;
            this.txtCodigo.TabStop = false;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(15, 57);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(40, 17);
            this.lblCliente.TabIndex = 30;
            this.lblCliente.Text = "Cliente";
            this.lblCliente.UseCompatibleTextRendering = true;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(19, 14);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(38, 13);
            this.lblCodigo.TabIndex = 29;
            this.lblCodigo.Text = "Venda";
            // 
            // lblClienteNome
            // 
            this.lblClienteNome.Location = new System.Drawing.Point(72, 79);
            this.lblClienteNome.Name = "lblClienteNome";
            this.lblClienteNome.Size = new System.Drawing.Size(144, 17);
            this.lblClienteNome.TabIndex = 41;
            this.lblClienteNome.UseCompatibleTextRendering = true;
            // 
            // lblProdutoDescricao
            // 
            this.lblProdutoDescricao.Location = new System.Drawing.Point(288, 79);
            this.lblProdutoDescricao.Name = "lblProdutoDescricao";
            this.lblProdutoDescricao.Size = new System.Drawing.Size(157, 17);
            this.lblProdutoDescricao.TabIndex = 42;
            this.lblProdutoDescricao.UseCompatibleTextRendering = true;
            // 
            // lblQuantidadeMensagem
            // 
            this.lblQuantidadeMensagem.Location = new System.Drawing.Point(95, 160);
            this.lblQuantidadeMensagem.Name = "lblQuantidadeMensagem";
            this.lblQuantidadeMensagem.Size = new System.Drawing.Size(265, 17);
            this.lblQuantidadeMensagem.TabIndex = 43;
            this.lblQuantidadeMensagem.UseCompatibleTextRendering = true;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(542, 75);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(48, 23);
            this.btnIncluir.TabIndex = 44;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // dgvVenda
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvVenda.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNome,
            this.IdProduto,
            this.colCpf,
            this.colTelefone});
            this.dgvVenda.Location = new System.Drawing.Point(12, 110);
            this.dgvVenda.MultiSelect = false;
            this.dgvVenda.Name = "dgvVenda";
            this.dgvVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVenda.Size = new System.Drawing.Size(581, 153);
            this.dgvVenda.TabIndex = 45;
            // 
            // colCodigo
            // 
            this.colCodigo.DataPropertyName = "IdCliente";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Format = "#,##0";
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            this.colCodigo.DefaultCellStyle = dataGridViewCellStyle2;
            this.colCodigo.HeaderText = "IdCliente";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            this.colCodigo.Width = 70;
            // 
            // colNome
            // 
            this.colNome.DataPropertyName = "Cliente";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colNome.DefaultCellStyle = dataGridViewCellStyle3;
            this.colNome.HeaderText = "Cliente";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            this.colNome.Width = 150;
            // 
            // IdProduto
            // 
            this.IdProduto.HeaderText = "IdProduto";
            this.IdProduto.Name = "IdProduto";
            this.IdProduto.Width = 70;
            // 
            // colCpf
            // 
            this.colCpf.DataPropertyName = "Produto";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colCpf.DefaultCellStyle = dataGridViewCellStyle4;
            this.colCpf.HeaderText = "Produto";
            this.colCpf.Name = "colCpf";
            this.colCpf.ReadOnly = true;
            this.colCpf.Width = 150;
            // 
            // colTelefone
            // 
            this.colTelefone.DataPropertyName = "Quantidade";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colTelefone.DefaultCellStyle = dataGridViewCellStyle5;
            this.colTelefone.HeaderText = "Quantidade";
            this.colTelefone.Name = "colTelefone";
            this.colTelefone.ReadOnly = true;
            this.colTelefone.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTelefone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTelefone.Width = 80;
            // 
            // frmVendasCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 322);
            this.Controls.Add(this.dgvVenda);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.lblQuantidadeMensagem);
            this.Controls.Add(this.lblProdutoDescricao);
            this.Controls.Add(this.lblClienteNome);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblCodigo);
            this.Name = "frmVendasCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVendasCadastrar";
            this.Load += new System.EventHandler(this.frmVendasCadastrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblClienteNome;
        private System.Windows.Forms.Label lblProdutoDescricao;
        private System.Windows.Forms.Label lblQuantidadeMensagem;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.DataGridView dgvVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefone;
    }
}