CREATE TABLE IF NOT EXISTS 'namirnice' (
  'sifra_nam' INTEGER NOT NULL primary key autoincrement,
  'naziv' VARCHAR(45) NOT NULL unique,
  'tip' VARCHAR(45) NOT NULL,
  'kolicina' INTEGER NOT NULL,
  'nabavna_cijena' FLOAT NOT NULL,
  'jed_mjera' VARCHAR(10) NOT NULL);
  
  
  CREATE TABLE IF NOT EXISTS `tip_artikla` (
  `idtip` INTEGER NOT NULL primary key autoincrement,
  `naziv` VARCHAR(45) NOT NULL,
  `porez` FLOAT NOT NULL);
  
  CREATE TABLE IF NOT EXISTS `artikl` (
  `sifra_art` INTEGER NOT NULL primary key autoincrement,
  `tip_artikla` INTEGER NOT NULL,
  `naziv` VARCHAR(45) NOT NULL unique,
  `prodajna_cijena` FLOAT NOT NULL,
  CONSTRAINT `fk_artikl_tip_artikla1`
    FOREIGN KEY (`tip_artikla`) REFERENCES `tip_artikla` (`idtip`));
	
	
	
	CREATE TABLE IF NOT EXISTS `sastojak` (
  `sifra_art` INTEGER NOT NULL,
  `sifra_nam` INTEGER NOT NULL,
  `kolicina` INTEGER NOT NULL,
  PRIMARY KEY (`sifra_art`, `sifra_nam`),
  CONSTRAINT `fk_Artikl_has_namirnice_Artikl`
    FOREIGN KEY (`sifra_art`)
    REFERENCES `artikl` (`sifra_art`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Artikl_has_namirnice_namirnice1`
    FOREIGN KEY (`sifra_nam`)
    REFERENCES `namirnice` (`sifra_nam`));
	
	
	CREATE TABLE IF NOT EXISTS `ovlasti` (
  `idovlasti` INTEGER NOT NULL primary key autoincrement,
  `razina` INTEGER NOT NULL,
  `status` INTEGER NOT NULL);
  
  
  CREATE TABLE IF NOT EXISTS 'korisnik' (
  'idkorisnik' INTEGER NOT NULL primary key autoincrement,
  'idovlasti' INTEGER NOT NULL,
  'ime' VARCHAR(45) NOT NULL,
  'prezime' VARCHAR(45) NOT NULL,
  'broj_ziro' VARCHAR(15) NOT NULL,
  'telefon' VARCHAR(12) NOT NULL,
  'adresa' VARCHAR(30) NOT NULL,
  'grad' VARCHAR(30) NOT NULL,
  CONSTRAINT 'fk_korisnik_ovlasti1'
    FOREIGN KEY ('idovlasti')
    REFERENCES 'ovlasti' ('idovlasti'));
	
	
	CREATE TABLE IF NOT EXISTS `narudzbenica` (
  `idnarudzbenica` INTEGER NOT NULL primary key autoincrement,
  `idkorisnik` INTEGER NOT NULL,
  `datum_narudzbe` DATETIME NOT NULL,
  CONSTRAINT `fk_narudzbenica_korisnik1`
    FOREIGN KEY (`idkorisnik`)
    REFERENCES `korisnik` (`idkorisnik`));
	
	
	CREATE TABLE IF NOT EXISTS `narucena_kolicina` (
  `sifra_narudzbenice` INTEGER NOT NULL,
  `sifra_namirnice` INTEGER NOT NULL,
  `kolicina` INTEGER NOT NULL,
  PRIMARY KEY (`sifra_narudzbenice`, `sifra_namirnice`),
  CONSTRAINT `fk_narudzbenica_has_namirnice_narudzbenica1`
    FOREIGN KEY (`sifra_namirnice`)
    REFERENCES `narudzbenica` (`idnarudzbenica`),
  CONSTRAINT `fk_narudzbenica_has_namirnice_namirnice1`
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
  
	
  CONSTRAINT `fk_racun_stol1`
    FOREIGN KEY (`idstol`)
    REFERENCES `stol` (`idstol`),
  CONSTRAINT `fk_racun_nacin_placanja1`
    FOREIGN KEY (`idnacin_placanja`)
    REFERENCES `nacin_placanja` (`idnacin_placanja`),
  CONSTRAINT `fk_racun_korisnik1`
    FOREIGN KEY (`idkorisnik`)
    REFERENCES `korisnik` (`idkorisnik`));
	
	CREATE TABLE IF NOT EXISTS `stavke_racuna` (
	`idstavke_racuna` integer not null primary key autoincrement,
  `idracun` INTEGER NOT NULL,
  `idartika` INTEGER NOT NULL,
  `kolicina` VARCHAR(45) NOT NULL,
  CONSTRAINT `fk_racun_has_artikl_racun1`
    FOREIGN KEY (`idracun`)
    REFERENCES `racun` (`idracun`),
  CONSTRAINT `fk_racun_has_artikl_artikl1`
    FOREIGN KEY (`idartika`)
    REFERENCES `artikl` (`sifra_art`));
	
	
	CREATE TABLE IF NOT EXISTS `izvjesca` (
  `idizvjesca` INTEGER NOT NULL primary key autoincrement,
  `idkorisnik` INTEGER NOT NULL,
  `datum_kreiranja` VARCHAR(45) NOT NULL,
  `opis` VARCHAR(45) NOT NULL,
  CONSTRAINT `fk_izvjesca_korisnik1`
    FOREIGN KEY (`idkorisnik`)
    REFERENCES `korisnik` (`idkorisnik`));
	
	
	CREATE TABLE IF NOT EXISTS `log` (
  `idlog` INTEGER NOT NULL primary key autoincrement,
  `idkorisnik` INTEGER NOT NULL,
  `datum_prijave` VARCHAR(45) NULL,
  `datum_odjave` VARCHAR(45) NULL,
  CONSTRAINT `fk_log_korisnik1`
    FOREIGN KEY (`idkorisnik`)
    REFERENCES `korisnik` (`idkorisnik`));
	
	
	
	CREATE TABLE IF NOT EXISTS `radnja` (
  `idradnja` INTEGER NOT NULL primary key autoincrement,
  `idkorisnik` INTEGER NOT NULL,
  `datum_radnje` DATETIME NOT NULL,
  `radnja` VARCHAR(45) NOT NULL,
  CONSTRAINT `fk_radnja_korisnik1`
    FOREIGN KEY (`idkorisnik`)
    REFERENCES `korisnik` (`idkorisnik`));
  
  
  
  
  