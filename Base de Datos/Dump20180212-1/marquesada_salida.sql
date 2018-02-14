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
-- Table structure for table `salida`
--

DROP TABLE IF EXISTS `salida`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `salida` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `tipo` varchar(50) NOT NULL,
  `descr` varchar(200) NOT NULL,
  `activo` tinyint(1) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=119 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `salida`
--

LOCK TABLES `salida` WRITE;
/*!40000 ALTER TABLE `salida` DISABLE KEYS */;
INSERT INTO `salida` VALUES (1,'Todos','Todos',1),(2,'Viáticos','Alimentación',1),(3,'Gasolina','Magna/Premium',1),(4,'Hotel','1-5 Estrellas',1),(5,'Lavado','Lavado de automóvil',1),(6,'Estacionamiento','Lugar donde estuvo el carro',1),(7,'Crédito','Préstamos',1),(8,'Papelería','Utilería',1),(9,'Limpieza','Gastos de limpieza',1),(10,'Mantenimiento','Costos de construcción',1),(11,'Luz','Pago del recibo de luz',1),(12,'Teléfono','Pago del recibo del teléfono',1),(13,'Internet','Pago del internet',1),(14,'Refacciones','Costo de reemplazo de piezas',1),(15,'Equipos','Compra de equipos',1),(16,'Lavandería','Costo de lavado de ropa',1),(17,'Pan','Compra de pan para oficina y rutas.',1),(18,'Agua','Compra de garrafón de agua',1),(19,'Alimentación','Compra de almuerzo/comida',1),(20,'Medicamentos','Surtido de botiquín',1),(21,'Otros','Gastos recomendados registrar en una opción',1),(22,'Bocinas','Compra de artículos de sonido.',1),(23,'Pasajes','Pasajes dados usualmente a Abraham',1),(24,'Depósito','Depósitos de pagos (artículos, cuentas, etc)',1),(25,'Renta','Pago hecho de renta de locales.',1),(26,'Pago Gabriel','Pago hecho por equipos de telefonía.',1),(27,'Edecanes','Pago a personal.',1),(28,'Aire acondicionado','Pago de equipo e instalación.',1),(29,'Casetas','Gastos de casetas de autopista.',1),(30,'Etiquetas','Compra de etiquetas de papelería',1),(31,'Tina Ultrasónica','Compra de artículo.',1),(32,'Pago de Refrendo','Pago hecho de refrendo',1),(33,'Refrendo','S/D',1),(34,'Equipo cómputo','Compra de equipo de cómputo.',1),(35,'Bebidas','S/D',1),(36,'Muebles','S/D',1),(37,'Pago de Nomina','S/D',1),(38,'Prestamo','S/D',1),(39,'Abono','S/D',1),(40,'Servicio Mecanico','S/D',1),(41,'Pago de Contabilidad','S/D',1),(42,'Pago de Servicios','S/D',1),(43,'Gastos Medicos','S/D',1),(44,'Pago de Equipo','S/D',1),(45,'Retiro','S/D',1),(46,'Liquidacion','S/D',1),(47,'Comision Oficina','S/D',1),(48,'Ajuste de Caja','S/D',1),(49,'Ajuste ','S/D',1),(50,'Verificacion','S/D',1),(51,'Adeudo','S/D',1),(52,'Publicidad','S/D',1),(53,'Material de Empaque','S/D',1),(54,'Placas','S/D',1),(55,'Multa','S/D',1),(56,'Desechables','S/D',1),(57,'Accesorios','S/D',1),(58,'Dep Transferencia','S/D',1),(59,'Equipo de Computo','S/D',1),(60,'Servicio Electrico','S/D',1),(61,'Envio','S/D',1),(62,'Cafe','S/D',1),(63,'Compra de Saldo','S/D',1),(64,'Uniformes','S/D',1),(65,'Alarmas','S/D',1),(66,'Pago Sr. Piñon','S/D',1),(67,'Pago Portabilidad','S/D',1),(68,'Pago de Alarma','S/D',1),(69,'Pago de Finiquitos','S/D',1),(70,'Pago Dominio Web','S/D',1),(71,'Curso','S/D',1),(72,'Pago Deposito Planes','S/D',1),(73,'Cuenta Zaragoza','S/D',1),(74,'Mensualidad Autos','S/D',1),(75,'Polarizado','S/D',1),(76,'Liberaciones','S/D',1),(77,'Boletos','S/D',1),(78,'Comision','S/D',1),(79,'Bolsas','S/D',1),(80,'Bono','S/D',1),(81,'Mensualidad Frontier','S/D',1),(82,'Deposito Cadenas','S/D',1),(83,'Deposito Nomina','S/D',1),(84,'Deposito Nomina IMSS','S/D',1),(85,'Mensualidad Duster','S/D',1),(86,'Mensualidad Toledo16','S/D',1),(87,'Pago IMSS','S/D',1),(88,'Mensualidad IbizaPl','S/D',1),(89,'Mensualidad Ibiza Gr','S/D',1),(90,'Mensualidad Toledo17','S/D',1),(91,'Transporte','S/D',1),(92,'Cargadores','S/D',1),(93,'Llantas','S/D',1),(94,'Creditos','S/D',1),(95,'Hojalateria','S/D',1),(96,'Liquido Fumigante','S/D',1),(97,'Mensualidad Gol','S/D',1),(98,' Lentes','S/D',1),(99,'Pago Garantias','S/D',1),(100,'Devolucion','S/D',1),(101,'Pago de Impuestos','S/D',1),(102,'Impuestos','S/D',1),(103,'Playeras','S/D',1),(104,'Colegiatura','S/D',1),(105,'Bonificacion','S/D',1),(106,'Pago Planes','S/D',1),(107,'Dulces','S/D',1),(108,'Reparaciones','S/D',1),(109,'Capacitacion','S/D',1),(110,'Plan Tarifario','S/D',1),(111,'Musica','S/D',1),(112,'Seguridad','S/D',1),(113,'Permiso','S/D',1),(114,'Aguinaldos','S/D',1),(115,'Material Mecatronico','S/D',1),(116,'Mensualidad Passat','S/D',1),(117,'RSIM','S/D',1),(118,'Pago con Tarjeta','S/D',1);
/*!40000 ALTER TABLE `salida` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-02-12 17:59:17
