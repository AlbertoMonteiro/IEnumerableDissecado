using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableDissecado
{
    class Program
    {
        static void Main(string[] args)
        {
            var numerosDe1A10 = NumerosDe1a10().Onde(x => x < 10);

            foreach (var i in numerosDe1A10)
            {
                Console.WriteLine(i);
            }
        }

        public static IEnumerable<int> NumerosDe1a10()
        {
            int i = 0;
            while (true)
                yield return i++;
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
