namespace SpeedlinePDV
{
    partial class FormCadastro
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lstCarros;
        private System.Windows.Forms.Label lblCodigo, lblNome, lblMarca, lblCusto, lblVenda, lblEstoque, lblImagem, lblFornecedor;
        private System.Windows.Forms.TextBox txtCodigo, txtNome, txtMarca, txtCusto, txtVenda, txtEstoque, txtImagem;
        private System.Windows.Forms.Button btnCarregarFoto, btnSalvar, btnNovo, btnExcluir, btnCancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbFornecedor;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lstCarros = new System.Windows.Forms.ListBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblCusto = new System.Windows.Forms.Label();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.lblVenda = new System.Windows.Forms.Label();
            this.txtVenda = new System.Windows.Forms.TextBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.cmbFornecedor = new System.Windows.Forms.ComboBox();
            this.lblImagem = new System.Windows.Forms.Label();
            this.txtImagem = new System.Windows.Forms.TextBox();
            this.btnCarregarFoto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstCarros
            // 
            this.lstCarros.FormattingEnabled = true;
            this.lstCarros.Location = new System.Drawing.Point(12, 12);
            this.lstCarros.Name = "lstCarros";
            this.lstCarros.Size = new System.Drawing.Size(220, 394);
            this.lstCarros.TabIndex = 0;
            this.lstCarros.SelectedIndexChanged += new System.EventHandler(this.lstCarros_SelectedIndexChanged);
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(250, 12);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(100, 23);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código do Produto";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(250, 32);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(180, 20);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // lblNome
            // 
            this.lblNome.Location = new System.Drawing.Point(250, 62);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(100, 23);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(250, 82);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(300, 20);
            this.txtNome.TabIndex = 4;
            // 
            // lblMarca
            // 
            this.lblMarca.Location = new System.Drawing.Point(250, 112);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(100, 23);
            this.lblMarca.TabIndex = 5;
            this.lblMarca.Text = "Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(250, 132);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(200, 20);
            this.txtMarca.TabIndex = 6;
            // 
            // lblCusto
            // 
            this.lblCusto.Location = new System.Drawing.Point(250, 162);
            this.lblCusto.Name = "lblCusto";
            this.lblCusto.Size = new System.Drawing.Size(100, 23);
            this.lblCusto.TabIndex = 7;
            this.lblCusto.Text = "Preço Custo";
            // 
            // txtCusto
            // 
            this.txtCusto.Location = new System.Drawing.Point(250, 182);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(120, 20);
            this.txtCusto.TabIndex = 8;
            // 
            // lblVenda
            // 
            this.lblVenda.Location = new System.Drawing.Point(380, 162);
            this.lblVenda.Name = "lblVenda";
            this.lblVenda.Size = new System.Drawing.Size(100, 23);
            this.lblVenda.TabIndex = 9;
            this.lblVenda.Text = "Preço Venda";
            // 
            // txtVenda
            // 
            this.txtVenda.Location = new System.Drawing.Point(380, 182);
            this.txtVenda.Name = "txtVenda";
            this.txtVenda.Size = new System.Drawing.Size(120, 20);
            this.txtVenda.TabIndex = 10;
            // 
            // lblEstoque
            // 
            this.lblEstoque.Location = new System.Drawing.Point(250, 212);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(100, 23);
            this.lblEstoque.TabIndex = 11;
            this.lblEstoque.Text = "Estoque";
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(250, 232);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(80, 20);
            this.txtEstoque.TabIndex = 12;
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.Location = new System.Drawing.Point(250, 262);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(100, 23);
            this.lblFornecedor.TabIndex = 13;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // cmbFornecedor
            // 
            this.cmbFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFornecedor.Location = new System.Drawing.Point(250, 282);
            this.cmbFornecedor.Name = "cmbFornecedor";
            this.cmbFornecedor.Size = new System.Drawing.Size(300, 21);
            this.cmbFornecedor.TabIndex = 14;
            // 
            // lblImagem
            // 
            this.lblImagem.Location = new System.Drawing.Point(250, 312);
            this.lblImagem.Name = "lblImagem";
            this.lblImagem.Size = new System.Drawing.Size(100, 23);
            this.lblImagem.TabIndex = 15;
            this.lblImagem.Text = "Caminho Imagem";
            // 
            // txtImagem
            // 
            this.txtImagem.Location = new System.Drawing.Point(250, 332);
            this.txtImagem.Name = "txtImagem";
            this.txtImagem.Size = new System.Drawing.Size(300, 20);
            this.txtImagem.TabIndex = 16;
            // 
            // btnCarregarFoto
            // 
            this.btnCarregarFoto.Location = new System.Drawing.Point(560, 330);
            this.btnCarregarFoto.Name = "btnCarregarFoto";
            this.btnCarregarFoto.Size = new System.Drawing.Size(100, 23);
            this.btnCarregarFoto.TabIndex = 17;
            this.btnCarregarFoto.Text = "Carregar Foto";
            this.btnCarregarFoto.Click += new System.EventHandler(this.btnCarregarFoto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(560, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(250, 370);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 3;
            this.btnNovo.Text = "Novo";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(340, 370);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(430, 370);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(520, 370);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormCadastro
            // 
            this.ClientSize = new System.Drawing.Size(937, 420);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCarregarFoto);
            this.Controls.Add(this.txtImagem);
            this.Controls.Add(this.lblImagem);
            this.Controls.Add(this.cmbFornecedor);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.txtVenda);
            this.Controls.Add(this.lblVenda);
            this.Controls.Add(this.txtCusto);
            this.Controls.Add(this.lblCusto);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lstCarros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Carros";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
