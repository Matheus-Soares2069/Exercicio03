using System;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto Skyrim = new JogoDigital("The Elder Scrolls V: Skyrim Special Edition", 169.90, "Pc");
            Produto PathOfExile = new JogoDigital("Path of Exile", 00.00, "Pc"); 
            Produto HarryPotter = new Livro("Harry Potter e a Câmara Secreta", 29.99, "J. K. Rowling");
            Produto Cthulhu = new Livro("call of cthulhu", 42.90, "H.P lovecraft");

            Produto[] produtos = { Skyrim, PathOfExile, HarryPotter, Cthulhu};
            
            foreach (Produto item in produtos)
            {
                item.InformarDescrição();
                item.InformarPreço();
                Console.WriteLine("--------------------------------");
                Console.ReadLine();
            }
        }
    }
}
