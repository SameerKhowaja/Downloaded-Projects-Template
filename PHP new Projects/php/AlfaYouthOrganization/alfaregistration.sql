-- phpMyAdmin SQL Dump
-- version 3.2.0.1
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Jun 03, 2015 at 09:03 AM
-- Server version: 5.1.36
-- PHP Version: 5.3.0

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";

--
-- Database: `alfaregistration`
--

-- --------------------------------------------------------

--
-- Table structure for table `members`
--

CREATE TABLE IF NOT EXISTS `members` (
  `UserID` int(11) NOT NULL AUTO_INCREMENT,
  `FirstName` varchar(100) DEFAULT NULL,
  `LastName` varchar(100) DEFAULT NULL,
  `UserName` varchar(100) DEFAULT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `Password` varchar(100) DEFAULT NULL,
  `RegTime` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `UserLevel` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`UserID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `members`
--

INSERT INTO `members` (`UserID`, `FirstName`, `LastName`, `UserName`, `Email`, `Password`, `RegTime`, `UserLevel`) VALUES
(1, 'kithinji', 'GODFREY', 'king', 'godkith19@gmail.com', '1234', '2015-05-28 09:59:32', 0),
(2, 'mworia ', 'john', 'jm', 'JM@gmail.com', '1234', '2015-05-29 14:20:07', 0);
