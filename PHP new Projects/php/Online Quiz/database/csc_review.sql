-- phpMyAdmin SQL Dump
-- version 4.0.4
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Jun 02, 2016 at 04:59 AM
-- Server version: 5.6.12-log
-- PHP Version: 5.4.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `csc_review`
--
CREATE DATABASE IF NOT EXISTS `csc_review` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `csc_review`;

-- --------------------------------------------------------

--
-- Table structure for table `person`
--

CREATE TABLE IF NOT EXISTS `person` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Firstname` varchar(255) NOT NULL,
  `Lastname` varchar(255) NOT NULL,
  `Middlename` varchar(255) NOT NULL,
  `Address` varchar(255) NOT NULL,
  `Gender` varchar(255) NOT NULL,
  `Age` int(11) NOT NULL,
  `Score` int(11) NOT NULL,
  `Remarks` varchar(255) NOT NULL,
  `Imagename` varchar(255) NOT NULL,
  `Imagepath` varchar(255) NOT NULL,
  `Imagetype` varchar(255) NOT NULL,
  `Deleted` int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=73 ;

--
-- Dumping data for table `person`
--

INSERT INTO `person` (`ID`, `Firstname`, `Lastname`, `Middlename`, `Address`, `Gender`, `Age`, `Score`, `Remarks`, `Imagename`, `Imagepath`, `Imagetype`, `Deleted`) VALUES
(58, 'Janine', 'Antenor', 'Monterey', 'Pili, Mogpog', 'FEMALE', 20, 19, 'PASSED', 'default.png', 'uploaded_pic/default.png', 'PNG', 0),
(59, 'Keylyn', 'Falsceso', 'Narvas', 'Masiga, Gasan', 'FEMALE', 29, 17, 'PASSED', 'default.png', 'uploaded_pic/default.png', 'PNG', 1),
(60, 'Glenda', 'Soberano', 'Madrigal', 'Sta. Barbara, San Mateo Rizal', 'FEMALE', 34, 2, 'FAILED', 'default.png', 'uploaded_pic/default.png', 'PNG', 0),
(61, 'John Wilson', 'Marapya', 'Macalintal', 'Lipa, Batangas', 'MALE', 21, 2, 'FAILED', 'default.png', 'uploaded_pic/default.png', 'PNG', 0),
(62, 'Angelica Rose', 'Naling', 'Quinto', 'Pawa, Boac', 'FEMALE', 20, 17, 'PASSED', 'default.png', 'uploaded_pic/default.png', 'PNG', 0),
(64, 'Rertertre', 'Reyeryreet', 'Reytry', 'Ertyery', 'FEMALE', 18, 8, 'FAILED', '19.jpg', 'uploaded_pic/19.jpg', 'image/jpeg', 0),
(65, 'tyrtyet', 'ertyry', 'reyrt', 'rrrrrrrrrrrrrrrr', 'MALE', 21, 8, 'FAILED', 'ayala6.jpg', 'uploaded_pic/ayala6.jpg', 'image/jpeg', 0),
(66, 'gfdfgfg', 'dfgdfg', 'dgdfgfgdf', 'dfgdfgfg', 'FEMALE', 24, 8, 'FAILED', 'default.png', 'uploaded_pic/default.png', 'PNG', 0),
(67, 'John Matthews', 'Mascarenas', 'Cruzado', 'Balimbing,Boac', 'MALE', 21, 18, 'PASSED', 'default.png', 'uploaded_pic/default.png', 'PNG', 0),
(68, 'erteerte', 'rtet', 'ete', 'erte', 'MALE', 23, 1, 'FAILED', 'default.png', 'uploaded_pic/default.png', 'PNG', 0),
(69, 'rwer', 'ewr', 'wer', 'erwr', 'FEMALE', 23, 0, 'FAILED', 'default.png', 'uploaded_pic/default.png', 'PNG', 0),
(70, 'John Matthews', 'Mascarenas', 'Cruzado', 'Balimbing, Boac', 'MALE', 21, 15, 'PASSED', 'ACER - matty.png', 'uploaded_pic/ACER - matty.png', 'image/png', 0),
(71, 'John Matthew', 'Mascarenas', 'Cruzado', 'Balimbing', 'MALE', 19, 3, 'FAILED', 'matthews mascarenas.jpg', 'uploaded_pic/matthews mascarenas.jpg', 'image/jpeg', 0),
(72, 'Janine', 'Antenor', 'Monterey', 'Pili', 'FEMALE', 19, 6, 'FAILED', 'default.png', 'uploaded_pic/default.png', 'PNG', 1);

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE IF NOT EXISTS `user` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Username` varchar(255) NOT NULL,
  `Password` varchar(255) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`ID`, `Username`, `Password`) VALUES
(2, 'matthew', 'matthew');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
