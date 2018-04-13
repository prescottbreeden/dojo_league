-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema dojo_league
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema dojo_league
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `dojo_league` DEFAULT CHARACTER SET utf8 ;
USE `dojo_league` ;

-- -----------------------------------------------------
-- Table `dojo_league`.`Dojos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dojo_league`.`Dojos` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(45) NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `dojo_league`.`Ninjas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dojo_league`.`Ninjas` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(45) NULL,
  `Level` INT NULL,
  `Description` TEXT(1000) NULL,
  `created_at` DATETIME NOT NULL DEFAULT NOW(),
  `updated_at` DATETIME NOT NULL DEFAULT NOW(),
  `Dojos_id` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_Ninjas_Dojos_idx` (`Dojos_id` ASC),
  CONSTRAINT `fk_Ninjas_Dojos`
    FOREIGN KEY (`Dojos_id`)
    REFERENCES `dojo_league`.`Dojos` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
