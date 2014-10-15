﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableDissecado
{
    class Program
    {
        private static bool deveParar = false;
        static void Main(string[] args)
        {
            var maquinaEstado = NumerosDe1a10(0);
            //var maquinaEstado = new MaquinaEstado(0);

            var numerosDe1A10 = NumerosDe1a10(1).Onde(x => x < 10);

            foreach (var i in numerosDe1A10)
            {
                Console.WriteLine(i);
            }
            deveParar = true;
            foreach (var i in numerosDe1A10)
            {
                Console.WriteLine(i);
            }
        }

        public static IEnumerable<int> NumerosDe1a10(int x)
        {
           /* int i = 0;
            while (true)
                yield return i++;*/
            yield return 1;
            yield return 2;
            yield return 3/x;
            if (deveParar)
                yield break;
            yield return 4;
            yield return 5;
            yield return 6;
            yield return 7;
            yield return 8;
            yield return 9;
        }
    }

    public static class MeuLinq
    {
        public static IEnumerable<T> Onde<T>(this IEnumerable<T> lista, Func<T, bool> condicao)
        {
            foreach (var item in lista)
                if (condicao(item))
                    yield return item;
                else
                    yield break;
        }
    }
}
