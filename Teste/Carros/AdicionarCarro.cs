using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.Utilitarios;

namespace Teste.Carros
{
    public class AdicionarCarro : ListaDeCarros
    {
        public void AdicionarCarros()
        {
            Console.WriteLine("Escrever número de série");
            string serie = Console.ReadLine();
            Carro newcarro = new Carro(serie);
            Console.WriteLine("Proprietário");
            newcarro.Proprietario = Console.ReadLine();
            Console.WriteLine("Capacidade");
            newcarro.Capacidade = int.Parse(Console.ReadLine());
            Carro.carroList.Add(newcarro.Serie);
            Carro.carros.Add(newcarro);
        }

    }
}
