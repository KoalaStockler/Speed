using System;
using System.Windows.Forms;

namespace SpeedlinePDV
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            
        }

        private void Produto_Click(object sender, EventArgs e)
        {
            using (var f = new FormCadastro())
                f.ShowDialog();
        }

        private void Caixa_Click(object sender, EventArgs e)
        {
            using (var f = new FormVendas())
                f.ShowDialog();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Cliente_Click(object sender, EventArgs e)
        {
            using (var f = new FrmCadastroCliente())
                f.ShowDialog();
        }

        private void Fornecedor_Click(object sender, EventArgs e)
        {
            using (var f = new FrmCadastroFornecedor())
                f.ShowDialog();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Consulta_Click(object sender, EventArgs e)
        {
            using (var f = new FrmEditarDados())
                f.ShowDialog();
        }
    }
}
