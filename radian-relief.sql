-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 09, 2020 at 07:20 PM
-- Server version: 10.1.36-MariaDB
-- PHP Version: 7.2.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `radian-relief`
--

-- --------------------------------------------------------

--
-- Table structure for table `class`
--

CREATE TABLE `class` (
  `No` int(11) NOT NULL,
  `Name` text NOT NULL,
  `One` int(11) NOT NULL,
  `Two` int(11) NOT NULL,
  `Three` int(11) NOT NULL,
  `Four` int(11) NOT NULL,
  `Five` int(11) NOT NULL,
  `Six` int(11) NOT NULL,
  `Seven` int(11) NOT NULL,
  `Eight` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Table structure for table `subject`
--

CREATE TABLE `subject` (
  `No` int(11) NOT NULL,
  `Name` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Table structure for table `teacher`
--

CREATE TABLE `teacher` (
  `No` int(11) NOT NULL,
  `Name` text NOT NULL,
  `Section` text,
  `One` int(11) DEFAULT '0',
  `Two` int(11) DEFAULT '0',
  `Three` int(11) DEFAULT '0',
  `Four` int(11) DEFAULT '0',
  `Five` int(11) DEFAULT '0',
  `Six` int(11) DEFAULT '0',
  `Seven` int(11) DEFAULT '0',
  `Eight` int(11) DEFAULT '0',
  `Present` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `class`
--
ALTER TABLE `class`
  ADD PRIMARY KEY (`No`);

--
-- Indexes for table `subject`
--
ALTER TABLE `subject`
  ADD PRIMARY KEY (`No`);

--
-- Indexes for table `teacher`
--
ALTER TABLE `teacher`
  ADD UNIQUE KEY `No` (`No`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
