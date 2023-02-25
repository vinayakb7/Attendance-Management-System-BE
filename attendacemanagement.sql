-- MySQL dump 10.13  Distrib 8.0.30, for Win64 (x86_64)
--
-- Host: localhost    Database: attendancemanagement
-- ------------------------------------------------------
-- Server version	8.0.29

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
-- Table structure for table `attendance`
--

DROP TABLE IF EXISTS `attendance`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `attendance` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `AITId` varchar(35) NOT NULL,
  `Date` date DEFAULT NULL,
  `CheckIn` time DEFAULT NULL,
  `CheckOut` time DEFAULT NULL,
  `Status` varchar(45) DEFAULT NULL,
  `reasonForRegularization` varchar(355) DEFAULT NULL,
  `descriptionForRegularization` varchar(355) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=163 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `attendance`
--

LOCK TABLES `attendance` WRITE;
/*!40000 ALTER TABLE `attendance` DISABLE KEYS */;
INSERT INTO `attendance` VALUES (1,'AIT-123','2022-10-10','08:00:00','10:00:00','Absent',NULL,NULL),(2,'AIT-123','2022-10-10','12:00:00','14:30:00','Absent',NULL,NULL),(3,'AIT-124','2022-10-10','08:00:00','17:00:00','Present',NULL,NULL),(4,'AIT-124','2022-10-10','18:00:00','19:00:00','Absent',NULL,NULL),(5,'AIT-123','2022-10-11','12:00:00','14:00:00','Absent',NULL,NULL),(6,'AIT-123','2022-10-12','10:00:00','15:30:00','Absent',NULL,NULL),(7,'AIT-123','2022-10-13','08:10:23','10:20:45','Absent',NULL,NULL),(8,'AIT-123','2022-10-13','10:40:45','15:20:45','Absent',NULL,NULL),(9,'AIT-123','2022-10-13','15:50:45','21:20:45','Absent',NULL,NULL),(10,'AIT-123','2022-11-14','08:10:10','21:10:10','Present',NULL,NULL),(11,'AIT-123','2022-10-14','12:30:00','15:10:30','Absent',NULL,NULL),(12,'AIT-123','2022-10-14','12:03:00','15:10:03','Absent',NULL,NULL),(13,'AIT-123','2022-10-17','14:07:52','00:00:00','Absent',NULL,NULL),(17,'AIT-123','2022-10-06','12:20:43','13:08:15',NULL,NULL,NULL),(18,'AIT-123','2022-10-06','13:08:42','15:46:26',NULL,NULL,NULL),(19,'AIT-123','2022-10-06','15:47:49','15:49:32',NULL,NULL,NULL),(20,'AIT-123','2022-10-06','15:49:41','15:50:12',NULL,NULL,NULL),(24,'AIT-124','2022-11-12','14:08:43','20:20:20',NULL,NULL,NULL),(26,'AIT-124','2022-11-13','12:12:12','20:20:20',NULL,NULL,NULL),(29,'AIT-150','2022-10-11','08:56:39','21:21:21',NULL,NULL,NULL),(30,'AIT-130','2022-11-12','14:35:43','14:37:21',NULL,NULL,NULL),(31,'AIT-130','2022-11-12','14:37:42','14:38:24',NULL,NULL,NULL),(32,'AIT-130','2022-11-12','14:38:32','14:38:41',NULL,NULL,NULL),(33,'AIT-130','2022-11-12','14:39:00','14:49:23',NULL,NULL,NULL),(34,'AIT-130','2022-11-12','14:49:26','16:03:03',NULL,NULL,NULL),(35,'AIT-130','2022-11-12','16:03:13','14:08:30',NULL,NULL,NULL),(36,'AIT-130','2022-11-12','14:08:36','14:08:57',NULL,NULL,NULL),(37,'AIT-130','2022-11-12','14:09:52','14:09:54',NULL,NULL,NULL),(38,'AIT-130','2022-11-12','14:11:13','14:11:16',NULL,NULL,NULL),(39,'AIT-130','2022-11-12','14:13:29','14:13:32',NULL,NULL,NULL),(40,'AIT-130','2022-11-12','14:14:34','14:14:39',NULL,NULL,NULL),(41,'AIT-130','2022-11-12','14:14:59','14:15:06',NULL,NULL,NULL),(42,'AIT-130','2022-11-12','14:16:16','14:16:20',NULL,NULL,NULL),(43,'AIT-130','2022-11-12','14:17:28','14:17:31',NULL,NULL,NULL),(44,'AIT-130','2022-11-12','14:17:37','14:17:45',NULL,NULL,NULL),(45,'AIT-130','2022-11-12','14:18:02','14:18:12',NULL,NULL,NULL),(46,'AIT-130','2022-11-12','14:18:19','14:18:21',NULL,NULL,NULL),(47,'AIT-130','2022-11-12','14:18:25','14:18:28',NULL,NULL,NULL),(48,'AIT-130','2022-11-12','14:19:14','14:19:18',NULL,NULL,NULL),(49,'AIT-130','2022-11-12','14:19:23','14:19:27',NULL,NULL,NULL),(50,'AIT-123','2022-10-13','10:10:10','17:36:34',NULL,NULL,NULL),(51,'AIT-123','2022-10-13','10:10:10','17:36:34',NULL,NULL,NULL),(52,'AIT-123','2022-10-13','10:10:10','11:11:11','Request',NULL,NULL),(53,'AIT-123','2022-10-12','14:31:42','14:32:03',NULL,NULL,NULL),(54,'AIT-123','2022-10-12','14:32:48','14:32:55',NULL,NULL,NULL),(55,'AIT-123','2022-10-12','14:33:30','14:33:38',NULL,NULL,NULL),(56,'AIT-123','2022-10-12','14:34:14','14:34:18',NULL,NULL,NULL),(57,'AIT-123','2022-10-12','14:34:24','14:34:31',NULL,NULL,NULL),(58,'AIT-123','2022-10-12','14:34:38','14:34:39',NULL,NULL,NULL),(59,'AIT-123','2022-10-12','14:34:44','14:34:45',NULL,NULL,NULL),(60,'AIT-123','2022-10-12','14:34:49','14:34:50',NULL,NULL,NULL),(61,'AIT-123','2022-10-12','14:34:51','14:34:52',NULL,NULL,NULL),(62,'AIT-123','2022-10-12','17:31:28','17:31:30',NULL,NULL,NULL),(63,'AIT-123','2022-10-12','17:32:01','17:32:22',NULL,NULL,NULL),(64,'AIT-123','2022-10-12','17:58:21','17:58:24',NULL,NULL,NULL),(65,'AIT-123','2022-10-12','18:27:37','18:27:38',NULL,NULL,NULL),(66,'AIT-123','2022-10-12','18:27:42','18:27:45',NULL,NULL,NULL),(67,'AIT-123','2022-10-12','19:04:36','19:04:39',NULL,NULL,NULL),(68,'AIT-123','2022-10-13','17:38:34','17:38:38',NULL,NULL,NULL),(115,'AIT-123','2022-10-13','17:50:46','17:50:46',NULL,NULL,NULL),(116,'AIT-123','2022-10-13','18:09:37','18:09:37',NULL,NULL,NULL),(117,'AIT-123','2022-10-13','18:09:49','18:09:51',NULL,NULL,NULL),(118,'AIT-123','2022-10-13','18:10:39','18:10:39',NULL,NULL,NULL),(119,'AIT-123','2022-10-14','13:00:28','13:00:29',NULL,NULL,NULL),(120,'AIT-123','2022-10-26','10:10:14','20:40:50','Request',NULL,NULL),(121,'AIT-123','2022-10-26','10:10:14','20:40:50','Request',NULL,NULL),(122,'AIT-123','2022-10-26','10:10:14','20:40:50','Request',NULL,NULL),(123,'AIT-123','2022-10-26','10:10:14','20:40:50','Request',NULL,NULL),(124,'AIT-123','2022-10-14','17:31:59','17:32:07',NULL,NULL,NULL),(125,'AIT-123','2022-10-14','17:32:08','17:33:33',NULL,NULL,NULL),(126,'AIT-123','2022-10-14','17:33:36','17:34:44',NULL,NULL,NULL),(127,'AIT-123','2022-10-14','17:34:50','17:34:52',NULL,NULL,NULL),(128,'AIT-123','2022-10-14','17:34:54','17:34:55',NULL,NULL,NULL),(129,'AIT-123','2022-10-17','12:35:22','12:35:23',NULL,NULL,NULL),(130,'AIT-123','2022-10-17','12:35:24','12:35:28',NULL,NULL,NULL),(131,'AIT-123','2022-10-17','12:36:25','12:36:26',NULL,NULL,NULL),(132,'AIT-123','2022-10-17','13:20:21','13:20:23',NULL,NULL,NULL),(133,'AIT-123','2022-10-17','13:20:28','13:23:02',NULL,NULL,NULL),(134,'AIT-123','2022-10-17','13:23:04','13:23:07',NULL,NULL,NULL),(135,'AIT-123','2022-10-17','13:23:09','13:23:11',NULL,NULL,NULL),(136,'AIT-123','2022-10-17','13:23:15','13:33:42',NULL,NULL,NULL),(140,'AIT-123','2022-10-14','10:10:10','20:00:10','Request',NULL,NULL),(141,'AIT-123','2022-09-29','08:10:10','11:11:11','Request',NULL,NULL),(142,'AIT-123','2022-10-17','13:37:37',NULL,NULL,NULL,NULL),(143,'AIT-123','2022-10-18','14:26:39','14:26:44',NULL,NULL,NULL),(144,'AIT-123','2022-10-18','14:27:00','14:27:01',NULL,NULL,NULL),(145,'AIT-123','2022-10-18','14:27:23','14:27:25',NULL,NULL,NULL),(146,'AIT-123','2022-10-18','14:28:03','14:28:04',NULL,NULL,NULL),(147,'AIT-123','2022-10-18','14:28:28','14:28:28',NULL,NULL,NULL),(148,'AIT-123','2022-10-18','14:32:00','14:32:13',NULL,NULL,NULL),(149,'AIT-123','2022-10-18','14:32:45','14:32:46','Absent',NULL,NULL),(150,'AIT-123','2022-10-18','16:58:02','16:58:03',NULL,NULL,NULL),(151,'AIT-123','2022-10-18','16:58:04','16:58:07','Absent',NULL,NULL),(152,'AIT-123','2022-10-18','17:18:57','17:19:15',NULL,NULL,NULL),(153,'AIT-123','2022-10-18','17:21:32','17:22:11',NULL,NULL,NULL),(154,'AIT-123','2022-10-18','17:23:23','17:23:30','Absent',NULL,NULL),(155,'AIT-123','2022-10-18','17:39:12','17:39:13','Absent',NULL,NULL),(156,'AIT-123','2022-10-18','17:39:16','17:39:16','Absent',NULL,NULL),(157,'AIT-123','2022-10-18','17:39:20','19:16:08','Absent',NULL,NULL),(158,'AIT-123','2022-10-18','19:16:15','19:17:45','Absent',NULL,NULL),(159,'AIT-123','2022-10-18','19:17:47','19:18:08','Absent',NULL,NULL),(160,'AIT-123','2022-10-13','08:10:12','16:12:14','Request','Reason','Description'),(161,'AIT-123','2022-10-18','19:40:00','19:40:02','Absent',NULL,NULL),(162,'AIT-123','2022-10-19','14:35:39','14:37:35','Absent',NULL,NULL);
/*!40000 ALTER TABLE `attendance` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `emp_details`
--

DROP TABLE IF EXISTS `emp_details`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `emp_details` (
  `Emp_Id` int NOT NULL,
  `AITId` varchar(45) NOT NULL,
  `Emp_ProfilePic` varchar(255) NOT NULL,
  `Emp_Name` varchar(200) NOT NULL,
  `Emp_Address` varchar(355) NOT NULL,
  `Emp_Contact` varchar(10) NOT NULL,
  `Emp_Gender` varchar(6) NOT NULL,
  `Emp_Country` varchar(55) NOT NULL,
  `Emp_Language` varchar(60) NOT NULL,
  `Emp_NickName` varchar(30) NOT NULL,
  `Emp_Email` varchar(200) NOT NULL,
  `Emp_Password` varchar(250) NOT NULL,
  `Emp_Department` varchar(45) NOT NULL,
  `Emp_JoiningDate` date DEFAULT NULL,
  `Emp_ReportingManager` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Emp_Id`),
  UNIQUE KEY `Emp_Email_UNIQUE` (`Emp_Email`),
  UNIQUE KEY `AITId_UNIQUE` (`AITId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `emp_details`
--

LOCK TABLES `emp_details` WRITE;
/*!40000 ALTER TABLE `emp_details` DISABLE KEYS */;
/*!40000 ALTER TABLE `emp_details` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'attendancemanagement'
--

--
-- Dumping routines for database 'attendancemanagement'
--
/*!50003 DROP PROCEDURE IF EXISTS `checkIn` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `checkIn`(idd varchar(30),dt varchar(30),checkIn varchar(30))
BEGIN
insert into attendance(AITId,Date,CheckIn)values(idd,dt,checkIn);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `checkOut` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `checkOut`(idd varchar(30),dt varchar(30),co varchar(30),sts varchar(30))
BEGIN
update attendance set CheckOut = co,status=sts where AITId=idd and Date=dt and CheckOut is null;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `getAttendaceDetails` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `getAttendaceDetails`(idd varchar(30),dt date)
BEGIN
select Id,Date,AITId,Status,min(CheckIn) as CheckIn,max(CheckOut) as CheckOut from attendancemanagement.attendance where AITId=idd and Date = dt;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `getByMonth` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `getByMonth`(idd varchar(30),mnth varchar(30),yrs varchar(30))
BEGIN
select Id,Date,AITId,Status,min(CheckIn) as CheckIn,max(CheckOut) as CheckOut from attendancemanagement.attendance where AITId=idd and month(Date)=mnth and year(Date)=yrs group by Date;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `getByWeek` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `getByWeek`(idd varchar(30),dt1 varchar(30),dt2 varchar(30))
BEGIN
select Id,Date,AITId,Status,min(CheckIn) as CheckIn,max(CheckOut) as CheckOut from attendancemanagement.attendance where AITId=idd and Date between dt1 and dt2 group by Date;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `getByWeekStatus` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `getByWeekStatus`(idd varchar(30),dt1 varchar(30),dt2 varchar(30))
BEGIN
select Id,Date,AITId,Status,min(CheckIn) as CheckIn,max(CheckOut) as CheckOut from attendancemanagement.attendance where AITId=idd and status='Present' and Date between dt1 and dt2 group by Date;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `getCheckIn` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `getCheckIn`(idd varchar(30),dt varchar(30))
BEGIN
select * from attendancemanagement.attendance where AITId=idd and Date=dt and CheckOut is null;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `getPresentByMonth` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `getPresentByMonth`(idd varchar(30),mnth varchar(30),yrs varchar(30))
BEGIN
select Id,Date,AITId,Status,min(CheckIn) as CheckIn,max(CheckOut) as CheckOut from attendancemanagement.attendance where AITId=idd and month(Date)=mnth and status !='Request' and year(Date)=yrs group by Date;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `regularization` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `regularization`(idd varchar(30))
BEGIN
select * from attendance where status = 'Request' and AITId=idd;
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

-- Dump completed on 2022-10-19 14:49:03
