namespace SpeedlinePDV
{
    partial class FrmCadastroCliente
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Size = new System.Drawing.Size(400, 35);
            this.lblTitulo.Text = "Cadastro de Cliente";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Labels
            // 
            this.lblNome.Text = "Nome:";
            this.lblNome.Location = new System.Drawing.Point(40, 70);
            this.lblCpf.Text = "CPF:";
            this.lblCpf.Location = new System.Drawing.Point(40, 120);
            this.lblEmail.Text = "Email:";
            this.lblEmail.Location = new System.Drawing.Point(40, 170);
            this.lblTelefone.Text = "Telefone:";
            this.lblTelefone.Location = new System.Drawing.Point(40, 220);
            this.lblEndereco.Text = "Endereço:";
            this.lblEndereco.Location = new System.Drawing.Point(40, 270);
            // 
            // TextBoxes
            // 
            this.txtNome.Location = new System.Drawing.Point(140, 70);
            this.txtNome.Size = new System.Drawing.Size(250, 23);
            this.txtCpf.Location = new System.Drawing.Point(140, 120);
            this.txtCpf.Size = new System.Drawing.Size(250, 23);
            this.txtEmail.Location = new System.Drawing.Point(140, 170);
            this.txtEmail.Size = new System.Drawing.Size(250, 23);
            this.txtTelefone.Location = new System.Drawing.Point(140, 220);
            this.txtTelefone.Size = new System.Drawing.Size(250, 23);
            this.txtEndereco.Location = new System.Drawing.Point(140, 270);
            this.txtEndereco.Size = new System.Drawing.Size(250, 23);
            // 
            // Botões
            // 
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Location = new System.Drawing.Point(60, 320);
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.Location = new System.Drawing.Point(170, 320);
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            this.btnFechar.Text = "Fechar";
            this.btnFechar.Location = new System.Drawing.Point(280, 320);
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FrmCadastroCliente
            // 
            this.ClientSize = new System.Drawing.Size(450, 380);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnFechar);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
