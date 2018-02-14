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
-- Table structure for table `lada`
--

DROP TABLE IF EXISTS `lada`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `lada` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `tipo` varchar(5) NOT NULL,
  `activo` tinyint(1) NOT NULL,
  `region_id` int(10) unsigned NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=45 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lada`
--

LOCK TABLES `lada` WRITE;
/*!40000 ALTER TABLE `lada` DISABLE KEYS */;
INSERT INTO `lada` VALUES (1,'438',1,1),(2,'436',1,1),(3,'352',1,1),(4,'351',1,1),(5,'443',1,1),(6,'353',1,1),(7,'417',1,2),(8,'413',1,2),(9,'478',1,2),(10,'461',1,2),(11,'438',1,2),(12,'466',1,2),(13,'411',1,2),(14,'429',1,2),(15,'418',1,2),(16,'473',1,2),(17,'462',1,2),(18,'412',1,2),(19,'474',1,2),(20,'464',1,2),(21,'468',1,2),(22,'472',1,2),(23,'465',1,2),(24,'427',1,2),(25,'421',1,2),(26,'456',1,2),(27,'445',1,2),(28,'449',1,2),(29,'496',1,2),(30,'469',1,2),(31,'432',1,2),(32,'381',1,2),(33,'383',1,2),(34,'355',1,2),(35,'S/R',1,3),(36,'442',1,2),(37,'487',1,2),(38,'921',1,2),(39,'346',1,2),(40,'485',1,2),(41,'924',1,2),(42,'451',1,1),(43,'341',1,1),(44,'447',1,2);
/*!40000 ALTER TABLE `lada` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-02-12 18:00:42
