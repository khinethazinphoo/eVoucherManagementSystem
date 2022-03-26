-- MySQL dump 10.13  Distrib 8.0.28, for Win64 (x86_64)
--
-- Host: localhost    Database: evouchermanagementsystem
-- ------------------------------------------------------
-- Server version	8.0.28

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
-- Table structure for table `tbl_evoucher`
--

DROP TABLE IF EXISTS `tbl_evoucher`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_evoucher` (
  `EVoucherId` int NOT NULL AUTO_INCREMENT,
  `Title` varchar(100) DEFAULT NULL,
  `Description` varchar(200) DEFAULT NULL,
  `Image` varchar(500) DEFAULT NULL,
  `Amount` decimal(18,2) DEFAULT NULL,
  `PaymentMethod` varchar(45) DEFAULT NULL,
  `Quantity` varchar(45) DEFAULT NULL,
  `BuyType` varchar(45) DEFAULT NULL,
  `Name` varchar(45) DEFAULT NULL,
  `PhoneNumber` varchar(45) DEFAULT NULL,
  `MaxeVoucherlimit` int DEFAULT NULL,
  `GiftperUserlimit` varchar(45) DEFAULT NULL,
  `UserId` varchar(50) DEFAULT NULL,
  `IsActive` bit(1) DEFAULT NULL,
  `DateExpire` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`EVoucherId`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_evoucher`
--

LOCK TABLES `tbl_evoucher` WRITE;
/*!40000 ALTER TABLE `tbl_evoucher` DISABLE KEYS */;
INSERT INTO `tbl_evoucher` VALUES (1,'Test','Testing',NULL,1000.00,NULL,NULL,'Onlyme',NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2,'Test','Testing Testing',NULL,1000.00,NULL,NULL,'Onlyme',NULL,NULL,NULL,NULL,NULL,NULL,NULL),(3,'Test','Testing Test1',NULL,1000.00,NULL,NULL,'Onlyme',NULL,NULL,NULL,NULL,NULL,NULL,NULL),(4,'Test','Testing Test1',NULL,2000.00,NULL,NULL,'Onlyme',NULL,NULL,NULL,NULL,'94EFCA7E-F808-4B76-B7BB-08BAF64ED5F0',NULL,NULL),(5,NULL,NULL,NULL,0.00,NULL,NULL,'Onlyme',NULL,NULL,NULL,NULL,NULL,NULL,NULL),(6,NULL,NULL,NULL,0.00,NULL,NULL,'Onlyme',NULL,NULL,NULL,NULL,NULL,NULL,NULL),(7,NULL,NULL,NULL,0.00,NULL,NULL,'Onlyme',NULL,NULL,NULL,NULL,NULL,NULL,NULL),(8,NULL,NULL,NULL,0.00,NULL,NULL,'Onlyme',NULL,NULL,NULL,NULL,NULL,NULL,NULL),(9,NULL,NULL,NULL,0.00,NULL,NULL,'Onlyme',NULL,NULL,NULL,NULL,NULL,NULL,NULL),(10,NULL,NULL,NULL,0.00,NULL,NULL,'Onlyme',NULL,NULL,NULL,NULL,NULL,NULL,NULL),(11,NULL,NULL,NULL,NULL,NULL,NULL,'Onlyme',NULL,NULL,NULL,NULL,NULL,_binary '\0',NULL),(12,NULL,NULL,NULL,NULL,NULL,NULL,'Onlyme',NULL,NULL,NULL,NULL,'94EFCA7E-F808-4B76-B7BB-08BAF64ED5F0',_binary '\0',NULL),(13,NULL,NULL,NULL,NULL,NULL,NULL,'Onlyme',NULL,NULL,NULL,NULL,'94EFCA7E-F808-4B76-B7BB-08BAF64ED5F0',_binary '\0',NULL),(14,NULL,NULL,NULL,NULL,NULL,NULL,'Onlyme',NULL,NULL,NULL,NULL,'94EFCA7E-F808-4B76-B7BB-08BAF64ED5F0',_binary '\0',NULL),(15,NULL,NULL,NULL,NULL,NULL,NULL,'Onlyme',NULL,NULL,NULL,NULL,'94EFCA7E-F808-4B76-B7BB-08BAF64ED5F0',_binary '\0',NULL),(16,'Test','Testing',NULL,300.00,NULL,'1','Onlyme','Phoo','09459574212',1,NULL,'94EFCA7E-F808-4B76-B7BB-08BAF64ED5F0',_binary '',NULL),(17,'Test','Testing',NULL,600.00,NULL,'2','Onlyme','Phoo','09459574212',1,NULL,'94EFCA7E-F808-4B76-B7BB-08BAF64ED5F0',_binary '\0','2022-03-23'),(18,NULL,NULL,NULL,600.00,NULL,'2','Onlyme','Phoo','09459574212',1,NULL,'94EFCA7E-F808-4B76-B7BB-08BAF64ED5F0',_binary '',NULL);
/*!40000 ALTER TABLE `tbl_evoucher` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_purchasehistory`
--

DROP TABLE IF EXISTS `tbl_purchasehistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_purchasehistory` (
  `PurchaseHistoryId` int NOT NULL AUTO_INCREMENT,
  `Title` varchar(100) DEFAULT NULL,
  `Description` varchar(200) DEFAULT NULL,
  `ExpiryDate` varchar(50) DEFAULT NULL,
  `Image` varchar(500) DEFAULT NULL,
  `Amount` decimal(18,2) DEFAULT NULL,
  `PaymentMethod` varchar(45) DEFAULT NULL,
  `Quantity` varchar(45) DEFAULT NULL,
  `BuyType` varchar(45) DEFAULT NULL,
  `Name` varchar(45) DEFAULT NULL,
  `PhoneNumber` varchar(45) DEFAULT NULL,
  `MaxeVoucherlimit` int DEFAULT NULL,
  `GiftperUserlimit` varchar(45) DEFAULT NULL,
  `IsActive` bit(1) DEFAULT NULL,
  `PromoCode` varchar(12) DEFAULT NULL,
  `UserId` varchar(50) DEFAULT NULL,
  `Base64ForQR` varchar(500) DEFAULT NULL,
  `IsUsed` bit(1) DEFAULT NULL,
  PRIMARY KEY (`PurchaseHistoryId`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_purchasehistory`
--

LOCK TABLES `tbl_purchasehistory` WRITE;
/*!40000 ALTER TABLE `tbl_purchasehistory` DISABLE KEYS */;
INSERT INTO `tbl_purchasehistory` VALUES (1,'Test','Testing','2022-03-23',NULL,300.00,'VISA','1','Onlyme','Phoo','09459574212',5,NULL,_binary '',NULL,'94EFCA7E-F808-4B76-B7BB-08BAF64ED5F0',NULL,NULL),(2,'Test','Testing','2022-03-23',NULL,300.00,'VISA','1','Onlyme','Phoo','09459574212',5,NULL,_binary '',NULL,'94EFCA7E-F808-4B76-B7BB-08BAF64ED5F0',NULL,NULL),(3,'Test','Testing','2022-03-23',NULL,300.00,'VISA','1','Onlyme','Phoo','09459574212',3,NULL,_binary '','HDPBV035174','94EFCA7E-F808-4B76-B7BB-08BAF64ED5F0',NULL,NULL),(4,'Test','Testing','2022-03-23',NULL,300.00,'VISA','1','Onlyme','Phoo','09459574212',3,NULL,_binary '','RLVMR387851','94EFCA7E-F808-4B76-B7BB-08BAF64ED5F0',NULL,NULL),(5,'Test','Testing','2022-03-23',NULL,300.00,'VISA','1','Onlyme','Phoo','09459574212',3,NULL,_binary '','SRTJO635800','94EFCA7E-F808-4B76-B7BB-08BAF64ED5F0','hQVDUFYwMWEUTwhlVm91Y2hlclAIZVZvdWNoZXJhFE8IZVZvdWNoZXJQCGVWb3VjaGVyDVcLU1JUSk82MzU4MDA=',NULL),(6,'Test','Testing','2022-03-23',NULL,300.00,'VISA','1','Onlyme','Phoo','09459574212',0,NULL,_binary '','ZULKL288450','94EFCA7E-F808-4B76-B7BB-08BAF64ED5F0','hQVDUFYwMWEUTwhlVm91Y2hlclAIZVZvdWNoZXJhFE8IZVZvdWNoZXJQCGVWb3VjaGVyDVcLWlVMS0wyODg0NTA=',_binary ''),(7,'Test','Testing','2022-03-23',NULL,300.00,'VISA','1','Onlyme','Phoo','09459574222',5,NULL,_binary '','ZEVDQ447420','94EFCA7E-F808-4B76-B7BB-08BAF64ED5F0','hQVDUFYwMWEUTwhlVm91Y2hlclAIZVZvdWNoZXJhFE8IZVZvdWNoZXJQCGVWb3VjaGVyDVcLWkVWRFE0NDc0MjA=',_binary '\0');
/*!40000 ALTER TABLE `tbl_purchasehistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_user`
--

DROP TABLE IF EXISTS `tbl_user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_user` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `UserId` varchar(50) DEFAULT NULL,
  `Name` varchar(45) DEFAULT NULL,
  `Phone` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_user`
--

LOCK TABLES `tbl_user` WRITE;
/*!40000 ALTER TABLE `tbl_user` DISABLE KEYS */;
INSERT INTO `tbl_user` VALUES (1,'94EFCA7E-F808-4B76-B7BB-08BAF64ED5F0','PHOO','09459574212');
/*!40000 ALTER TABLE `tbl_user` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-03-24  7:26:49
