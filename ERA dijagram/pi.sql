SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';


-- -----------------------------------------------------
-- Table `tip_artikla`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `tip_artikla` ;

CREATE TABLE IF NOT EXISTS `tip_artikla` (
  `idtip` INT NOT NULL AUTO_INCREMENT,
  `naziv` VARCHAR(45) NOT NULL,
  `porez` FLOAT NOT NULL,
  PRIMARY KEY (`idtip`),
  UNIQUE INDEX `idtip_UNIQUE` (`idtip` ASC),
  UNIQUE INDEX `naziv_UNIQUE` (`naziv` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `artikl`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `artikl` ;

CREATE TABLE IF NOT EXISTS `artikl` (
  `sifra_art` INT NOT NULL AUTO_INCREMENT,
  `tip_artikla` INT NOT NULL,
  `naziv` VARCHAR(45) NOT NULL,
  `prodajna_cijena` FLOAT NOT NULL,
  `zaliha` INT NULL,
  PRIMARY KEY (`sifra_art`),
  UNIQUE INDEX `idArtikl_UNIQUE` (`sifra_art` ASC),
  UNIQUE INDEX `naziv_UNIQUE` (`naziv` ASC),
  INDEX `fk_artikl_tip_artikla1_idx` (`tip_artikla` ASC),
  CONSTRAINT `fk_artikl_tip_artikla1`
    FOREIGN KEY (`tip_artikla`)
    REFERENCES `tip_artikla` (`idtip`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `narudzbenica`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `narudzbenica` ;

CREATE TABLE IF NOT EXISTS `narudzbenica` (
  `idnarudzbenica` INT NOT NULL AUTO_INCREMENT,
  `datum_narudzbe` DATETIME NOT NULL,
  PRIMARY KEY (`idnarudzbenica`),
  UNIQUE INDEX `idnarudzbenica_UNIQUE` (`idnarudzbenica` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `nacin_placanja`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `nacin_placanja` ;

CREATE TABLE IF NOT EXISTS `nacin_placanja` (
  `idnacin_placanja` INT NOT NULL AUTO_INCREMENT,
  `naziv` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idnacin_placanja`),
  UNIQUE INDEX `idnacin_placanja_UNIQUE` (`idnacin_placanja` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `ovlasti`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `ovlasti` ;

CREATE TABLE IF NOT EXISTS `ovlasti` (
  `idovlasti` INT NOT NULL AUTO_INCREMENT,
  `razina` INT NOT NULL,
  `status` INT NOT NULL,
  PRIMARY KEY (`idovlasti`),
  UNIQUE INDEX `idovlasti_UNIQUE` (`idovlasti` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `korisnik`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `korisnik` ;

CREATE TABLE IF NOT EXISTS `korisnik` (
  `idkorisnik` INT NOT NULL AUTO_INCREMENT,
  `idovlasti` INT NOT NULL,
  `ime` VARCHAR(45) NOT NULL,
  `prezime` VARCHAR(45) NOT NULL,
  `broj_ziro` VARCHAR(15) NOT NULL,
  `telefon` VARCHAR(12) NOT NULL,
  `adresa` VARCHAR(30) NOT NULL,
  `grad` VARCHAR(30) NOT NULL,
  `Username` VARCHAR(20) NOT NULL,
  `Password` VARCHAR(20) NOT NULL,
  PRIMARY KEY (`idkorisnik`, `idovlasti`),
  UNIQUE INDEX `idkorisnik_UNIQUE` (`idkorisnik` ASC),
  INDEX `fk_korisnik_ovlasti1_idx` (`idovlasti` ASC),
  UNIQUE INDEX `kor_ime_UNIQUE` (`Username` ASC),
  CONSTRAINT `fk_korisnik_ovlasti1`
    FOREIGN KEY (`idovlasti`)
    REFERENCES `ovlasti` (`idovlasti`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `racun`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `racun` ;

CREATE TABLE IF NOT EXISTS `racun` (
  `idracun` INT NOT NULL AUTO_INCREMENT,
  `stol` INT NOT NULL,
  `idnacin_placanja` INT NOT NULL,
  `idkorisnik` INT NOT NULL,
  `broj_gostiju` INT NOT NULL,
  `iznos` FLOAT NOT NULL,
  `datum_kreiranja` DATETIME NOT NULL,
  `status` INT NOT NULL DEFAULT 1,
  PRIMARY KEY (`idracun`, `idnacin_placanja`, `idkorisnik`),
  UNIQUE INDEX `idracun_UNIQUE` (`idracun` ASC),
  INDEX `fk_racun_nacin_placanja1_idx` (`idnacin_placanja` ASC),
  INDEX `fk_racun_korisnik1_idx` (`idkorisnik` ASC),
  CONSTRAINT `fk_racun_nacin_placanja1`
    FOREIGN KEY (`idnacin_placanja`)
    REFERENCES `nacin_placanja` (`idnacin_placanja`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_racun_korisnik1`
    FOREIGN KEY (`idkorisnik`)
    REFERENCES `korisnik` (`idkorisnik`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `stavke_racuna`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `stavke_racuna` ;

CREATE TABLE IF NOT EXISTS `stavke_racuna` (
  `idracun` INT NOT NULL,
  `idartika` INT NOT NULL,
  `kolicina` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idracun`, `idartika`),
  INDEX `fk_racun_has_artikl_artikl1_idx` (`idartika` ASC),
  INDEX `fk_racun_has_artikl_racun1_idx` (`idracun` ASC),
  CONSTRAINT `fk_racun_has_artikl_racun1`
    FOREIGN KEY (`idracun`)
    REFERENCES `racun` (`idracun`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_racun_has_artikl_artikl1`
    FOREIGN KEY (`idartika`)
    REFERENCES `artikl` (`sifra_art`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `narucena_kolicina`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `narucena_kolicina` ;

CREATE TABLE IF NOT EXISTS `narucena_kolicina` (
  `sifra_narudzbenice` INT NOT NULL,
  `id_artikla` INT NOT NULL,
  `kolicina` INT NOT NULL,
  PRIMARY KEY (`sifra_narudzbenice`, `id_artikla`),
  INDEX `fk_narudzbenica_has_artikl_artikl1_idx` (`id_artikla` ASC),
  INDEX `fk_narudzbenica_has_artikl_narudzbenica1_idx` (`sifra_narudzbenice` ASC),
  CONSTRAINT `fk_narudzbenica_has_artikl_narudzbenica1`
    FOREIGN KEY (`sifra_narudzbenice`)
    REFERENCES `narudzbenica` (`idnarudzbenica`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_narudzbenica_has_artikl_artikl1`
    FOREIGN KEY (`id_artikla`)
    REFERENCES `artikl` (`sifra_art`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
