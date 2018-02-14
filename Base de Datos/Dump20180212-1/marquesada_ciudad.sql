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
-- Table structure for table `ciudad`
--

DROP TABLE IF EXISTS `ciudad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ciudad` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `nombre` varchar(200) NOT NULL,
  `activo` tinyint(1) NOT NULL,
  `lada_id` int(10) unsigned NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=106 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ciudad`
--

LOCK TABLES `ciudad` WRITE;
/*!40000 ALTER TABLE `ciudad` DISABLE KEYS */;
INSERT INTO `ciudad` VALUES (1,'Abasolo',1,14),(2,'Acambaro',1,7),(3,'Aguascalientes',1,28),(4,'Apaseo el alto',1,8),(5,'Apaseo el grande',1,8),(6,'Calera',1,9),(7,'Celaya',1,10),(8,'Cerano',1,11),(9,'Chamacuaro',1,7),(10,'Comonfort',1,18),(11,'Loreto',1,29),(12,'Coroneo',1,25),(13,'Cortazar',1,13),(14,'Cueramaro',1,14),(15,'Cupareo',1,12),(16,'Dolores Hidalgo',1,15),(17,'El sabino',1,12),(18,'Empalme escobedo',1,18),(19,'Guanajuato',1,16),(20,'Hunimaro',1,14),(21,'Irapuato',1,17),(22,'Jaral del progreso',1,13),(23,'Jerecuaro',1,25),(24,'Jesus Maria',1,28),(25,'Juventino Rosas',1,18),(26,'La Moncada',1,18),(27,'La Piedad',1,3),(28,'Lagos de Moreno',1,19),(29,'Molino de Santa Ana',1,17),(30,'Nuevo Chupicuaro',1,7),(31,'Obrajuelo',1,7),(32,'Pabellon de Arteaga',1,23),(33,'Paracuaro',1,7),(34,'Pastor Ortiz',1,11),(35,'Penjamo',1,30),(36,'Pueblo Nuevo',1,14),(37,'Puruandiro',1,11),(38,'Rincon de Romos',1,23),(39,'Rincon de Tamayo',1,10),(40,'Romita',1,31),(41,'Sahuayo',1,6),(42,'Salamanca',1,20),(43,'San Diego',1,15),(44,'San Francisco',1,23),(45,'San José de Gracia',1,32),(46,'San José de Iturbide',1,14),(47,'San Juan de la Vega',1,10),(48,'San Juan del Rio',1,24),(49,'San Luis de la Paz',1,21),(50,'San Pedro de los Naranjos',1,21),(51,'Santa Maria del Refugio',1,10),(52,'Santiago Maravatio',1,12),(53,'Santo Tomás',1,12),(54,'Salvatierra',1,12),(55,'Sarabia',1,13),(56,'Tangamandapio',1,33),(57,'Tangancicuaro',1,34),(58,'Tarandacuao',1,25),(59,'Tarimoro',1,12),(60,'Uriangato',1,27),(61,'Urireo',1,12),(62,'Valle de Santiago',1,26),(63,'Villagran',1,13),(64,'Yuriria',1,27),(65,'Zacapú',1,2),(66,'S/R',1,35),(67,'Queretaro',1,36),(68,'Victoria de Cortazar',1,13),(69,'Morelia',1,5),(70,'Tepezala',1,23),(71,'Crespo',1,10),(72,'Huandacareo',1,5),(73,'Doctor Mora',1,21),(74,'Villajimenez',1,5),(75,'San Nicolas de los Agustinos',1,12),(76,'Quiroga',1,5),(77,'Moroleon',1,27),(78,'Puruagua',1,7),(79,'Rio Verde',1,37),(80,'La Piedad Queretaro',1,36),(81,'SANTANAMAYA',1,5),(82,'Encarnación de Díaz',1,4),(83,'ANDADOR SANTA LUCIA',1,24),(84,'Valtierrilla',1,28),(85,'Roque',1,10),(86,'Alvaro Obregon',1,5),(87,'Arco de Rayo',1,4),(88,'Vista Hermosa',1,6),(89,'Mexicanos',1,38),(90,'Anachuen',1,4),(91,'Villa Mar',1,6),(92,'Zapata',1,6),(93,'Teocaitione',1,39),(94,'Santa Maria del Rio',1,40),(95,'San Jose Agua Azul',1,41),(96,'Cacalote',1,39),(97,'Araro',1,42),(98,'Indaparapeo',1,5),(99,'Jaral del Refugio Gto.',1,7),(100,'Sinapecuaro Michoacán',1,42),(101,'San Jose Parangeo',1,43),(102,'Comunidad Tepetates',1,13),(103,'Jerehuaro',1,44),(104,'San Bartolome',1,36),(105,'San Miguel Otopan ',1,10);
/*!40000 ALTER TABLE `ciudad` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-02-12 18:00:07
