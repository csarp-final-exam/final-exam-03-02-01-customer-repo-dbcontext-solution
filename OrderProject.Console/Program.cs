// See https://aka.ms/new-console-template for more information
using OrderProject.Console.Models;

Console.WriteLine("Hello, World!");

try
{
    // 1. Feladat: Negatív keretösszegű vásárló létrehozása és kivétel kezelése
    var invalidCustomer = new Customer("Hibás Péter", "hibas.peter@example.com", -500);
}
catch (Exception ex)
{
    Console.WriteLine("Hiba: " + ex.Message);
}

// 1. Feladat: Érvényes vásárló létrehozása
var valér = new Customer("Vásárló Valér", "vasarlo.valer@sokatveszek.hu", 20000);
Console.WriteLine(valér);

// 2. Feladat: Keretösszeg növelése
valér.IncreaseBalance(5000);
valér.IncreaseBalance(10000);
Console.WriteLine($"Valér keretösszeg növelések száma: {valér.BalanceIncreaseCount}");

// 2. Feladat: Ellenőrzés, hogy Valér meg tud-e venni egy 45 000 Ft-os monitort
Console.WriteLine($"Valér meg tudja venni a 45 000 Ft-os monitort? {(valér.CanPurchase(45000) ? "Igen" : "Nem")}");

// 3. Feladat: Vásárlás kivételkezeléssel
try
{
    valér.Purchase(200000);
}
catch (Exception ex)
{
    Console.WriteLine("Hiba: " + ex.Message);
}

// 3. Feladat: Sikeres vásárlás
valér.Purchase(10000);
Console.WriteLine("Valér új egyenlege: " + valér.Balance + " Ft");
Console.WriteLine(valér);

// 4. Feladat: Több vásárló létrehozása
var customers = new Customer[]
{
                new Customer("Anna Alapos", "anna.alapos@example.com", 15000),
                new Customer("Béla Bátor", "bela.bator@example.com", 30000),
                new Customer("Csaba Csendes", "csaba.csendes@example.com", 5000),
                new Customer("Dénes Derék", "denes.derek@example.com", 0) // Nulla keretösszegű vásárló
};

foreach (var customer in customers)
{
    Console.WriteLine(customer);
}
        