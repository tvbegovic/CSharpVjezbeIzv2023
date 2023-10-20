Console.Write("Unesite 1. broj: ");
var unos = Console.ReadLine();
var broj1 = int.Parse(unos);
Console.Write("Unesite 2. broj: ");
unos = Console.ReadLine();
var broj2 = int.Parse(unos);
Console.WriteLine("Zbroj je {0}", broj1 + broj2);
Console.WriteLine("Razlika je {0}", broj1 - broj2);
Console.WriteLine("Produkt je {0}", broj1 * broj2);
if (broj2 == 0)
    Console.WriteLine("Ne mogu dijeliti s 0");
else
    Console.WriteLine("Kvocijent je {0}", broj1 / broj2);