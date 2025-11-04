namespace SpeedlinePDV
{
    partial class FrmEditarDados
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox comboClientes;
        private System.Windows.Forms.ComboBox comboFornecedores;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCnpjCpf;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCnpjCpf;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnFechar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.comboClientes = new System.Windows.Forms.ComboBox();
            this.comboFornecedores = new System.Windows.Forms.ComboBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCnpjCpf = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCnpjCpf = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(760, 35);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Editar Cadastro de Cliente ou Fornecedor";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCliente
            // 
            this.lblCliente.Location = new System.Drawing.Point(40, 70);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(54, 23);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.Location = new System.Drawing.Point(400, 70);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(75, 23);
            this.lblFornecedor.TabIndex = 3;
            this.lblFornecedor.Text = "Fornecedor:";
            // 
            // comboClientes
            // 
            this.comboClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboClientes.Location = new System.Drawing.Point(100, 67);
            this.comboClientes.Name = "comboClientes";
            this.comboClientes.Size = new System.Drawing.Size(250, 21);
            this.comboClientes.TabIndex = 2;
            this.comboClientes.SelectedIndexChanged += new System.EventHandler(this.comboClientes_SelectedIndexChanged);
            // 
            // comboFornecedores
            // 
            this.comboFornecedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFornecedores.Location = new System.Drawing.Point(490, 67);
            this.comboFornecedores.Name = "comboFornecedores";
            this.comboFornecedores.Size = new System.Drawing.Size(250, 21);
            this.comboFornecedores.TabIndex = 4;
            this.comboFornecedores.SelectedIndexChanged += new System.EventHandler(this.comboFornecedores_SelectedIndexChanged);
            // 
            // lblNome
            // 
            this.lblNome.Location = new System.Drawing.Point(40, 130);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(100, 23);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome:";
            // 
            // lblCnpjCpf
            // 
            this.lblCnpjCpf.Location = new System.Drawing.Point(40, 170);
            this.lblCnpjCpf.Name = "lblCnpjCpf";
            this.lblCnpjCpf.Size = new System.Drawing.Size(100, 23);
            this.lblCnpjCpf.TabIndex = 7;
            this.lblCnpjCpf.Text = "CNPJ/CPF:";
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(40, 210);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 23);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.Location = new System.Drawing.Point(40, 250);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(100, 23);
            this.lblTelefone.TabIndex = 11;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.Location = new System.Drawing.Point(40, 290);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(100, 23);
            this.lblEndereco.TabIndex = 13;
            this.lblEndereco.Text = "Endereço:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(140, 130);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(600, 20);
            this.txtNome.TabIndex = 6;
            // 
            // txtCnpjCpf
            // 
            this.txtCnpjCpf.Location = new System.Drawing.Point(140, 170);
            this.txtCnpjCpf.Name = "txtCnpjCpf";
            this.txtCnpjCpf.Size = new System.Drawing.Size(600, 20);
            this.txtCnpjCpf.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(140, 210);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(600, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(140, 250);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(600, 20);
            this.txtTelefone.TabIndex = 12;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(140, 290);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(600, 20);
            this.txtEndereco.TabIndex = 14;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(250, 340);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 15;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(400, 340);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 16;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FrmEditarCadastro
            // 
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.comboClientes);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.comboFornecedores);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblCnpjCpf);
            this.Controls.Add(this.txtCnpjCpf);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnFechar);
            this.Name = "FrmEditarCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
