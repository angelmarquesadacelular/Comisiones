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
-- Dumping routines for database 'recargasatc'
--
/*!50003 DROP PROCEDURE IF EXISTS `fecha_recargas` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`xampp`@`%` PROCEDURE `fecha_recargas`(IN fecha DATE, IN tipo INT, IN cliente_id INT)
BEGIN
	IF tipo = 1 THEN
		SELECT fecha, COUNT(a.id) AS total,
			(SELECT COUNT(a.id) FROM numero n, activado a, carrier c WHERE a.numero_id = n.id AND c.id = n.carrier_id AND CAST(a.fecha AS DATE) = fecha AND c.nombre = 'TELCEL') AS telcel, 
			(SELECT COUNT(a.id) FROM numero n, activado a, carrier c WHERE a.numero_id = n.id AND c.id = n.carrier_id AND CAST(a.fecha AS DATE) = fecha AND c.nombre = 'MOVISTAR') AS movistar, 
			(SELECT COUNT(a.id) FROM numero n, activado a, carrier c WHERE a.numero_id = n.id AND c.id = n.carrier_id AND CAST(a.fecha AS DATE) = fecha AND c.nombre = 'AT&T') AS att, 
			(SELECT COUNT(a.id) FROM numero n, activado a, carrier c WHERE a.numero_id = n.id AND c.id = n.carrier_id AND CAST(a.fecha AS DATE) = fecha AND c.nombre = 'UNEFON') AS unefon 
		FROM numero n, activado a, carrier c 
		WHERE a.numero_id = n.id 
		AND c.id = n.carrier_id 
		AND CAST(a.fecha AS DATE) = fecha; 
    ELSE
		SELECT fecha, COUNT(a.id) AS total,
			(SELECT COUNT(a.id) FROM numero n, activado a, carrier c WHERE a.numero_id = n.id AND c.id = n.carrier_id AND CAST(a.fecha AS DATE) = fecha AND c.nombre = 'TELCEL' AND n.cliente_id = cliente_id) AS telcel, 
			(SELECT COUNT(a.id) FROM numero n, activado a, carrier c WHERE a.numero_id = n.id AND c.id = n.carrier_id AND CAST(a.fecha AS DATE) = fecha AND c.nombre = 'MOVISTAR' AND n.cliente_id = cliente_id) AS movistar, 
			(SELECT COUNT(a.id) FROM numero n, activado a, carrier c WHERE a.numero_id = n.id AND c.id = n.carrier_id AND CAST(a.fecha AS DATE) = fecha AND c.nombre = 'AT&T' AND n.cliente_id = cliente_id) AS att, 
			(SELECT COUNT(a.id) FROM numero n, activado a, carrier c WHERE a.numero_id = n.id AND c.id = n.carrier_id AND CAST(a.fecha AS DATE) = fecha AND c.nombre = 'UNEFON' AND n.cliente_id = cliente_id) AS unefon 
		FROM numero n, activado a, carrier c 
		WHERE a.numero_id = n.id 
		AND c.id = n.carrier_id 
		AND CAST(a.fecha AS DATE) = fecha
        AND n.cliente_id = cliente_id; 
    END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-02-12 17:58:38
