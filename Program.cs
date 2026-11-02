namespace SzemelyStatisztika
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Add meg a neved: ");
            string nev = Console.ReadLine()?.Trim() ?? string.Empty;
            while (nev.Length == 0)
            {
                Console.Write("A név nem lehet üres, add meg újra: ");
                nev = Console.ReadLine()?.Trim() ?? string.Empty;
            }

            Console.Write("Add meg a születési éved: ");
            int szulEv = ReadBirthYear();

            var szemely = new Szemely(nev, szulEv);
            string[] koszontesek =
            {
                "Legyen szép napod!",
                "Szeretettel köszöntelek!",
                "Üdvözöllek!"
            };

            Console.WriteLine();
            Console.WriteLine(szemely.Koszont(szemely.Nev));
            Console.WriteLine($"Életkor: {szemely.Eletkor} év");
            Console.WriteLine($"Ledolgozandó évek nyugdíjig: {szemely.NyugdijigHatralevoEvek} év");
            Console.WriteLine();
            Console.WriteLine("A három lehetséges köszöntés:");
            foreach (string koszontes in koszontesek)
            {
                Console.WriteLine($"- {koszontes} {szemely.Nev}");
            }

            Console.WriteLine();
            Console.WriteLine($"Véletlenszerűen kiválasztva: {szemely.Koszont(koszontesek)}");
        }

        private static int ReadBirthYear()
        {
            while (true)
            {
                string input = Console.ReadLine()?.Trim() ?? string.Empty;
                if (int.TryParse(input, out int year) &&
                    year >= 1 &&
                    year <= Szemely.AktualisEv)
                {
                    return year;
                }

                Console.Write($"Érvénytelen év, adj meg egy 1 és {Szemely.AktualisEv} közötti értéket: ");
            }
        }
    }
}