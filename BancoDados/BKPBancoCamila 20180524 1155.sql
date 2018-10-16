-- MySQL Administrator dump 1.4
--
-- ------------------------------------------------------
-- Server version	5.5.58-0ubuntu0.14.04.1


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


--
-- Create schema sql10195674
--

CREATE DATABASE IF NOT EXISTS sql10195674;
USE sql10195674;

--
-- Definition of table `tb_ItemPedido`
--

DROP TABLE IF EXISTS `tb_ItemPedido`;
CREATE TABLE `tb_ItemPedido` (
  `ipo_Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `ipo_SerId` int(10) unsigned NOT NULL,
  `ipo_Qtde` int(10) unsigned NOT NULL,
  `ipo_Valor` decimal(10,2) NOT NULL,
  `ipo_PrjId` int(10) unsigned NOT NULL,
  PRIMARY KEY (`ipo_Id`),
  KEY `FK_tb_ItemPedido_Projeto` (`ipo_PrjId`),
  KEY `FK_tb_ItemPedido_servicos` (`ipo_SerId`),
  CONSTRAINT `FK_tb_ItemPedido_Projeto` FOREIGN KEY (`ipo_PrjId`) REFERENCES `tb_projeto` (`prj_Id`),
  CONSTRAINT `FK_tb_ItemPedido_servicos` FOREIGN KEY (`ipo_SerId`) REFERENCES `tb_servicos` (`ser_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_ItemPedido`
--

/*!40000 ALTER TABLE `tb_ItemPedido` DISABLE KEYS */;
INSERT INTO `tb_ItemPedido` (`ipo_Id`,`ipo_SerId`,`ipo_Qtde`,`ipo_Valor`,`ipo_PrjId`) VALUES 
 (11,55,1,'2900.00',17),
 (13,61,1,'1000.00',19),
 (14,55,1,'6850.00',20),
 (15,40,1,'272.00',22);
/*!40000 ALTER TABLE `tb_ItemPedido` ENABLE KEYS */;


--
-- Definition of table `tb_acessos`
--

DROP TABLE IF EXISTS `tb_acessos`;
CREATE TABLE `tb_acessos` (
  `ace_Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `ace_UsrId` int(10) unsigned NOT NULL,
  `ace_TelasId` int(10) unsigned NOT NULL,
  PRIMARY KEY (`ace_Id`),
  KEY `FK_tb_acessos_Usuarios` (`ace_UsrId`),
  KEY `FK_tb_acessos_Telas` (`ace_TelasId`),
  CONSTRAINT `FK_tb_acessos_Telas` FOREIGN KEY (`ace_TelasId`) REFERENCES `tb_telas` (`tel_Id`),
  CONSTRAINT `FK_tb_acessos_Usuarios` FOREIGN KEY (`ace_UsrId`) REFERENCES `tb_usuario` (`usr_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=61 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_acessos`
--

/*!40000 ALTER TABLE `tb_acessos` DISABLE KEYS */;
INSERT INTO `tb_acessos` (`ace_Id`,`ace_UsrId`,`ace_TelasId`) VALUES 
 (2,4,12),
 (3,4,11),
 (4,4,10),
 (5,4,9),
 (6,4,8),
 (7,4,7),
 (8,4,6),
 (9,4,5),
 (10,4,4),
 (11,4,3),
 (12,4,2),
 (13,4,1),
 (26,6,12),
 (27,6,11),
 (28,6,10),
 (29,6,9),
 (30,6,8),
 (31,6,7),
 (32,6,6),
 (33,6,5),
 (34,6,4),
 (35,6,3),
 (36,6,2),
 (37,6,1),
 (49,5,12),
 (50,5,11),
 (51,5,10),
 (52,5,9),
 (53,5,8),
 (54,5,7),
 (55,5,6),
 (56,5,5),
 (57,5,4),
 (58,5,3),
 (59,5,2),
 (60,5,1);
/*!40000 ALTER TABLE `tb_acessos` ENABLE KEYS */;


--
-- Definition of table `tb_cliente`
--

DROP TABLE IF EXISTS `tb_cliente`;
CREATE TABLE `tb_cliente` (
  `cli_Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `cli_Descricao` varchar(200) NOT NULL,
  `cli_Fantasia` varchar(200) NOT NULL,
  `cli_CpfCnpj` varchar(30) DEFAULT NULL,
  `cli_Logradouro` varchar(300) DEFAULT NULL,
  `cli_Numero` varchar(10) DEFAULT NULL,
  `cli_Cidade` varchar(100) DEFAULT NULL,
  `cli_Estado` varchar(200) DEFAULT NULL,
  `cli_CEP` varchar(9) DEFAULT NULL,
  `cli_Complemento` varchar(200) DEFAULT NULL,
  `cli_Contato` varchar(200) NOT NULL,
  `cli_Telefone` varchar(15) DEFAULT NULL,
  `cli_Celular` varchar(20) DEFAULT NULL,
  `cli_Email` varchar(200) DEFAULT NULL,
  `cli_Data` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `cli_Ativo` tinyint(1) NOT NULL DEFAULT '1',
  `cli_Bairro` varchar(200) NOT NULL,
  `cli_LogradouroObra` varchar(300) NOT NULL,
  `cli_NumeroObra` varchar(10) NOT NULL,
  `cli_CidadeObra` varchar(100) NOT NULL,
  `cli_EstadoObra` varchar(200) NOT NULL,
  `cli_CEPObra` varchar(9) NOT NULL,
  `cli_ComplementoObra` varchar(200) NOT NULL,
  `cli_BairroObra` varchar(200) NOT NULL,
  PRIMARY KEY (`cli_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_cliente`
--

/*!40000 ALTER TABLE `tb_cliente` DISABLE KEYS */;
INSERT INTO `tb_cliente` (`cli_Id`,`cli_Descricao`,`cli_Fantasia`,`cli_CpfCnpj`,`cli_Logradouro`,`cli_Numero`,`cli_Cidade`,`cli_Estado`,`cli_CEP`,`cli_Complemento`,`cli_Contato`,`cli_Telefone`,`cli_Celular`,`cli_Email`,`cli_Data`,`cli_Ativo`,`cli_Bairro`,`cli_LogradouroObra`,`cli_NumeroObra`,`cli_CidadeObra`,`cli_EstadoObra`,`cli_CEPObra`,`cli_ComplementoObra`,`cli_BairroObra`) VALUES 
 (11,'VestCasa','VestCasa','  ,   ,   /    -','','','','','     -','','Sra.Gabriela','(  )     -','(  )      -','','2018-03-04 13:51:39',1,'','','','','','     -','',''),
 (12,'Shopping Grande Circular - Grão Espresso ','Shopping Grande Circular - Grão Espresso ','128,538,998-02','','','Manaus','Amazonas','     -','','Ivaneide Caracas Bezerra','(  )     -','(92) 91461-500','graoespresso.amazonas.shopping@gmail.com','2018-03-09 09:45:08',1,'','Avenida Autaz Mirim','','Manaus','Amazonas','69085-000','Loja 2015 piso 02 - Shopping Grande Circular','São José Operário'),
 (13,'Ponta Porã - Grão Espresso','Ponta Porã - Grão Espresso','   ,   ,   -','','','','','     -','','Daniel','(  )     -','(  )      -','','2018-03-09 09:44:43',1,'','','','','','     -','',''),
 (14,'UNICSUL - Grão Espresso','UNICSUL - Grão Espresso','   ,   ,   -','','','','','     -','','Lucas','(  )     -','(  )      -','','2018-03-09 09:46:08',1,'','','','','','     -','',''),
 (15,'','Gilberto','   ,   ,   -','','','','','     -','','','(  )     -','(  )      -','','2018-03-15 17:56:41',1,'','','','','','     -','',''),
 (16,'MAIS PETS','MAIS PETS','   ,   ,   -','','','','','     -','','Renan Vazquez','(  )     -','(11) 98085-4667','renan.vazquez@indigosoft.com.br','2018-04-18 19:30:56',1,'','','','','','     -','','');
/*!40000 ALTER TABLE `tb_cliente` ENABLE KEYS */;


--
-- Definition of table `tb_despesas`
--

DROP TABLE IF EXISTS `tb_despesas`;
CREATE TABLE `tb_despesas` (
  `des_Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `des_Descricao` varchar(45) NOT NULL,
  `des_GrfId` int(10) unsigned NOT NULL,
  PRIMARY KEY (`des_Id`),
  KEY `FK_tb_despesas_GrupoFinanceiro` (`des_GrfId`),
  CONSTRAINT `FK_tb_despesas_GrupoFinanceiro` FOREIGN KEY (`des_GrfId`) REFERENCES `tb_grupoFinanceiro` (`grf_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_despesas`
--

/*!40000 ALTER TABLE `tb_despesas` DISABLE KEYS */;
INSERT INTO `tb_despesas` (`des_Id`,`des_Descricao`,`des_GrfId`) VALUES 
 (1,'Quilômetragem',6),
 (2,'Café da manhã',7),
 (3,'Almoço',7),
 (4,'Pedágio',6);
/*!40000 ALTER TABLE `tb_despesas` ENABLE KEYS */;


--
-- Definition of table `tb_empresa`
--

DROP TABLE IF EXISTS `tb_empresa`;
CREATE TABLE `tb_empresa` (
  `emp_Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `emp_Nome` varchar(255) DEFAULT NULL,
  `emp_CNPJ` varchar(100) DEFAULT NULL,
  `emp_Telefone` varchar(100) DEFAULT NULL,
  `emp_Logradouro` varchar(255) DEFAULT NULL,
  `emp_Numero` varchar(15) DEFAULT NULL,
  `emp_Bairro` varchar(255) DEFAULT NULL,
  `emp_Cidade` varchar(255) DEFAULT NULL,
  `emp_Estado` varchar(255) DEFAULT NULL,
  `emp_Complemento` varchar(255) DEFAULT NULL,
  `emp_CEP` varchar(20) DEFAULT NULL,
  `emp_RazaoSocial` varchar(255) DEFAULT NULL,
  `emp_VersaoSistema` varchar(45) DEFAULT NULL,
  `emp_LocalVersao` varchar(255) DEFAULT NULL,
  `emp_Email` varchar(255) NOT NULL,
  `emp_LoginPagSeguro` varchar(255) NOT NULL,
  `emp_TokenPagSeguro` varchar(255) NOT NULL,
  `emp_TestePagSeguro` varchar(45) NOT NULL,
  `emp_SenhaEmail` varchar(45) NOT NULL,
  PRIMARY KEY (`emp_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_empresa`
--

/*!40000 ALTER TABLE `tb_empresa` DISABLE KEYS */;
INSERT INTO `tb_empresa` (`emp_Id`,`emp_Nome`,`emp_CNPJ`,`emp_Telefone`,`emp_Logradouro`,`emp_Numero`,`emp_Bairro`,`emp_Cidade`,`emp_Estado`,`emp_Complemento`,`emp_CEP`,`emp_RazaoSocial`,`emp_VersaoSistema`,`emp_LocalVersao`,`emp_Email`,`emp_LoginPagSeguro`,`emp_TokenPagSeguro`,`emp_TestePagSeguro`,`emp_SenhaEmail`) VALUES 
 (2,'Camila Moraes Arquitetura','  ,   ,   /    -','(11) 98085-4667','Rua Antônio Pinto Guedes','195','Cézar de Souza','Mogi das Cruzes','São Paulo','Ap 22 Bl 7','08820-430','Camila Moraes Arquitetura','1.0.5.0',NULL,'contato@camilamoraesarquitetura.com','contato@camilamoraesarquitetura.com','5EF6FE13FFE649FEB76A80F1FEE16387','1','2402C@mila');
/*!40000 ALTER TABLE `tb_empresa` ENABLE KEYS */;


--
-- Definition of table `tb_fases`
--

DROP TABLE IF EXISTS `tb_fases`;
CREATE TABLE `tb_fases` (
  `fas_Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `fas_Descricao` varchar(200) NOT NULL,
  `fas_Dias` int(10) unsigned NOT NULL,
  `fas_Ativo` tinyint(1) NOT NULL,
  PRIMARY KEY (`fas_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_fases`
--

/*!40000 ALTER TABLE `tb_fases` DISABLE KEYS */;
INSERT INTO `tb_fases` (`fas_Id`,`fas_Descricao`,`fas_Dias`,`fas_Ativo`) VALUES 
 (7,'Layout 3D',4,1),
 (8,'Layout 2D',1,1),
 (9,'Fachada',5,1),
 (10,'Cortes',5,1),
 (11,'Paginação de Piso',5,1),
 (12,'Marcenaria',7,1),
 (13,'Planta de execução',5,1),
 (14,'Emissão de RRT',7,1),
 (15,'Memorial descritivo',8,1),
 (16,'Projeto de elétrica',12,1),
 (17,'Projeto de Hidráulica',12,1),
 (18,'Projeto de ar-condicionado',12,1),
 (19,'Projeto de estrutura',12,1),
 (22,'Aprovação de Layout',3,1),
 (23,'Aprovação de projeto executivo',19,1);
/*!40000 ALTER TABLE `tb_fases` ENABLE KEYS */;


--
-- Definition of table `tb_fasesProjeto`
--

DROP TABLE IF EXISTS `tb_fasesProjeto`;
CREATE TABLE `tb_fasesProjeto` (
  `fap_Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `fap_FasId` int(10) unsigned NOT NULL,
  `fap_PrjId` int(10) unsigned NOT NULL,
  `fap_DataPrevista` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00',
  `fap_DataReal` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00',
  `fap_Finalizada` tinyint(1) NOT NULL,
  PRIMARY KEY (`fap_Id`),
  KEY `FK_tb_fasesProjeto_Fases` (`fap_FasId`),
  KEY `FK_tb_fasesProjeto_Projeto` (`fap_PrjId`),
  CONSTRAINT `FK_tb_fasesProjeto_Fases` FOREIGN KEY (`fap_FasId`) REFERENCES `tb_fases` (`fas_Id`),
  CONSTRAINT `FK_tb_fasesProjeto_Projeto` FOREIGN KEY (`fap_PrjId`) REFERENCES `tb_projeto` (`prj_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=158 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_fasesProjeto`
--

/*!40000 ALTER TABLE `tb_fasesProjeto` DISABLE KEYS */;
INSERT INTO `tb_fasesProjeto` (`fap_Id`,`fap_FasId`,`fap_PrjId`,`fap_DataPrevista`,`fap_DataReal`,`fap_Finalizada`) VALUES 
 (67,7,17,'2018-03-08 13:51:50','2018-03-04 13:51:50',0),
 (68,8,17,'2018-03-05 13:51:50','2018-03-04 13:51:50',0),
 (69,9,17,'2018-03-09 13:51:50','2018-03-04 13:51:50',0),
 (70,10,17,'2018-03-09 13:51:50','2018-03-04 13:51:50',0),
 (71,11,17,'2018-03-09 13:51:50','2018-03-04 13:51:50',0),
 (72,12,17,'2018-03-11 13:51:50','2018-03-04 13:51:50',0),
 (73,13,17,'2018-03-09 13:51:50','2018-03-04 13:51:50',0),
 (74,14,17,'2018-03-11 13:51:50','2018-03-04 13:51:50',0),
 (75,15,17,'2018-03-12 13:51:50','2018-03-04 13:51:50',0),
 (76,16,17,'2018-03-16 13:51:50','2018-03-04 13:51:50',0),
 (77,17,17,'2018-03-16 13:51:50','2018-03-04 13:51:50',0),
 (78,18,17,'2018-03-16 13:51:50','2018-03-04 13:51:50',0),
 (79,19,17,'2018-03-16 13:51:50','2018-03-04 13:51:50',0),
 (80,22,17,'2018-03-07 13:51:50','2018-03-04 13:51:50',0),
 (81,23,17,'2018-03-23 13:51:50','2018-03-04 13:51:50',0),
 (82,7,18,'2018-03-09 11:02:50','2018-03-06 11:24:09',1),
 (83,8,18,'2018-03-06 11:02:50','2018-03-05 13:06:29',1),
 (84,9,18,'2018-03-10 11:02:50','2018-03-09 08:45:02',1),
 (85,10,18,'2018-03-10 11:02:50','2018-03-09 08:45:07',1),
 (86,11,18,'2018-03-10 11:02:50','2018-03-09 08:45:10',1),
 (87,12,18,'2018-03-12 11:02:50','2018-03-09 08:45:15',1),
 (88,13,18,'2018-03-10 11:02:50','2018-03-09 08:45:18',1),
 (89,14,18,'2018-03-12 11:02:50','2018-03-09 08:45:20',1),
 (90,15,18,'2018-03-13 11:02:50','2018-03-09 08:45:23',1),
 (91,16,18,'2018-03-17 11:02:50','2018-03-05 11:02:50',0),
 (92,17,18,'2018-03-17 11:02:50','2018-03-05 11:02:50',0),
 (93,18,18,'2018-03-17 11:02:50','2018-03-05 11:02:50',0),
 (94,19,18,'2018-03-17 11:02:50','2018-03-05 11:02:50',0),
 (95,22,18,'2018-03-08 11:02:50','2018-03-05 13:06:35',1),
 (96,23,18,'2018-03-24 11:02:50','2018-03-05 11:02:50',0),
 (112,7,20,'2018-03-18 09:53:30','2018-03-12 09:53:30',0),
 (113,8,20,'2018-03-15 09:53:30','2018-03-12 09:53:30',0),
 (114,9,20,'2018-03-19 09:53:30','2018-03-12 09:53:30',0),
 (115,10,20,'2018-03-19 09:53:30','2018-03-12 09:53:30',0),
 (116,11,20,'2018-03-19 09:53:30','2018-03-12 09:53:30',0),
 (117,12,20,'2018-03-21 09:53:30','2018-03-12 09:53:30',0),
 (118,13,20,'2018-03-19 09:53:30','2018-03-12 09:53:30',0),
 (119,14,20,'2018-03-21 09:53:30','2018-03-12 09:53:30',0),
 (120,15,20,'2018-03-22 09:53:30','2018-03-12 09:53:30',0),
 (121,16,20,'2018-03-26 09:53:30','2018-03-12 09:53:30',0),
 (122,17,20,'2018-03-26 09:53:30','2018-03-12 09:53:30',0),
 (123,18,20,'2018-03-26 09:53:30','2018-03-12 09:53:30',0),
 (124,19,20,'2018-03-26 09:53:30','2018-03-12 09:53:30',0),
 (125,22,20,'2018-03-17 09:53:30','2018-03-12 09:53:30',0),
 (126,23,20,'2018-04-02 09:53:30','2018-03-12 09:53:30',0),
 (128,7,21,'2018-03-19 17:56:58','2018-03-15 17:56:58',0),
 (129,8,21,'2018-03-16 17:56:58','2018-03-15 17:56:58',0),
 (130,9,21,'2018-03-20 17:56:58','2018-03-15 17:56:58',0),
 (131,10,21,'2018-03-20 17:56:58','2018-03-15 17:56:58',0),
 (132,11,21,'2018-03-20 17:56:58','2018-03-15 17:56:58',0),
 (133,12,21,'2018-03-22 17:56:58','2018-03-15 17:56:58',0),
 (134,13,21,'2018-03-20 17:56:58','2018-03-15 17:56:58',0),
 (135,14,21,'2018-03-22 17:56:58','2018-03-15 17:56:58',0),
 (136,15,21,'2018-03-23 17:56:58','2018-03-15 17:56:58',0),
 (137,16,21,'2018-03-27 17:56:58','2018-03-15 17:56:58',0),
 (138,17,21,'2018-03-27 17:56:58','2018-03-15 17:56:58',0),
 (139,18,21,'2018-03-27 17:56:58','2018-03-15 17:56:58',0),
 (140,19,21,'2018-03-27 17:56:58','2018-03-15 17:56:58',0),
 (141,22,21,'2018-03-18 17:56:58','2018-03-15 17:56:58',0),
 (142,23,21,'2018-04-03 17:56:58','2018-03-15 17:56:58',0),
 (143,7,22,'2018-04-01 17:33:44','2018-03-28 17:33:44',0),
 (144,8,22,'2018-03-29 17:33:44','2018-03-28 17:33:44',0),
 (145,9,22,'2018-04-02 17:33:44','2018-03-28 17:33:44',0),
 (146,10,22,'2018-04-02 17:33:44','2018-03-28 17:33:44',0),
 (147,11,22,'2018-04-02 17:33:44','2018-03-28 17:33:44',0),
 (148,12,22,'2018-04-04 17:33:44','2018-03-28 17:33:44',0),
 (149,13,22,'2018-04-02 17:33:44','2018-03-28 17:33:44',0),
 (150,14,22,'2018-04-04 17:33:44','2018-03-28 17:33:44',0),
 (151,15,22,'2018-04-05 17:33:44','2018-03-28 17:33:44',0),
 (152,16,22,'2018-04-09 17:33:44','2018-03-28 17:33:44',0),
 (153,17,22,'2018-04-09 17:33:44','2018-03-28 17:33:44',0),
 (154,18,22,'2018-04-09 17:33:44','2018-03-28 17:33:44',0),
 (155,19,22,'2018-04-09 17:33:44','2018-03-28 17:33:44',0),
 (156,22,22,'2018-03-31 17:33:44','2018-03-28 17:33:44',0),
 (157,23,22,'2018-04-16 17:33:44','2018-03-28 17:33:44',0);
/*!40000 ALTER TABLE `tb_fasesProjeto` ENABLE KEYS */;


--
-- Definition of table `tb_fluxoCaixa`
--

DROP TABLE IF EXISTS `tb_fluxoCaixa`;
CREATE TABLE `tb_fluxoCaixa` (
  `flc_Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `flc_DataCadastro` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `flc_Entrada` tinyint(1) NOT NULL,
  `flc_UsrId` int(10) unsigned NOT NULL,
  `flc_Descricao` varchar(200) NOT NULL,
  `flc_Valor` decimal(10,2) NOT NULL,
  `flc_DataCaixa` datetime NOT NULL,
  `flc_GrfId` int(10) unsigned DEFAULT NULL,
  `flc_PagSeguro` tinyint(3) unsigned NOT NULL,
  `flc_PagamentoConfirmado` tinyint(3) unsigned NOT NULL,
  `flc_URLPagamento` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`flc_Id`),
  KEY `FK_FluxoCaixa_Usuario` (`flc_UsrId`),
  KEY `FK_tb_fluxoCaixa_GrupoFinanceiro` (`flc_GrfId`),
  CONSTRAINT `FK_FluxoCaixa_Usuario` FOREIGN KEY (`flc_UsrId`) REFERENCES `tb_usuario` (`usr_Id`),
  CONSTRAINT `FK_tb_fluxoCaixa_GrupoFinanceiro` FOREIGN KEY (`flc_GrfId`) REFERENCES `tb_grupoFinanceiro` (`grf_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_fluxoCaixa`
--

/*!40000 ALTER TABLE `tb_fluxoCaixa` DISABLE KEYS */;
INSERT INTO `tb_fluxoCaixa` (`flc_Id`,`flc_DataCadastro`,`flc_Entrada`,`flc_UsrId`,`flc_Descricao`,`flc_Valor`,`flc_DataCaixa`,`flc_GrfId`,`flc_PagSeguro`,`flc_PagamentoConfirmado`,`flc_URLPagamento`) VALUES 
 (1,'2018-04-18 20:22:06',1,4,'Pagamento do Projeto via PagSeguro','272.00','2018-04-18 19:42:38',9,1,1,'https://sandbox.pagseguro.uol.com.br/v2/checkout/payment.html?code=6B5E5CC8F5F5B7B004009F8EAB8BC6CA'),
 (2,'2018-05-08 14:30:47',1,4,'Pagamento do Projeto via PagSeguro','272.00','2018-04-28 00:36:30',9,1,1,'https://sandbox.pagseguro.uol.com.br/v2/checkout/payment.html?code=D3CD5332DFDF7E6CC4491F9428FB1BB0'),
 (3,'2018-04-28 00:39:28',0,4,'Almoço','15.00','2018-04-28 00:39:17',7,0,0,NULL);
/*!40000 ALTER TABLE `tb_fluxoCaixa` ENABLE KEYS */;


--
-- Definition of table `tb_grupoFinanceiro`
--

DROP TABLE IF EXISTS `tb_grupoFinanceiro`;
CREATE TABLE `tb_grupoFinanceiro` (
  `grf_Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `grf_Descricao` varchar(50) NOT NULL,
  `grf_Ativo` tinyint(1) NOT NULL DEFAULT '1',
  `grf_Data` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`grf_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_grupoFinanceiro`
--

/*!40000 ALTER TABLE `tb_grupoFinanceiro` DISABLE KEYS */;
INSERT INTO `tb_grupoFinanceiro` (`grf_Id`,`grf_Descricao`,`grf_Ativo`,`grf_Data`) VALUES 
 (6,'Deslocamento',1,'2018-03-04 13:32:34'),
 (7,'Refeição',1,'2018-03-04 13:32:45'),
 (8,'Estadia',1,'2018-03-04 13:33:23'),
 (9,'Entrada',1,'2018-04-18 19:42:13');
/*!40000 ALTER TABLE `tb_grupoFinanceiro` ENABLE KEYS */;


--
-- Definition of table `tb_mensagens`
--

DROP TABLE IF EXISTS `tb_mensagens`;
CREATE TABLE `tb_mensagens` (
  `msg_Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `msg_Texto` varchar(255) NOT NULL,
  `msg_DataHora` datetime NOT NULL,
  `msg_Lida` tinyint(3) unsigned NOT NULL,
  `msg_UsrId` int(10) unsigned NOT NULL,
  `msg_UsrIdEnvio` int(10) unsigned NOT NULL,
  PRIMARY KEY (`msg_Id`),
  KEY `FK_tb_Mensagens_Usuario` (`msg_UsrId`),
  CONSTRAINT `FK_tb_Mensagens_Usuario` FOREIGN KEY (`msg_UsrId`) REFERENCES `tb_usuario` (`usr_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_mensagens`
--

/*!40000 ALTER TABLE `tb_mensagens` DISABLE KEYS */;
INSERT INTO `tb_mensagens` (`msg_Id`,`msg_Texto`,`msg_DataHora`,`msg_Lida`,`msg_UsrId`,`msg_UsrIdEnvio`) VALUES 
 (1,'Pagamento do projeto 22 liberado no PagSeguro.','2018-04-18 20:21:44',1,4,0),
 (2,'Pagamento do projeto 22 liberado no PagSeguro.','2018-04-18 20:21:44',1,5,0),
 (3,'Pagamento do projeto 22 liberado no PagSeguro.','2018-04-18 20:21:44',0,6,0),
 (4,'Oi','2018-04-28 00:32:55',1,5,4),
 (5,'oi, tudo bem e você?','2018-04-28 00:34:27',0,4,5),
 (6,'\r\n','2018-04-28 00:34:28',0,4,5),
 (7,'\r\nto  bem','2018-04-28 00:34:36',0,5,4),
 (8,'Pagamento do projeto 22 liberado no PagSeguro.','2018-05-08 14:29:06',0,4,0),
 (9,'Pagamento do projeto 22 liberado no PagSeguro.','2018-05-08 14:29:06',0,5,0),
 (10,'Pagamento do projeto 22 liberado no PagSeguro.','2018-05-08 14:29:06',0,6,0);
/*!40000 ALTER TABLE `tb_mensagens` ENABLE KEYS */;


--
-- Definition of table `tb_orcamento`
--

DROP TABLE IF EXISTS `tb_orcamento`;
CREATE TABLE `tb_orcamento` (
  `orc_Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `orc_SerId` int(10) unsigned NOT NULL,
  `orc_PrjId` int(10) unsigned NOT NULL,
  `orc_Qtde` int(10) unsigned NOT NULL,
  PRIMARY KEY (`orc_Id`),
  KEY `FK_tb_orcamento_Servico` (`orc_SerId`),
  KEY `FK_tb_orcamento_Projeto` (`orc_PrjId`),
  CONSTRAINT `FK_tb_orcamento_Projeto` FOREIGN KEY (`orc_PrjId`) REFERENCES `tb_projeto` (`prj_Id`),
  CONSTRAINT `FK_tb_orcamento_Servico` FOREIGN KEY (`orc_SerId`) REFERENCES `tb_servicos` (`ser_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=114 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_orcamento`
--

/*!40000 ALTER TABLE `tb_orcamento` DISABLE KEYS */;
INSERT INTO `tb_orcamento` (`orc_Id`,`orc_SerId`,`orc_PrjId`,`orc_Qtde`) VALUES 
 (48,49,17,1),
 (58,40,17,1),
 (59,41,17,1),
 (60,42,17,1),
 (61,43,17,1),
 (62,46,17,1),
 (63,47,17,1),
 (64,48,17,1),
 (65,50,17,1),
 (66,56,17,233),
 (67,58,17,2),
 (68,57,17,2),
 (69,59,17,8),
 (70,40,18,2),
 (71,41,18,2),
 (72,42,18,2),
 (73,43,18,2),
 (76,43,19,1),
 (77,40,19,1),
 (78,42,19,1),
 (79,46,19,1),
 (80,47,19,1),
 (81,48,19,1),
 (82,48,19,1),
 (83,49,19,1),
 (84,50,19,1),
 (85,56,19,272),
 (86,57,19,2),
 (87,58,19,2),
 (88,59,19,16),
 (89,61,19,1),
 (90,40,20,1),
 (91,41,20,1),
 (92,42,20,1),
 (93,43,20,1),
 (94,46,20,1),
 (95,47,20,1),
 (96,48,20,1),
 (97,49,20,1),
 (98,50,20,1),
 (100,56,20,272),
 (101,57,20,2),
 (102,58,20,2),
 (103,59,20,8),
 (104,61,20,1),
 (105,51,20,950),
 (106,52,20,750),
 (107,56,21,2400),
 (108,58,21,40),
 (109,57,21,40),
 (110,40,22,1),
 (111,41,22,1),
 (112,42,22,1),
 (113,43,22,1);
/*!40000 ALTER TABLE `tb_orcamento` ENABLE KEYS */;


--
-- Definition of table `tb_projeto`
--

DROP TABLE IF EXISTS `tb_projeto`;
CREATE TABLE `tb_projeto` (
  `prj_Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `prj_CliId` int(10) unsigned NOT NULL,
  `prj_DataInicio` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `prj_DataFimPrevista` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00',
  `prj_DataFimReal` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00',
  `prj_UsrId` int(10) unsigned NOT NULL,
  `prj_Obs` varchar(20000) DEFAULT NULL,
  `prj_PerGanho` int(10) unsigned NOT NULL,
  `prj_Arredondamento` decimal(10,2) NOT NULL,
  PRIMARY KEY (`prj_Id`),
  KEY `FK_Projeto_Cliente` (`prj_CliId`),
  KEY `FK_Projeto_Usuario` (`prj_UsrId`),
  CONSTRAINT `FK_Projeto_Cliente` FOREIGN KEY (`prj_CliId`) REFERENCES `tb_cliente` (`cli_Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_Projeto_Usuario` FOREIGN KEY (`prj_UsrId`) REFERENCES `tb_usuario` (`usr_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_projeto`
--

/*!40000 ALTER TABLE `tb_projeto` DISABLE KEYS */;
INSERT INTO `tb_projeto` (`prj_Id`,`prj_CliId`,`prj_DataInicio`,`prj_DataFimPrevista`,`prj_DataFimReal`,`prj_UsrId`,`prj_Obs`,`prj_PerGanho`,`prj_Arredondamento`) VALUES 
 (17,11,'2018-03-04 13:51:50','2018-03-23 13:51:50','2018-03-04 13:51:50',6,'Shopping Aricanduva',0,'2179.88'),
 (18,12,'2018-03-05 11:02:50','2018-03-24 11:02:50','2018-03-09 08:45:23',6,'Grão Espresso - Shopping Grande Circular',0,'0.00'),
 (19,13,'2018-03-06 14:15:33','2018-03-25 14:15:33','2018-03-06 14:15:33',6,'Elaboração de projeto de forro',0,'462.00'),
 (20,14,'2018-03-14 09:53:30','2018-03-31 09:53:30','2018-03-12 09:53:30',6,'',0,'4390.48'),
 (21,15,'2018-03-15 17:56:58','2018-04-03 17:56:58','2018-03-15 17:56:58',6,'TRABALHAR COM GILBERTO FULL TIME NA VEST CASA',0,'5000.00'),
 (22,16,'2018-03-28 17:33:44','2018-04-16 17:33:44','2018-03-28 17:33:44',6,'MAIS PETS MARGINAL',0,'136.00');
/*!40000 ALTER TABLE `tb_projeto` ENABLE KEYS */;


--
-- Definition of table `tb_projetoFluxoCaixa`
--

DROP TABLE IF EXISTS `tb_projetoFluxoCaixa`;
CREATE TABLE `tb_projetoFluxoCaixa` (
  `pfc_Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `pfc_PrjId` int(10) unsigned NOT NULL,
  `pfc_FlcId` int(10) unsigned NOT NULL,
  `pfc_Despesa` tinyint(1) NOT NULL,
  PRIMARY KEY (`pfc_Id`),
  KEY `FK_tb_projetoFluxoCaixa_Projeto` (`pfc_PrjId`),
  KEY `FK_tb_projetoFluxoCaixa_FluxoCaixa` (`pfc_FlcId`),
  CONSTRAINT `FK_tb_projetoFluxoCaixa_FluxoCaixa` FOREIGN KEY (`pfc_FlcId`) REFERENCES `tb_fluxoCaixa` (`flc_Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_tb_projetoFluxoCaixa_Projeto` FOREIGN KEY (`pfc_PrjId`) REFERENCES `tb_projeto` (`prj_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_projetoFluxoCaixa`
--

/*!40000 ALTER TABLE `tb_projetoFluxoCaixa` DISABLE KEYS */;
INSERT INTO `tb_projetoFluxoCaixa` (`pfc_Id`,`pfc_PrjId`,`pfc_FlcId`,`pfc_Despesa`) VALUES 
 (1,22,1,0),
 (2,22,2,0),
 (3,22,3,1);
/*!40000 ALTER TABLE `tb_projetoFluxoCaixa` ENABLE KEYS */;


--
-- Definition of table `tb_servicos`
--

DROP TABLE IF EXISTS `tb_servicos`;
CREATE TABLE `tb_servicos` (
  `ser_Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `ser_Descricao` varchar(50) NOT NULL,
  `ser_Valor` decimal(10,2) NOT NULL,
  `ser_Ativo` tinyint(1) NOT NULL DEFAULT '1',
  `ser_Data` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `ser_UniId` int(10) unsigned NOT NULL,
  PRIMARY KEY (`ser_Id`),
  KEY `FK_Servicos_Unidade` (`ser_UniId`),
  CONSTRAINT `FK_Servicos_Unidade` FOREIGN KEY (`ser_UniId`) REFERENCES `tb_unidade` (`uni_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=62 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_servicos`
--

/*!40000 ALTER TABLE `tb_servicos` DISABLE KEYS */;
INSERT INTO `tb_servicos` (`ser_Id`,`ser_Descricao`,`ser_Valor`,`ser_Ativo`,`ser_Data`,`ser_UniId`) VALUES 
 (40,'Layout 3D','32.00',1,'2018-03-04 15:40:48',4),
 (41,'Layout 2D','64.00',1,'2018-03-04 15:41:04',4),
 (42,'Fachada','24.00',1,'2018-03-04 15:41:11',4),
 (43,'Cortes','16.00',1,'2018-03-04 15:41:25',4),
 (46,'Paginação de Piso','2.16',1,'2018-03-04 15:41:37',4),
 (47,'Marcenaria','256.00',1,'2018-03-04 15:41:52',4),
 (48,'Planta de execução','2.16',1,'2018-03-04 15:42:01',4),
 (49,'Emissão de RRT','90.00',1,'2018-03-04 14:02:46',8),
 (50,'Memorial descritivo','16.00',1,'2018-03-04 15:42:12',4),
 (51,'Projeto de elétrica','1.00',1,'2018-03-04 13:28:15',4),
 (52,'Projeto de Hidráulica','1.00',1,'2018-03-04 13:28:29',4),
 (53,'Projeto de ar-condicionado','1.00',1,'2018-03-04 13:29:57',4),
 (54,'Projeto de estrutura','1.00',1,'2018-03-04 13:30:11',4),
 (55,'Projeto Executivo','1.00',1,'2018-03-04 13:58:20',4),
 (56,'Quilômetragem','0.60',1,'2018-03-04 14:08:59',6),
 (57,'Almoço','25.00',1,'2018-03-04 14:21:15',8),
 (58,'Café da Manhã','10.00',1,'2018-03-04 14:21:46',8),
 (59,'Pedágio ','1.00',1,'2018-03-04 14:23:07',4),
 (60,'Visita técnica','1.00',1,'2018-03-04 14:29:42',4),
 (61,'Planta de forro','16.00',1,'2018-03-06 14:17:16',8);
/*!40000 ALTER TABLE `tb_servicos` ENABLE KEYS */;


--
-- Definition of table `tb_telas`
--

DROP TABLE IF EXISTS `tb_telas`;
CREATE TABLE `tb_telas` (
  `tel_Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `tel_Nome` varchar(45) NOT NULL,
  `tel_frmPrincipal` varchar(45) NOT NULL,
  `tel_Icone` varchar(200) NOT NULL,
  PRIMARY KEY (`tel_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_telas`
--

/*!40000 ALTER TABLE `tb_telas` DISABLE KEYS */;
INSERT INTO `tb_telas` (`tel_Id`,`tel_Nome`,`tel_frmPrincipal`,`tel_Icone`) VALUES 
 (1,'&Usuários','Usuario.frmUsuario','User.png'),
 (2,'&Clientes','Clientes.frmClientes','person.png'),
 (3,'Cus&tos','Servicos.frmServicos','service.png'),
 (4,'&Grupo Financeiro','GrupoFinanceiro.frmGrupoFinanceiro','Financesgroup.png'),
 (5,'&Unidades','Unidades.frmUnidades','UnidadeRulers-icon.png'),
 (6,'&Projetos','Projetos.frmProjetos','project.png'),
 (7,'&Despesas','Despesas.frmDespesas','deleteCoin2.png'),
 (8,'&Fases','Fases.frmFases','Next.png'),
 (9,'D&ashBoard de Projetos','DashBoard.frmDashBoardProjetos','DashProjetos.png'),
 (10,'F&luxo Caixa','FluxoCaixa.frmFluxoCaixa','cash.png'),
 (11,'&Senha','Usuario.frmSenhaUsuario','Lock2.png'),
 (12,'&Empresa','Configuracoes.frmConfiguracoesEmpresa','settings-icon.png');
/*!40000 ALTER TABLE `tb_telas` ENABLE KEYS */;


--
-- Definition of table `tb_unidade`
--

DROP TABLE IF EXISTS `tb_unidade`;
CREATE TABLE `tb_unidade` (
  `uni_Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `uni_Descricao` varchar(45) NOT NULL,
  PRIMARY KEY (`uni_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_unidade`
--

/*!40000 ALTER TABLE `tb_unidade` DISABLE KEYS */;
INSERT INTO `tb_unidade` (`uni_Id`,`uni_Descricao`) VALUES 
 (4,'R$'),
 (5,'m'),
 (6,'km'),
 (7,'h'),
 (8,'Un');
/*!40000 ALTER TABLE `tb_unidade` ENABLE KEYS */;


--
-- Definition of table `tb_usuario`
--

DROP TABLE IF EXISTS `tb_usuario`;
CREATE TABLE `tb_usuario` (
  `usr_Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `usr_Email` varchar(200) NOT NULL,
  `usr_Senha` varchar(50) NOT NULL,
  `usr_Nome` varchar(200) NOT NULL,
  `usr_Ativo` tinyint(1) NOT NULL DEFAULT '1',
  `usr_Data` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`usr_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_usuario`
--

/*!40000 ALTER TABLE `tb_usuario` DISABLE KEYS */;
INSERT INTO `tb_usuario` (`usr_Id`,`usr_Email`,`usr_Senha`,`usr_Nome`,`usr_Ativo`,`usr_Data`) VALUES 
 (4,'admin','2402','Administrador do Sistema',1,'2018-04-06 20:29:22'),
 (5,'camila.moraes','1909','Camila Moraes',1,'2018-04-09 16:11:30'),
 (6,'raul.vazquez','1909','Raul Vazquez',1,'2018-04-09 11:25:11');
/*!40000 ALTER TABLE `tb_usuario` ENABLE KEYS */;




/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
