-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: May 10, 2016 at 01:44 PM
-- Server version: 5.6.17
-- PHP Version: 5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `fpms`
--

-- --------------------------------------------------------

--
-- Table structure for table `accounts`
--

CREATE TABLE IF NOT EXISTS `accounts` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Bank_Name` varchar(200) DEFAULT NULL,
  `Account_Number` varchar(200) DEFAULT NULL,
  `Branch` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=7 ;

--
-- Dumping data for table `accounts`
--

INSERT INTO `accounts` (`id`, `Bank_Name`, `Account_Number`, `Branch`) VALUES
(1, 'LIPA NA MPESA', '11111110', 'Safaricom'),
(2, 'COPARATIVE BANK', '0213289993', 'Meru'),
(3, 'NATIONAL BANK', '099887765666', 'Meru'),
(4, 'COMMERCIAL BANK', '3476374654623', 'Meru'),
(5, 'STARDAND CHARTER', '345646332', 'Meru'),
(6, 'EQUIT BANK', '21242423432', 'Meru');

-- --------------------------------------------------------

--
-- Table structure for table `activity_log`
--

CREATE TABLE IF NOT EXISTS `activity_log` (
  `activity_log_id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(100) NOT NULL,
  `date` varchar(100) NOT NULL,
  `action` varchar(128) NOT NULL,
  PRIMARY KEY (`activity_log_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=44 ;

--
-- Dumping data for table `activity_log`
--

INSERT INTO `activity_log` (`activity_log_id`, `username`, `date`, `action`) VALUES
(23, 'admin', '2016-03-21 12:28:12', 'Add System User admin'),
(24, 'fark murithi', '2016-03-21 12:37:56', 'Added Student scs05'),
(26, 'James Mwenda', '2016-03-21 12:49:28', 'paid fees'),
(27, 'James Mwenda', '2016-03-21 12:51:35', 'paid fees'),
(28, 'James Mwenda', '2016-03-21 12:51:58', 'paid fees'),
(29, 'James Mwenda', '2016-03-21 12:53:07', 'paid fees'),
(30, '', '2016-03-23 10:27:58', 'Added Student '),
(31, 'denis muthamia', '2016-03-23 10:28:22', 'paid fees'),
(32, 'fark murithi', '2016-03-23 11:14:52', 'Added Student scs20'),
(33, 'fark murithi', '2016-03-27 20:41:11', 'Added Student scs19'),
(34, 'mutua stephen', '2016-03-27 20:42:29', 'paid fees'),
(35, '', '2016-03-27 20:43:16', 'Added Student '),
(36, 'mutua stephen', '2016-03-27 20:43:35', 'paid fees'),
(37, 'admin', '2016-03-29 13:07:50', 'Added Student scs06'),
(38, '', '2016-03-29 13:14:13', 'Added Student '),
(39, 'Julius Yego ', '2016-03-29 13:16:25', 'paid fees'),
(40, '', '2016-03-29 16:07:22', 'Added Student '),
(41, 'Julius Yego ', '2016-03-29 16:07:59', 'paid fees'),
(42, '', '2016-03-29 16:09:02', 'Added Student '),
(43, 'Julius Yego ', '2016-03-29 16:10:03', 'paid fees');

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE IF NOT EXISTS `admin` (
  `admin_id` int(128) NOT NULL AUTO_INCREMENT,
  `firstname` varchar(128) NOT NULL,
  `lastname` varchar(128) NOT NULL,
  `username` varchar(128) NOT NULL,
  `password` varchar(128) NOT NULL,
  `adminthumbnails` varchar(300) NOT NULL,
  PRIMARY KEY (`admin_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`admin_id`, `firstname`, `lastname`, `username`, `password`, `adminthumbnails`) VALUES
(1, 'Kithinji', 'Gocdfrey', 'admin', 'admin', 'uploads/IMG_20160228_152154.jpg'),
(2, 'admin', 'admin', 'master', '1234', 'images/NO-IMAGE-AVAILABLE.jpg');

-- --------------------------------------------------------

--
-- Table structure for table `announcement`
--

CREATE TABLE IF NOT EXISTS `announcement` (
  `announcement_id` int(11) NOT NULL AUTO_INCREMENT,
  `title` varchar(20) NOT NULL,
  `content` text NOT NULL,
  PRIMARY KEY (`announcement_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `announcement`
--

INSERT INTO `announcement` (`announcement_id`, `title`, `content`) VALUES
(1, 'notice', 'ALL FEES SHOULD BE PAID THROUGH THE ACCOUNTS GIVEN. NO CASH WILL BE ACCEPTED');

-- --------------------------------------------------------

--
-- Table structure for table `bank`
--

CREATE TABLE IF NOT EXISTS `bank` (
  `slip_number` int(11) NOT NULL AUTO_INCREMENT,
  `Amount` smallint(6) NOT NULL,
  `time` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `bank_name` varchar(32) DEFAULT NULL,
  `balance` int(8) DEFAULT NULL,
  `account` varchar(200) DEFAULT NULL,
  `regno` varchar(200) DEFAULT NULL,
  `name` varchar(200) NOT NULL,
  PRIMARY KEY (`slip_number`),
  UNIQUE KEY `time` (`time`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=22 ;

--
-- Dumping data for table `bank`
--

INSERT INTO `bank` (`slip_number`, `Amount`, `time`, `bank_name`, `balance`, `account`, `regno`, `name`) VALUES
(5, 19000, '2016-03-16 23:45:13', 'national bank', 4000, '102993984', 'scs11', 'kathhurima mularia'),
(6, 23000, '2016-03-17 00:16:40', 'Faulu', 0, '00908765656', 'scs32', 'kithijni gosfrey'),
(7, 20000, '2016-03-17 08:01:18', 'Equity', 3000, '1212223', 'scs21', 'Kareei'),
(8, 5000, '2016-03-17 14:21:33', 'coop', 18000, 'okumu', 'gte545', 'chur chill'),
(9, 20000, '2016-03-18 12:32:01', 'Coop Bank', 3000, '099847747', 'scs12', 'robert cherotich'),
(10, 22344, '2016-03-18 13:01:59', 'Equity', 656, '34242', 'scs31', 'martin muthuri '),
(11, 20000, '2016-03-21 09:48:31', 'KCB', 3000, '34242', 'scs05', 'James Mwenda'),
(12, 19000, '2016-03-21 12:38:25', 'Equity', 4000, '00908765656', 'scs03', 'harun mwau'),
(13, 4000, '2016-03-21 13:22:30', 'equity', 19000, '34242', 'scs03', 'harun mwau'),
(14, 21000, '2016-03-22 13:43:49', 'Equity', 2000, '234342554', 'scs11', 'James Mwenda'),
(15, 21000, '2016-03-23 07:27:58', 'KCB', 2000, '989905940', 'scs10', 'Dennis Muthamia'),
(16, 21700, '2016-03-23 08:18:48', 'KCB', 1300, '43232', 'scs20', 'kevin muinde'),
(17, 15000, '2016-03-24 13:58:28', 'KCB', 8000, '5345252', 'scs03', 'haron mwau'),
(18, 12000, '2016-03-27 17:43:16', 'Equity', 11000, '00908765656', 'scs19', 'mutua stephen'),
(19, 21000, '2016-03-29 10:14:12', 'national bank', 2000, '099887765666', 'scs06', 'Julius Yego'),
(20, 20000, '2016-03-29 13:07:22', 'national bank', 3000, '099887765666', 'scs06', 'julius yego'),
(21, 20000, '2016-03-29 13:09:02', 'national bank', 3000, '099887765666', 'scs06', 'Julius Yego');

-- --------------------------------------------------------

--
-- Table structure for table `constants`
--

CREATE TABLE IF NOT EXISTS `constants` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Fee_expected` smallint(6) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `constants`
--

INSERT INTO `constants` (`id`, `Fee_expected`) VALUES
(1, 23000);

-- --------------------------------------------------------

--
-- Table structure for table `fees`
--

CREATE TABLE IF NOT EXISTS `fees` (
  `fee_id` int(11) NOT NULL AUTO_INCREMENT,
  `fee_paid` int(11) DEFAULT NULL,
  `slip_number` varchar(128) DEFAULT NULL,
  `bank_name` varchar(200) DEFAULT NULL,
  `balance` int(28) DEFAULT NULL,
  `time` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `regno` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`fee_id`),
  UNIQUE KEY `time` (`time`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=23 ;

--
-- Dumping data for table `fees`
--

INSERT INTO `fees` (`fee_id`, `fee_paid`, `slip_number`, `bank_name`, `balance`, `time`, `regno`) VALUES
(3, 12000, '1', 'National Bank', 11000, '2016-03-16 22:42:16', 'scs32'),
(8, 20000, '9', 'Coop Bank', 3000, '2016-03-18 12:41:35', 'scs32'),
(9, 5000, '8', 'coop', 18000, '2016-03-18 12:48:20', 'scs12'),
(10, 23000, '6', 'Faulu', 0, '2016-03-18 13:09:31', 'scs32'),
(11, 20000, '11', 'KCB', 3000, '2016-03-21 09:49:28', 'scs05'),
(12, 19000, '5', 'national bank', 4000, '2016-03-21 09:53:07', 'scs11'),
(13, 19000, '12', 'Equity', 4000, '2016-03-21 12:38:48', 'scs03'),
(14, 4000, '13', 'equity', 19000, '2016-03-21 13:23:38', 'scs03'),
(15, 21000, '14', 'Equity', 2000, '2016-03-22 13:46:23', 'scs11'),
(16, 21000, '15', 'KCB', 2000, '2016-03-23 07:28:22', 'scs10'),
(17, 21700, '16', 'KCB', 1300, '2016-03-23 08:19:07', 'scs20'),
(18, 15000, '17', 'KCB', 8000, '2016-03-24 13:58:53', 'scs03'),
(19, 12000, '18', 'Equity', 11000, '2016-03-27 17:43:35', 'scs19'),
(20, 21000, '19', 'national bank', 2000, '2016-03-29 10:16:24', 'scs06'),
(21, 20000, '20', 'national bank', 3000, '2016-03-29 13:07:59', 'scs06'),
(22, 20000, '21', 'national bank', 3000, '2016-03-29 13:10:03', 'scs06');

-- --------------------------------------------------------

--
-- Table structure for table `message`
--

CREATE TABLE IF NOT EXISTS `message` (
  `msg_id` int(11) NOT NULL AUTO_INCREMENT,
  `student_id` int(11) NOT NULL,
  `message` varchar(255) NOT NULL,
  `status` varchar(255) NOT NULL,
  `time` datetime NOT NULL,
  `username` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`msg_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=19 ;

--
-- Dumping data for table `message`
--

INSERT INTO `message` (`msg_id`, `student_id`, `message`, `status`, `time`, `username`) VALUES
(15, 8, 'chech my account', 'staff', '2016-03-23 09:57:54', NULL),
(17, 5, 'kilo speaker\r\n', 'student', '2016-03-23 10:06:32', NULL),
(18, 1, 'kkilo ', 'staff', '2016-03-23 10:06:50', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `reply`
--

CREATE TABLE IF NOT EXISTS `reply` (
  `msg_id` int(11) NOT NULL AUTO_INCREMENT,
  `id` int(11) NOT NULL,
  `message` varchar(255) NOT NULL,
  `status` varchar(255) NOT NULL,
  `time` datetime NOT NULL,
  PRIMARY KEY (`msg_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `signature`
--

CREATE TABLE IF NOT EXISTS `signature` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `p` varchar(300) DEFAULT NULL,
  `dp` varchar(300) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `signature`
--

INSERT INTO `signature` (`id`, `p`, `dp`) VALUES
(1, 'img/p.jpg', 'img/dp.jpg');

-- --------------------------------------------------------

--
-- Table structure for table `staff`
--

CREATE TABLE IF NOT EXISTS `staff` (
  `staff_id` int(128) NOT NULL AUTO_INCREMENT,
  `username` varchar(128) NOT NULL,
  `password` varchar(128) NOT NULL,
  `firstname` varchar(128) NOT NULL,
  `lastname` varchar(128) NOT NULL,
  `thumbnails` varchar(200) NOT NULL,
  PRIMARY KEY (`staff_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Dumping data for table `staff`
--

INSERT INTO `staff` (`staff_id`, `username`, `password`, `firstname`, `lastname`, `thumbnails`) VALUES
(1, 'bursar', '1234', 'fark', 'murithi', 'uploads/IMG_20130601_031759.jpg'),
(2, 'asa', '12', 'q', 'q', 'uploads/DSC04034.JPG'),
(3, 'sas', '1234', 'kithinji ', 'Godfrey', 'images/NO-IMAGE-AVAILABLE.jpg');

-- --------------------------------------------------------

--
-- Table structure for table `student`
--

CREATE TABLE IF NOT EXISTS `student` (
  `student_id` int(128) NOT NULL AUTO_INCREMENT,
  `username` varchar(300) NOT NULL,
  `Name` varchar(300) DEFAULT NULL,
  `Form` varchar(128) DEFAULT NULL,
  `password` varchar(300) DEFAULT NULL,
  `contacts` varchar(200) DEFAULT NULL,
  `post_address` varchar(200) DEFAULT NULL,
  `Postal_code` varchar(200) DEFAULT NULL,
  `Date_of_Birth` int(11) DEFAULT NULL,
  `Place_of_Birth` varchar(200) DEFAULT NULL,
  `thumbnail` varchar(500) DEFAULT NULL,
  `contact_name` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`student_id`),
  UNIQUE KEY `username` (`username`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=15 ;

--
-- Dumping data for table `student`
--

INSERT INTO `student` (`student_id`, `username`, `Name`, `Form`, `password`, `contacts`, `post_address`, `Postal_code`, `Date_of_Birth`, `Place_of_Birth`, `thumbnail`, `contact_name`) VALUES
(1, 'scs32', 'Kithinji Godfrey Mutia', '4S', '1234', '072435389ll', '56', '60602', 1990, 'Kenya', 'uploads/20150322_110408.jpg', 'Bejamin Mutia'),
(2, 'scs31', 'martin muthuri', '4k', '1234', '0723456789', '45 nyeri', '8080', 1992, 'kirirnyaga', 'uploads/DSC07376.JPG', 'mama'),
(3, 'scs23', 'Johnstone kenyatta', '2K', '1234', '0545485787', '897 kiri', '9090', 1993, 'kiki', 'uploads/Family.jpg', 'mamamamama'),
(4, 'scs12', 'robert cherotich', '3K', '1234', '09876543', '67hgsd', '2344', 1993, 'kericho', 'uploads/DSC00166.JPG', 'Kipcherotich'),
(5, 'scs10', 'denis muthamia', '1L', '1234', '09876543', '78', '3232', 1998, 'kiaaaa', 'uploads/20151106_141658.jpg', 'adsded'),
(6, 'scs11', 'Ezra Mugambi', '2d', '1234', '2131231', '123', '1232', 1994, 'fdfd', '', 'sarah'),
(7, 'scs01', 'kevinn muinde', '2J', '1234', '098594758', '76jhc', '845747', 1992, 'machakus', 'uploads/20150322_110401.jpg', 'Muinde'),
(8, 'scs02', 'cyrus Murimi', '3e', '1234', '5456546', '56', '23423', 1990, 'kinuki', '', 'Milka'),
(9, 'scs03', 'haron mwau', '2D', '1234', '435345', '12', '32', 1994, 'kililil', 'uploads/JED.png', 'justin'),
(11, 'scs05', 'James Mwenda', '4K', '1234', '072324232', '89-9000', '2320', 1997, 'kirima', '', 'joseph'),
(12, 'scs20', 'kevin Muinde', '3K', '4321', '078989878', '45 nyeri', '80909', 1994, 'Machakos', 'uploads/DSC04106.JPG', 'Muide 2'),
(13, 'scs19', 'mutua stephen', '3K', '12345', '07454547547', '34', '43222', 1992, 'makueni', '', 'Abraham'),
(14, 'scs06', 'Julius Yego ', '3J', '1234', '072324232', '56 Kianjai', '60602', 1992, 'kirinyaga', 'uploads/IMG_20151203_084651.jpg', 'Tony Maina');

-- --------------------------------------------------------

--
-- Table structure for table `user_log`
--

CREATE TABLE IF NOT EXISTS `user_log` (
  `user_log_id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(25) NOT NULL,
  `login_date` varchar(30) NOT NULL,
  `logout_date` varchar(128) NOT NULL,
  `admin_id` int(128) NOT NULL,
  `student_id` varchar(128) NOT NULL,
  PRIMARY KEY (`user_log_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=73 ;

--
-- Dumping data for table `user_log`
--

INSERT INTO `user_log` (`user_log_id`, `username`, `login_date`, `logout_date`, `admin_id`, `student_id`) VALUES
(3, 'scs32', '2016-03-10 15:41:17', '2016-03-18', 0, '1'),
(4, 'admin', '2016-03-10 15:47:48', '2016-05-06', 1, ''),
(5, 'scs31', '2016-03-10 15:54:14', '2016-05-06', 0, '2'),
(6, 'scs32', '2016-03-11 13:26:36', '2016-03-18', 0, '1'),
(7, 'scs31', '2016-03-11 20:59:25', '2016-05-06', 0, '2'),
(8, 'scs31', '2016-03-11 21:11:40', '2016-05-06', 0, '2'),
(9, 'scs32', '2016-03-14 09:06:44', '2016-03-18', 0, '1'),
(10, 'admin', '2016-03-14 09:07:36', '2016-05-06', 1, ''),
(11, 'admin', '2016-03-13 15:24:31', '2016-05-06', 1, ''),
(12, 'admin', '2016-03-13 15:24:33', '2016-05-06', 1, ''),
(13, 'scs12', '2016-03-14 14:51:36', '2016-03-18', 0, '4'),
(14, 'admin', '2016-03-16 20:45:10', '2016-05-06', 1, ''),
(15, 'admin', '2016-03-16 20:45:11', '2016-05-06', 1, ''),
(16, 'admin', '2016-03-16 20:45:10', '2016-05-06', 1, ''),
(17, 'admin', '2016-03-16 20:45:11', '2016-05-06', 1, ''),
(18, 'admin', '2016-03-16 20:45:11', '2016-05-06', 1, ''),
(33, 'admin', '2016-03-18 15:56:39', '2016-05-06', 1, ''),
(34, 'scs32', '2016-03-18 16:07:35', '', 0, '1'),
(35, 'admin', '2016-03-21 12:23:38', '2016-05-06', 1, ''),
(36, 'scs05', '2016-03-21 12:49:13', '', 0, '11'),
(37, 'scs10', '2016-03-21 13:07:10', '2016-05-06', 0, '5'),
(38, 'admin', '2016-03-21 13:09:48', '2016-05-06', 1, ''),
(39, 'admin', '2016-03-21 15:36:52', '2016-05-06', 1, ''),
(40, 'scs03', '2016-03-21 15:37:29', '', 0, '9'),
(41, 'scs03', '2016-03-21 16:23:24', '', 0, '9'),
(42, 'scs11', '2016-03-22 16:45:33', '', 0, '6'),
(43, 'admin', '2016-03-22 23:19:07', '2016-05-06', 1, ''),
(44, 'scs03', '2016-03-22 23:28:56', '', 0, '9'),
(45, 'scs10', '2016-03-23 09:45:46', '2016-05-06', 0, '5'),
(46, 'admin', '2016-03-23 09:57:25', '2016-05-06', 1, ''),
(47, 'admin', '2016-03-23 10:07:09', '2016-05-06', 1, ''),
(48, 'scs20', '2016-03-23 11:15:53', '', 0, '12'),
(49, 'scs20', '2016-03-23 11:15:54', '', 0, '12'),
(50, 'admin', '2016-03-24 16:51:41', '2016-05-06', 1, ''),
(51, 'scs03', '2016-03-24 16:56:47', '', 0, '9'),
(52, 'scs10', '2016-03-24 19:50:48', '2016-05-06', 0, '5'),
(53, 'admin', '2016-03-26 21:05:22', '2016-05-06', 1, ''),
(54, 'scs19', '2016-03-27 20:41:55', '', 0, '13'),
(55, 'admin', '2016-03-28 16:11:23', '2016-05-06', 1, ''),
(56, 'admin', '2016-03-28 18:15:46', '2016-05-06', 1, ''),
(57, 'admin', '2016-03-29 13:05:19', '2016-05-06', 1, ''),
(58, 'scs06', '2016-03-29 13:10:59', '', 0, '14'),
(59, 'admin', '2016-03-29 13:54:11', '2016-05-06', 1, ''),
(60, 'admin', '2016-03-29 13:55:29', '2016-05-06', 1, ''),
(61, 'scs06', '2016-03-29 14:01:38', '', 0, '14'),
(62, 'admin', '2016-03-29 16:04:02', '2016-05-06', 1, ''),
(63, 'scs06', '2016-03-29 16:06:33', '', 0, '14'),
(64, 'scs06', '2016-03-29 16:09:48', '', 0, '14'),
(65, 'admin', '2016-03-29 16:16:18', '2016-05-06', 1, ''),
(66, 'admin', '2016-04-03 18:30:17', '2016-05-06', 1, ''),
(67, 'admin', '2016-04-30 15:14:52', '2016-05-06', 1, ''),
(68, 'admin', '2016-05-03 12:31:47', '2016-05-06', 1, ''),
(69, 'scs31', '2016-05-06 11:28:44', '2016-05-06', 0, '2'),
(70, 'scs10', '2016-05-06 11:29:50', '2016-05-06', 0, '5'),
(71, 'admin', '2016-05-06 11:32:43', '', 1, ''),
(72, 'admin', '2016-05-10 14:44:01', '', 1, '');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
