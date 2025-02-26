## **B)** Repó

##  Vásárlók kezelése egy tároló osztályban

#### 1. feladat - Vásárlók tárolása és kezelése

Készítsen egy osztályt, amely több vásárló tárolására alkalmas.
 * A vásárlók adatai közvetlenül ne legyenek írhatók, csak lekérdezhetők.
 * Az osztályban legyen lehetőség új vásárló hozzáadására.
    * Ne lehessen két vásárlónak ugyanaz az email címe.
    * Ha mégis megpróbálunk duplikált email címmel vásárlót hozzáadni, a rendszer dobjon kivételt!
* Biztosítsa a vásárlók törlését email cím alapján lehetőséget.
    * Ha az adott email cím nem létezik, a rendszer dobjon kivételt!

---

#### 2. feladat - Vásárlók hozzáadása és törlése

* Vegye fel Valér és a további négy vásárló adatait a vásárlókat tároló objektumba!
* Írja ki a képernyőre a tárolt vásárlók számát és adataikat!
* Töröljön egy vásárlót és írja ki újra a tárolt vásárlók számát!

---

#### 3. feladat - Vásárlók adatainak lekérdezése

Készítsen metódusokat az osztályhoz a következő információk lekérdezésére, és írassa ki az eredményeket a főprogramban:

1. A legnagyobb keretösszeggel rendelkező vásárló(k) neve és keretösszege. Ha több vásárlónak azonos a legnagyobb keretösszege, mindet írja ki.
2. A legkisebb keretösszeggel rendelkező vásárló(k) email címe(i). Ha több vásárlónak azonos a legkisebb keretösszege, mindet írja ki.
3. A pozitív keretösszeggel rendelkező vásárlók keretösszegeinek átlaga, ezres kerekítéssel.
    * A 0 Ft-os vásárlók kihagyása az átlagolásból.
    * Az átlag értéket matematikailag kerekítse ezresekre!
4. Generáljon a főprogramban két számot a legnagyobb és legkisebb keretösszeg között!
    * Írja ki azokat a vásárlókat, akik ezen két szám között tudnak vásárolni keretösszegük alapján!
    * Ha nincs ilyen vásárló, azt is jelezze a program.
    * Írja ki a rendezett listát a vásárlók neveivel és keretösszegeikkel.
5. Összes vásárló teljes keretösszegének kiszámítása és az eredmény kiírása.
6. Keresés email cím alapján.
    * Írjon egy metódust, amely egy adott email cím alapján visszaadja a vásárló adatait.
    * Ha a vásárló nem található, a program jelezze ezt megfelelően.
7. A vásárlók százalékos eloszlása keretösszeg kategóriák szerint.
8. Kategóriák:
    * 0 Ft** (pl. nincs pénze)**
    * 1 - 10 000 Ft
    * 10 001 - 50 000 Ft
    * 50 001 Ft felett
  Számítsa ki, hogy a vásárlók hány százaléka tartozik az egyes kategóriákba, és írja ki a képernyőre.
