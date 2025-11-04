namespace SpeedlinePDV
{
    partial class FormVendas
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ComboBox selecionarCli;
        private System.Windows.Forms.ComboBox selecionarCarro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNome, lblMarca, lblPreco, lblTotal, lblEstoque, lblQtdLabel;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.Button btnConfirmar, btnCancelar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.selecionarCli = new System.Windows.Forms.ComboBox();
            this.selecionarCarro = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.lblQtdLabel = new System.Windows.Forms.Label();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // selecionarCli
            // 
            this.selecionarCli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selecionarCli.Location = new System.Drawing.Point(12, 12);
            this.selecionarCli.Name = "selecionarCli";
            this.selecionarCli.Size = new System.Drawing.Size(250, 21);
            this.selecionarCli.TabIndex = 0;
            // 
            // selecionarCarro
            // 
            this.selecionarCarro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selecionarCarro.FormattingEnabled = true;
            this.selecionarCarro.Location = new System.Drawing.Point(12, 50);
            this.selecionarCarro.Name = "selecionarCarro";
            this.selecionarCarro.Size = new System.Drawing.Size(250, 21);
            this.selecionarCarro.TabIndex = 1;
            this.selecionarCarro.SelectedIndexChanged += new System.EventHandler(this.selecionarCarro_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(280, 90);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(0, 13);
            this.lblNome.TabIndex = 3;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(280, 120);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(0, 13);
            this.lblMarca.TabIndex = 4;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(280, 150);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(42, 13);
            this.lblPreco.TabIndex = 5;
            this.lblPreco.Text = "R$0,00";
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Location = new System.Drawing.Point(280, 180);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(13, 13);
            this.lblEstoque.TabIndex = 6;
            this.lblEstoque.Text = "0";
            // 
            // lblQtdLabel
            // 
            this.lblQtdLabel.AutoSize = true;
            this.lblQtdLabel.Location = new System.Drawing.Point(280, 210);
            this.lblQtdLabel.Name = "lblQtdLabel";
            this.lblQtdLabel.Size = new System.Drawing.Size(62, 13);
            this.lblQtdLabel.TabIndex = 7;
            this.lblQtdLabel.Text = "Quantidade";
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.Location = new System.Drawing.Point(280, 230);
            this.nudQuantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(100, 20);
            this.nudQuantidade.TabIndex = 8;
            this.nudQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantidade.ValueChanged += new System.EventHandler(this.nudQuantidade_ValueChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(280, 260);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(42, 13);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "R$0,00";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(280, 290);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(100, 25);
            this.btnConfirmar.TabIndex = 10;
            this.btnConfirmar.Text = "Confirmar Venda";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(400, 290);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 25);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormVendas
            // 
            this.ClientSize = new System.Drawing.Size(550, 350);
            this.Controls.Add(this.selecionarCli);
            this.Controls.Add(this.selecionarCarro);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.lblQtdLabel);
            this.Controls.Add(this.nudQuantidade);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas - SpeedlinePDV";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
