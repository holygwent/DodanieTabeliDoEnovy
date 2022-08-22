# DodanieTabeliDoEnovy
Dodanie Tabeli Do programu Enova.
Kolejnośc wykonywanych zadań:
1.tworzymy tabele z kolumnami w pliku *.business.xml TowarCennyDodatkowe.business.xml
2.dodajemy klasy (odpowiedno nazwane CennaDodatkowa i CennyDodatkowe) row oraz table dziedziczące odpowiedni typ z ...Module.cs(TowarCennyDodatkoweModule)  i konstruktorem
3.Stworzenie widoku używający viewform.xml są to pliki CennaDodatkowaViewInfo.cs oraz CennaDodatkowaViewInfo.viewform.xml
4.W celu dodania zakładki edytowanie po kliknięciu dodajemy pageform CennaDodatkowa.ogolne.pageform.xml
5. w celu dodanie zakładki po lewej stronie obiektu zawierającego naszą nową tabele tworzymy extender który pobiera widok oraz pageform (TowaryExtender.cs,Towar.CennaDodatkowa.pageform.xml)
