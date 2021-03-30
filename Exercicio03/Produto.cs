using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio03
{
    class Produto
    {
        
        public string Titulo { get;protected set; }
        public Double Preco { get;protected set; }

        public Produto(string titulo, double preco)
        {
            Titulo = titulo;
            Preco = preco;
        }

        public virtual void InformarDescrição() 
        {
            Console.WriteLine("Item da Loja");
        }
        public void InformarPreço() 
        {
            Console.WriteLine($"{Preco.ToString("C")}");
        }

    }
}
