using Rafael;
using System;

namespace Rafael
{
    public class Voo
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Custo { get; set; }
        public int Distancia { get; set; }
        public String Captura { get; set; }
        public int Dor { get; set; }

        public Voo()
        {
        }

        public Voo(int id, DateTime data, double custo, int distancia, string captura, int dor)
        {
            Id = id;
            Data = data;
            Custo = custo;
            Distancia = distancia;
            Captura = captura;
            Dor = dor;
        }
    }
}
