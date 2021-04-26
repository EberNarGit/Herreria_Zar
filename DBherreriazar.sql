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
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `catalogo_clientes`
--

LOCK TABLES `catalogo_clientes` WRITE;
/*!40000 ALTER TABLE `catalogo_clientes` DISABLE KEYS */;
INSERT INTO `catalogo_clientes` VALUES (1,'pepe','perez','perales','pepe@pepe','8443600994',1);
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
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `catalogo_productos`
--

LOCK TABLES `catalogo_productos` WRITE;
/*!40000 ALTER TABLE `catalogo_productos` DISABLE KEYS */;
INSERT INTO `catalogo_productos` VALUES (1,'urldeimagen','es una puerta muy bonita',1,1);
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
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categoria`
--

LOCK TABLES `categoria` WRITE;
/*!40000 ALTER TABLE `categoria` DISABLE KEYS */;
INSERT INTO `categoria` VALUES (1,'puerta');
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
  `fecha` date NOT NULL,
  `venta_general_fk` int NOT NULL,
  `usuarios_fk` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `ventaG_pagos_fk_idx` (`venta_general_fk`),
  KEY `usuarios_pagos_fk_idx` (`usuarios_fk`),
  CONSTRAINT `usuarios_pagos_fk` FOREIGN KEY (`usuarios_fk`) REFERENCES `usuarios` (`id`),
  CONSTRAINT `ventaG_pagos_fk` FOREIGN KEY (`venta_general_fk`) REFERENCES `venta_general` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pagos`
--

LOCK TABLES `pagos` WRITE;
/*!40000 ALTER TABLE `pagos` DISABLE KEYS */;
INSERT INTO `pagos` VALUES (1,4250,'2020-06-18',1,1);
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
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (1,'Eber Eliud','Rodriguez','Alvarado','EberNar844','844183');
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
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `venta_especifica`
--

LOCK TABLES `venta_especifica` WRITE;
/*!40000 ALTER TABLE `venta_especifica` DISABLE KEYS */;
INSERT INTO `venta_especifica` VALUES (1,175.5,10.5,85.2,'negro mate',1,2500,1,1);
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
  `fecha` date NOT NULL,
  `fecha_b` date NOT NULL,
  `total` float NOT NULL,
  `anticipo` float NOT NULL,
  `clientes_fk` int NOT NULL,
  `usuarios_fk` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `usuarios_ventaG_fk_idx` (`usuarios_fk`),
  KEY `clientes_ventaG_fk_idx` (`clientes_fk`),
  CONSTRAINT `clientes_ventaG_fk` FOREIGN KEY (`clientes_fk`) REFERENCES `catalogo_clientes` (`id`),
  CONSTRAINT `usuarios_ventaG_fk` FOREIGN KEY (`usuarios_fk`) REFERENCES `usuarios` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `venta_general`
--

LOCK TABLES `venta_general` WRITE;
/*!40000 ALTER TABLE `venta_general` DISABLE KEYS */;
INSERT INTO `venta_general` VALUES (1,'2020-05-18','2020-06-18',8500,4250,1,1);
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

-- Dump completed on 2021-04-26 15:50:47
