-- MySQL dump 10.13  Distrib 8.0.30, for Win64 (x86_64)
--
-- Host: localhost    Database: OfficeSupplies
-- ------------------------------------------------------
-- Server version	8.0.30

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Current Database: `OfficeSupplies`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `OfficeSupplies` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;

USE `OfficeSupplies`;

--
-- Table structure for table `categories`
--

DROP TABLE IF EXISTS `categories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categories` (
  `categoryId` smallint NOT NULL,
  `categoryName` varchar(50) DEFAULT NULL,
  `description` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`categoryId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categories`
--

LOCK TABLES `categories` WRITE;
/*!40000 ALTER TABLE `categories` DISABLE KEYS */;
INSERT INTO `categories` VALUES (1,'Notebooks','All types of notebooks'),(2,'Pens','Includes all kinds of pens'),(3,'Paper','Printer and photocopier paper'),(4,'Office Essentials','Staplers, binders, and other essentials'),(5,'Stationery','All kinds of stationery products'),(6,'Office Electronics','Various electronic products for office use');
/*!40000 ALTER TABLE `categories` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `products`
--

DROP TABLE IF EXISTS `products`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `products` (
  `productId` int NOT NULL AUTO_INCREMENT,
  `name` varchar(50) DEFAULT NULL,
  `description` varchar(150) DEFAULT NULL,
  `price` decimal(4,2) DEFAULT NULL,
  `quantity` smallint DEFAULT NULL,
  `categoryId` smallint DEFAULT NULL,
  `supplierID` int DEFAULT NULL,
  PRIMARY KEY (`productId`),
  KEY `idx_name` (`name`),
  KEY `idx_categoryId` (`categoryId`),
  KEY `FK_Supplier` (`supplierID`),
  CONSTRAINT `FK_Supplier` FOREIGN KEY (`supplierID`) REFERENCES `suppliers` (`supplierID`),
  CONSTRAINT `products_ibfk_1` FOREIGN KEY (`categoryId`) REFERENCES `categories` (`categoryId`),
  CONSTRAINT `CHK_Price` CHECK ((`price` >= 0.01)),
  CONSTRAINT `CHK_Quantity` CHECK ((`quantity` >= 0))
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `products`
--

LOCK TABLES `products` WRITE;
/*!40000 ALTER TABLE `products` DISABLE KEYS */;
INSERT INTO `products` VALUES (1,'test','test',10.00,10,3,NULL),(2,'asdasd','asdasd',15.00,12,1,NULL),(3,'Printer Paper','500 sheets of A4 printer paper',5.95,300,3,NULL),(4,'Staplers','Sturdy metal stapler',8.20,100,4,NULL),(5,'Markers','Set of 4 whiteboard markers',7.00,120,2,NULL),(6,'Test','Test',10.00,10,3,NULL),(7,'Erasable Pens','Pack of 5 blue erasable pens',3.75,200,1,NULL),(8,'Multifunction Printer','All-in-one printer with scanning, printing, and faxing',99.99,30,2,NULL),(9,'Pencils','30 pack of pencils',12.00,30,1,NULL),(10,'test','test',99.00,10,1,NULL),(11,'aasdsaasd','asdsadsadasda',7.50,12,1,NULL),(12,'New Product','A valid description',25.99,100,1,NULL),(13,'fdsfs','sfsdf',12.00,12,1,NULL),(14,'New Product','A valid description',25.99,100,1,NULL),(15,'Test','Test',12.00,10,1,NULL),(16,'Test','Test',10.00,100,1,NULL),(17,'Test','Test',10.00,3000,1,NULL),(18,'Test','Test',19.00,10,3,NULL);
/*!40000 ALTER TABLE `products` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `restocks`
--

DROP TABLE IF EXISTS `restocks`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `restocks` (
  `restockID` int NOT NULL AUTO_INCREMENT,
  `itemId` int DEFAULT NULL,
  `supplierId` int DEFAULT NULL,
  `quantity` smallint DEFAULT NULL,
  `expRestock` datetime DEFAULT NULL,
  PRIMARY KEY (`restockID`),
  KEY `supplierId` (`supplierId`),
  CONSTRAINT `restocks_ibfk_1` FOREIGN KEY (`supplierId`) REFERENCES `suppliers` (`supplierID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `restocks`
--

LOCK TABLES `restocks` WRITE;
/*!40000 ALTER TABLE `restocks` DISABLE KEYS */;
INSERT INTO `restocks` VALUES (1,1,1,100,'2023-12-15 00:00:00'),(2,3,2,50,'2023-12-20 00:00:00');
/*!40000 ALTER TABLE `restocks` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `suppliers`
--

DROP TABLE IF EXISTS `suppliers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `suppliers` (
  `supplierID` int NOT NULL,
  `supplierName` varchar(50) DEFAULT NULL,
  `phoneNumber` varchar(15) DEFAULT NULL,
  `email` varchar(75) DEFAULT NULL,
  `address` varchar(150) DEFAULT NULL,
  `city` varchar(75) DEFAULT NULL,
  `region` varchar(100) DEFAULT NULL,
  `country` varchar(65) DEFAULT NULL,
  `postalCode` varchar(10) DEFAULT NULL,
  `salesRepName` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`supplierID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `suppliers`
--

LOCK TABLES `suppliers` WRITE;
/*!40000 ALTER TABLE `suppliers` DISABLE KEYS */;
INSERT INTO `suppliers` VALUES (1,'Paper Products Co.','123-456-7890','info@paperproducts.com','123 Paper St.','Milltown','Midwest','USA','50001','John Doe'),(2,'Office Gadgets Ltd.','321-654-0987','contact@officegadgets.com','456 Tech Avenue','Gadget City','Southwest','USA','50002','Jane Smith');
/*!40000 ALTER TABLE `suppliers` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-05-13 21:05:47
