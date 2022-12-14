using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.Utilitarios;

namespace Teste.Carros
{
    public class ApagarCarro : ListaDeCarros
    {
        public void Apagar(string Serie)
        {

            int index = GetIndex(Serie);
            Carro.carros[index].Proprietario = null;
            Carro.carros[index].Serie = null;
            Carro.carros[index].GasolinaDisponivel = 0;
            Carro.carroList.RemoveAt(index);
            Carro.carros.RemoveAt(index);

        }
    }
}
