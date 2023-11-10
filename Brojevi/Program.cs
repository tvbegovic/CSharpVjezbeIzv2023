﻿var nastavi = true;
do
{
    Console.Write("Unesite broj elemenata (1-100): ");
    var unos = Console.ReadLine();
    if(string.IsNullOrEmpty(unos))
        nastavi = false;
    else
    {
        var ok = int.TryParse(unos, out int brojElemenata);
        if (!ok)
        {
            Console.WriteLine("Pogrešan format broja");
            continue;
        }
        if (brojElemenata < 1 || brojElemenata > 100) 
        {
            Console.WriteLine("Broj je izvan raspona");
            continue;
        }
        int[] brojevi = new int[brojElemenata];
        var i = 0;
        while (i < brojElemenata)
        {
            Console.Write("Element {0}: ", i + 1);
            unos = Console.ReadLine();
            ok = int.TryParse(unos, out brojevi[i]);
            if(!ok)
            {
                Console.WriteLine("Pogrešan format broja");
                continue;
            }
            i++;
        }
        Console.WriteLine("Unijeli ste polje: ");
        foreach (var broj in brojevi)
        {
            Console.Write("{0} ", broj);
        }
        Console.WriteLine();
        var zbroj = 0;
        var najmanji = brojevi[0];
        var najveci = brojevi[0];
        foreach (var broj in brojevi)
        {
            zbroj += broj;
            if (broj < najmanji)
                najmanji = broj;
            if (broj > najveci)
                najveci = broj;
        }
        var prosjek = zbroj * 1.0 / brojevi.Length;
        Console.WriteLine("Suma elemenata polja je {0}", zbroj);
        Console.WriteLine("Prosjek vrijednosti je {0}", prosjek);
        Console.WriteLine("Najveći element polja je {0}", najveci);
        Console.WriteLine("Najmanji element polja je {0}", najmanji);

        Array.Sort(brojevi);
        Console.WriteLine("Sortirano polje je: ");
        foreach (var broj in brojevi)
        {
            Console.Write("{0} ", broj);
        }
        Console.WriteLine();

        Console.WriteLine("Rješenje upotrebom extension funkcija");
        zbroj = brojevi.Sum();
        prosjek = brojevi.Average();
        najmanji = brojevi.Min();
        najveci = brojevi.Max();
        var sortirano = brojevi.OrderBy(x => -x).ToArray();
        var sortSilazno = brojevi.OrderByDescending(x => x).ToArray();

        Console.WriteLine("Suma elemenata polja je {0}", zbroj);
        Console.WriteLine("Prosjek vrijednosti je {0}", prosjek);
        Console.WriteLine("Najveći element polja je {0}", najveci);
        Console.WriteLine("Najmanji element polja je {0}", najmanji);

        Console.WriteLine("Sortirano polje je: ");
        foreach (var broj in sortirano)
        {
            Console.Write("{0} ", broj);
        }
        Console.WriteLine();

        Console.WriteLine("Sortirano polje od najvećeg prema najmanjem je: ");
        foreach (var broj in sortSilazno)
        {
            Console.Write("{0} ", broj);
        }
        Console.WriteLine();

    }
} while (nastavi);