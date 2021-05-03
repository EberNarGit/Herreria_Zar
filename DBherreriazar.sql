CREATE DATABASE  IF NOT EXISTS `herreriazar` /*!40100 DEFAULT CHARACTER SET utf8 */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `herreriazar`;
-- MySQL dump 10.13  Distrib 8.0.22, for Win64 (x86_64)
--
-- Host: localhost    Database: herreriazar
-- ------------------------------------------------------
-- Server version	8.0.22

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `catalogo_clientes`
--

DROP TABLE IF EXISTS `catalogo_clientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `catalogo_clientes` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) NOT NULL,
  `paterno` varchar(45) NOT NULL,
  `materno` varchar(45) NOT NULL,
  `correo` varchar(45) DEFAULT NULL,
  `telefono` varchar(45) DEFAULT NULL,
  `usuarios_fk` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `usuarios_catcli_fk_idx` (`usuarios_fk`),
  CONSTRAINT `usuarios_catcli_fk` FOREIGN KEY (`usuarios_fk`) REFERENCES `usuarios` (`id`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=52 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `catalogo_clientes`
--

LOCK TABLES `catalogo_clientes` WRITE;
/*!40000 ALTER TABLE `catalogo_clientes` DISABLE KEYS */;
INSERT INTO `catalogo_clientes` VALUES (1,'pepe','perez','perales','pepe@pepe','8443600994',1),(2,'Mac','Gierardi','Amery','mamery0@diigo.com','660 246 7098',4),(3,'Analiese','McAtamney','Fuzzens','afuzzens1@ameblo.jp','458 565 8033',4),(4,'Etty','McGauhy','Carter','ecarter2@addtoany.com','575 775 9582',4),(5,'Nicola','Gecke','Cantillion','ncantillion3@google.nl','694 390 5920',2),(6,'Kristine','Wadeson','Threlfall','kthrelfall4@spiegel.de','188 621 2359',2),(7,'Aidan','Barnwille','Matthiae','amatthiae5@a8.net','202 920 0828',5),(8,'Yves','Simakov','Gubbin','ygubbin6@gmpg.org','832 862 8834',4),(9,'Reinold','Sesons','Covill','rcovill7@amazonaws.com','409 944 3199',3),(10,'Jayme','Kaaskooper','O\' Sullivan','josullivan8@behance.net','492 876 5854',1),(11,'Patrick','Lafrentz','Szymoni','pszymoni9@tripod.com','584 353 2724',3),(12,'Fiona','Rothery','Catenot','fcatenota@domainmarket.com','841 663 7031',2),(13,'Kendra','Hallows','Doby','kdobyb@pen.io','611 711 9056',1),(14,'Yves','Steagall','Vannet','yvannetc@paginegialle.it','519 254 5967',3),(15,'Timothea','Sapauton','Roantree','troantreed@arizona.edu','834 395 0255',5),(16,'Chas','Petteford','Pimley','cpimleye@taobao.com','413 326 1652',2),(17,'Gustavo','Risborough','Burman','gburmanf@loc.gov','842 198 0090',1),(18,'Chlo','Mockes','Grovier','cgrovierg@globo.com','123 311 7239',3),(19,'Corinna','Bottle','Whitefoot','cwhitefooth@bloglines.com','178 279 0916',1),(20,'Darbee','Giorgietto','Kosiada','dkosiadai@sphinn.com','478 495 3625',3),(21,'Fletcher','Delany','Leaney','fleaneyj@skype.com','722 374 7507',5),(22,'Jenny','Rowena','Chiplin','jchiplink@opera.com','670 260 5422',4),(23,'Burnard','MacCartair','Fairham','bfairhaml@cloudflare.com','602 589 1095',4),(24,'Carny','Raulston','Cossans','ccossansm@blinklist.com','220 300 2966',4),(25,'Wilmer','Gunner','Stonestreet','wstonestreetn@sogou.com','998 346 4472',2),(26,'Darci','Eckly','Acum','dacumo@yolasite.com','403 661 4466',3),(27,'Colly','McCorkindale','Shears','cshearsp@abc.net.au','510 249 8790',1),(28,'Ernaline','Momford','Boriston','eboristonq@liveinternet.ru','970 480 0195',2),(29,'Locke','Plessing','Judge','ljudger@redcross.org','490 892 4804',3),(30,'Karim','Shoorbrooke','Di Baudi','kdibaudis@economist.com','396 605 1317',3),(31,'Rebbecca','Rhymer','Espadate','respadatet@blogtalkradio.com','928 904 1962',3),(32,'Roddy','Bennitt','Elloy','relloyu@gmpg.org','590 715 4770',5),(33,'Dorris','Allright','Merrell','dmerrellv@ebay.com','890 144 8655',1),(34,'Doralin','Peetermann','Cassar','dcassarw@tuttocitta.it','405 992 9301',2),(35,'Olag','Riddiough','Summergill','osummergillx@cbsnews.com','592 182 3103',3),(36,'Dulcea','Patriskson','McNaught','dmcnaughty@chronoengine.com','437 545 3994',3),(37,'Jasper','Eadmead','Farnan','jfarnanz@typepad.com','319 430 3160',4),(38,'Eryn','Phlippsen','McCollum','emccollum10@surveymonkey.com','887 308 3114',5),(39,'Tiebout','Mocher','Harlin','tharlin11@blogs.com','958 955 3693',4),(40,'Dyanne','Valentin','Son','dson12@yolasite.com','586 336 4027',3),(41,'Anatollo','Shemwell','Reasun','areasun13@dailymail.co.uk','406 271 2703',1),(42,'Heather','Stooke','Gorries','hgorries14@php.net','279 371 6238',3),(43,'Dacie','Jacombs','Palethorpe','dpalethorpe15@cisco.com','340 842 3216',3),(44,'Amy','Jarrard','Mendez','amendez16@cloudflare.com','640 839 6646',3),(45,'Chelsie','Raulston','Kalaher','ckalaher17@wufoo.com','178 153 4833',5),(46,'Carl','Letts','Mafham','cmafham18@msu.edu','777 691 8357',3),(47,'Una','Luck','Sebley','usebley19@mail.ru','257 131 0175',2),(48,'Irvine','De Domenicis','Zuann','izuann1a@noaa.gov','258 892 8958',3),(49,'Dunstan','Langsbury','Skewes','dskewes1b@wordpress.com','575 822 2820',4),(50,'Jonie','Broadfoot','Doggerell','jdoggerell1c@ed.gov','717 651 7261',1),(51,'Zelig','Follet','Speakman','zspeakman1d@godaddy.com','958 367 2950',3);
/*!40000 ALTER TABLE `catalogo_clientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `catalogo_productos`
--

DROP TABLE IF EXISTS `catalogo_productos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `catalogo_productos` (
  `id` int NOT NULL AUTO_INCREMENT,
  `imagen` varchar(300) NOT NULL,
  `descripcion` varchar(300) DEFAULT NULL,
  `usuarios_fk` int NOT NULL,
  `categorias_fk` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `categorias_catpro_fk_idx` (`categorias_fk`),
  KEY `usuarios_catpro_fk_idx` (`usuarios_fk`),
  CONSTRAINT `categorias_catpro_fk` FOREIGN KEY (`categorias_fk`) REFERENCES `categoria` (`id`) ON UPDATE CASCADE,
  CONSTRAINT `usuarios_catpro_fk` FOREIGN KEY (`usuarios_fk`) REFERENCES `usuarios` (`id`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `catalogo_productos`
--

LOCK TABLES `catalogo_productos` WRITE;
/*!40000 ALTER TABLE `catalogo_productos` DISABLE KEYS */;
INSERT INTO `catalogo_productos` VALUES (1,'urldeimagen','es una puerta muy bonita',1,1),(2,'http://dummyimage.com/231x100.png/dddddd/000000','Type II occipital condyle fracture, left side, sequela',4,5),(3,'http://dummyimage.com/190x100.png/cc0000/ffffff','Unspecified focal traumatic brain injury with loss of consciousness greater than 24 hours without return to pre-existing conscious level with patient surviving, sequela',3,5),(4,'http://dummyimage.com/173x100.png/cc0000/ffffff','Corrosion of second degree of unspecified upper arm, sequela',2,2),(5,'http://dummyimage.com/169x100.png/ff4444/ffffff','Induration penis plastica',4,5),(6,'http://dummyimage.com/121x100.png/cc0000/ffffff','Contracture, shoulder',5,5);
/*!40000 ALTER TABLE `catalogo_productos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `categoria`
--

DROP TABLE IF EXISTS `categoria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categoria` (
  `id` int NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categoria`
--

LOCK TABLES `categoria` WRITE;
/*!40000 ALTER TABLE `categoria` DISABLE KEYS */;
INSERT INTO `categoria` VALUES (1,'puerta'),(2,'ventana'),(3,'porton'),(4,'asador'),(5,'especial');
/*!40000 ALTER TABLE `categoria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pagos`
--

DROP TABLE IF EXISTS `pagos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pagos` (
  `id` int NOT NULL AUTO_INCREMENT,
  `pago` float NOT NULL,
  `fecha` datetime NOT NULL,
  `venta_general_fk` int NOT NULL,
  `usuarios_fk` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `ventaG_pagos_fk_idx` (`venta_general_fk`),
  KEY `usuarios_pagos_fk_idx` (`usuarios_fk`),
  CONSTRAINT `usuarios_pagos_fk` FOREIGN KEY (`usuarios_fk`) REFERENCES `usuarios` (`id`),
  CONSTRAINT `ventaG_pagos_fk` FOREIGN KEY (`venta_general_fk`) REFERENCES `venta_general` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=97 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pagos`
--

LOCK TABLES `pagos` WRITE;
/*!40000 ALTER TABLE `pagos` DISABLE KEYS */;
INSERT INTO `pagos` VALUES (1,4250,'2020-06-18 00:00:00',1,1),(2,3500,'2021-07-19 00:00:00',2,1),(3,17054,'2023-07-07 00:00:00',54,4),(4,6823,'2021-03-31 00:00:00',62,3),(5,8655,'2023-03-26 00:00:00',42,2),(6,13288,'2020-11-24 00:00:00',79,3),(7,17183,'2021-09-27 00:00:00',89,5),(8,5298,'2022-04-21 00:00:00',14,2),(9,7400,'2022-12-11 00:00:00',11,1),(10,1936,'2023-04-10 00:00:00',27,2),(11,12950,'2022-10-23 00:00:00',40,5),(12,6626,'2022-08-25 00:00:00',29,5),(13,5574,'2022-08-16 00:00:00',67,3),(14,1764,'2021-08-07 00:00:00',89,2),(15,2020,'2021-09-24 00:00:00',91,4),(16,7798,'2020-08-13 00:00:00',78,1),(17,11110,'2021-12-19 00:00:00',7,5),(18,9130,'2022-04-04 00:00:00',1,3),(19,16993,'2020-11-18 00:00:00',95,3),(20,1034,'2022-10-20 00:00:00',12,1),(21,4335,'2023-02-18 00:00:00',45,4),(22,8500,'2020-06-09 00:00:00',47,4),(24,11827,'2020-10-18 00:00:00',66,1),(25,19308,'2023-04-21 00:00:00',14,5),(26,12737,'2022-08-07 00:00:00',17,5),(27,13162,'2022-10-29 00:00:00',18,5),(28,17044,'2022-05-19 00:00:00',50,2),(29,4200,'2020-11-30 00:00:00',38,4),(30,13762,'2023-06-24 00:00:00',25,3),(31,19223,'2020-08-29 00:00:00',26,2),(32,6066,'2022-11-08 00:00:00',75,1),(33,11813,'2023-06-13 00:00:00',36,2),(34,16029,'2022-08-11 00:00:00',66,1),(35,14825,'2023-08-24 00:00:00',24,4),(36,15204,'2023-03-07 00:00:00',43,4),(37,2141,'2021-12-04 00:00:00',101,3),(38,10495,'2021-05-24 00:00:00',55,2),(39,19628,'2020-11-20 00:00:00',51,5),(40,12079,'2022-01-26 00:00:00',25,4),(41,10001,'2022-05-08 00:00:00',78,3),(42,2837,'2022-02-12 00:00:00',73,4),(43,12219,'2022-11-01 00:00:00',30,3),(44,2452,'2023-06-16 00:00:00',40,4),(45,16398,'2023-05-27 00:00:00',53,4),(46,3238,'2021-05-20 00:00:00',36,5),(47,11545,'2022-04-15 00:00:00',36,5),(48,7171,'2023-02-15 00:00:00',55,4),(49,11391,'2021-12-19 00:00:00',88,2),(50,18653,'2022-04-12 00:00:00',24,5),(51,17554,'2020-06-15 00:00:00',56,2),(52,19773,'2021-04-13 00:00:00',36,5),(53,9848,'2022-11-11 00:00:00',58,2),(54,3252,'2020-10-01 00:00:00',58,1),(55,16855,'2023-01-04 00:00:00',11,3),(56,3896,'2021-06-07 00:00:00',37,3),(57,19030,'2022-04-18 00:00:00',89,5),(58,4388,'2021-05-03 00:00:00',102,3),(59,844,'2021-02-13 00:00:00',35,5),(60,8952,'2022-01-04 00:00:00',40,4),(61,19632,'2020-06-28 00:00:00',42,1),(62,5164,'2022-03-19 00:00:00',52,4),(63,5629,'2022-06-29 00:00:00',36,2),(64,13762,'2020-11-22 00:00:00',89,3),(65,10505,'2020-07-18 00:00:00',50,1),(66,7241,'2020-11-09 00:00:00',2,5),(67,9625,'2023-05-24 00:00:00',49,4),(68,7089,'2021-07-02 00:00:00',64,5),(69,14068,'2021-11-21 00:00:00',90,1),(70,12626,'2022-04-05 00:00:00',68,3),(71,17552,'2020-09-05 00:00:00',79,5),(72,1049,'2022-11-12 00:00:00',50,4),(73,15408,'2020-09-17 00:00:00',48,4),(74,3353,'2020-06-08 00:00:00',21,3),(75,15833,'2022-09-03 00:00:00',61,3),(76,1453,'2022-12-22 00:00:00',8,4),(77,19201,'2023-01-21 00:00:00',46,3),(78,5055,'2023-07-14 00:00:00',85,4),(79,12055,'2021-12-29 00:00:00',20,1),(80,19591,'2020-09-05 00:00:00',26,3),(81,4284,'2020-08-09 00:00:00',72,2),(82,15570,'2020-12-17 00:00:00',56,5),(83,3283,'2022-07-03 00:00:00',40,4),(84,521,'2022-10-15 00:00:00',83,2),(85,11386,'2022-05-23 00:00:00',87,1),(86,6433,'2022-06-02 00:00:00',65,3),(87,19936,'2021-07-03 00:00:00',59,3),(88,1980,'2022-08-19 00:00:00',101,1),(89,11148,'2021-05-28 00:00:00',39,3),(90,17622,'2022-03-06 00:00:00',100,2),(91,3836,'2020-06-15 00:00:00',11,1),(92,1423,'2021-01-25 00:00:00',57,5),(93,620,'2021-07-21 00:00:00',40,4),(94,3377,'2023-03-02 00:00:00',67,5),(95,5550,'2022-11-24 00:00:00',37,1),(96,17054,'2023-07-07 00:00:00',54,4);
/*!40000 ALTER TABLE `pagos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarios` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) NOT NULL,
  `paterno` varchar(45) NOT NULL,
  `materno` varchar(45) NOT NULL,
  `usuario` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `usuario_UNIQUE` (`usuario`),
  UNIQUE KEY `password_UNIQUE` (`password`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (1,'Eber Eliud','Rodriguez','Alvarado','EberNar844','844183'),(2,'Armando','Brake','Tamas','atamas0','z4gIISeKm6aB'),(3,'Benedicta','Kimbrough','Zum Felde','bzumfelde1','CC71oh6G'),(4,'Esdras','Jordine','Jancey','ejancey2','GOMqcs3'),(5,'Lebbie','Osman','Tadgell','ltadgell3','FOQ4q7hb'),(6,'Loren','Relf','Aitkin','laitkin4','43Dq4FS6ULw');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `venta_especifica`
--

DROP TABLE IF EXISTS `venta_especifica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `venta_especifica` (
  `id` int NOT NULL AUTO_INCREMENT,
  `alto` float NOT NULL,
  `ancho` float NOT NULL,
  `largo` float NOT NULL,
  `color` varchar(45) DEFAULT NULL,
  `cantidad` int NOT NULL,
  `precio` double NOT NULL,
  `productos_fk` int NOT NULL,
  `venta_general_fk` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `productos_ventaE_fk_idx` (`productos_fk`),
  KEY `ventaG_ventaE_fk_idx` (`venta_general_fk`),
  CONSTRAINT `productos_ventaE_fk` FOREIGN KEY (`productos_fk`) REFERENCES `catalogo_productos` (`id`),
  CONSTRAINT `ventaG_ventaE_fk` FOREIGN KEY (`venta_general_fk`) REFERENCES `venta_general` (`id`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=96 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `venta_especifica`
--

LOCK TABLES `venta_especifica` WRITE;
/*!40000 ALTER TABLE `venta_especifica` DISABLE KEYS */;
INSERT INTO `venta_especifica` VALUES (1,175.5,10.5,85.2,'negro mate',1,2500,1,1),(2,80,5.2,50,'cafe',2,3500,1,2),(3,105,290,484,'Maroon',1,33895,1,32),(4,65,312,269,'Crimson',1,24327,6,58),(5,376,400,219,'Maroon',4,28658,2,48),(6,317,59,327,'Blue',2,7057,5,29),(7,272,293,330,'Pink',3,25855,4,42),(8,360,438,440,'Puce',2,2062,2,28),(9,55,223,134,'Aquamarine',4,31023,1,83),(10,274,456,413,'Pink',3,8193,4,98),(11,381,329,295,'Maroon',5,27690,5,28),(12,187,126,248,'Fuscia',5,1829,4,85),(13,191,250,336,'Orange',2,31525,4,103),(14,261,202,223,'Aquamarine',2,31439,3,80),(15,314,126,452,'Yellow',1,24013,2,48),(16,250,251,261,'Puce',4,39529,1,14),(17,486,469,351,'Indigo',2,8754,2,73),(18,447,114,355,'Mauv',4,15903,3,57),(19,346,100,433,'Purple',4,16791,6,29),(20,484,462,205,'Fuscia',2,23653,5,42),(21,178,206,418,'Indigo',1,17394,2,90),(22,254,241,139,'Aquamarine',5,37588,6,80),(23,449,440,159,'Yellow',1,33190,4,72),(24,267,417,152,'Turquoise',4,36244,6,50),(25,284,104,396,'Khaki',2,32161,4,84),(26,248,298,57,'Pink',3,12127,1,9),(27,283,171,324,'Violet',4,37148,1,81),(28,200,129,461,'Khaki',2,11165,3,60),(29,236,219,318,'Red',3,34785,1,85),(30,82,106,158,'Goldenrod',4,36496,4,4),(31,224,225,215,'Crimson',2,24920,2,14),(32,337,156,271,'Crimson',5,35780,1,46),(33,418,324,407,'Yellow',4,1428,1,46),(34,346,188,372,'Crimson',5,39600,2,16),(35,392,404,155,'Purple',2,3905,1,38),(36,496,327,324,'Yellow',5,8092,5,62),(37,118,93,461,'Purple',2,25837,1,14),(38,142,451,198,'Aquamarine',4,12076,4,28),(39,432,339,454,'Pink',5,33769,5,2),(40,106,92,197,'Turquoise',3,5406,5,78),(41,193,292,459,'Orange',2,26652,1,88),(42,332,187,199,'Pink',4,19041,3,76),(43,435,64,378,'Green',4,16336,4,97),(44,150,271,392,'Turquoise',5,8994,6,50),(45,250,436,162,'Puce',3,36907,1,101),(46,56,414,114,'Khaki',5,34582,3,11),(47,158,486,117,'Crimson',3,29527,4,69),(48,182,106,152,'Indigo',5,35403,4,83),(49,419,171,489,'Blue',2,10259,4,51),(50,406,74,355,'Maroon',3,3909,5,16),(51,121,151,63,'Khaki',4,26876,3,36),(52,308,348,57,'Purple',1,4658,5,77),(53,367,119,370,'Crimson',1,17054,1,62),(54,271,123,275,'Green',5,27641,3,13),(55,131,245,79,'Green',3,38930,3,78),(56,109,223,354,'Goldenrod',4,1808,5,103),(57,493,68,100,'Orange',2,15537,2,25),(58,497,197,120,'Goldenrod',3,25870,2,55),(59,410,275,270,'Violet',5,27924,5,49),(60,448,168,200,'Violet',3,12678,5,50),(61,120,255,311,'Turquoise',5,33591,3,72),(62,126,168,185,'Goldenrod',3,20573,4,62),(63,113,309,292,'Turquoise',2,22288,2,66),(64,297,268,121,'Violet',3,23030,1,76),(65,259,120,174,'Green',3,17712,2,61),(66,393,78,460,'Khaki',4,7949,3,53),(67,328,495,258,'Blue',2,34913,1,56),(68,452,493,152,'Indigo',3,32664,5,59),(69,486,153,321,'Goldenrod',5,34043,3,57),(70,454,280,258,'Goldenrod',3,39808,3,12),(71,321,130,363,'Maroon',2,13707,5,57),(72,122,468,288,'Purple',3,18322,4,31),(73,349,419,300,'Turquoise',2,38769,2,31),(74,242,287,186,'Green',2,37753,5,74),(75,361,161,480,'Teal',5,31394,1,18),(76,233,269,425,'Violet',2,3223,4,13),(77,243,74,211,'Crimson',3,4434,4,72),(78,269,274,65,'Fuscia',3,32484,4,27),(79,465,328,74,'Blue',4,6170,1,87),(80,146,97,365,'Aquamarine',5,31103,4,23),(81,469,104,433,'Red',4,10566,4,11),(82,52,253,255,'Puce',5,18859,4,49),(83,406,424,246,'Turquoise',3,27165,1,77),(84,245,341,84,'Turquoise',5,21582,6,48),(85,421,114,58,'Goldenrod',4,8805,4,15),(86,366,133,153,'Blue',5,34758,4,55),(87,489,325,80,'Puce',5,2603,4,38),(88,63,118,440,'Maroon',1,36399,6,88),(89,254,351,235,'Pink',5,10578,3,47),(90,421,322,443,'Violet',2,20216,2,71),(91,256,113,234,'Red',2,13819,5,64),(92,401,259,411,'Purple',3,39525,4,13),(93,181,123,366,'Violet',3,27173,6,39),(94,64,459,471,'Yellow',3,6275,1,81);
/*!40000 ALTER TABLE `venta_especifica` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `venta_general`
--

DROP TABLE IF EXISTS `venta_general`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `venta_general` (
  `id` int NOT NULL AUTO_INCREMENT,
  `fecha` datetime NOT NULL,
  `fecha_b` datetime NOT NULL,
  `total` float NOT NULL,
  `anticipo` float NOT NULL,
  `clientes_fk` int NOT NULL,
  `usuarios_fk` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `usuarios_ventaG_fk_idx` (`usuarios_fk`),
  KEY `clientes_ventaG_fk_idx` (`clientes_fk`),
  CONSTRAINT `clientes_ventaG_fk` FOREIGN KEY (`clientes_fk`) REFERENCES `catalogo_clientes` (`id`),
  CONSTRAINT `usuarios_ventaG_fk` FOREIGN KEY (`usuarios_fk`) REFERENCES `usuarios` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=104 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `venta_general`
--

LOCK TABLES `venta_general` WRITE;
/*!40000 ALTER TABLE `venta_general` DISABLE KEYS */;
INSERT INTO `venta_general` VALUES (1,'2020-05-18 00:00:00','2020-06-18 00:00:00',8500,4250,1,1),(2,'2021-06-18 00:00:00','2021-07-18 00:00:00',7000,3500,1,1),(4,'2020-06-29 00:00:00','2023-03-17 00:00:00',9552,8633,14,2),(5,'2022-04-06 00:00:00','2020-08-30 00:00:00',20906,5665,21,1),(6,'2020-10-27 00:00:00','2023-05-24 00:00:00',37509,17930,18,4),(7,'2020-05-11 00:00:00','2020-11-04 00:00:00',11862,13607,20,4),(8,'2020-10-14 00:00:00','2022-02-03 00:00:00',11380,19516,1,2),(9,'2021-11-09 00:00:00','2023-02-01 00:00:00',23038,3287,19,5),(10,'2022-07-09 00:00:00','2021-08-25 00:00:00',3128,15254,4,3),(11,'2021-10-18 00:00:00','2021-08-01 00:00:00',36037,15062,49,4),(12,'2021-07-05 00:00:00','2022-04-01 00:00:00',1518,4643,41,5),(13,'2021-04-15 00:00:00','2023-03-18 00:00:00',37886,12741,47,5),(14,'2021-08-19 00:00:00','2020-09-20 00:00:00',8287,2771,21,2),(15,'2022-02-09 00:00:00','2023-04-12 00:00:00',11894,1618,24,5),(16,'2020-06-15 00:00:00','2022-08-28 00:00:00',28060,19103,48,4),(17,'2020-06-24 00:00:00','2020-12-30 00:00:00',7261,10480,44,3),(18,'2020-10-26 00:00:00','2020-11-18 00:00:00',1047,1372,28,2),(19,'2021-01-18 00:00:00','2020-08-25 00:00:00',18788,5282,18,3),(20,'2020-11-13 00:00:00','2023-01-26 00:00:00',32333,3961,15,4),(21,'2020-05-16 00:00:00','2022-08-28 00:00:00',25204,2065,36,4),(22,'2021-12-09 00:00:00','2020-07-23 00:00:00',20091,6897,50,2),(23,'2021-09-11 00:00:00','2020-11-23 00:00:00',7538,4640,29,3),(24,'2022-07-14 00:00:00','2023-06-03 00:00:00',31914,1655,48,3),(25,'2022-07-26 00:00:00','2022-11-26 00:00:00',4809,7869,5,4),(26,'2020-07-19 00:00:00','2021-11-28 00:00:00',30161,16599,30,2),(27,'2021-11-08 00:00:00','2022-05-23 00:00:00',17597,9425,28,2),(28,'2022-02-18 00:00:00','2021-04-25 00:00:00',36002,2128,49,2),(29,'2022-05-23 00:00:00','2021-05-03 00:00:00',30141,19842,24,3),(30,'2022-03-17 00:00:00','2021-05-13 00:00:00',6457,19618,26,5),(31,'2020-12-16 00:00:00','2021-01-03 00:00:00',28795,10857,6,3),(32,'2021-11-17 00:00:00','2021-01-29 00:00:00',12169,17898,20,1),(33,'2022-03-28 00:00:00','2021-01-05 00:00:00',16930,8633,18,3),(34,'2021-07-10 00:00:00','2022-01-24 00:00:00',11782,12797,9,2),(35,'2020-12-12 00:00:00','2023-05-25 00:00:00',21692,9310,34,3),(36,'2021-08-27 00:00:00','2020-06-06 00:00:00',19001,5754,9,4),(37,'2022-07-26 00:00:00','2021-03-10 00:00:00',7218,16168,47,2),(38,'2022-02-07 00:00:00','2022-11-14 00:00:00',10387,13363,2,3),(39,'2021-04-24 00:00:00','2020-08-12 00:00:00',13757,4779,28,1),(40,'2021-07-26 00:00:00','2021-10-31 00:00:00',20253,16398,5,5),(41,'2021-12-16 00:00:00','2021-11-29 00:00:00',29091,17736,7,2),(42,'2021-06-17 00:00:00','2022-05-08 00:00:00',29581,3271,5,5),(43,'2022-08-04 00:00:00','2020-09-18 00:00:00',3029,13970,4,5),(44,'2021-06-06 00:00:00','2023-01-13 00:00:00',37008,13066,10,5),(45,'2021-01-28 00:00:00','2022-02-25 00:00:00',3057,18138,7,3),(46,'2020-12-27 00:00:00','2020-08-20 00:00:00',25141,9898,9,3),(47,'2022-07-14 00:00:00','2022-05-24 00:00:00',9987,19362,22,2),(48,'2022-02-02 00:00:00','2022-08-24 00:00:00',10831,11261,23,5),(49,'2021-12-01 00:00:00','2020-11-08 00:00:00',8743,10658,20,4),(50,'2020-09-01 00:00:00','2022-04-09 00:00:00',34441,10681,12,1),(51,'2021-12-30 00:00:00','2021-12-14 00:00:00',25715,15484,42,2),(52,'2021-02-26 00:00:00','2022-04-21 00:00:00',33589,16136,4,2),(53,'2021-10-27 00:00:00','2021-01-31 00:00:00',2356,19802,26,2),(54,'2020-06-07 00:00:00','2023-07-12 00:00:00',33325,1122,3,3),(55,'2020-05-24 00:00:00','2022-09-24 00:00:00',8219,8710,11,2),(56,'2021-08-25 00:00:00','2022-05-25 00:00:00',36604,1990,24,4),(57,'2022-04-18 00:00:00','2021-10-13 00:00:00',34664,1415,9,2),(58,'2021-07-14 00:00:00','2021-05-07 00:00:00',26902,4887,30,2),(59,'2022-05-12 00:00:00','2023-02-08 00:00:00',23827,1163,32,1),(60,'2022-07-08 00:00:00','2021-08-29 00:00:00',34861,3069,46,1),(61,'2020-10-04 00:00:00','2020-07-28 00:00:00',33215,6574,41,1),(62,'2020-08-18 00:00:00','2022-03-25 00:00:00',14094,15731,5,5),(63,'2021-03-30 00:00:00','2021-09-23 00:00:00',5253,17954,44,4),(64,'2021-09-27 00:00:00','2022-07-21 00:00:00',27305,2530,40,3),(65,'2021-05-24 00:00:00','2022-07-14 00:00:00',32802,9455,11,4),(66,'2022-07-08 00:00:00','2021-03-28 00:00:00',17550,19381,39,1),(67,'2021-09-05 00:00:00','2022-06-21 00:00:00',2111,18409,25,1),(68,'2021-10-06 00:00:00','2022-01-15 00:00:00',29566,3270,43,3),(69,'2020-05-16 00:00:00','2020-11-21 00:00:00',20882,13798,36,4),(70,'2021-05-11 00:00:00','2023-03-23 00:00:00',16996,3206,6,5),(71,'2020-05-09 00:00:00','2021-02-10 00:00:00',10124,13025,36,4),(72,'2021-02-18 00:00:00','2020-10-21 00:00:00',19755,11397,38,1),(73,'2021-04-18 00:00:00','2023-01-12 00:00:00',4504,16983,40,2),(74,'2021-05-05 00:00:00','2022-12-23 00:00:00',1005,7481,17,2),(75,'2022-06-19 00:00:00','2021-01-09 00:00:00',33804,2155,46,5),(76,'2020-05-15 00:00:00','2022-01-08 00:00:00',5697,13879,43,1),(77,'2020-08-26 00:00:00','2022-08-04 00:00:00',22238,17618,20,5),(78,'2022-05-02 00:00:00','2021-10-13 00:00:00',18537,16044,6,5),(79,'2022-07-21 00:00:00','2021-05-17 00:00:00',20719,10828,32,1),(80,'2021-07-04 00:00:00','2021-09-26 00:00:00',12674,5090,42,2),(81,'2021-11-12 00:00:00','2020-10-24 00:00:00',27921,13867,8,2),(82,'2021-12-29 00:00:00','2023-02-07 00:00:00',21431,17582,32,3),(83,'2021-05-13 00:00:00','2023-07-29 00:00:00',30304,13371,50,3),(84,'2022-03-15 00:00:00','2022-01-20 00:00:00',10604,15557,17,2),(85,'2022-07-28 00:00:00','2021-08-31 00:00:00',30847,10955,20,3),(86,'2022-06-17 00:00:00','2023-06-13 00:00:00',17766,9122,9,3),(87,'2021-08-04 00:00:00','2021-03-21 00:00:00',9230,7698,49,2),(88,'2021-07-12 00:00:00','2021-07-10 00:00:00',14747,10718,1,2),(89,'2020-12-19 00:00:00','2020-12-23 00:00:00',17571,17526,21,4),(90,'2021-12-10 00:00:00','2021-10-25 00:00:00',11699,9516,32,3),(91,'2020-05-14 00:00:00','2022-03-07 00:00:00',25557,19754,36,3),(92,'2022-01-10 00:00:00','2021-10-10 00:00:00',4399,12270,18,3),(93,'2020-12-16 00:00:00','2021-11-20 00:00:00',24172,10456,20,3),(94,'2021-10-15 00:00:00','2023-05-25 00:00:00',24138,10787,34,5),(95,'2021-03-04 00:00:00','2021-04-11 00:00:00',26615,8159,6,2),(96,'2021-07-15 00:00:00','2022-11-27 00:00:00',36565,19574,19,3),(97,'2021-06-16 00:00:00','2022-06-28 00:00:00',15758,16683,31,3),(98,'2020-08-22 00:00:00','2022-01-31 00:00:00',18524,12223,12,4),(99,'2021-11-25 00:00:00','2020-09-04 00:00:00',14802,19599,4,4),(100,'2022-06-27 00:00:00','2023-02-20 00:00:00',14739,9262,29,5),(101,'2021-05-13 00:00:00','2021-09-27 00:00:00',23607,12459,7,1),(102,'2021-12-20 00:00:00','2023-06-04 00:00:00',6687,12136,29,1),(103,'2020-10-26 00:00:00','2022-07-31 00:00:00',8850,18515,23,1);
/*!40000 ALTER TABLE `venta_general` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'herreriazar'
--

--
-- Dumping routines for database 'herreriazar'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-05-02 15:38:58
