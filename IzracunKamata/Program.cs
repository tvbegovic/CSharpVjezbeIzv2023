double IzracunKamata(double iznos, double stopa)
{
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
        if (glavnica <= 0)
        {
            Console.WriteLine("Glavnica mora biti pozitivna");
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
        if (stopa < 1 || stopa > 20)
        {
            Console.WriteLine("Stopa je izvan raspona");
            continue;
        }
        var kamata = IzracunKamata(glavnica, stopa);
        Console.WriteLine("Za zadanu glavnicu {0:N2} i stopu {1} kamata je {2:N2}",
            glavnica, stopa, kamata);
    }
} while (nastavi);
