using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SpeedlinePDV
{
    public partial class FrmEditarDados : Form
    {
        string connectionString = "Server=localhost;Database=speedline_pdv;Uid=root;Pwd=;";

        public FrmEditarDados()
        {
            InitializeComponent();
            CarregarClientes();
            CarregarFornecedores();
        }

        private void CarregarClientes()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string sql = "SELECT id, nome FROM clientes ORDER BY nome ASC";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DataRow dr = dt.NewRow();
                dr["id"] = 0;
                dr["nome"] = "--- Selecione seu cliente ---";
                dt.Rows.InsertAt(dr, 0);

                comboClientes.DataSource = dt;
                comboClientes.DisplayMember = "nome";
                comboClientes.ValueMember = "id";
                comboClientes.SelectedIndex = 0;
            }
        }

        private void CarregarFornecedores()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string sql = "SELECT id, nome FROM fornecedores ORDER BY nome ASC";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DataRow dr = dt.NewRow();
                dr["id"] = 0;
                dr["nome"] = "--- Selecione seu fornecedor ---";
                dt.Rows.InsertAt(dr, 0);

                comboFornecedores.DataSource = dt;
                comboFornecedores.DisplayMember = "nome";
                comboFornecedores.ValueMember = "id";
                comboFornecedores.SelectedIndex = 0;
            }
        }

        private void comboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboClientes.SelectedIndex <= 0)
            {
                LimparCampos();
                return;
            }

            int id = Convert.ToInt32(comboClientes.SelectedValue);
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string sql = "SELECT nome, cpf, email, telefone, endereco FROM clientes WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtNome.Text = dr["nome"].ToString();
                    txtCnpjCpf.Text = dr["cpf"].ToString();
                    txtEmail.Text = dr["email"].ToString();
                    txtTelefone.Text = dr["telefone"].ToString();
                    txtEndereco.Text = dr["endereco"].ToString();
                }
            }
        }

        private void comboFornecedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFornecedores.SelectedIndex <= 0)
            {
                LimparCampos();
                return;
            }

            int id = Convert.ToInt32(comboFornecedores.SelectedValue);
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string sql = "SELECT nome, cnpj, email, telefone, endereco FROM fornecedores WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtNome.Text = dr["nome"].ToString();
                    txtCnpjCpf.Text = dr["cnpj"].ToString();
                    txtEmail.Text = dr["email"].ToString();
                    txtTelefone.Text = dr["telefone"].ToString();
                    txtEndereco.Text = dr["endereco"].ToString();
                }
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (comboClientes.SelectedIndex == 0 && comboFornecedores.SelectedIndex == 0)
            {
                MessageBox.Show("Selecione um cliente OU um fornecedor para atualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtCnpjCpf.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtTelefone.Text) ||
                string.IsNullOrWhiteSpace(txtEndereco.Text))
            {
                MessageBox.Show("Preencha todos os campos antes de atualizar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tabela = comboClientes.SelectedIndex > 0 ? "clientes" : "fornecedores";
            int id = comboClientes.SelectedIndex > 0
                ? Convert.ToInt32(comboClientes.SelectedValue)
                : Convert.ToInt32(comboFornecedores.SelectedValue);

            string campoCodigo = tabela == "clientes" ? "cpf" : "cnpj";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string sql = $"UPDATE {tabela} SET nome=@nome, {campoCodigo}=@codigo, email=@email, telefone=@telefone, endereco=@endereco WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@codigo", txtCnpjCpf.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cadastro atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LimparCampos();
            comboClientes.SelectedIndex = 0;
            comboFornecedores.SelectedIndex = 0;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtCnpjCpf.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = "";
            txtEndereco.Text = "";
        }
    }
}
