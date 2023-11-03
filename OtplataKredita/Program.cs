void IzracunParametara(double iznos, double stopa, int brojGodina, out double anuitet, out double iznosKamata)
{
    if (iznos < 0 || stopa < 0 || brojGodina < 0)
        throw new ArgumentException("Parametri moraju biti pozitivni brojevi");
    var n = brojGodina * 12;
    var r = Kamatnjak(stopa);
    anuitet = iznos * Math.Pow(r, n) * (r - 1) / (Math.Pow(r, n) - 1);
    iznosKamata = anuitet * n - iznos;
}

double Kamatnjak(double stopa)
{
    return 1 + stopa / 100 / 12;
    //dekurzivno
    //return Math.Pow(1 + stopa / 100, 1.0 / 12);
}

var nastavi = true;
do
{
    Console.Write("Unesite glavnicu: ");
    var unos = Console.ReadLine();
    if (string.IsNullOrEmpty(unos))
        nastavi = false;
    else
    {
        var ok = double.TryParse(unos, out double glavnica);
        if (!ok)
        {
            Console.WriteLine("Pogrešan format broja");
            continue;
        }
        Console.Write("Stopa: ");
        unos = Console.ReadLine();
        ok = double.TryParse(unos, out double stopa);
        if (!ok)
        {
            Console.WriteLine("Pogrešan format broja");
            continue;
        }
        Console.Write("Broj godina: ");
        unos = Console.ReadLine();
        ok = int.TryParse(unos, out int godina);
        if (!ok)
        {
            Console.WriteLine("Pogrešan format broja");
            continue;
        }
        try
        {
            
            IzracunParametara(glavnica, stopa, godina, out double anuitet, out double ukupno);
            Console.WriteLine("Za zadanu glavnicu {0:N2}, stopu {1} i broj godina {2} anuitet je {3:N2} a ukupna kamata je {4:N2}",
                glavnica, stopa, godina, anuitet, ukupno);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Dogodila se pogreška. Tekst: {0}", ex.Message);
        }
    }
} while (nastavi);


