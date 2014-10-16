using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace IEnumerableDissecado
{
    class Program
    {
        static void Main(string[] args)
        {
            var inteiros = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var ints = from inteiro in inteiros
                       where "Antes do where " + inteiro
                       where inteiro % 2 == 0
                       where "Antes do order by " + inteiro
                       orderby inteiro descending
                       where "Antes do select " + inteiro
                       select inteiro;

            foreach (var i in ints)
            {
                Console.WriteLine(i);
            }
        }
    }

    public static class MyClass
    {
        public static IEnumerable<T> Where<T>(this IEnumerable<T> lista, Func<T, string> predicado)
        {
            foreach (var item in lista)
            {
                Console.WriteLine(predicado(item));
                yield return item;
            }
        }
    }
}
