Console.Write("Ime: ");
var ime = Console.ReadLine();
Console.Write("Prezime: ");
var prezime = Console.ReadLine();
if(string.IsNullOrEmpty(ime) || string.IsNullOrEmpty(prezime))
{
    Console.WriteLine("Ime i prezime moraju biti uneseni");
    return;
}
Console.WriteLine("Inicijali su {0}.{1}.", ime.Substring(0,1), prezime.Substring(0,1));