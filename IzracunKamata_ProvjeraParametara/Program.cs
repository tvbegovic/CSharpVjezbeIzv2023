double IzracunKamata(double iznos, double stopa)
{
    if (iznos <= 0)
        throw new ArgumentException("Iznos mora biti pozitivan");
    if (stopa < 1 || stopa > 20)
        throw new ArgumentException("Stopa mora biti u rasponu 1-20");
    return iznos * stopa / 100;
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
        Console.Write("Stopa (1-20%): ");
        unos = Console.ReadLine();
        ok = double.TryParse(unos, out double stopa);
        if (!ok)
        {
            Console.WriteLine("Pogrešan format broja");
            continue;
        }
        try
        {
            var kamata = IzracunKamata(glavnica, stopa);
            Console.WriteLine("Za zadanu glavnicu {0:N2} i stopu {1} kamata je {2:N2}",
                glavnica, stopa, kamata);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Dogodila se pogreška. Tekst: {0}", ex.Message);
        }
    }
} while (nastavi);
