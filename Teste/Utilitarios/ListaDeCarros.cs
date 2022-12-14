using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Teste.Utilitarios
{
    using Teste.Carros;
    public class ListaDeCarros 
    {
        
        public int GetIndex(string Serie)
        {
            int index = Carro.carroList.FindIndex(x => x==Serie);
            return index;
            
            
        }

        public void GetList()
        {

            foreach (string c in Carro.carroList)
            {
                Console.WriteLine(c.ToString());
            }
        }

    }
}
