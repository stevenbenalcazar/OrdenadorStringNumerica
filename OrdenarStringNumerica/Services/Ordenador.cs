using OrdenarStringNumerica.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OrdenarStringNumerica.Services
{
    public static class Ordenador<T> where T : BaseModel
    {
        public static void OrganizarStringNumerica(List<T> lista)
        {
            List<(double, T)> listaParaOrdenar = new List<(double, T)>();
            foreach (var item in lista)
            {
                var count = 0;
                var stringSeparada = item.Nome.ToCharArray();
                double soma = 0;

                for (int i = 0; i < item.Nome.Length; i++)
                {
                    if (Int32.TryParse(stringSeparada[i].ToString(), out int number))
                        count++;
                    else
                        break;
                }

                int[] valorBruto = new int[count];

                for (int i = 0; i < count; i++)
                {
                    if (Int32.TryParse(stringSeparada[i].ToString(), out int number))
                        valorBruto[i] = number;
                }
                Array.Reverse(valorBruto);
                for (int i = 0; i < valorBruto.Length; i++)
                {
                    soma += valorBruto[i] * Math.Pow(10, i);
                }

                listaParaOrdenar.Add((soma, item));
            }

            listaParaOrdenar = listaParaOrdenar.OrderBy(x => x.Item1 == 0)
                                                .ThenBy(x => x.Item1)
                                                .ThenBy(x => x.Item2.Nome).ToList();

            lista.Clear();

            listaParaOrdenar.ForEach(x => lista.Add(x.Item2));

        }
    }
}
