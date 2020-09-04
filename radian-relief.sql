-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 04, 2020 at 10:09 AM
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
-- Table structure for table `fri`
--

CREATE TABLE `fri` (
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
-- Table structure for table `mon`
--

CREATE TABLE `mon` (
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

-- --------------------------------------------------------

--
-- Table structure for table `section`
--

CREATE TABLE `section` (
  `No` int(11) NOT NULL,
  `Name` text NOT NULL
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
  `TeacherID` text NOT NULL,
  `Section` int(11) DEFAULT '0',
  `TPNo` text NOT NULL,
  `One` int(11) DEFAULT '0',
  `Two` int(11) DEFAULT '0',
  `Three` int(11) DEFAULT '0',
  `Four` int(11) DEFAULT '0',
  `Five` int(11) DEFAULT '0',
  `Six` int(11) DEFAULT '0',
  `Seven` int(11) DEFAULT '0',
  `Eight` int(11) DEFAULT '0',
  `Present` int(11) DEFAULT NULL,
  `English_Lit` int(11) DEFAULT NULL,
  `Tamil` int(11) DEFAULT NULL,
  `Drama` int(11) DEFAULT NULL,
  `Dancing` int(11) DEFAULT NULL,
  `Music` int(11) DEFAULT NULL,
  `Buddhism` int(11) DEFAULT NULL,
  `Health` int(11) DEFAULT NULL,
  `Art` int(11) DEFAULT NULL,
  `History` int(11) DEFAULT NULL,
  `Geography` int(11) DEFAULT NULL,
  `ICT` int(11) DEFAULT NULL,
  `PTS` int(11) DEFAULT NULL,
  `LCCE` int(11) DEFAULT NULL,
  `Sinhala` int(11) DEFAULT NULL,
  `English` int(11) DEFAULT NULL,
  `Science` int(11) DEFAULT NULL,
  `Maths` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Table structure for table `thu`
--

CREATE TABLE `thu` (
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

-- --------------------------------------------------------

--
-- Table structure for table `tue`
--

CREATE TABLE `tue` (
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

-- --------------------------------------------------------

--
-- Table structure for table `wed`
--

CREATE TABLE `wed` (
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
-- Indexes for dumped tables
--

--
-- Indexes for table `class`
--
ALTER TABLE `class`
  ADD PRIMARY KEY (`No`);

--
-- Indexes for table `fri`
--
ALTER TABLE `fri`
  ADD PRIMARY KEY (`No`);

--
-- Indexes for table `mon`
--
ALTER TABLE `mon`
  ADD PRIMARY KEY (`No`);

--
-- Indexes for table `section`
--
ALTER TABLE `section`
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

--
-- Indexes for table `thu`
--
ALTER TABLE `thu`
  ADD PRIMARY KEY (`No`);

--
-- Indexes for table `tue`
--
ALTER TABLE `tue`
  ADD PRIMARY KEY (`No`);

--
-- Indexes for table `wed`
--
ALTER TABLE `wed`
  ADD PRIMARY KEY (`No`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
