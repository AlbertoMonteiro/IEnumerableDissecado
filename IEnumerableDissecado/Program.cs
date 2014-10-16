using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace IEnumerableDissecado
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = Stopwatch.StartNew();
            var linhas = File.ReadLines(@"C:\temp\variaslinhas.txt")
                            .Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt"))
                            .Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt"))
                            .Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt"))
                            .Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt"))
                            .Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt"))
                            .Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt"))
                            .Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt"))
                            .Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt"))
                            .Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt"))
                            .Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt"))
                            .Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt"))
                            .Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt"))
                            .Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt"))
                            .Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt"))
                            .Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt"))
                            .Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt"))
                            .Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt"))
                            .Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt"))
                            .Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt"))
                            .Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt"))
                            .Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt"))
                            .Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt"))
                            .Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt"))
                            .Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt"))
                            .Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt"))
                            .Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt"))
                            .Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt"))
                            .Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt"))
                            .Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt"))
                            .Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt"))
                            .Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt"))
                            .Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt"))
                            .Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt"))
                            .Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt"))
                            .Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt"))
                            .Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt"))
                            .Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt"))
                            .Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt"))
                            .Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt"))
                            .Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt"))
                            .Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt"))
                            .Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt")).Union(File.ReadLines(@"C:\temp\variaslinhas.txt"))
                            .Union(File.ReadLines(@"C:\temp\variaslinhas.txt"))
                            .Where(x => x.EndsWith("10"));
            stopwatch.Stop();
            Console.WriteLine("Executado em {0}", stopwatch.Elapsed);
            foreach (var linha in linhas)
            {
                Console.WriteLine(linha);
            }
        }
    }
}
