using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio03
{
    class JogoDigital : Produto
    {
        public JogoDigital(string titulo, double preco, string plataforma) : base(titulo, preco)
        {
            Plataforma = plataforma;
        }

        public string Plataforma { get; private set; }

        public override void InformarDescrição()
        {
            Console.WriteLine($"{Titulo} para {Plataforma}");
        }
    }
}
