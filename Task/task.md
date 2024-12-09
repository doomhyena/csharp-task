# Feladat: "Készíts egy egyszerű Todo alkalmazást Pythonban!"

## Leírás:
Készíts egy Python programot, amely egy egyszerű Todo listát kezelő alkalmazásként működik. Az alkalmazás lehetővé teszi a felhasználó számára, hogy feladatokat adjon hozzá, jelenítsen meg, és töröljön egy menüvezérelt rendszer segítségével.

## Feladatok:
1. **Feladatok tárolása**:
   - Tárold a feladatokat egy Python listában, ahol minden feladat egy szövegként (`str`) szerepel.

2. **Felhasználói interakció**:
   - Hozz létre egy menürendszert, ahol a felhasználó az alábbi opciók közül választhat:
     1. Új feladat hozzáadása.
     2. Feladatok megjelenítése.
     3. Feladat eltávolítása.
     4. Kilépés az alkalmazásból.
   - Kezeld a felhasználói bevitel hibáit úgy, hogy a program ne álljon le érvénytelen input esetén.

3. **Funkcionalitás**:
   - **Új feladat hozzáadása**:
     - Kérd be a felhasználótól a feladat szövegét, és add hozzá a lista végéhez.
     - Ellenőrizd, hogy a bevitt szöveg ne legyen üres.
   - **Feladatok megjelenítése**:
     - Jelenítsd meg a feladatok listáját számozott formában.
     - Jelezd, ha a lista üres.
   - **Feladat eltávolítása**:
     - Jelenítsd meg a feladatok listáját.
     - Kérd be a felhasználótól az eltávolítandó feladat sorszámát.
     - Ellenőrizd, hogy a megadott sorszám érvényes-e, és távolítsd el a megfelelő feladatot.

4. **Kilépés**:
   - Az alkalmazás addig fusson, amíg a felhasználó nem választja a "Kilépés" opciót.

## Pontos instrukciók:
- A programot egy Python fájlban (`todo_app.py`) valósítsd meg.
- Használj `input()` függvényt a felhasználói bevitel kezelésére.
- Gondoskodj a bevitel helyes kezeléséről (pl. csak számokat fogadj el menüpont választásakor).
- A feladatok szövege tetszőleges lehet, de üres bevitel ne kerülhessen a listába.
- A feladat eltávolításánál kezeld az érvénytelen sorszámokat (pl. negatív szám vagy a lista méretén kívüli szám).

## Tesztelési példák:
1. **Feladat hozzáadása**:
   - Adj hozzá több feladatot, és ellenőrizd, hogy azok megjelennek a lista megtekintésekor.
2. **Feladatok megjelenítése**:
   - Ellenőrizd, hogy üres lista esetén a megfelelő üzenet jelenik meg.
3. **Feladat eltávolítása**:
   - Próbálj meg törölni egy nem létező sorszámú feladatot, és ellenőrizd, hogy hibaüzenet jelenik meg.
   - Törölj egy létező feladatot, és ellenőrizd, hogy az eltűnik a listából.
4. **Kilépés**:
   - Ellenőrizd, hogy a program sikeresen kilép, ha a felhasználó a megfelelő opciót választja.