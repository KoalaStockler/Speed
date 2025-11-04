using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SpeedlinePDV
{
    public partial class FrmCadastroCliente : Form
    {
        string connectionString = "Server=localhost;Database=speedline_pdv;Uid=root;Pwd=;";

        public FrmCadastroCliente()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // ================== VALIDAÇÕES BÁSICAS ==================
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtCpf.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtTelefone.Text) ||
                string.IsNullOrWhiteSpace(txtEndereco.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ================== CPF ==================
            if (txtCpf.Text.Length != 11 || !long.TryParse(txtCpf.Text, out _))
            {
                MessageBox.Show("CPF inválido! Digite apenas números (11 dígitos).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ================== TELEFONE ==================
            string telefone = Regex.Replace(txtTelefone.Text, @"\D", ""); // remove tudo que não é número
            if (telefone.Length < 10 || telefone.Length > 11)
            {
                MessageBox.Show("Telefone inválido! Digite DDD + número (mínimo 10 dígitos).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ================== EMAIL ==================
            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
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

                    // ======== VALIDA DUPLICIDADE DE CPF ========
                    string verificaCPF = "SELECT COUNT(*) FROM clientes WHERE cpf = @cpf";
                    using (MySqlCommand cmd = new MySqlCommand(verificaCPF, con))
                    {
                        cmd.Parameters.AddWithValue("@cpf", txtCpf.Text.Trim());
                        int existe = Convert.ToInt32(cmd.ExecuteScalar());
                        if (existe > 0)
                        {
                            MessageBox.Show("Já existe um cliente com esse CPF!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // ======== VALIDA DUPLICIDADE DE EMAIL ========
                    string verificaEmail = "SELECT COUNT(*) FROM clientes WHERE email = @em";
                    using (MySqlCommand cmd = new MySqlCommand(verificaEmail, con))
                    {
                        cmd.Parameters.AddWithValue("@em", txtEmail.Text.Trim());
                        int existe = Convert.ToInt32(cmd.ExecuteScalar());
                        if (existe > 0)
                        {
                            MessageBox.Show("Já existe um cliente com esse e-mail!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // ================== INSERE CLIENTE ==================
                    string sql = "INSERT INTO clientes (nome, cpf, email, telefone, endereco) VALUES (@nome, @cpf, @email, @telefone, @endereco)";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@nome", txtNome.Text.Trim());
                        cmd.Parameters.AddWithValue("@cpf", txtCpf.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text.Trim());
                        cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtCpf.Clear();
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
