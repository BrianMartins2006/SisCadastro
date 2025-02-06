-- MySQL dump 10.13  Distrib 8.0.40, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: siscadastro
-- ------------------------------------------------------
-- Server version	5.5.5-10.4.32-MariaDB
create database SisCadastro;
use SisCadastro;

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
-- Table structure for table `categorias`
--

DROP TABLE IF EXISTS `categorias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categorias` (
  `CategoriaID` int(11) NOT NULL AUTO_INCREMENT,
  `Nomecategoria` varchar(50) NOT NULL,
  PRIMARY KEY (`CategoriaID`)
);
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categorias`
--

LOCK TABLES `categorias` WRITE;
/*!40000 ALTER TABLE `categorias` DISABLE KEYS */;
INSERT INTO `categorias` VALUES (1,'Espetos'),(2,'porções'),(3,'Bebidas'),(4,'Sucos'),(5,'Cervejas'),(6,'especiais');
/*!40000 ALTER TABLE `categorias` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clientes`
--

DROP TABLE IF EXISTS `clientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clientes` (
  `ClienteID` int(11) NOT NULL AUTO_INCREMENT,
  `Nomecliente` varchar(100) NOT NULL,
  PRIMARY KEY (`ClienteID`)
);
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clientes`
--

LOCK TABLES `clientes` WRITE;
/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
INSERT INTO `clientes` VALUES (1,'João Silva'),(2,'Maria Oliveira'),(3,'Guilherme Martins'),(4,'Ana Carolina');
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `funcionarios`
--

DROP TABLE IF EXISTS `funcionarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `funcionarios` (
  `FuncionarioID` int(11) NOT NULL AUTO_INCREMENT,
  `Nomefuncionario` varchar(100) NOT NULL,
  `Cargo` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`FuncionarioID`)
) ;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `funcionarios`
--

LOCK TABLES `funcionarios` WRITE;
/*!40000 ALTER TABLE `funcionarios` DISABLE KEYS */;
INSERT INTO `funcionarios` VALUES (1,'Bria Gustavo M. Silva','Garçon'),(2,'Ana Clara Domingues','Garçonete'),(3,'Joelma Alves Martins','Cozinheira'),(4,'Pamila Decarti','Gerente'),(5,'Thobias da Assis','Barman');
/*!40000 ALTER TABLE `funcionarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mesas`
--

DROP TABLE IF EXISTS `mesas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mesas` (
  `MesaID` int(11) NOT NULL AUTO_INCREMENT,
  `Descricao` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`MesaID`)
) ;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mesas`
--

LOCK TABLES `mesas` WRITE;
/*!40000 ALTER TABLE `mesas` DISABLE KEYS */;
INSERT INTO `mesas` VALUES (1,'Mesa 1'),(2,'Mesa 2'),(3,'Mesa 3'),(4,'Mesa 4'),(5,'Mesa 6'),(6,'Mesa 7'),(7,'Mesa 8'),(8,'Mesa 9'),(9,'Mesa 10');
/*!40000 ALTER TABLE `mesas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pagamentos`
--

DROP TABLE IF EXISTS `pagamentos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pagamentos` (
  `PagamentoID` int(11) NOT NULL AUTO_INCREMENT,
  `PedidoID` int(11) DEFAULT NULL,
  `Valor` decimal(10,2) NOT NULL,
  `MetodoPagamento` varchar(50) DEFAULT NULL,
  `DataHora` datetime DEFAULT current_timestamp(),
  PRIMARY KEY (`PagamentoID`),
  KEY `PedidoID` (`PedidoID`),
  CONSTRAINT `pagamentos_ibfk_1` FOREIGN KEY (`PedidoID`) REFERENCES `pedidos` (`PedidoID`)
) ;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pagamentos`
--

LOCK TABLES `pagamentos` WRITE;
/*!40000 ALTER TABLE `pagamentos` DISABLE KEYS */;
INSERT INTO `pagamentos` VALUES (1,1,82.50,'Cartão de Crédito','2025-01-07 14:28:46'),(2,2,94.90,'Cartão de Débito','2025-01-07 14:28:46'),(3,3,50.00,'Dinheiro','2025-01-07 14:28:46'),(4,4,73.40,'Pix','2025-01-07 14:28:46');
/*!40000 ALTER TABLE `pagamentos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pedidos`
--

DROP TABLE IF EXISTS `pedidos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pedidos` (
  `PedidoID` int(11) NOT NULL AUTO_INCREMENT,
  `ClienteID` int(11) DEFAULT NULL,
  `FuncionarioID` int(11) DEFAULT NULL,
  `MesaID` int(11) DEFAULT NULL,
  `DataHora` datetime DEFAULT current_timestamp(),
  PRIMARY KEY (`PedidoID`),
  KEY `ClienteID` (`ClienteID`),
  KEY `FuncionarioID` (`FuncionarioID`),
  KEY `MesaID` (`MesaID`),
  CONSTRAINT `pedidos_ibfk_1` FOREIGN KEY (`ClienteID`) REFERENCES `clientes` (`ClienteID`),
  CONSTRAINT `pedidos_ibfk_2` FOREIGN KEY (`FuncionarioID`) REFERENCES `funcionarios` (`FuncionarioID`),
  CONSTRAINT `pedidos_ibfk_3` FOREIGN KEY (`MesaID`) REFERENCES `mesas` (`MesaID`)
) ;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pedidos`
--

LOCK TABLES `pedidos` WRITE;
/*!40000 ALTER TABLE `pedidos` DISABLE KEYS */;
INSERT INTO `pedidos` VALUES (1,1,1,1,'2025-01-07 14:28:31'),(2,2,1,2,'2025-01-07 14:28:31'),(3,3,2,3,'2025-01-07 14:28:31'),(4,4,2,4,'2025-01-07 14:28:31');
/*!40000 ALTER TABLE `pedidos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `produtos`
--

DROP TABLE IF EXISTS `produtos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `produtos` (
  `ProdutoID` int(11) NOT NULL AUTO_INCREMENT,
  `Nomeproduto` varchar(100) NOT NULL,
  `Preco` decimal(10,2) NOT NULL,
  `CategoriaID` int(11) DEFAULT NULL,
  PRIMARY KEY (`ProdutoID`),
  KEY `CategoriaID` (`CategoriaID`),
  CONSTRAINT `produtos_ibfk_1` FOREIGN KEY (`CategoriaID`) REFERENCES `categorias` (`CategoriaID`)
) ;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `produtos`
--

LOCK TABLES `produtos` WRITE;
/*!40000 ALTER TABLE `produtos` DISABLE KEYS */;
INSERT INTO `produtos` VALUES (1,'Espeto de Boi',9.00,1),(2,'Espeto de Frango e Bacon',9.00,1),(3,'Espeto de Porco',9.00,1),(5,'Porção Batata isadora',39.00,2),(6,'Porção Frango Crocante',47.00,2),(8,'Coca-Cola',6.00,3),(9,'Guarana-Antartica',6.00,3),(10,'Suco de Laranja',9.00,4),(11,'Suco de Abacaxi',9.00,4),(12,'Suco de Morango',9.00,4),(16,'Porção de Alcatra com Fritas',68.00,2),(17,'Linguiça de Pimenta',9.00,1),(19,'Fanta Laranja',5.00,3),(20,'Suco de Melancia',10.00,4),(21,'Porção de Picanha',135.00,2),(22,'Original 600',12.90,5),(23,'Heineken',15.00,5),(24,'Medalhão de Nozinho',9.00,6),(25,'Espeto de Costela',9.90,6);
/*!40000 ALTER TABLE `produtos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reservas`
--

DROP TABLE IF EXISTS `reservas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reservas` (
  `ReservaID` int(11) NOT NULL AUTO_INCREMENT,
  `ClienteID` int(11) NOT NULL,
  `MesaID` int(11) NOT NULL,
  `DataReserva` date NOT NULL,
  `HoraReserva` time NOT NULL,
  `Observacoes` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ReservaID`),
  KEY `ClienteID` (`ClienteID`),
  KEY `MesaID` (`MesaID`),
  CONSTRAINT `reservas_ibfk_1` FOREIGN KEY (`ClienteID`) REFERENCES `clientes` (`ClienteID`),
  CONSTRAINT `reservas_ibfk_2` FOREIGN KEY (`MesaID`) REFERENCES `mesas` (`MesaID`)
);
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reservas`
--

LOCK TABLES `reservas` WRITE;
/*!40000 ALTER TABLE `reservas` DISABLE KEYS */;
INSERT INTO `reservas` VALUES (1,1,1,'2025-01-10','19:00:00','Mesa próxima ao palco'),(2,2,2,'2025-01-10','20:00:00','Mesa para 4 pessoas'),(3,3,3,'2025-01-11','18:30:00','Mesa com boa iluminação'),(4,4,4,'2025-01-11','21:00:00',NULL);
/*!40000 ALTER TABLE `reservas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarios` (
  `UsuariosID` int(11) NOT NULL AUTO_INCREMENT,
  `Nome` varchar(100) NOT NULL,
  `Senha` varchar(100) NOT NULL,
  PRIMARY KEY (`UsuariosID`)
) ;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (5,'adm','03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4'),(6,'Brian','cd818bff1af82883f75da4215a3ee0c468e124f7dc50ab27d98cc78fa8d74607');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'siscadastro'
--
/*!50003 DROP PROCEDURE IF EXISTS `sp_alteraproduto` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_ZERO_IN_DATE,NO_ZERO_DATE,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_alteraproduto`(
    id INT,
    nome VARCHAR(100),
    preco DECIMAL(10,2),
    categoria INT
)
BEGIN
    UPDATE Produtos
    SET
        Nomeproduto = nome,
        Preco = preco,
        CategoriaID = categoria
    WHERE ProdutoID = id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_consultarlogin` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_ZERO_IN_DATE,NO_ZERO_DATE,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_consultarlogin`(Usuario varchar(100), Senha varchar(100))
BEGIN

select * from Usuarios where Usuarios.Nome = Usuario and Usuarios.Senha = Senha;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_inserecategoria` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_ZERO_IN_DATE,NO_ZERO_DATE,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_inserecategoria`(Nome varchar(50))
BEGIN
insert into categoria (Nomecategoria) values (Nome);

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_insereCategorias` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_ZERO_IN_DATE,NO_ZERO_DATE,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_insereCategorias`(Nomecategoria varchar(50))
BEGIN
INSERT INTO categorias
(Nomecategoria)
VALUES
(Nomecategoria);

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_insereproduto` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_ZERO_IN_DATE,NO_ZERO_DATE,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_insereproduto`(Nomeproduto varchar(100), Preco decimal(10,2),CategoriaID int)
BEGIN
INSERT INTO produtos
(Nomeproduto,
Preco,
CategoriaID)
VALUES
(Nomeproduto,
Preco,
CategoriaID);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_listacategorias` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_ZERO_IN_DATE,NO_ZERO_DATE,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_listacategorias`()
BEGIN
   select * from categorias;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_listaprodutos` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_ZERO_IN_DATE,NO_ZERO_DATE,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_listaprodutos`()
BEGIN
SELECT 
    Produtos.ProdutoID,
    Produtos.Nomeproduto,
    Produtos.Preco,
    Categorias.Nomecategoria as Categoria
FROM 
    Produtos
INNER JOIN 
    Categorias
ON 
    Produtos.CategoriaID = Categorias.CategoriaID;


END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_removeproduto` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_ZERO_IN_DATE,NO_ZERO_DATE,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_removeproduto`(RemoveID int)
BEGIN
delete from produtos where ProdutoID = RemoveID;
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

-- Dump completed on 2025-01-24  7:55:36