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
-- Table structure for table `articulo_marca`
--

DROP TABLE IF EXISTS `articulo_marca`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `articulo_marca` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `marca_id` int(10) unsigned NOT NULL,
  `tipoArticulo_id` int(10) unsigned DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=87 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `articulo_marca`
--

LOCK TABLES `articulo_marca` WRITE;
/*!40000 ALTER TABLE `articulo_marca` DISABLE KEYS */;
INSERT INTO `articulo_marca` VALUES (1,1,2),(2,2,2),(3,3,2),(4,4,2),(5,5,2),(6,6,2),(7,7,2),(8,8,2),(9,9,2),(10,10,2),(11,11,2),(12,12,2),(13,1,3),(14,2,3),(15,3,3),(16,4,3),(17,5,3),(18,6,3),(19,7,3),(20,8,3),(21,9,3),(22,10,3),(23,11,3),(24,12,3),(25,1,4),(26,2,4),(27,3,4),(28,4,4),(29,5,4),(30,6,4),(31,7,4),(32,8,4),(33,9,4),(34,10,4),(35,11,4),(36,12,4),(37,1,5),(38,2,5),(39,3,5),(40,4,5),(41,5,5),(42,6,5),(43,7,5),(44,8,5),(45,9,5),(46,10,5),(47,11,5),(48,12,5),(49,1,6),(50,2,6),(51,3,6),(52,4,6),(53,5,6),(54,6,6),(55,7,6),(56,8,6),(57,9,6),(58,10,6),(59,11,6),(60,12,6),(61,1,7),(62,2,6),(63,1,7),(64,2,7),(65,3,7),(66,4,7),(67,5,7),(68,6,7),(69,7,7),(70,8,7),(71,9,7),(72,10,7),(73,11,7),(74,12,7),(75,1,8),(76,2,8),(77,3,8),(78,4,8),(79,5,8),(80,6,8),(81,7,8),(82,8,8),(83,9,8),(84,10,8),(85,11,8),(86,12,8);
/*!40000 ALTER TABLE `articulo_marca` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-02-12 18:01:00
