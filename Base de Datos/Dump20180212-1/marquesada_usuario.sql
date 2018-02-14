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
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuario` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(200) NOT NULL,
  `activo` tinyint(1) NOT NULL,
  `puesto_id` int(11) NOT NULL,
  `categoria_id` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=67 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (1,'Roberto Luna López',0,1,16),(2,'Adriana García García',0,3,5),(3,'Adriana Molina López',1,6,14),(4,'Mariela Girón Tapia',0,3,2),(5,'Yohaira Itzel Vera Puga',0,3,3),(6,'Elizabeth Vázquez Delgado',0,3,3),(7,'Ana María Serrano Rosillo',1,3,4),(8,'Carmen Aguilar',0,3,4),(9,'Christian González Méndez',0,3,6),(10,'Claudia Alcocer Martínez',1,3,6),(11,'Tania Betelhausel Villagómez',0,2,16),(12,'Rosa Isela Calderón Peralta',0,5,13),(13,'Carmen Pérez Rojas',0,5,13),(14,'María Cindy Chávez Robles',1,3,13),(15,'Ruth Lanuza Ramírez',0,3,13),(16,'Héctor Omar Núñez Muñoz',1,1,15),(17,'Serafín Solís Moreno',1,3,7),(18,'Francisco J. González Martínez',1,3,8),(19,'Eric Ramírez Abonce',0,3,9),(20,'Rebeca Betsabe Vera Villagómez',0,3,2),(21,'Jaime Pacheco',1,7,17),(22,'Magdalena Ferreira Arreola',1,7,17),(23,'José Alfredo Rodríguez',0,6,11),(24,'Abraham Castro Lara',0,4,12),(25,'Ana Belem Martínez Muñoz',0,3,2),(26,'Mayra del Carmen Tapia López',1,4,13),(27,'Javier Serrano Lule',1,4,14),(28,'María Teresa Tiliano Mandujano',0,3,4),(29,'Jennifer Gómez Rangel',0,5,13),(30,'David Israel',0,2,16),(31,'David Sámano Ferreira',1,8,18),(32,'Isabel Aguilar',1,7,17),(33,'Martín Sánchez',0,2,15),(34,'Jessica Hurtado Lara',0,6,13),(35,'Jazmin Danae Muñiz Aguilar',0,2,15),(36,'Jose Eduardo Cruz Arreguin',1,10,19),(37,'Siloe Perez Perez',1,8,17),(38,'María del Carmen Muñíz Hernández',0,9,4),(39,'Fabiola Ramírez Martínez',1,6,14),(40,'Roberto Carlos Alejandre Torres',0,3,7),(41,'Pedro Martinez Piña',0,4,17),(42,'Alfredo Sanchez Quijano',0,3,1),(43,'Jose Luis Ramirez Robles',1,7,4),(44,'Juana Jazmin Gomez Rangel',1,3,5),(45,'Rafael Villagomez',0,3,1),(46,'JOSEFINA  PAOLA  AGUILAR NIETO',0,5,19),(47,'Josefina Paola Aguilar Nieto',1,5,19),(48,'Jose Roberto Sierra Granados',1,6,12),(49,'Bertha Angelica Villagomez Parache',1,9,6),(50,'Perla Iveth Alfaro Martinez',1,2,10),(51,'Andrea Azucena Piña Lara',0,6,13),(52,'Armando Lopez Rosillo',0,7,17),(53,'Angel  Campos Alejo',1,6,14),(54,'Jose Guadalupe Chavez Robles',1,6,13),(55,'Monica G. Lopez Hernandez',0,6,13),(56,'Cindy Cornejo Miranda',1,6,4),(57,'Luis Fernando Aguilar Valerio',1,9,4),(58,'Jesus Martinez Ruiz',0,6,19),(59,'Karina Paniagua Vazquez',0,9,17),(60,'Jose Espinoza Huerta',1,3,7),(61,'Elizabeth Flores ',1,6,13),(62,'Valeria Raya Pulido',0,9,2),(63,'Javier Serrano',1,7,17),(64,'Fernando Urbina',1,9,2),(65,'Ana Urbina',1,7,17),(66,'Marisol Cruz Arreguin',1,6,13);
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-02-12 18:01:01
