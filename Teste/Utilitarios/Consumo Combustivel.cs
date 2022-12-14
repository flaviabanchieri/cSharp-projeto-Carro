using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Teste.Carros;

namespace Teste.Utilitarios
{
    public class Gasolina
    {






        public void AbastecerCarro(Carro carro, int valor)
        {
            if (carro.GasolinaDisponivel + valor <= carro.Capacidade)
            {

                carro.GasolinaDisponivel += valor;
            }
            else
            {
                int abasteceu = carro.Capacidade - carro.GasolinaDisponivel;
                carro.GasolinaDisponivel = carro.Capacidade;
                
                Console.WriteLine("Abasteceu somente " + abasteceu + "litros, tanque está cheio");
            }
        }

        public void Rodar(Carro carro, int valor)
        {
            int rodar = carro.GasolinaDisponivel - valor;

            if (rodar >= 0)
            {
                carro.GasolinaDisponivel -= valor;
                Console.WriteLine("Rodar");
            }
            else
            {
                Console.WriteLine("Sem combustível disponível para rodar");
                
            }
        }

       
    }
}
