using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SpeedlinePDV
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
            CarregarLista();
            CarregarFornecedores();

            // Placeholder visual (primeiro item em cinza)
            cmbFornecedor.DrawMode = DrawMode.OwnerDrawFixed;
            cmbFornecedor.DrawItem += (s, e) =>
            {
                e.DrawBackground();
                if (e.Index < 0) return;
                string text = cmbFornecedor.GetItemText(cmbFornecedor.Items[e.Index]);
                Brush brush = (e.Index == 0) ? Brushes.Gray : Brushes.Black;
                e.Graphics.DrawString(text, e.Font, brush, e.Bounds);
            };
        }

        // ===================== LISTAGEM =====================
        private void CarregarLista()
        {
            lstCarros.Items.Clear();
            using (var conn = Conexao.GetConnection())
            {
                string sql = "SELECT codigo, nome FROM carros ORDER BY nome";
                using (var cmd = new MySqlCommand(sql, conn))
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                        lstCarros.Items.Add($"{rdr.GetString("codigo")} - {rdr.GetString("nome")}");
                }
            }
        }

        // ===================== FORNECEDORES =====================
        private void CarregarFornecedores()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("nome", typeof(string));

            using (var conn = Conexao.GetConnection())
            {
                string sql = "SELECT id, nome FROM fornecedores ORDER BY nome";
                using (var cmd = new MySqlCommand(sql, conn))
                using (var rdr = cmd.ExecuteReader())
                {
                    dt.Rows.Add(0, "--- Selecione um fornecedor ---");
                    while (rdr.Read())
                        dt.Rows.Add(rdr.GetInt32("id"), rdr.GetString("nome"));
                }
            }

            cmbFornecedor.DataSource = dt;
            cmbFornecedor.DisplayMember = "nome";
            cmbFornecedor.ValueMember = "id";
            cmbFornecedor.SelectedIndex = 0;
        }

        // ===================== VALIDAÇÃO DE CAMPOS =====================
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Informe o código do produto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Informe o nome do carro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMarca.Text))
            {
                MessageBox.Show("Informe a marca do carro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMarca.Focus();
                return false;
            }

            if (!decimal.TryParse(txtCusto.Text, out decimal custo) || custo <= 0)
            {
                MessageBox.Show("Informe um preço de custo válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCusto.Focus();
                return false;
            }

            if (!decimal.TryParse(txtVenda.Text, out decimal venda) || venda <= 0)
            {
                MessageBox.Show("Informe um preço de venda válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVenda.Focus();
                return false;
            }

            if (!int.TryParse(txtEstoque.Text, out int estoque) || estoque < 0)
            {
                MessageBox.Show("Informe um estoque válido (0 ou mais).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEstoque.Focus();
                return false;
            }

            if (cmbFornecedor.SelectedIndex <= 0)
            {
                MessageBox.Show("Selecione um fornecedor válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbFornecedor.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtImagem.Text) && !File.Exists(txtImagem.Text))
            {
                MessageBox.Show("O caminho da imagem não é válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtImagem.Focus();
                return false;
            }

            return true;
        }

        // ===================== SALVAR =====================
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
            {
                using (var conn = Conexao.GetConnection())
                {
                    // Verifica se o código já existe
                    string check = "SELECT COUNT(*) FROM carros WHERE codigo=@codigo";
                    using (var cmd = new MySqlCommand(check, conn))
                    {
                        cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                        bool exists = Convert.ToInt32(cmd.ExecuteScalar()) > 0;

                        if (exists)
                        {
                            // Confirma atualização
                            if (MessageBox.Show("Este código já existe. Deseja atualizar o registro existente?",
                                "Código duplicado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                            {
                                return;
                            }
                        }

                        string sql;
                        if (exists)
                        {
                            sql = @"UPDATE carros 
                                    SET nome=@nome, marca=@marca, preco_custo=@pc, preco_venda=@pv, estoque=@es, imagem=@img, id_fornecedor=@forn 
                                    WHERE codigo=@codigo";
                        }
                        else
                        {
                            sql = @"INSERT INTO carros (codigo, nome, marca, preco_custo, preco_venda, estoque, imagem, id_fornecedor)
                                    VALUES (@codigo, @nome, @marca, @pc, @pv, @es, @img, @forn)";
                        }

                        using (var cmd2 = new MySqlCommand(sql, conn))
                        {
                            cmd2.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                            cmd2.Parameters.AddWithValue("@nome", txtNome.Text);
                            cmd2.Parameters.AddWithValue("@marca", txtMarca.Text);
                            cmd2.Parameters.AddWithValue("@pc", decimal.Parse(txtCusto.Text));
                            cmd2.Parameters.AddWithValue("@pv", decimal.Parse(txtVenda.Text));
                            cmd2.Parameters.AddWithValue("@es", int.Parse(txtEstoque.Text));
                            cmd2.Parameters.AddWithValue("@img", txtImagem.Text);
                            cmd2.Parameters.AddWithValue("@forn", cmbFornecedor.SelectedValue);
                            cmd2.ExecuteNonQuery();
                        }
                    }
                }

                CarregarLista();
                MessageBox.Show("Registro salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao salvar no banco de dados:\n" + ex.Message, "Erro de Banco", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            // (vazio de propósito)
        }


        // ===================== FOTO =====================
        private void btnCarregarFoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtImagem.Text = ofd.FileName;
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        // ===================== SELECIONAR CARRO =====================
        private void lstCarros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCarros.SelectedIndex < 0) return;
            var codigo = lstCarros.SelectedItem.ToString().Split('-')[0].Trim();

            try
            {
                using (var conn = Conexao.GetConnection())
                {
                    string sql = "SELECT nome, marca, preco_custo, preco_venda, estoque, imagem, id_fornecedor FROM carros WHERE codigo=@codigo";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@codigo", codigo);
                        using (var rdr = cmd.ExecuteReader())
                        {
                            if (rdr.Read())
                            {
                                txtCodigo.Text = codigo;
                                txtNome.Text = rdr.GetString("nome");
                                txtMarca.Text = rdr.GetString("marca");
                                txtCusto.Text = rdr.GetDecimal("preco_custo").ToString();
                                txtVenda.Text = rdr.GetDecimal("preco_venda").ToString();
                                txtEstoque.Text = rdr.GetInt32("estoque").ToString();
                                txtImagem.Text = rdr.IsDBNull(5) ? "" : rdr.GetString("imagem");
                                cmbFornecedor.SelectedValue = rdr.IsDBNull(6) ? 0 : rdr.GetInt32(6);

                                if (!string.IsNullOrWhiteSpace(txtImagem.Text) && File.Exists(txtImagem.Text))
                                    pictureBox1.Image = Image.FromFile(txtImagem.Text);
                                else
                                    pictureBox1.Image = null;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do carro:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===================== EXCLUIR =====================
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Código inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Deseja realmente excluir este carro?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            try
            {
                using (var conn = Conexao.GetConnection())
                {
                    string del = "DELETE FROM carros WHERE codigo=@codigo";
                    using (var cmd = new MySqlCommand(del, conn))
                    {
                        cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Carro excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===================== NOVO / CANCELAR =====================
        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtMarca.Clear();
            txtCusto.Clear();
            txtVenda.Clear();
            txtEstoque.Clear();
            txtImagem.Clear();
            pictureBox1.Image = null;
            cmbFornecedor.SelectedIndex = 0;
            txtCodigo.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
