namespace SpeedlinePDV
{
    partial class FormMenu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitulo;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Empresa = new System.Windows.Forms.ToolStripButton();
            this.Cliente = new System.Windows.Forms.ToolStripButton();
            this.Fornecedor = new System.Windows.Forms.ToolStripButton();
            this.Funcionario = new System.Windows.Forms.ToolStripButton();
            this.Produto = new System.Windows.Forms.ToolStripButton();
            this.FormPGTO = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.PDV = new System.Windows.Forms.ToolStripButton();
            this.Entradas = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Caixa = new System.Windows.Forms.ToolStripButton();
            this.ContasReceber = new System.Windows.Forms.ToolStripButton();
            this.ContasPG = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Consulta = new System.Windows.Forms.ToolStripButton();
            this.Sair = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.janelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(493, 416);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(623, 65);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "SpeedlinePDV - Versão 1.0";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(80, 80);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Empresa,
            this.Cliente,
            this.Fornecedor,
            this.Funcionario,
            this.Produto,
            this.FormPGTO,
            this.toolStripSeparator1,
            this.PDV,
            this.Entradas,
            this.toolStripSeparator2,
            this.Caixa,
            this.ContasReceber,
            this.ContasPG,
            this.toolStripSeparator3,
            this.Consulta,
            this.Sair});
            this.toolStrip1.Location = new System.Drawing.Point(256, 36);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1122, 87);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // Empresa
            // 
            this.Empresa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Empresa.Enabled = false;
            this.Empresa.Image = ((System.Drawing.Image)(resources.GetObject("Empresa.Image")));
            this.Empresa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Empresa.Name = "Empresa";
            this.Empresa.Size = new System.Drawing.Size(84, 84);
            this.Empresa.Text = "Empresa";
            // 
            // Cliente
            // 
            this.Cliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Cliente.Image = ((System.Drawing.Image)(resources.GetObject("Cliente.Image")));
            this.Cliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(84, 84);
            this.Cliente.Text = "Cliente";
            this.Cliente.Click += new System.EventHandler(this.Cliente_Click);
            // 
            // Fornecedor
            // 
            this.Fornecedor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Fornecedor.Image = ((System.Drawing.Image)(resources.GetObject("Fornecedor.Image")));
            this.Fornecedor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Fornecedor.Name = "Fornecedor";
            this.Fornecedor.Size = new System.Drawing.Size(84, 84);
            this.Fornecedor.Text = "Fornecedor";
            this.Fornecedor.Click += new System.EventHandler(this.Fornecedor_Click);
            // 
            // Funcionario
            // 
            this.Funcionario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Funcionario.Enabled = false;
            this.Funcionario.Image = ((System.Drawing.Image)(resources.GetObject("Funcionario.Image")));
            this.Funcionario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Funcionario.Name = "Funcionario";
            this.Funcionario.Size = new System.Drawing.Size(84, 84);
            this.Funcionario.Text = "Funcionario";
            // 
            // Produto
            // 
            this.Produto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Produto.Image = ((System.Drawing.Image)(resources.GetObject("Produto.Image")));
            this.Produto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Produto.Name = "Produto";
            this.Produto.Size = new System.Drawing.Size(84, 84);
            this.Produto.Text = "Produto";
            this.Produto.Click += new System.EventHandler(this.Produto_Click);
            // 
            // FormPGTO
            // 
            this.FormPGTO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FormPGTO.Enabled = false;
            this.FormPGTO.Image = ((System.Drawing.Image)(resources.GetObject("FormPGTO.Image")));
            this.FormPGTO.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FormPGTO.Name = "FormPGTO";
            this.FormPGTO.Size = new System.Drawing.Size(84, 84);
            this.FormPGTO.Text = "FormaPGTO";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 87);
            // 
            // PDV
            // 
            this.PDV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PDV.Enabled = false;
            this.PDV.Image = ((System.Drawing.Image)(resources.GetObject("PDV.Image")));
            this.PDV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PDV.Name = "PDV";
            this.PDV.Size = new System.Drawing.Size(84, 84);
            this.PDV.Text = "PDV";
            // 
            // Entradas
            // 
            this.Entradas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Entradas.Enabled = false;
            this.Entradas.Image = ((System.Drawing.Image)(resources.GetObject("Entradas.Image")));
            this.Entradas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Entradas.Name = "Entradas";
            this.Entradas.Size = new System.Drawing.Size(84, 84);
            this.Entradas.Text = "Entradas";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 87);
            // 
            // Caixa
            // 
            this.Caixa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Caixa.Image = ((System.Drawing.Image)(resources.GetObject("Caixa.Image")));
            this.Caixa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Caixa.Name = "Caixa";
            this.Caixa.Size = new System.Drawing.Size(84, 84);
            this.Caixa.Text = "Caixa";
            this.Caixa.Click += new System.EventHandler(this.Caixa_Click);
            // 
            // ContasReceber
            // 
            this.ContasReceber.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ContasReceber.Enabled = false;
            this.ContasReceber.Image = ((System.Drawing.Image)(resources.GetObject("ContasReceber.Image")));
            this.ContasReceber.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ContasReceber.Name = "ContasReceber";
            this.ContasReceber.Size = new System.Drawing.Size(84, 84);
            this.ContasReceber.Text = "ContasReceber";
            // 
            // ContasPG
            // 
            this.ContasPG.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ContasPG.Enabled = false;
            this.ContasPG.Image = ((System.Drawing.Image)(resources.GetObject("ContasPG.Image")));
            this.ContasPG.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ContasPG.Name = "ContasPG";
            this.ContasPG.Size = new System.Drawing.Size(84, 84);
            this.ContasPG.Text = "ContasPG";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 87);
            // 
            // Consulta
            // 
            this.Consulta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Consulta.Image = ((System.Drawing.Image)(resources.GetObject("Consulta.Image")));
            this.Consulta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Consulta.Name = "Consulta";
            this.Consulta.Size = new System.Drawing.Size(84, 84);
            this.Consulta.Text = "Consulta";
            this.Consulta.Click += new System.EventHandler(this.Consulta_Click);
            // 
            // Sair
            // 
            this.Sair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Sair.Image = ((System.Drawing.Image)(resources.GetObject("Sair.Image")));
            this.Sair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(84, 84);
            this.Sair.Text = "Sair";
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(12, 12);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.exibirToolStripMenuItem,
            this.cadastrosToolStripMenuItem,
            this.entradasToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.financeiroToolStripMenuItem,
            this.reToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.utilitáriosToolStripMenuItem,
            this.configuraçãoToolStripMenuItem,
            this.janelaToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1484, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.exibirToolStripMenuItem.Text = "Exibir";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // entradasToolStripMenuItem
            // 
            this.entradasToolStripMenuItem.Name = "entradasToolStripMenuItem";
            this.entradasToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.entradasToolStripMenuItem.Text = "Entradas";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // reToolStripMenuItem
            // 
            this.reToolStripMenuItem.Name = "reToolStripMenuItem";
            this.reToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.reToolStripMenuItem.Text = "Relatórios";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // utilitáriosToolStripMenuItem
            // 
            this.utilitáriosToolStripMenuItem.Name = "utilitáriosToolStripMenuItem";
            this.utilitáriosToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.utilitáriosToolStripMenuItem.Text = "Utilitários";
            // 
            // configuraçãoToolStripMenuItem
            // 
            this.configuraçãoToolStripMenuItem.Name = "configuraçãoToolStripMenuItem";
            this.configuraçãoToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.configuraçãoToolStripMenuItem.Text = "Configuração";
            // 
            // janelaToolStripMenuItem
            // 
            this.janelaToolStripMenuItem.Name = "janelaToolStripMenuItem";
            this.janelaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.janelaToolStripMenuItem.Text = "Janela";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(439, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fornecedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(525, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Funcionário";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(620, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Produto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(684, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Forma de PGTO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(804, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "PDV";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(884, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Entradas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(975, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Caixa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1028, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Contas a receber";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1122, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Contas a pagar";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1227, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Consulta";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1312, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Sair";
            // 
            // FormMenu
            // 
            this.ClientSize = new System.Drawing.Size(1484, 881);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpeedlinePDV";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Empresa;
        private System.Windows.Forms.ToolStripButton Cliente;
        private System.Windows.Forms.ToolStripButton Fornecedor;
        private System.Windows.Forms.ToolStripButton Funcionario;
        private System.Windows.Forms.ToolStripButton Produto;
        private System.Windows.Forms.ToolStripButton FormPGTO;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton PDV;
        private System.Windows.Forms.ToolStripButton Entradas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton Caixa;
        private System.Windows.Forms.ToolStripButton ContasReceber;
        private System.Windows.Forms.ToolStripButton ContasPG;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton Consulta;
        private System.Windows.Forms.ToolStripButton Sair;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilitáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem janelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}
