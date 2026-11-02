namespace SzemelyStatisztika
{
    internal sealed class Szemely
    {
        private static readonly string[] Koszontesek =
        {
            "Legyen szép napod!",
            "Szeretettel köszöntelek!",
            "Üdvözöllek!"
        };

        public const int AktualisEv = 2026;
        private const int Nyugdijkorhatar = 65;

        public Szemely(string nev, int szulEv)
        {
            if (string.IsNullOrWhiteSpace(nev))
            {
                throw new ArgumentException("A név nem lehet üres.", nameof(nev));
            }

            if (szulEv < 1 || szulEv > AktualisEv)
            {
                throw new ArgumentOutOfRangeException(nameof(szulEv));
            }

            Nev = nev;
            SzuletesiEv = szulEv;
        }

        public string Nev { get; }
        public int SzuletesiEv { get; }

        // Az életkort az aktuális év és a születési év különbsége adja.
        public int Eletkor => AktualisEv - SzuletesiEv;

        // A nyugdíjkorhatárból levonjuk az életkort.
        public int NyugdijigHatralevoEvek => Nyugdijkorhatar - Eletkor;

        // Köszöntés a megadott névvel.
        public string Koszont(string nev)
        {
            return $"Szia, {nev}!";
        }

        // Véletlenszerűen kiválasztunk egy köszöntést a tömbből.
        public string Koszont()
        {
            int index = Random.Shared.Next(Koszontesek.Length);
            return $"{Koszontesek[index]} {Nev}";
        }

        // A tömbben tárolt mindhárom köszöntést visszaadjuk.
        public IEnumerable<string> MindenKoszontes()
        {
            foreach (string koszontes in Koszontesek)
            {
                yield return $"{koszontes} {Nev}";
            }
        }
    }
}
