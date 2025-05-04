-- MySQL dump 10.13  Distrib 8.0.30, for Win64 (x86_64)
--
-- Host: localhost    Database: jem_jed
-- ------------------------------------------------------
-- Server version	8.0.30

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
-- Table structure for table `admin`
--

DROP TABLE IF EXISTS `admin`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `admin` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL,
  `UserName` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `admin`
--

LOCK TABLES `admin` WRITE;
/*!40000 ALTER TABLE `admin` DISABLE KEYS */;
INSERT INTO `admin` VALUES (1,'Jim','jim','password');
/*!40000 ALTER TABLE `admin` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `classid`
--

DROP TABLE IF EXISTS `classid`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `classid` (
  `ClassId` int NOT NULL AUTO_INCREMENT,
  `ClassName` varchar(50) NOT NULL,
  PRIMARY KEY (`ClassId`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `classid`
--

LOCK TABLES `classid` WRITE;
/*!40000 ALTER TABLE `classid` DISABLE KEYS */;
INSERT INTO `classid` VALUES (1,'firstClass'),(2,'secondClass');
/*!40000 ALTER TABLE `classid` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gradeyear`
--

DROP TABLE IF EXISTS `gradeyear`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `gradeyear` (
  `GradeId` int NOT NULL AUTO_INCREMENT,
  `GradeYear` int NOT NULL,
  PRIMARY KEY (`GradeId`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gradeyear`
--

LOCK TABLES `gradeyear` WRITE;
/*!40000 ALTER TABLE `gradeyear` DISABLE KEYS */;
INSERT INTO `gradeyear` VALUES (1,1),(2,2),(3,3);
/*!40000 ALTER TABLE `gradeyear` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `notifications`
--

DROP TABLE IF EXISTS `notifications`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `notifications` (
  `NotificationId` int NOT NULL AUTO_INCREMENT,
  `SenderRoleId` int NOT NULL,
  `TeacherId` int NOT NULL,
  `StudentId` int NOT NULL,
  `Date` date DEFAULT NULL,
  `MessageHeading` varchar(500) DEFAULT NULL,
  `MessageBody` varchar(5000) DEFAULT NULL,
  PRIMARY KEY (`NotificationId`),
  KEY `StudentId_idx` (`StudentId`),
  KEY `TeacherId_idx` (`TeacherId`),
  CONSTRAINT `NoStudentId` FOREIGN KEY (`StudentId`) REFERENCES `student` (`Id`),
  CONSTRAINT `NoTeacherId` FOREIGN KEY (`TeacherId`) REFERENCES `teacher` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `notifications`
--

LOCK TABLES `notifications` WRITE;
/*!40000 ALTER TABLE `notifications` DISABLE KEYS */;
INSERT INTO `notifications` VALUES (2,2,5,5,'2025-00-28','You have been scheduled for a tutoring session','Teacher: Adam\nTime: 09:00 - 10:00\nCost: 909'),(5,2,5,5,'2025-04-28','Tutoring Session on 4/28/2025','You have been scheduled for a tutoring session\r\nSubject:Math\r\nTeacher: Adam\r\nDate: 4/28/2025\r\nTime: 12:00 - 13:00\r\nCost: 34'),(15,2,5,5,'2025-04-29','Tutoring Session on 4/29/2025','You have been scheduled for a tutoring session\r\nSubject:History\r\nTeacher: Adam\r\nDate: 4/29/2025\r\nTime: 10:00 - 11:00\r\nCost: 4345'),(18,2,5,5,'2025-04-29','Tutoring Session on 4/29/2025','You have been scheduled for a tutoring session\r\nSubject:History\r\nTeacher: Adam\r\nDate: 4/29/2025\r\nTime: 09:00 - 10:00\r\nCost: 190'),(24,2,5,4,'2025-05-01','Tutoring Session on 5/1/2025','You have been scheduled for a tutoring session\r\nSubject:Literature\r\nTeacher: Adam\r\nDate: 5/1/2025\r\nTime: 09:00 - 10:00\r\nCost: 11'),(26,2,5,4,'2025-05-02','Tutoring Session on 5/2/2025','You have been scheduled for a tutoring session\r\nSubject:History\r\nTeacher: Adam\r\nDate: 5/2/2025\r\nTime: 08:00 - 09:00\r\nCost: 777'),(27,2,5,4,'2025-05-02','Tutoring Session on 5/2/2025','You have been scheduled for a tutoring session\r\nSubject:Literature\r\nTeacher: Adam\r\nDate: 5/2/2025\r\nTime: 09:00 - 10:00\r\nCost: 999'),(28,2,5,5,'2025-05-03','Tutoring Session on 5/3/2025','You have been scheduled for a tutoring session\r\nSubject:Literature\r\nTeacher: Adam\r\nDate: 5/3/2025\r\nTime: 08:00 - 09:00\r\nCost: 333');
/*!40000 ALTER TABLE `notifications` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `payments`
--

DROP TABLE IF EXISTS `payments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `payments` (
  `AccountId` int NOT NULL AUTO_INCREMENT,
  `Date` datetime NOT NULL,
  `Amount` decimal(10,2) NOT NULL,
  `Type` varchar(50) NOT NULL,
  PRIMARY KEY (`AccountId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `payments`
--

LOCK TABLES `payments` WRITE;
/*!40000 ALTER TABLE `payments` DISABLE KEYS */;
/*!40000 ALTER TABLE `payments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `session`
--

DROP TABLE IF EXISTS `session`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `session` (
  `SessionId` int NOT NULL AUTO_INCREMENT,
  `StudentId` int NOT NULL,
  `TeacherId` int NOT NULL,
  `SessionDate` date NOT NULL,
  `SubjectId` int NOT NULL,
  `TimeSlot` varchar(50) NOT NULL,
  `Cost` decimal(10,2) NOT NULL,
  PRIMARY KEY (`SessionId`),
  KEY `StudentId_idx` (`StudentId`),
  KEY `TeacherId_idx` (`TeacherId`),
  KEY `SubjectId_idx` (`SubjectId`),
  CONSTRAINT `StudentId` FOREIGN KEY (`StudentId`) REFERENCES `student` (`Id`),
  CONSTRAINT `SubjectId` FOREIGN KEY (`SubjectId`) REFERENCES `subject` (`SubjectId`),
  CONSTRAINT `TeacherId` FOREIGN KEY (`TeacherId`) REFERENCES `teacher` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=50 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `session`
--

LOCK TABLES `session` WRITE;
/*!40000 ALTER TABLE `session` DISABLE KEYS */;
INSERT INTO `session` VALUES (3,5,6,'2026-03-03',3,'3:00 PM',150.00),(37,4,5,'2025-04-28',3,'18:00 - 19:00',9.00),(38,4,5,'2025-04-28',2,'19:00 - 20:00',1.00),(39,4,5,'2025-04-29',3,'08:00 - 09:00',43.00),(40,5,5,'2025-04-29',3,'10:00 - 11:00',4345.00),(41,5,5,'2025-04-29',3,'09:00 - 10:00',190.00),(42,4,5,'2025-04-29',2,'11:00 - 12:00',80.00),(43,4,5,'2025-04-29',2,'14:00 - 15:00',89.00),(44,4,5,'2025-05-01',3,'08:00 - 09:00',88.00),(45,4,5,'2025-05-01',2,'09:00 - 10:00',11.00),(46,4,5,'2025-05-01',1,'10:00 - 11:00',90.00),(47,4,5,'2025-05-02',3,'08:00 - 09:00',777.00),(48,4,5,'2025-05-02',2,'09:00 - 10:00',999.00),(49,5,5,'2025-05-03',2,'08:00 - 09:00',333.00);
/*!40000 ALTER TABLE `session` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `student`
--

DROP TABLE IF EXISTS `student`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `student` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL,
  `GradeId` int NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Phone` varchar(50) NOT NULL,
  `Bio` varchar(5000) NOT NULL,
  `TotalBudget` decimal(10,0) NOT NULL,
  `SubjectName` varchar(50) NOT NULL,
  `UserName` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `ClassId` int NOT NULL,
  `ImageStudent` longblob,
  `Address` varchar(50) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `GradeId_idx` (`GradeId`),
  KEY `ClassId_idx` (`ClassId`),
  CONSTRAINT `ClassId` FOREIGN KEY (`ClassId`) REFERENCES `classid` (`ClassId`),
  CONSTRAINT `GradeId` FOREIGN KEY (`GradeId`) REFERENCES `gradeyear` (`GradeId`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `student`
--

LOCK TABLES `student` WRITE;
/*!40000 ALTER TABLE `student` DISABLE KEYS */;
INSERT INTO `student` VALUES (4,'John',2,'Example@gmail.com','715-773-1111','John is named John',500,'Math','john','password',1,NULL,'123 Easy Street'),(5,'Jane',2,'OtherEmail@gmail.com','898-232-1111','Jane is named Jane',1000,'does','jane','password2',2,NULL,'streetaddress1');
/*!40000 ALTER TABLE `student` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `subject`
--

DROP TABLE IF EXISTS `subject`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `subject` (
  `SubjectId` int NOT NULL AUTO_INCREMENT,
  `SuGradeId` int NOT NULL,
  `SubjectName` varchar(50) NOT NULL,
  `GradeLetter` varchar(50) NOT NULL,
  PRIMARY KEY (`SubjectId`),
  KEY `GradeId_idx` (`SuGradeId`),
  CONSTRAINT `SuGradeId` FOREIGN KEY (`SuGradeId`) REFERENCES `gradeyear` (`GradeId`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `subject`
--

LOCK TABLES `subject` WRITE;
/*!40000 ALTER TABLE `subject` DISABLE KEYS */;
INSERT INTO `subject` VALUES (1,1,'Math','A'),(2,2,'Literature','B'),(3,3,'History','C');
/*!40000 ALTER TABLE `subject` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `teacher`
--

DROP TABLE IF EXISTS `teacher`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `teacher` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `AdminId` int NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Phone` varchar(50) NOT NULL,
  `UserName` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `TeClassId` int NOT NULL,
  `ImageTeacher` longblob,
  `Address` varchar(50) NOT NULL,
  `Bio` varchar(5000) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `AdminId_idx` (`AdminId`),
  KEY `ClassId_idx` (`TeClassId`),
  CONSTRAINT `AdminId` FOREIGN KEY (`AdminId`) REFERENCES `admin` (`Id`),
  CONSTRAINT `TeClassId` FOREIGN KEY (`TeClassId`) REFERENCES `classid` (`ClassId`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `teacher`
--

LOCK TABLES `teacher` WRITE;
/*!40000 ALTER TABLE `teacher` DISABLE KEYS */;
INSERT INTO `teacher` VALUES (5,1,'Adam','Example@gmail.com','715-773-1111','adam','password',1,NULL,'456 Not As Easy Street','I am Adam'),(6,1,'Steve','Teacher@email.com','717-909-2434','steve','password2',2,NULL,'678 Another Street','I am Steve');
/*!40000 ALTER TABLE `teacher` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-05-03 20:28:42
