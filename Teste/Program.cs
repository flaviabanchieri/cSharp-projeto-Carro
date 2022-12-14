using System;
using System.Drawing;
using System.Runtime.Serialization;
using Teste.Carros;
using Teste.Utilitarios;


Gasolina abs = new Gasolina();
ListaDeCarros listadecarros = new ListaDeCarros();

Carro carro1 = new Carro("123456");
{
    carro1.Proprietario = "Pedro";
    carro1.Capacidade = 50;
    
    Carro.carroList.Add(carro1.Serie);
    Carro.carros.Add(carro1);
    
}

Carro carro2 = new Carro("456789");
{
    carro2.Proprietario = "Maria";
    carro2.Capacidade = 55;
    Carro.carroList.Add(carro2.Serie);
    Carro.carros.Add(carro2);
}

Carro carro3 = new Carro("789123");
{
    carro3.Proprietario = "Luana";
    carro3.Capacidade = 40;
    Carro.carroList.Add(carro3.Serie);
    Carro.carros.Add(carro3);
}






try
{
    bool RodarPrograma = true;
    do
    {
        string strings = @"----------------
                       Escolha uma número:
                       1 - Abastecer
                       2 - Rodar
                       3 - Incluir Carro
                       4 - Excluir Carro
                        ------------------";
        Console.WriteLine(strings);

        string result = Console.ReadLine();
        

        if (result == "1")
        {
            RodarPrograma = false;
            Console.WriteLine("Escolher carro por número de série:");
            listadecarros.GetList();
            string serie = Console.ReadLine();
            int index = listadecarros.GetIndex(serie);
            try
            {
                Carro carro = Carro.carros[index];
                Console.WriteLine("Quantidade de Litros a serem abastecidos: ");
                var valor = int.Parse(Console.ReadLine());

                abs.AbastecerCarro(carro, valor);
                Console.WriteLine("Carro com série n." + carro.Serie + " Total de Gasolina:" + carro.GasolinaDisponivel);
                RodarPrograma = true;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Tente novamente");
                
            }


            


        }
        if (result == "2")
        {
            Console.WriteLine("Escolher carro por número de série:");
            listadecarros.GetList();
            string serie = Console.ReadLine();
            int index = listadecarros.GetIndex(serie);
            try
            {
                Carro carro = Carro.carros[index];
                Console.WriteLine("Quantidade de Litros a serem rodados: ");
                var valor = int.Parse(Console.ReadLine());

                abs.Rodar(carro, valor);
                Console.WriteLine("Carro com série n." + carro.Serie + " Total de Gasolina:" + carro.GasolinaDisponivel);

            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Tente novamente");
                
            }


           

        }
        if (result == "3")
        {
            AdicionarCarro adicionar = new AdicionarCarro();
            {
                adicionar.AdicionarCarros();
            }





        }
        if (result == "4")
        {
            ApagarCarro apagar = new ApagarCarro();
            {
                Console.WriteLine("Escolher carro por número de série:");
                listadecarros.GetList();
                string serie = Console.ReadLine();
           
                apagar.Apagar(serie);
            }
        }
    } while (RodarPrograma = true);
   
        



}
catch (Exception)
{

    Console.WriteLine("Por favor inserir um número da lista");
    throw;
}










