using System;
using System.Collections.Generic;

namespace IEnumerableDissecado
{
    class Program
    {
        static void Main(string[] args)
        {
            var numerosDe1A10 = NumerosDe1a10(1);

            var totalMemory = GC.GetTotalMemory(forceFullCollection: true);
            Console.WriteLine("Memória total: {0}", totalMemory);

            foreach (var i in numerosDe1A10)
            {
                Console.WriteLine(i);
                totalMemory = GC.GetTotalMemory(forceFullCollection: true);
                Console.WriteLine("Memória total: {0}", totalMemory);
            }
        }

        public static IEnumerable<int> NumerosDe1a10(int x)
        {
            /*int i = 0;
            while (true)
                yield return i++;*/
            byte[] bytes;
            yield return 1;
            yield return 2;
            yield return 3 / x;
            bytes = new byte[10 * 1024 * 1024];
            yield return 4;
            yield return bytes.Length;
            yield return 5;
            yield return 6;
            yield return 7;
            yield return 8;
            yield return 9;
        }
    }
}
