namespace SzemelyStatisztika
{
    internal sealed class Szemely
    {
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

        // A kapott köszöntések közül véletlenszerűen kiválasztunk egyet.
        public string Koszont(params string[] koszontesek)
        {
            if (koszontesek.Length == 0)
            {
                throw new ArgumentException("Legalább egy köszöntést meg kell adni.", nameof(koszontesek));
            }

            int index = Random.Shared.Next(koszontesek.Length);
            return $"{koszontesek[index]} {Nev}";
        }
    }
}
