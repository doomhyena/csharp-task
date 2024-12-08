# Todo Lista Alkalmazás Pythonban

## Funkciók
- Feladatok hozzáadása a listához.
- Feladatok megtekintése számozott listában.
- Feladatok eltávolítása a lista sorszáma alapján.
- Egyszerű konzolos menürendszer a funkciók eléréséhez.

## Telepítés

### Előfeltételek

Győződj meg róla, hogy a következő program telepítve van a rendszeredre:
- [Python 3.7 vagy újabb](https://www.python.org/downloads/)

### Telepítés lépései

1. Klónozd a projektet a GitHub-ról (példa URL):
   ```bash
   git clone https://github.com/doomhyena/python-todo.git
   ```

2. Navigálj a projekt mappájába:
   ```bash
   cd python-todo
   ```

3. Futtasd az alkalmazást:
   ```bash
   python todo_app.py
   ```

## Használat

1. Indítás után a konzolon megjelenik egy menü:
   - 1: Új feladat hozzáadása.
   - 2: Feladatok megjelenítése.
   - 3: Feladat eltávolítása.
   - 4: Kilépés.

2. Válassz egy opciót a menüből a megfelelő szám beírásával és az **Enter** megnyomásával.

3. Kövesd a program utasításait a feladatok kezeléséhez.

4. A program addig fut, amíg a kilépési opciót nem választod.

## Példa használat

### Feladat hozzáadása
Adja meg a feladat szövegét:
```plaintext
Írj egy dokumentációt.
```

### Feladatok megtekintése
A lista megjelenítése a következő formában:
```plaintext
--- Feladatok ---
1. Írj egy dokumentációt.
```

### Feladat eltávolítása
Adja meg az eltávolítani kívánt feladat számát:
```plaintext
1
```

A rendszer visszaigazolja:
```plaintext
Feladat eltávolítva!
```

### Kilépés
A menüben válaszd a 4-es opciót, hogy kilépj a programból:
```plaintext
Szia!
```
