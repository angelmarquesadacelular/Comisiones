-- MySQL dump 10.13  Distrib 5.7.12, for Win32 (AMD64)
--
-- Host: 187.189.152.4    Database: recargasatc
-- ------------------------------------------------------
-- Server version	5.5.5-10.1.25-MariaDB

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
-- Table structure for table `permiso_administrador`
--

DROP TABLE IF EXISTS `permiso_administrador`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `permiso_administrador` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `nickname` varchar(200) NOT NULL,
  `pass` varchar(200) NOT NULL,
  `activo` tinyint(1) NOT NULL,
  `administrador_id` int(10) unsigned NOT NULL,
  `permiso_id` int(10) unsigned NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `permiso_administrador`
--

LOCK TABLES `permiso_administrador` WRITE;
/*!40000 ALTER TABLE `permiso_administrador` DISABLE KEYS */;
INSERT INTO `permiso_administrador` VALUES (1,'Principal','M989at+tjQxHNT2JVchRo6q+B4qklbS1M3ThVcUv2oA=',1,1,3),(2,'Sistemas','fru0ljjXxDC3pogal8pC3u0eOMTfXUjnhqGHuDThErw=',1,2,3),(3,'Oficina','mmtu+/RdPvxUC2WHzaQnOTwX8i1OX6Df8H+Nyp+RMTI=',1,3,1),(4,'recargasatc','UxoTxzF00JCdbcvi9XlkC9CBkEnaycgcwqhOCojzk20=',1,4,1),(5,'arturo','aIgmjHjZKRmgcRawLXgVcg+rGUMpJ76I80uaT0BesIg=',1,5,1);
/*!40000 ALTER TABLE `permiso_administrador` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-02-12 17:56:37
