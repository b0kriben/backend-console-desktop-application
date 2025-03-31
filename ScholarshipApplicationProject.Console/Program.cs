﻿using ScholarshipApplicationProject.Console.Models;
using ScholarshipApplicationProject.Console.Repo;


Console.WriteLine("1. feladat");
try
{
    ScholarshipApplicant empty = new ScholarshipApplicant("", "Null");
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}
Console.WriteLine();

Console.WriteLine("2. feladat");
ScholarshipApplicant odon = new ScholarshipApplicant("odon@nyertes.hu", "Ösztöndíj Ödön");
Console.WriteLine(odon);
Console.WriteLine();

Console.WriteLine("3. feladat");
try
{
    odon.Win(-30000);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
Console.WriteLine();

Console.WriteLine("4. feladat");
odon.Win(20000);
odon.Win(30000);
Console.WriteLine(odon);
Console.WriteLine();


ScholarshipRepo repo = new ScholarshipRepo();

Console.WriteLine("5. feladat");
Console.WriteLine($"Ösztöndíjasok száma: {repo.GetNumberOfScholarship()}");
Console.WriteLine();


// 1. feladat: Az összes ösztöndíjas listázása
Console.WriteLine("1. feladat");
Console.WriteLine(repo.ListAllScholarships());
Console.WriteLine("");

// 2. feladat: Meghatározott összeg feletti ösztöndíjasok listázása
Console.WriteLine("2. feladat");
Console.WriteLine(repo.ListScholarshipsAboveAmount(1800));
Console.WriteLine("");

// 3. feladat: Az ösztöndíjasok rendezése összeg szerint csökkenő sorrendben
Console.WriteLine("3. feladat");
Console.WriteLine(repo.ListScholarshipsSortedByAmountDescending());
Console.WriteLine("");

// 4. feladat: Új ösztöndíjas hozzáadása az adatbázishoz
/*Console.WriteLine("4. feladat");
Console.WriteLine(repo.AddScholarship("eva@example.com", "Eva Green", 1700));
Console.WriteLine("Új ösztöndíjas hozzáadva. Az ösztöndíjasok listája:");
Console.WriteLine(repo.ListAllScholarships());
Console.WriteLine("");

// 5. feladat: Egy adott diák ösztöndíjának módosítása
Console.WriteLine("5. feladat");
Console.WriteLine(repo.UpdateScholarshipAmount("charlie@example.com", 2500));
Console.WriteLine("Az ösztöndíjasok listája módosítás után:");
Console.WriteLine(repo.ListScholarshipsSortedByAmountDescending());
Console.WriteLine("");

// 6. feladat: Egy adott diák törlése az adatbázisból
Console.WriteLine("6. feladat");
Console.WriteLine(repo.DeleteScholarshipByEmail("bob@example.com"));
Console.WriteLine("Az ösztöndíjasok listája törlés után:");
Console.WriteLine(repo.ListAllScholarships());
Console.WriteLine("");*/

// 7. feladat: Az összes ösztöndíj összege és az átlagos ösztöndíj kiszámítása
Console.WriteLine("7. feladat");
Console.WriteLine(repo.CalculateTotalAndAverageScholarships());
Console.WriteLine("");

// 8. feladat: Ösztöndíjasok csoportosítása összeg szerint
Console.WriteLine("8. feladat");
Console.WriteLine(repo.GroupScholarshipsByAmount());
Console.WriteLine("");

// 9. feladat: Ösztöndíjasok listázása bizonyos feltételek alapján
Console.WriteLine("9. feladat");
Console.WriteLine(repo.ListScholarshipsWithConditions());
Console.WriteLine("");

// 10. feladat: Ösztöndíjasok listázása más feltételek alapján
Console.WriteLine("10. feladat");
Console.WriteLine(repo.ListScholarshipsWithAlternateConditions());
Console.WriteLine("");
