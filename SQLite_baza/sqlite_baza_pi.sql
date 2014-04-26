CREATE TABLE IF NOT EXISTS 'namirnice' (
  'sifra_nam' INTEGER NOT NULL primary key autoincrement,
  'naziv' VARCHAR(45) NOT NULL unique,
  'kolicina' INTEGER NOT NULL,
  'nabavna_cijena' FLOAT NOT NULL,
  'jed_mjera' VARCHAR(10) NOT NULL);
 

 FOREIGN KEY (P_Id) REFERENCES Persons(P_Id)
  
  CREATE TABLE IF NOT EXISTS `tip_artikla` (
  `idtip` INTEGER NOT NULL primary key autoincrement,
  `naziv` VARCHAR(45) NOT NULL,
  `porez` FLOAT NOT NULL);
  
  CREATE TABLE IF NOT EXISTS 'artikl' (
  'sifra_art' INTEGER NOT NULL primary key autoincrement,
  'tip_artikla' INTEGER NOT NULL,
  'naziv' VARCHAR(45) NOT NULL unique,
  'prodajna_cijena' FLOAT NOT NULL,
  foreign key('tip_artikla') references tip_artikla('idtip'));
	
	--------------------------------------------------------------------------------
	
	CREATE TABLE IF NOT EXISTS `sastojak` (
  `sifra_art` INTEGER NOT NULL,
  `sifra_nam` INTEGER NOT NULL,
  `kolicina` INTEGER NOT NULL,
  PRIMARY KEY (`sifra_art`, `sifra_nam`),
  foreign key ('sifra_art') references artikl('sifra_art'),
  foreign key ('sifra_nam') references namirnice('sifra_nam'));
	----------------------------------------------------------------------------------
	
	CREATE TABLE IF NOT EXISTS `ovlasti` (
  `idovlasti` INTEGER NOT NULL primary key autoincrement,
  `razina` INTEGER NOT NULL,
  `status` INTEGER NOT NULL);
  ----------------------------------------------------------
  
  CREATE TABLE IF NOT EXISTS 'korisnik' (
  'idkorisnik' INTEGER NOT NULL primary key autoincrement,
  'idovlasti' INTEGER NOT NULL,
  'ime' VARCHAR(45) NOT NULL,
  'prezime' VARCHAR(45) NOT NULL,
  'broj_ziro' VARCHAR(15) NOT NULL,
  'telefon' VARCHAR(12) NOT NULL,
  'adresa' VARCHAR(30) NOT NULL,
  'grad' VARCHAR(30) NOT NULL,
  foreign key ('idovlasti') references ovlasti('idovlasti'));

	
	
	CREATE TABLE IF NOT EXISTS `narudzbenica` (
  `idnarudzbenica` INTEGER NOT NULL primary key autoincrement,
  `idkorisnik` INTEGER NOT NULL,
  `datum_narudzbe` DATETIME NOT NULL,
    FOREIGN KEY (`idkorisnik`)
    REFERENCES korisnik (`idkorisnik`));
	
	
	CREATE TABLE IF NOT EXISTS `narucena_kolicina` (
  `sifra_narudzbenice` INTEGER NOT NULL,
  `sifra_namirnice` INTEGER NOT NULL,
  `kolicina` INTEGER NOT NULL,
  PRIMARY KEY (`sifra_narudzbenice`, `sifra_namirnice`),
    FOREIGN KEY (`sifra_namirnice`)
    REFERENCES `narudzbenica` (`idnarudzbenica`),
    FOREIGN KEY (`sifra_narudzbenice`)
    REFERENCES `namirnice` (`sifra_nam`));
	
	
	
	CREATE TABLE IF NOT EXISTS 'stol' (
  'idstol' INTEGER NOT NULL unique primary key autoincrement,
  'broj_mjesta' INTEGER NOT NULL,
  'zauzet' INTEGER NOT NULL);
  
  CREATE TABLE IF NOT EXISTS `nacin_placanja` (
  `idnacin_placanja` INTEGER NOT NULL primary key autoincrement,
  `naziv` VARCHAR(45) NOT NULL);
  
  
  CREATE TABLE IF NOT EXISTS `racun` (
  `idracun` INTEGER NOT NULL primary key autoincrement,
  `idstol` INTEGER NOT NULL,
  `idnacin_placanja` INTEGER NOT NULL,
  `idkorisnik` INTEGER NOT NULL,
  `broj gostiju` INTEGER NOT NULL,
  `iznos` FLOAT NOT NULL,
  `datum_kreiranja` DATETIME NOT NULL,
    FOREIGN KEY (`idstol`)
    REFERENCES `stol` (`idstol`),
    FOREIGN KEY (`idnacin_placanja`)
    REFERENCES `nacin_placanja` (`idnacin_placanja`),
    FOREIGN KEY (`idkorisnik`)
    REFERENCES `korisnik` (`idkorisnik`));
	
	CREATE TABLE  `stavke_racuna` (
  `idracun` INTEGER NOT NULL,
  `idartika` INTEGER NOT NULL,
  `kolicina` VARCHAR(45) NOT NULL,
  primary key(`idracun`,`idartika`),

    FOREIGN KEY (`idracun`)
    REFERENCES `racun` (`idracun`),
 
    FOREIGN KEY (`idartika`)
    REFERENCES `artikl` (`sifra_art`));
	
	
	CREATE TABLE IF NOT EXISTS `izvjesca` (
  `idizvjesca` INTEGER NOT NULL primary key autoincrement,
  `idkorisnik` INTEGER NOT NULL,
  `datum_kreiranja` VARCHAR(45) NOT NULL,
  `opis` VARCHAR(45) NOT NULL,
    FOREIGN KEY (`idkorisnik`)
    REFERENCES `korisnik` (`idkorisnik`));
	
	
	CREATE TABLE IF NOT EXISTS `log` (
  `idlog` INTEGER NOT NULL primary key autoincrement,
  `idkorisnik` INTEGER NOT NULL,
  `datum_prijave` VARCHAR(45) NULL,
  `datum_odjave` VARCHAR(45) NULL,
    FOREIGN KEY (`idkorisnik`)
    REFERENCES `korisnik` (`idkorisnik`));
	
	
	
	CREATE TABLE IF NOT EXISTS `radnja` (
  `idradnja` INTEGER NOT NULL primary key autoincrement,
  `idkorisnik` INTEGER NOT NULL,
  `datum_radnje` DATETIME NOT NULL,
  `radnja` VARCHAR(45) NOT NULL,
    FOREIGN KEY (`idkorisnik`)
    REFERENCES `korisnik` (`idkorisnik`));
  
  
  
  
  