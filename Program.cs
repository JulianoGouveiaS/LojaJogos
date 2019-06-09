using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojadeJogo
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            /*-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema LojaDeJogos
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema LojaDeJogos
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `LojaDeJogos` DEFAULT CHARACTER SET utf8 ;
USE `LojaDeJogos` ;

-- -----------------------------------------------------
-- Table `LojaDeJogos`.`Plataformas`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `LojaDeJogos`.`Plataformas` ;

CREATE TABLE IF NOT EXISTS `LojaDeJogos`.`Plataformas` (
  `idPlataformas` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(45) NULL,
  PRIMARY KEY (`idPlataformas`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `LojaDeJogos`.`Jogos`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `LojaDeJogos`.`Jogos` ;

CREATE TABLE IF NOT EXISTS `LojaDeJogos`.`Jogos` (
  `idJogos` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(45) NOT NULL,
  `preco` DOUBLE NOT NULL,
  `idPlataformas` INT NOT NULL,
  PRIMARY KEY (`idJogos`),
  INDEX `fk_Jogos_Plataformas1_idx` (`idPlataformas` ASC) VISIBLE,
  CONSTRAINT `fk_Jogos_Plataformas1`
    FOREIGN KEY (`idPlataformas`)
    REFERENCES `LojaDeJogos`.`Plataformas` (`idPlataformas`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `LojaDeJogos`.`Clientes`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `LojaDeJogos`.`Clientes` ;

CREATE TABLE IF NOT EXISTS `LojaDeJogos`.`Clientes` (
  `idClientes` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(45) NOT NULL,
  `telefone` BIGINT(45) NOT NULL,
  PRIMARY KEY (`idClientes`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `LojaDeJogos`.`Funcionarios`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `LojaDeJogos`.`Funcionarios` ;

CREATE TABLE IF NOT EXISTS `LojaDeJogos`.`Funcionarios` (
  `idFuncionarios` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(45) NOT NULL,
  `salario` DOUBLE NOT NULL,
  PRIMARY KEY (`idFuncionarios`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `LojaDeJogos`.`Vendas`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `LojaDeJogos`.`Vendas` ;

CREATE TABLE IF NOT EXISTS `LojaDeJogos`.`Vendas` (
  `idVendas` INT NOT NULL,
  `descricao` VARCHAR(45) NOT NULL,
  `valor` DOUBLE NULL,
  `idClientes` INT NOT NULL,
  `idJogos` INT NOT NULL,
  `idFuncionarios` INT NOT NULL,
  PRIMARY KEY (`idVendas`),
  INDEX `fk_vendas_Clientes_idx` (`idClientes` ASC) VISIBLE,
  INDEX `fk_vendas_jogos1_idx` (`idJogos` ASC) VISIBLE,
  INDEX `fk_Vendas_Funcionarios1_idx` (`idFuncionarios` ASC) VISIBLE,
  CONSTRAINT `fk_vendas_Clientes`
    FOREIGN KEY (`idClientes`)
    REFERENCES `LojaDeJogos`.`Clientes` (`idClientes`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_vendas_jogos1`
    FOREIGN KEY (`idJogos`)
    REFERENCES `LojaDeJogos`.`Jogos` (`idJogos`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Vendas_Funcionarios1`
    FOREIGN KEY (`idFuncionarios`)
    REFERENCES `LojaDeJogos`.`Funcionarios` (`idFuncionarios`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `LojaDeJogos`.`Backup`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `LojaDeJogos`.`Backup` ;

CREATE TABLE IF NOT EXISTS `LojaDeJogos`.`Backup` (
  `idBackup` INT NOT NULL AUTO_INCREMENT,
  `descricao` VARCHAR(45) NULL,
  `valor` DOUBLE NULL,
  `idClientes` INT(45) NULL,
  `idJogos` INT(45) NULL,
  `idFuncionarios` INT(45) NULL,
  PRIMARY KEY (`idBackup`))
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

 */
        }
    }
}
