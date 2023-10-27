﻿var nastavi = true;
do
{
    Console.Write("Unesite broj (1-100.000): ");
    var unos = Console.ReadLine();
    if (string.IsNullOrEmpty(unos))
        nastavi = false;
    else
    {
        var ok = int.TryParse(unos, out int broj);
        if (!ok)
        {            
            Console.WriteLine("Broj je u pogrešnom formatu");
            continue;
        }
        if (broj < 1 || broj > 100000)
        {
            Console.WriteLine("Broj je izvan raspona");
            continue;
        }
        long zbroj = 0;
        for (int i = 1; i <= broj; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
                zbroj += i;
        }
        Console.WriteLine("Zbroj brojeva djeljivih sa 3 ili 5 od 1 do {0:N0} je {1:N0}", broj, zbroj);
    }
} while (nastavi);