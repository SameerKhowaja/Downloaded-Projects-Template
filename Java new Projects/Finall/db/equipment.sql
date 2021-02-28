-- phpMyAdmin SQL Dump
-- version 3.3.9
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: May 24, 2016 at 06:09 PM
-- Server version: 5.5.8
-- PHP Version: 5.3.5

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `equipment`
--

-- --------------------------------------------------------

--
-- Table structure for table `allocated`
--

CREATE TABLE IF NOT EXISTS `allocated` (
  `allocid` varchar(100) NOT NULL,
  `username` varchar(100) NOT NULL,
  `itemid` varchar(100) NOT NULL,
  `qty` int(100) NOT NULL,
  `datealloc` date NOT NULL,
  `status` varchar(100) NOT NULL,
  PRIMARY KEY (`allocid`),
  KEY `itemid` (`itemid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `allocated`
--


-- --------------------------------------------------------

--
-- Table structure for table `category`
--

CREATE TABLE IF NOT EXISTS `category` (
  `cateid` int(11) NOT NULL AUTO_INCREMENT,
  `role` varchar(100) NOT NULL,
  PRIMARY KEY (`cateid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

--
-- Dumping data for table `category`
--


-- --------------------------------------------------------

--
-- Table structure for table `course`
--

CREATE TABLE IF NOT EXISTS `course` (
  `coursid` varchar(45) NOT NULL,
  `crsename` varchar(100) NOT NULL,
  PRIMARY KEY (`coursid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `course`
--

INSERT INTO `course` (`coursid`, `crsename`) VALUES
('BAM', 'bachelors of bussiness'),
('BIT', 'bachelors of IT'),
('EDS', 'development studies');

-- --------------------------------------------------------

--
-- Table structure for table `dept`
--

CREATE TABLE IF NOT EXISTS `dept` (
  `deptid` varchar(10) NOT NULL,
  `deptname` varchar(100) NOT NULL,
  PRIMARY KEY (`deptid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `dept`
--

INSERT INTO `dept` (`deptid`, `deptname`) VALUES
('BAM', 'Bachelor of BAM'),
('BIT', 'bachelors of IT');

-- --------------------------------------------------------

--
-- Table structure for table `items`
--

CREATE TABLE IF NOT EXISTS `items` (
  `itemid` varchar(100) NOT NULL,
  `itemname` varchar(100) NOT NULL,
  `itemType` varchar(100) DEFAULT NULL,
  `storeid` varchar(100) NOT NULL,
  `status` varchar(100) NOT NULL,
  PRIMARY KEY (`itemid`),
  KEY `items_ibfk_1` (`itemType`),
  KEY `items_ibfk_2` (`storeid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `items`
--

INSERT INTO `items` (`itemid`, `itemname`, `itemType`, `storeid`, `status`) VALUES
('COMP', 'ACCER lAPTOP', '22', 'BB01', 'new'),
('COMP2', 'ACCER lAPTOP', '22', 'BB01', 'damaged');

-- --------------------------------------------------------

--
-- Table structure for table `itemtype`
--

CREATE TABLE IF NOT EXISTS `itemtype` (
  `itemType` varchar(45) NOT NULL,
  `tyname` varchar(100) NOT NULL,
  PRIMARY KEY (`itemType`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `itemtype`
--

INSERT INTO `itemtype` (`itemType`, `tyname`) VALUES
('22', 'Stationary');

-- --------------------------------------------------------

--
-- Table structure for table `programs`
--

CREATE TABLE IF NOT EXISTS `programs` (
  `progId` varchar(30) NOT NULL,
  `progname` varchar(100) NOT NULL,
  PRIMARY KEY (`progId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `programs`
--

INSERT INTO `programs` (`progId`, `progname`) VALUES
('WKEND', 'weekend');

-- --------------------------------------------------------

--
-- Table structure for table `returned`
--

CREATE TABLE IF NOT EXISTS `returned` (
  `returnedid` varchar(50) NOT NULL,
  `allocid` varchar(100) NOT NULL,
  `qty` int(100) NOT NULL,
  `date` date NOT NULL,
  `status` varchar(100) NOT NULL,
  PRIMARY KEY (`returnedid`),
  KEY `allocid` (`allocid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `returned`
--


-- --------------------------------------------------------

--
-- Table structure for table `staff`
--

CREATE TABLE IF NOT EXISTS `staff` (
  `staffId` varchar(50) NOT NULL,
  `username` varchar(100) NOT NULL,
  `fname` varchar(100) NOT NULL,
  `lname` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `sex` varchar(10) NOT NULL,
  `contact` int(15) NOT NULL,
  `dep` varchar(20) NOT NULL,
  `status` varchar(100) NOT NULL,
  PRIMARY KEY (`staffId`),
  KEY `dep` (`dep`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `staff`
--

INSERT INTO `staff` (`staffId`, `username`, `fname`, `lname`, `email`, `sex`, `contact`, `dep`, `status`) VALUES
('B726', 'student', 'sada', 'asd', 'sdf', 'Male', 203908, 'BAM', 'active'),
('BIT02', 'student', 'sanyu', 'jose', 'sanyu@gmail.com', 'Male', 701000298, 'BIT', 'active');

-- --------------------------------------------------------

--
-- Table structure for table `store`
--

CREATE TABLE IF NOT EXISTS `store` (
  `storeid` varchar(50) NOT NULL,
  `storename` varchar(100) NOT NULL,
  PRIMARY KEY (`storeid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `store`
--

INSERT INTO `store` (`storeid`, `storename`) VALUES
('BB01', 'KKKAUYKG');

-- --------------------------------------------------------

--
-- Table structure for table `student`
--

CREATE TABLE IF NOT EXISTS `student` (
  `regNo` varchar(30) NOT NULL,
  `username` varchar(100) NOT NULL,
  `fname` varchar(100) NOT NULL,
  `lname` varchar(100) NOT NULL,
  `sex` varchar(10) NOT NULL,
  `contact` int(33) NOT NULL,
  `progid` varchar(30) NOT NULL,
  `crseid` varchar(34) NOT NULL,
  `status` varchar(100) NOT NULL,
  PRIMARY KEY (`regNo`),
  KEY `progid` (`progid`),
  KEY `crseid` (`crseid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `student`
--

INSERT INTO `student` (`regNo`, `username`, `fname`, `lname`, `sex`, `contact`, `progid`, `crseid`, `status`) VALUES
('2013-B071-70007', 'neville', 'kafeero', 'samuel', 'Male', 896376093, 'WKEND', 'BIT', 'disabled'),
('2013-B071-70009', 'neville', 'kafeero', 'samuel', 'Male', 896376093, 'WKEND', 'BIT', 'disabled'),
('2013-B071-70012', 'neville', 'Neville', 'Mwije', 'Male', 293892922, 'WKEND', 'BIT', 'active'),
('2013-B071-70013', 'student', 'Samuel', 'Kafero', 'Male', 293892922, 'WKEND', 'BIT', 'active');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE IF NOT EXISTS `users` (
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  `role` varchar(20) NOT NULL,
  PRIMARY KEY (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`username`, `password`, `role`) VALUES
('neville', 'neville', 'Admin'),
('student', 'student', 'user');

--
-- Constraints for dumped tables
--

--
-- Constraints for table `allocated`
--
ALTER TABLE `allocated`
  ADD CONSTRAINT `allocated_ibfk_1` FOREIGN KEY (`itemid`) REFERENCES `items` (`itemid`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `allocated_ibfk_2` FOREIGN KEY (`itemid`) REFERENCES `items` (`itemid`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `items`
--
ALTER TABLE `items`
  ADD CONSTRAINT `items_ibfk_1` FOREIGN KEY (`itemType`) REFERENCES `itemtype` (`itemType`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `items_ibfk_2` FOREIGN KEY (`storeid`) REFERENCES `store` (`storeid`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `returned`
--
ALTER TABLE `returned`
  ADD CONSTRAINT `returned_ibfk_1` FOREIGN KEY (`allocid`) REFERENCES `allocated` (`allocid`) ON DELETE CASCADE ON UPDATE CASCADE;
