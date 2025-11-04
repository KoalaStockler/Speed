using System;

namespace SpeedlinePDV
{
    public class Carro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public decimal PrecoCusto { get; set; }
        public decimal PrecoVenda { get; set; }
        public int Estoque { get; set; }
        public string Imagem { get; set; }
    }
}
