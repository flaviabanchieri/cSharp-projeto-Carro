using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Carros
{
    public class Carro
    {
        public static List<string> carroList = new List<string>();
        public static List<Carro> carros = new List<Carro>();

        public string Proprietario { get; set; }

        public int Capacidade { get; set; }
        public int GasolinaDisponivel { get; set; }
        public string Serie { get; set; }

        public static int?TotalDeCarros { get; set; }

        public Carro(string serie)
        {
            this.Serie = serie;
            this.GasolinaDisponivel = 0;
            TotalDeCarros++;
        }


    }
}
