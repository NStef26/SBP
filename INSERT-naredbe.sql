INSERT INTO Aktivista (ID_aktiviste, Ime, Ime_roditelja, Prezime, Datum_rodjenja, Adresa, ID_koordinatora, ID_glasackog_mesta, Primedba) 
	SELECT	1,'Pera', 'Perica', 'Peric', '11.10.1990', 'Cara Dusana 2', NULL, NULL, NULL FROM DUAL UNION
	SELECT	2,'Ivana','Marko','Ivanovic','03.04.1995','Jeronimova 27',3,1,NULL FROM DUAL UNION
	SELECT	3,'Darko','Marko','Ivanovic', '05.08.1990', 'Jeronimova 27',NULL, 1, NULL FROM DUAL UNION
	SELECT	4,'Zarko','Stefan','Petrovic','18.04.1992', 'Jeronimova 35', 3 , 1 , 'Druga stranka vodila dodatni birački spisak' FROM DUAL UNION
	SELECT	5,'Ivan','Marko','Ivanovic','05.06.1997','Jeronimova 27', 3 , 1 , NULL FROM DUAL UNION
	SELECT	6,'Ljubica', 'Ivan', 'Zarkovic', '31.03.1972', 'Kovanlucka 7', 1 , 2 , 'Kupovina glasova' FROM DUAL UNION
	SELECT	7, 'Nikola', 'Milan', 'Petrovic', '11.11.1991', 'Vozdova 3', NULL, NULL, NULL FROM DUAL UNION
	SELECT  8, 'Milan', 'Jovan', 'Petrovic', '3.11.1963', 'Vozdova 3', NULL, NULL, NULL FROM DUAL
	

INSERT INTO E_mail(ID_aktiviste, E_mail)
	SELECT 1,'nesta@gmail.com' FROM DUAL UNION
	SELECT 2,'nestodrugo@gmail.com' FROM DUAL
		
INSERT INTO Telefon(ID_aktiviste, Telefon)
	SELECT 1, '063111111' FROM DUAL UNION
	SELECT 2, '063222222' FROM DUAL

INSERT INTO Koordinator (ID_aktiviste, Ime_opstine, Adresa_kancelarije)
	SELECT 1,'Podunavska 3', 'Crveni krst' FROM DUAL UNION
	SELECT 3,'Palilula', 'Sarajevska 17' FROM DUAL
	
INSERT INTO Akcija(ID_akcije, Naziv)
	SELECT 1,'Deljenje letaka' FROM DUAL UNION
	SELECT 2,'Susreti' FROM DUAL UNION
	SELECT 3,'Miting' FROM DUAL UNION
	SELECT 4,'Zatvoreni prostor' FROM DUAL UNION
	SELECT 5,'Susreti sa penzionerima ' FROM DUAL UNION
	SELECT 6,'Zavrsni miting' FROM DUAL UNION
	SELECT 7,'Zatvoreni prostor' FROM DUAL
	
INSERT INTO Ucestvuje(ID_aktiviste0, ID_akcije1)
	SELECT 1,1 FROM DUAL UNION
	SELECT 1,2 FROM DUAL UNION
	SELECT 1,3 FROM DUAL UNION
	SELECT 2,3 FROM DUAL 
	
INSERT INTO Glasacko_mesto(ID_glasackog_mesta, Broj_glasackog_mesta, Naziv_izborne_jedinice, Ukupno_biraca, Rezultati_na_glasackom_mestu, Izborni_krug)
	SELECT 1,12,'Palilula 4', 1000, NULL, Drugi FROM DUAL UNION
	SELECT 2,15,'Medijana 1', 2000, 1 FROM DUAL

INSERT INTO Rezultati_izbora(ID_rezultata_izbora, Procenat_glasalih_za_kandidata,Broj_biraca_izaslih)
	VALUES (1, 0.4,1000);

INSERT INTO Deljenje_letaka(ID_akcije, Grad_deljenje)
	SELECT 4, 'Nis' FROM DUAL UNION
	SELECT 2, 'Nis' FROM DUAL
	
INSERT INTO Gost(ID_gosta, Ime_gosta, Prezime_gosta, Funkcija)
	SELECT 1, 'Pera', 'Mitic', 'Direktor' FROM DUAL UNION
	SELECT 2, 'Pejca', 'Lovac', 'Gospodin' FROM DUAL
	
INSERT INTO Miting(ID_akcije, Lokacija_mitinga, Mesto, ID_Gosta3)
	SELECT 6, 'Nis', 'Pasi Poljana', 2 FROM DUAL UNION
	SELECT 3, 'Nis', 'Medijana', 1 FROM DUAL
	
INSERT INTO Zatvoreni_prostor(ID_zatvorenog_prostora, Vlasnik_prostora, Cena_iznajmljivanja,ID_akcije3)
	SELECT 1, 'Pera Zikic', 155555, 6 FROM DUAL UNION
	SELECT 2, 'Marko Zikic', 155553, 3 FROM DUAL
	
INSERT INTO Susreti(ID_akcije, Grad_susret, Vreme_trajanja, Lokacija_susreta)
	SELECT 2, 'Nis', 3, 'Hala Cair' FROM DUAL UNION
	SELECT 5, 'Leskovac', 2, 'Hala Zdravlje' FROM DUAL
	

INSERT INTO Reklamni_prostor(ID_reklamnog_prostora, Iznos, Datum_od, Datum_do)
	SELECT 1, 15000,'04.03.2018','30.03.2018' FROM DUAL UNION
	SELECT 2, 30000,'03.04.2018','30.05.2018' FROM DUAL UNION
	SELECT 3, 17000,'03.04.2018','30.07.2018' FROM DUAL UNION
	SELECT 4, 170000,'1.1.2018', '1.3.2018' FROM DUAL UNION
	SELECT 5, 123333,'1.12.2017', '1.4.2018' FROM DUAL UNION
	SELECT 6, 1700,'1.3.2018', '2.3.2018' FROM DUAL
	
INSERT INTO Clanak(ID_reklamnog_prostora, Boja, Naziv_lista)
	SELECT 2, 'Kolor', 'Nedeljnik' FROM DUAL UNION
	SELECT 5, 'Crno-beli', 'Politika' FROM DUAL
	
INSERT INTO Reklama(ID_reklamnog_prostora, Trajanje, Br_emitovanja, Naziv_televizije)
	SELECT 3,7,100,'RTS' FROM DUAL UNION
	SELECT 6,7,125,'Happy' FROM DUAL

INSERT INTO Panoi(ID_reklamnog_prostora, Naziv_ulice, Grad_pano, Povrsina, Agencija_vlasnik)
	SELECT 1,'Sarajevska 15', 'Nis', 23, 'Panoi Lux' FROM DUAL UNION
	SELECT 4,'Episkopska 15', 'Nis', 27, 'Panoi Lux' FROM DUAL

INSERT INTO Pojavljivanje(ID_pojavljivanja)
	SELECT 1 FROM DUAL UNION
	SELECT 2 FROM DUAL UNION
	SELECT 3 FROM DUAL UNION
	SELECT 4 FROM DUAL UNION
	SELECT 5 FROM DUAL UNION
	SELECT 6 FROM DUAL 
	
INSERT INTO Intervju(ID_pojavljivanja, Datum_intervjua, Datum_objavljivanja, Naziv_lista)
	SELECT 1, '11.10.2018', '12.10.2018', 'NIN' FROM DUAL UNION
	SELECT 3, '12.04.2018', '14.04.2018', 'Politika' FROM DUAL UNION
	SELECT 4, '11.04.2018', '13.04.2018', 'NIN' FROM DUAL
	
INSERT INTO Gostovanje(ID_pojavljivanja, Gledanost, Naziv_emisije, Ime_voditelja)
	SELECT 2,1000000, 'Duel', 'Zaklina' FROM DUAL UNION
	SELECT 5,150000, 'Duel', 'Olivera' FROM DUAL UNION
	SELECT 6,1502000, 'OKO', 'Nadezda' FROM DUAL
	
INSERT INTO TV_duel(ID_tv_duela, Naziv_stanice,ID_pojavljivanja2)
	SELECT 1, 'RTS', 2 FROM DUAL UNION
	SELECT 2, 'RTS', 6 FROM DUAL

INSERT INTO Ime_protivkandidata(ID_pojavljivanja, Ime_protivkandidata)
	SELECT 1, 'Pera Peric' FROM DUAL UNION
	SELECT 2, 'Mirko Mikic' FROM DUAL
	
INSERT INTO Pitanje(ID_pojavljivanja, Pitanje)
	SELECT 3, 'Problem pasa lutalica' FROM DUAL UNION
	SELECT 5, 'Cistoca ulica' FROM DUAL UNION
	SELECT 6, 'Metro' FROM DUAL