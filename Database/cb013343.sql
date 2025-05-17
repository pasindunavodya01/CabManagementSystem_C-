-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 17, 2025 at 02:56 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `cb013343`
--

-- --------------------------------------------------------

--
-- Table structure for table `admins`
--

CREATE TABLE `admins` (
  `AdminId` int(11) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `ContactNumber` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `admins`
--

INSERT INTO `admins` (`AdminId`, `Name`, `ContactNumber`) VALUES
(1, 'Admin2', '0987654321'),
(2, 'Sandun', '2345646832'),
(3, 'final1', '1234567898'),
(4, 'June9A', '5432345678'),
(5, 'June10A', '4566785956');

-- --------------------------------------------------------

--
-- Table structure for table `cars`
--

CREATE TABLE `cars` (
  `CarId` int(11) NOT NULL,
  `Model` varchar(255) NOT NULL,
  `PlateNumber` varchar(255) NOT NULL,
  `Availability` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `cars`
--

INSERT INTO `cars` (`CarId`, `Model`, `PlateNumber`, `Availability`) VALUES
(7, 'Honda Civic', 'CAD_2345', 0),
(8, 'Suzuki Swift', 'CAR_1234', 0),
(9, 'Honda Civic', 'CAS-2345', 0),
(12, 'Toyota Ch-r', 'CBB-1828', 1),
(16, 'Toyota Vitz', 'KX-3749', 1),
(17, 'Tesla X', 'CBH-2265', 1),
(19, 'Toyota Hilux', 'PK-3744', 0),
(20, 'Nissan Bluebird', 'GH-3425', 1);

-- --------------------------------------------------------

--
-- Table structure for table `customers`
--

CREATE TABLE `customers` (
  `CustomerId` int(11) NOT NULL,
  `Name` varchar(255) DEFAULT NULL,
  `ContactNumber` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `customers`
--

INSERT INTO `customers` (`CustomerId`, `Name`, `ContactNumber`) VALUES
(1, 'John Doe', '+1234567890'),
(2, 'Pasindu', '1234567890'),
(3, 'cus1', '1234567890'),
(4, 'cus2', '123457897'),
(5, 'cus3', '3456789654'),
(6, 'Cus5', '1234567890'),
(7, 'Cus5', '1234567890'),
(8, 'cus6', '2345432134'),
(9, 'cus7', '4534728459'),
(10, 'cus', '345678895'),
(11, 'ccs', '23456796009'),
(12, 'Test1', '1234567890'),
(13, 't4', '3456758334'),
(14, 'finalc', '1235432456'),
(15, 'June6', '1234567897'),
(16, 'June9', '234567876'),
(17, 'June10', '7869567869');

-- --------------------------------------------------------

--
-- Table structure for table `drivers`
--

CREATE TABLE `drivers` (
  `DriverId` int(11) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `ContactNumber` varchar(255) NOT NULL,
  `Availability` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `drivers`
--

INSERT INTO `drivers` (`DriverId`, `Name`, `ContactNumber`, `Availability`) VALUES
(4, 'Pasindu', '1234567890', 1),
(5, 'Navodya', '2345678901', 0),
(7, 'Senesh', '234567876', 1),
(8, 'Nickel', '2345768901', 0),
(9, 'Dhulvin', '2343213456', 1),
(10, 'Kamal', '234565434', 1),
(11, 'Sanka', '2345686593', 1);

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE `orders` (
  `OrderId` int(11) NOT NULL,
  `CustomerId` int(11) DEFAULT NULL,
  `CarId` int(11) DEFAULT NULL,
  `DriverId` int(11) DEFAULT NULL,
  `OrderDate` datetime DEFAULT NULL,
  `CurrentLocation` varchar(255) DEFAULT NULL,
  `Destination` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `orders`
--

INSERT INTO `orders` (`OrderId`, `CustomerId`, `CarId`, `DriverId`, `OrderDate`, `CurrentLocation`, `Destination`) VALUES
(1, 1, 7, 4, '2024-05-01 00:00:00', NULL, NULL),
(2, 2, 8, 5, '2024-05-02 00:00:00', NULL, NULL),
(11, 1, 7, 5, '2024-05-30 19:22:13', NULL, NULL),
(12, 1, 8, 7, '2024-05-30 19:28:03', NULL, NULL),
(13, 1, 12, 8, '2024-05-30 19:31:11', NULL, NULL),
(14, 1, 16, 5, '2024-05-30 19:32:51', NULL, NULL),
(15, 1, 7, 4, '2024-05-30 21:04:19', 'l1', 'l2'),
(16, 1, 7, 4, '2024-05-30 21:13:02', 'l2', 'l2'),
(17, 1, 7, 4, '2024-05-30 21:25:01', 'l4', 'l3'),
(18, 1, 9, 5, '2024-05-30 21:25:51', 'Colombo', 'Negombo'),
(19, 1, 12, 5, '2024-05-30 22:01:10', 'Colombo', 'Negombo'),
(20, 1, 8, 4, '2024-05-31 10:50:20', 'Kandana', 'Dematagoda'),
(21, 1, 7, 4, '2024-05-31 11:56:21', 'Kandy', 'Rathnapura'),
(22, 1, 8, 7, '2024-05-31 15:28:32', 'America', 'Australia'),
(26, 1, 9, 8, '2024-05-31 16:07:47', 'jh', 'hh'),
(27, 1, 8, 4, '2024-05-31 16:19:09', 'jk', 'df'),
(28, NULL, 8, 4, '2024-05-31 21:02:38', 't2', 't2'),
(29, 1, 12, 8, '2024-05-31 21:07:32', 'gd', 'dj'),
(35, 1, 7, 4, '2024-05-31 21:26:19', 'ljkl', 'kjklj'),
(36, 1, 8, 5, '2024-05-31 21:28:54', 'kkl', 'lkl'),
(37, 1, 12, 7, '2024-05-31 21:34:31', 'klj', 'jk'),
(38, 2, 16, 8, '2024-05-31 21:58:57', 't4', 't4'),
(43, 7, 7, 4, '2024-05-31 22:22:02', 'lk', 'kl'),
(45, 9, 7, 8, '2024-05-31 22:35:15', 'th', 'bg'),
(46, 12, 7, 4, '2024-05-31 22:38:02', '12', '23'),
(47, 14, 8, 5, '2024-05-31 22:40:25', 'finalc', 'finald'),
(48, 14, 12, 7, '2024-05-31 22:40:57', 'finalc', 'finald'),
(49, 10, 16, 8, '2024-05-31 22:42:50', 'tt', 'tt'),
(50, 15, 8, 5, '2024-06-08 15:43:58', 'june6', 'June6'),
(51, 9, 7, 4, '2024-06-09 00:33:22', 'Mathara', 'Kandy'),
(52, 16, 9, 7, '2024-06-09 15:51:21', 'J9C', 'J9D'),
(53, 7, 7, 4, '2024-06-09 19:49:57', 'test', 'test'),
(54, 7, 12, 5, '2024-06-09 19:52:57', 'test2', 'test2'),
(55, 7, 16, 8, '2024-06-09 19:56:02', 'test3', 'test3'),
(56, 7, 17, 9, '2024-06-09 20:00:48', 'test4', 'test4'),
(57, 7, 19, 10, '2024-06-09 20:18:29', 'test5', 'test5'),
(58, 17, 7, 4, '2024-06-10 11:50:43', 'June10C', 'June10D'),
(59, 17, 8, 5, '2024-06-10 12:23:17', 'Negombo', 'Kurana'),
(60, 17, 9, 7, '2024-06-10 12:34:44', 'Negombo', 'Kurana'),
(61, 7, 12, 8, '2024-06-10 12:35:19', 'Kandy', 'Rathnapura'),
(62, 7, 7, 8, '2024-06-19 15:59:11', 'Test C', 'Test D');

-- --------------------------------------------------------

--
-- Table structure for table `person`
--

CREATE TABLE `person` (
  `Id` varchar(4) NOT NULL,
  `Name` varchar(15) NOT NULL,
  `ContactNumber` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `user_id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(100) NOT NULL,
  `role` enum('admin','customer') NOT NULL,
  `CustomerId` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`user_id`, `username`, `password`, `role`, `CustomerId`) VALUES
(1, 'admin', 'admin', 'admin', NULL),
(2, 'admin1', 'admin1', 'admin', NULL),
(3, 'pasindu', '123pasindu', 'customer', NULL),
(4, 'admin2', 'admin2', 'admin', NULL),
(5, 'admin3', 'admin3', 'admin', NULL),
(6, 'cus1', 'cus1', 'customer', NULL),
(7, 'cus2', 'cus2', 'customer', NULL),
(8, 'cus3', 'cus3', 'customer', NULL),
(9, 'cus5', 'cus5', 'customer', 7),
(10, 'cus6', 'cus6', 'customer', 8),
(11, 'cus7', 'cus7', 'customer', 9),
(12, 'cus', 'cus', 'customer', 10),
(13, 'cc1', 'cc1', 'customer', NULL),
(14, 'test1', 'test1', 'customer', 12),
(15, 't4', 't4', 'customer', 13),
(16, 'final', 'final', 'admin', NULL),
(17, 'finalc', 'finalc', 'customer', 14),
(18, 'june6', 'june6', 'customer', 15),
(19, 'june9c', 'june9c', 'customer', 16),
(20, 'june9a', 'june9a', 'admin', NULL),
(21, 'june10', 'june10', 'customer', 17),
(22, 'june10a', 'june10a', 'admin', NULL);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admins`
--
ALTER TABLE `admins`
  ADD PRIMARY KEY (`AdminId`);

--
-- Indexes for table `cars`
--
ALTER TABLE `cars`
  ADD PRIMARY KEY (`CarId`);

--
-- Indexes for table `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`CustomerId`);

--
-- Indexes for table `drivers`
--
ALTER TABLE `drivers`
  ADD PRIMARY KEY (`DriverId`);

--
-- Indexes for table `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`OrderId`),
  ADD KEY `CustomerId` (`CustomerId`),
  ADD KEY `DriverId` (`DriverId`),
  ADD KEY `fk_cars_id` (`CarId`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`user_id`),
  ADD UNIQUE KEY `username` (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admins`
--
ALTER TABLE `admins`
  MODIFY `AdminId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `cars`
--
ALTER TABLE `cars`
  MODIFY `CarId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT for table `customers`
--
ALTER TABLE `customers`
  MODIFY `CustomerId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `drivers`
--
ALTER TABLE `drivers`
  MODIFY `DriverId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `orders`
--
ALTER TABLE `orders`
  MODIFY `OrderId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=63;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `orders`
--
ALTER TABLE `orders`
  ADD CONSTRAINT `fk_cars_id` FOREIGN KEY (`CarId`) REFERENCES `cars` (`CarId`) ON DELETE NO ACTION,
  ADD CONSTRAINT `orders_ibfk_1` FOREIGN KEY (`CustomerId`) REFERENCES `customers` (`CustomerId`),
  ADD CONSTRAINT `orders_ibfk_2` FOREIGN KEY (`CarId`) REFERENCES `cars` (`CarId`),
  ADD CONSTRAINT `orders_ibfk_3` FOREIGN KEY (`DriverId`) REFERENCES `drivers` (`DriverId`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
