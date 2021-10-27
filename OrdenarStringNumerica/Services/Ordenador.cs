using OrdenarStringNumerica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace OrdenarStringNumerica.Services
{
    public static class Ordenador<T> where T : BaseModel
    {
        public static void OrganizarStringNumerica(List<T> lista)
        {
            List<(double, T)> listaParaOrdenar = new List<(double, T)>();
            foreach (var item in lista)
            {
                double valorBruto = 0;
                if (Regex.IsMatch(item.Nome, @"^\d+"))
                    valorBruto = Convert.ToInt32(Regex.Replace(item.Nome, @"[^0-9](\w+)", ""));

                listaParaOrdenar.Add((valorBruto, item));
            }

            listaParaOrdenar = listaParaOrdenar.OrderBy(x => x.Item1 == 0)
                                                .ThenBy(x => x.Item1)
                                                .ThenBy(x => x.Item2.Nome).ToList();

            lista.Clear();

            listaParaOrdenar.ForEach(x => lista.Add(x.Item2));
        }
    }
}
