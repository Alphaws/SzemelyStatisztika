# Személystatisztika

Egyszerű konzolos C# alkalmazás, amely egy személy neve és születési éve alapján alapvető adatokat jelenít meg.

## Funkciók

- A felhasználó nevének bekérése és ellenőrzése
- A születési év bekérése és ellenőrzése
- Életkor kiszámítása
- A nyugdíjig hátralévő évek kiszámítása
- A nyugdíjas évek számának kiszámítása 65 éves kor felett
- Három különböző köszöntés megjelenítése
- Véletlenszerű köszöntés kiválasztása túlterhelt metódussal
- Objektumorientált programozási szemlélet

## Követelmények

- .NET 10 SDK

## Futtatás

1. Klónozd a repositoryt:

   ```bash
   git clone https://github.com/Alphaws/SzemelyStatisztika.git
   cd SzemelyStatisztika
   ```

2. Indítsd el az alkalmazást:

   ```bash
   dotnet run
   ```

## Példafuttatás

```text
Add meg a neved: Anna
Add meg a születési éved: 2000

Szia, Anna!
Életkor: 26 év
Ledolgozandó évek nyugdíjig: 39 év

A három lehetséges köszöntés:
- Legyen szép napod! Anna
- Szeretettel köszöntelek! Anna
- Üdvözöllek! Anna

Véletlenszerűen kiválasztva: Üdvözöllek! Anna
```

## Projektstruktúra

- `Program.cs` – a program indítása és a felhasználói adatok bekérése
- `Szemely.cs` – a `Szemely` osztály, a számítások és a köszöntési metódusok
- `Koszonto.csproj` – a projekt beállításai

## Licenc

Ez a projekt oktatási célból készült.
