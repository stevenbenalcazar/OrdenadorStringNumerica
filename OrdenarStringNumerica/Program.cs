using OrdenarStringNumerica.Models;
using OrdenarStringNumerica.Services;
using System;
using System.Collections.Generic;

namespace OrdenarStringNumerica
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> lista = new List<Item>()
            {
                new Item(){Id = 1,  Nome = "A22"},
                new Item(){Id = 2,  Nome = "Bloco 2"},
                new Item(){Id = 3,  Nome = "2"},
                new Item(){Id = 4,  Nome = "22"},
                new Item(){Id = 5,  Nome = "3"},
                new Item(){Id = 6,  Nome = "A3"},
                new Item(){Id = 7,  Nome = "2-A"},
                new Item(){Id = 8,  Nome = "21-A"},
                new Item(){Id = 9,  Nome = "001"},
                new Item(){Id = 10, Nome = "Bloco 11"},
            };

            lista.ForEach(x => Console.WriteLine(x));

            Console.WriteLine("Lista Ordenada Abaixo\n");
            Ordenador<Item>.OrganizarStringNumerica(lista);

            lista.ForEach(x => Console.WriteLine(x));

            
        }
    }
}
