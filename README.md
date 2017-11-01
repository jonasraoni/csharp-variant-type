# C# Variant data type

A class that mimics the behavior of the so-called variant data type.

The Variant class can be transparently assigned and converted to/from any basic data type (string, datetime, sbyte, byte, short, int, long, ushort, uint, ulong, float, double, bool, char, decimal as well as their nullable types).

See the file [test.cs](test.cs) to view the possibilities.

```csharp
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
```
