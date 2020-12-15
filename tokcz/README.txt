A projektmunkáról:
Egy olyan alkalmazást szerettem volna létrehozni, mely egy rövid betekintést nyújt a magyarországi felsőoktatás helyzetébe.

------------------------------------------------------------------
Form2:
Ez az alkalmazás kezdőoldala. Itt, a felhasználónak lehetősége van:

- CSV file (rangsor.csv) beolvasására DataGridViewba a "CSV file beolvasása" gombra kattintva
- a beolvasást követően a "Törlés" gomb segítségével tetszőleges mennyiségű sort kitörölni a DataGridViewból
- az "Exel" gombra kattintva formázott excelként exportálni a DataGridViewban szereplő adatokat
- a "Mikroszimuláció" gombra kattintva egy szimulációs modellezést végrehajtani

Eredmény --> Megtekinthetjük Magyarország 2020-as Top 10 felsőoktatási intézményének a rangsorát és a nevükhöz tartozó rövidítést. Majd exportálhatjuk egy szépen formázott excel táblába. 
------------------------------------------------------------------

Form3:
Az "Mikroszimuláció" gomb lenyomása után jutunk el a "Form3" oldalra, ahol lehetőségünk van lineáris modellekkel nem leírható, kaotikus folyamatok elemzésére, és a modellek szemponjából exogén (külső) hatások vizsgálatára. 

Előkészületek -->
1) Létrehoztam minden egyes modellezni kívánt virtuális leképezését
2) Végigmentem az összes mondellben szereplő egyénen, és egy adott logika alapján módosítom az egyes egyének tulajdonságait. A vizsgált modellben ezen a ponton az egyének az örökkévalóságig járhatnak egyetemre, de diplomások is kikerülhetnek
3) Megnövelhetem a modellben szereplők életkorát, és megismételhetem a folyamatot a 2. ponttól egészen addig, míg el nem érem a szimuláció végét

Indításkor-->
- A "Böngészés" gomb lenyomásával tudom kiválasztani a beolvasandó .csv file-t, mely a "Hallgatók" label melletti textboxban fogja mejeleníteni a filehoz szükséges elérési utat 
- Az "Indítás" gomb lenyomásával és a "Záróév" melletti numericUpandDown segítségével kezdhetjük a modellezést

Eredmény -->


