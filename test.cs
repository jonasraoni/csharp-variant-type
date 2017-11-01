/*
 * C# Variant data type: A class that mimics the behavior of the so-called variant data type
 * Jonas Raoni Soares da Silva <http://raoni.org>
 * https://github.com/jonasraoni/csharp-variant-type
 */

using System;
using Raoni;

namespace Test{
    class Program{
        static void Main(string[] args){
            var v = new Variant(123);
            Variant v2 = 0;
            Console.WriteLine(v == v2);
            Console.WriteLine(v > v2);
            Console.WriteLine(v2 ? "v2 converted to true" : "v2 converted to false");
            Console.WriteLine((int)v);
            Console.WriteLine((bool)v);
            Console.WriteLine((double)v);
            Console.WriteLine(((int?)new Variant(null)).HasValue);
            Console.WriteLine(((DateTime)new Variant(DateTime.Now)).ToString("o"));
            Console.WriteLine((bool)new Variant("False"));
            Console.WriteLine((float)new Variant("123.321"));
        }
    }
}
