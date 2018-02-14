-- MySQL dump 10.13  Distrib 5.7.12, for Win32 (AMD64)
--
-- Host: 192.168.1.108    Database: marquesada
-- ------------------------------------------------------
-- Server version	5.7.17-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `articulo_rango`
--

DROP TABLE IF EXISTS `articulo_rango`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `articulo_rango` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `articulo_id` int(10) unsigned NOT NULL,
  `rango_id` int(10) unsigned NOT NULL,
  `requerimiento_id` int(10) unsigned NOT NULL,
  `colocacion_id` int(10) unsigned NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=86 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `articulo_rango`
--

LOCK TABLES `articulo_rango` WRITE;
/*!40000 ALTER TABLE `articulo_rango` DISABLE KEYS */;
INSERT INTO `articulo_rango` VALUES (1,1,1,1,1),(2,2,1,1,1),(3,3,1,1,1),(4,4,1,1,1),(5,5,1,1,1),(6,6,1,1,1),(7,7,1,1,1),(8,18,1,1,1),(9,19,1,1,1),(10,20,1,1,1),(11,31,1,1,1),(12,36,1,1,1),(13,37,1,1,1),(14,38,1,1,1),(15,8,2,1,1),(16,9,3,1,1),(17,16,3,1,1),(18,10,3,1,1),(19,10,2,1,1),(20,9,2,1,1),(21,42,2,1,1),(22,45,2,1,1),(23,47,2,1,1),(24,48,2,1,1),(25,49,2,1,1),(26,11,2,1,1),(27,11,3,1,1),(28,12,2,1,1),(29,12,3,1,1),(30,13,2,1,1),(31,13,3,1,1),(32,14,2,1,1),(33,14,3,1,1),(34,15,2,1,1),(35,15,3,1,1),(36,17,2,1,1),(37,17,3,1,1),(38,29,2,1,1),(39,29,3,1,1),(40,30,2,1,1),(41,30,3,1,1),(42,32,2,1,1),(43,32,3,1,1),(44,33,2,1,1),(45,33,3,1,1),(46,34,2,1,1),(47,34,3,1,1),(48,35,2,1,1),(49,35,3,1,1),(50,39,2,1,1),(51,39,3,1,1),(52,40,2,1,1),(53,40,3,1,1),(54,41,2,1,1),(55,41,3,1,1),(56,50,2,1,1),(57,50,3,1,1),(58,21,4,1,1),(59,22,5,1,1),(60,22,6,1,1),(61,22,7,1,1),(62,23,8,1,1),(63,24,9,1,1),(64,24,6,1,1),(65,24,7,1,1),(66,25,9,1,1),(67,25,6,1,1),(68,25,7,1,1),(69,26,9,1,1),(70,26,6,1,1),(71,26,7,1,1),(72,27,9,1,1),(73,27,6,1,1),(74,27,7,1,1),(75,28,8,1,1),(76,43,9,1,1),(77,43,6,1,1),(78,43,7,1,1),(79,54,1,1,1),(80,53,1,1,1),(81,51,9,1,1),(82,66,2,1,1),(83,65,2,1,1),(84,67,3,1,1),(85,112,1,1,1);
/*!40000 ALTER TABLE `articulo_rango` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-02-12 18:00:44
