using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SpeedlinePDV
{
    public partial class FormVendas : Form
    {
        public FormVendas()
        {
            InitializeComponent();
            CarregarClientes();
            CarregarCarros();
        }

        // ================= Carregar Clientes =================
        private void CarregarClientes()
        {
            try
            {
                using (var conn = Conexao.GetConnection())
                {
                    var cmd = new MySqlCommand("SELECT id, nome FROM clientes ORDER BY nome", conn);
                    using (var rdr = cmd.ExecuteReader())
                    {
                        var lista = new List<Cliente>();
                        lista.Add(new Cliente { Id = 0, Nome = "--- Selecione um cliente ---" });

                        while (rdr.Read())
                        {
                            lista.Add(new Cliente
                            {
                                Id = rdr.GetInt32("id"),
                                Nome = rdr.GetString("nome")
                            });
                        }

                        selecionarCli.DataSource = lista;
                        selecionarCli.DisplayMember = "Nome";
                        selecionarCli.ValueMember = "Id";
                        selecionarCli.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar clientes: " + ex.Message);
            }
        }

        // ================= Carregar Carros =================
        private void CarregarCarros()
        {
            try
            {
                using (var conn = Conexao.GetConnection())
                {
                    var cmd = new MySqlCommand("SELECT id, nome FROM carros ORDER BY nome", conn);
                    using (var rdr = cmd.ExecuteReader())
                    {
                        var lista = new List<CarroItem>();
                        lista.Add(new CarroItem { Id = 0, Nome = "--- Selecione um carro ---" });

                        while (rdr.Read())
                        {
                            lista.Add(new CarroItem
                            {
                                Id = rdr.GetInt32("id"),
                                Nome = rdr.GetString("nome")
                            });
                        }

                        selecionarCarro.DataSource = lista;
                        selecionarCarro.DisplayMember = "Nome";
                        selecionarCarro.ValueMember = "Id";
                        selecionarCarro.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar carros: " + ex.Message);
            }
        }

        // ================= Evento ao selecionar carro =================
        private void selecionarCarro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(selecionarCarro.SelectedItem is CarroItem carro)) return;

            if (carro.Id == 0)
            {
                LimparCamposCarro();
                return;
            }

            int carroId = carro.Id;

            using (var conn = Conexao.GetConnection())
            {
                var cmd = new MySqlCommand("SELECT nome, marca, preco_venda, estoque, imagem FROM carros WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", carroId);

                using (var rdr = cmd.ExecuteReader())
                {
                    if (rdr.Read())
                    {
                        lblNome.Text = rdr.GetString("nome");
                        lblMarca.Text = rdr.GetString("marca");
                        lblPreco.Text = rdr.GetDecimal("preco_venda").ToString("C");
                        lblEstoque.Text = rdr.GetInt32("estoque").ToString();

                        string imgPath = rdr.IsDBNull(4) ? "" : rdr.GetString("imagem");
                        if (!string.IsNullOrWhiteSpace(imgPath) && System.IO.File.Exists(imgPath))
                            pictureBox1.Image = System.Drawing.Image.FromFile(imgPath);
                        else
                            pictureBox1.Image = null;

                        nudQuantidade.Value = 1;
                        AtualizarTotal();
                    }
                }
            }
        }

        // ================= Atualizar Total =================
        private void AtualizarTotal()
        {
            if (decimal.TryParse(lblPreco.Text, System.Globalization.NumberStyles.Currency,
                System.Globalization.CultureInfo.CurrentCulture, out decimal preco))
            {
                decimal total = preco * nudQuantidade.Value;
                lblTotal.Text = total.ToString("C");
            }
        }

        private void nudQuantidade_ValueChanged(object sender, EventArgs e)
        {
            AtualizarTotal();
        }

        // ================= Confirmar Venda =================
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!(selecionarCli.SelectedItem is Cliente cliente) || cliente.Id == 0)
            {
                MessageBox.Show("Selecione um cliente antes de confirmar a venda!");
                return;
            }

            if (!(selecionarCarro.SelectedItem is CarroItem carro) || carro.Id == 0)
            {
                MessageBox.Show("Selecione um carro antes de confirmar a venda!");
                return;
            }

            int carroId = carro.Id;
            int quantidade = (int)nudQuantidade.Value;

            using (var conn = Conexao.GetConnection())
            {
                var cmdEstoque = new MySqlCommand("SELECT estoque FROM carros WHERE id=@id", conn);
                cmdEstoque.Parameters.AddWithValue("@id", carroId);
                int estoque = Convert.ToInt32(cmdEstoque.ExecuteScalar());

                if (estoque < quantidade)
                {
                    MessageBox.Show("Estoque insuficiente");
                    return;
                }

                var cmdUpdate = new MySqlCommand("UPDATE carros SET estoque = estoque - @qtd WHERE id=@id", conn);
                cmdUpdate.Parameters.AddWithValue("@qtd", quantidade);
                cmdUpdate.Parameters.AddWithValue("@id", carroId);
                cmdUpdate.ExecuteNonQuery();

                MessageBox.Show($"Venda confirmada para {cliente.Nome}!\nTotal: {lblTotal.Text}");

                // Limpar campos
                selecionarCarro.SelectedIndex = 0;
                LimparCamposCarro();
                selecionarCli.SelectedIndex = 0;
            }
        }

        // ================= Cancelar =================
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimparCamposCarro()
        {
            lblNome.Text = "";
            lblMarca.Text = "";
            lblPreco.Text = "R$0,00";
            lblEstoque.Text = "0";
            lblTotal.Text = "R$0,00";
            pictureBox1.Image = null;
            nudQuantidade.Value = 1;
        }

        private void lblPreco_Click(object sender, EventArgs e)
        {
            // opcional
        }
    }

    // ================= Classes Auxiliares =================
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public override string ToString() => Nome;
    }

    public class CarroItem
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public override string ToString() => Nome;
    }
}
