using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SpeedlinePDV
{
    public partial class FrmCadastroFornecedor : Form
    {
        string connectionString = "Server=localhost;Database=speedline_pdv;Uid=root;Pwd=;";

        public FrmCadastroFornecedor()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // ================== VALIDAÇÕES BÁSICAS ==================
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtCnpj.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtTelefone.Text) ||
                string.IsNullOrWhiteSpace(txtEndereco.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ================== CNPJ ==================
            string cnpj = Regex.Replace(txtCnpj.Text, @"\D", ""); // remove caracteres não numéricos
            if (cnpj.Length != 14 || !long.TryParse(cnpj, out _))
            {
                MessageBox.Show("CNPJ inválido! Digite apenas números (14 dígitos).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ================== TELEFONE ==================
            string telefone = Regex.Replace(txtTelefone.Text, @"\D", "");
            if (telefone.Length < 10 || telefone.Length > 11)
            {
                MessageBox.Show("Telefone inválido! Digite DDD + número (mínimo 10 dígitos).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ================== EMAIL ==================
            if (!Regex.IsMatch(txtEmail.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("E-mail inválido! Verifique o formato (ex: exemplo@dominio.com).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ================== CONEXÃO COM BANCO ==================
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    // ======== VERIFICA DUPLICIDADE DE CNPJ ========
                    string verificaCNPJ = "SELECT COUNT(*) FROM fornecedores WHERE cnpj = @cnpj";
                    using (MySqlCommand cmd = new MySqlCommand(verificaCNPJ, con))
                    {
                        cmd.Parameters.AddWithValue("@cnpj", txtCnpj.Text.Trim());
                        int existe = Convert.ToInt32(cmd.ExecuteScalar());
                        if (existe > 0)
                        {
                            MessageBox.Show("Já existe um fornecedor com esse CNPJ!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // ======== VERIFICA DUPLICIDADE DE EMAIL ========
                    string verificaEmail = "SELECT COUNT(*) FROM fornecedores WHERE email = @email";
                    using (MySqlCommand cmd = new MySqlCommand(verificaEmail, con))
                    {
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        int existe = Convert.ToInt32(cmd.ExecuteScalar());
                        if (existe > 0)
                        {
                            MessageBox.Show("Já existe um fornecedor com esse e-mail!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // ================== INSERE FORNECEDOR ==================
                    string sql = "INSERT INTO fornecedores (nome, cnpj, email, telefone, endereco) VALUES (@nome, @cnpj, @email, @telefone, @endereco)";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@nome", txtNome.Text.Trim());
                        cmd.Parameters.AddWithValue("@cnpj", txtCnpj.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text.Trim());
                        cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Fornecedor cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro de banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro inesperado: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtCnpj.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtEndereco.Clear();
            txtNome.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
