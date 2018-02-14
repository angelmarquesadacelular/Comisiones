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
-- Table structure for table `marca`
--

DROP TABLE IF EXISTS `marca`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `marca` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `nombre` varchar(30) NOT NULL,
  `activo` tinyint(1) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=98 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `marca`
--

LOCK TABLES `marca` WRITE;
/*!40000 ALTER TABLE `marca` DISABLE KEYS */;
INSERT INTO `marca` VALUES (1,'Telcel',1),(2,'Lanix',1),(3,'Eyo',1),(4,'Doppio',1),(5,'Azumi',1),(6,'Alcatel',1),(7,'Nyx',1),(8,'Unefon',1),(9,'Movistar',1),(10,'AT&T',1),(11,'Hand Spinner',1),(12,'Kingston',1),(13,'Samsung',1),(14,'Apple',1),(15,'Tango',1),(16,'Sin Marca',1),(17,'High Speed',1),(18,'A-66',1),(19,'Huawei',1),(20,'Polaroid',1),(21,'RAZZY',1),(22,'MTT',1),(23,'PCD',1),(24,'GLASS',1),(25,'ELUX',1),(26,'ADDIDAS',1),(27,'Addidas',1),(28,'Logic',1),(29,'RINNO',1),(30,'SENWA',1),(31,'VARIADO',1),(32,'360 FULL',1),(33,'S/N',1),(34,'MARIO',1),(35,'PECERA',1),(36,'MAIZ',1),(37,'JHW',1),(38,'MUSIC',1),(39,'UNIVERSAL',1),(40,'MARCAS',1),(41,'MOUNT HOLDER',1),(42,'SONY',1),(43,'ZTE',1),(44,'MOTOROLA',1),(45,'LG',1),(46,'M4',1),(47,'IPHONE',1),(48,'DIBUJOS',1),(49,'GOMA',1),(50,'OPPO',1),(51,'BLU',1),(52,'NOKIA',1),(53,'BLECK',1),(54,'Ear Pods',1),(55,'Mini- X6u',1),(56,'BINKEY',1),(57,'COMIE',1),(58,'SOFT FEELING',1),(59,'VISION CELL',1),(60,'DISEÑO',1),(61,'VISION CEL',1),(62,'VARIAS',1),(63,'RR',1),(64,'NEWCASE',1),(65,'S-M',1),(66,'GLOW',1),(67,'SIN MARCA',1),(68,'NN',1),(69,'JOYSTICK',1),(70,'Bumpers',1),(71,'Sony-Smg',1),(72,'R-SIM',1),(73,'SKY',1),(74,'TECH 4U',1),(75,'ADATA',1),(76,'JOINET',1),(77,'Q-SIM',1),(78,'H-Mobile',1),(79,'SAMSUNGS8',1),(80,'Samsung s8',1),(81,'HTC',1),(82,'VA',1),(83,'Tech',1),(84,'USB NEGRO',1),(85,'OWX-MOBILE',1),(86,'SELFIX_ONE',1),(87,'STELA ',1),(88,'Económico ',1),(89,'USB',1),(90,'Cable usb',1),(91,'No',1),(92,'Agujeta',1),(93,'USB V8',1),(94,'ALTER',1),(95,'RT PROJECT',1),(96,'X PHONE',1),(97,'Freetel',1);
/*!40000 ALTER TABLE `marca` ENABLE KEYS */;
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
