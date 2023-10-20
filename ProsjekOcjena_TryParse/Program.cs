Console.Write("Ocjena C: ");
var unos = Console.ReadLine();
var ok = int.TryParse(unos, out int ocjenaC);
if(!ok)
{
    Console.WriteLine("Pogrešan format broja");
    return;
}
Console.Write("Ocjena C++: ");
unos = Console.ReadLine();
ok = int.TryParse(unos, out int ocjenaCPlus);
if (!ok)
{
    Console.WriteLine("Pogrešan format broja");
    return;
}
Console.Write("Ocjena C#: ");
unos = Console.ReadLine();
ok = int.TryParse(unos, out int ocjenaCSharp);
if (!ok)
{
    Console.WriteLine("Pogrešan format broja");
    return;
}
if(ocjenaC < 1 || ocjenaC >5 || ocjenaCPlus < 1 || ocjenaCPlus > 5 || ocjenaCSharp < 1 || ocjenaCSharp > 5)
{
    Console.WriteLine("Ocjene moraju biti između 1-5");
    return;
}
var prosjek = (ocjenaC + ocjenaCPlus + ocjenaCSharp) / 3.0;
Console.WriteLine("Prosjek ocjena je: {0:N2}", prosjek);
