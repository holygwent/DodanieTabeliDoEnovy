# DodanieTabeliDoEnovy
Dodanie Tabeli Do programu Enova.<br>
Kolejnośc wykonywanych zadań:<br>
1.tworzymy tabele z kolumnami w pliku *.business.xml TowarCennyDodatkowe.business.xml<br>
2.dodajemy klasy (odpowiedno nazwane CennaDodatkowa i CennyDodatkowe) row oraz table dziedziczące odpowiedni typ z ...Module.cs(TowarCennyDodatkoweModule)  i konstruktorem<br>
3.Stworzenie widoku używający viewform.xml są to pliki CennaDodatkowaViewInfo.cs oraz CennaDodatkowaViewInfo.viewform.xml<br>
4.W celu dodania zakładki edytowanie po kliknięciu dodajemy pageform CennaDodatkowa.ogolne.pageform.xml<br>
5. w celu dodanie zakładki po lewej stronie obiektu zawierającego naszą nową tabele tworzymy extender który pobiera widok oraz pageform (TowaryExtender.cs,Towar.CennaDodatkowa.pageform.xml)<br>

W celu stworzenie relacji 1 do wiele zamień business.xml następująco (napisz odpowiednio klucz)
<table name="CennaDodatkowa"
		   tablename="CennyDodatkowe"
		   tablecaption="Cenny Dodatkowe"
		   guided="Child"
		 >


		<col name="Towar"
			 type="Towar"
			 readonly="true"
			 required ="true"
			 caption="Towar"
			 relname="CennaDodatkowa_Towar" 
			 delete="cascade"
			 relguided="inner"
			 children="Fields"
			 
			 />
		<key name="WgTowaru"
			 keyunique="true"
			 keyprimary="true"
			 >
			<keycol name="Towar"/>
			<keycol name="DataOd"/>
		
	
		</key>

		<col name="CenaNetto"
			 required="true"
			 type="doublecy"
			 />

		<col name="CenaBrutto"
			 required="true"
			 type="doublecy"
			 />

		<col name="DataOd"
			 required="true"
			 type="date"
			 />
		<col name="DataDo"
			 required="true"
			 type="date"
			 />


	</table>
