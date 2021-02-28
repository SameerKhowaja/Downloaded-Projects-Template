-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Jun 13, 2016 at 08:42 AM
-- Server version: 5.6.17
-- PHP Version: 5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `rms`
--

-- --------------------------------------------------------

--
-- Table structure for table `buy`
--

CREATE TABLE IF NOT EXISTS `buy` (
  `buy_id` int(11) NOT NULL AUTO_INCREMENT,
  `customer_id` int(11) NOT NULL,
  `gross_weight` varchar(500) NOT NULL,
  `total_bag` varchar(500) NOT NULL,
  `td` varchar(500) NOT NULL,
  `discount` varchar(500) NOT NULL,
  `shaft` varchar(500) NOT NULL,
  `dust` varchar(500) NOT NULL,
  `date` datetime NOT NULL,
  PRIMARY KEY (`buy_id`),
  KEY `customer_id` (`customer_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=21 ;

--
-- Dumping data for table `buy`
--

INSERT INTO `buy` (`buy_id`, `customer_id`, `gross_weight`, `total_bag`, `td`, `discount`, `shaft`, `dust`, `date`) VALUES
(10, 14, '40', '40bags', '34', '2345', '52', '24', '2016-05-11 00:54:33'),
(11, 9, '343', '334', '34', '34', '344', '34', '2016-04-08 01:18:18'),
(12, 2, '3443', '3434', '34', '343', '34', '34', '2016-06-13 01:18:36'),
(13, 11, '23', '232', '23', '23', '23', '23', '2016-06-13 01:19:16'),
(14, 9, '23', '33', '34', '53', '35', '56', '2016-03-08 01:19:33'),
(15, 8, '42', '242', '34', '34', '3434', '32', '2016-01-06 01:26:39'),
(16, 9, '32', '34', '34', '53', '32', '32', '2016-02-05 01:26:58'),
(17, 16, '232', '23', '523', '352', '23', '233', '2016-03-02 01:27:14'),
(18, 12, '322', '323', '232', '23', '323', '323', '2016-04-01 01:27:33'),
(19, 10, '324', '324', '32', '32', '32', '32', '2016-05-19 01:27:52'),
(20, 2, '64', '54', '43', '54', '43', '654', '2016-06-13 01:28:29');

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE IF NOT EXISTS `customer` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `customer_id` int(5) NOT NULL,
  `firstname` varchar(100) NOT NULL,
  `middlename` varchar(100) NOT NULL,
  `lastname` varchar(100) NOT NULL,
  `gender` varchar(100) NOT NULL,
  `home` varchar(100) NOT NULL,
  `phone` varchar(11) NOT NULL,
  `account` varchar(10) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=21 ;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`id`, `customer_id`, `firstname`, `middlename`, `lastname`, `gender`, `home`, `phone`, `account`) VALUES
(7, 11111, 'adebayo', '', 'Jeremiah', '', 'no 24 babiala street', '07023940302', '0093820343'),
(8, 32183, 'Samuel', '', 'Sulieman', '', 'no 29 sobiaya street', '09037483924', '0883471236'),
(9, 21456, 'Olateru', '', 'Christiana', '', 'no 42 kola-balogun street', '07034712839', '0113528120'),
(10, 32143, 'Stephen', '', 'Aina', '', 'no 9 joke silva street', '0812239873', '9082193043'),
(11, 22345, 'Olabimtan', '', 'Stella', 'female', 'no 4 ilado', '08021849302', '2238493020'),
(12, 33291, 'Shonekan', '', 'Olasunkanmi', '', 'no 12 jejelaiye street', '07034712333', '0099124838'),
(13, 22372, 'Kosoko', '', 'Janet', '', 'no 23 alakorede street', '08173923623', '2211473920'),
(14, 4567, 'idowu', 'john', 'rerwerw', '', 'hfjhbhj', '3456789', '4567832'),
(15, 12, 'idowu', 'C.', 'resa', '', 'djbjdjd', '07023940302', '0009354672'),
(16, 12, 'adebayo', 'john', 'Christiana', '', 'dsds', '07023940302', '0013458206'),
(17, 11111, 'Olabimtan', 'Y.', 'israel', '', 'hbj', '07023940302', '0012983749'),
(20, 123, 'adebayo', 'john', 'Edochie', 'Male', 'dsds', '07023940302', '0012983749');

-- --------------------------------------------------------

--
-- Table structure for table `haulage`
--

CREATE TABLE IF NOT EXISTS `haulage` (
  `id` int(100) NOT NULL AUTO_INCREMENT,
  `lorry` varchar(100) NOT NULL,
  `driver` varchar(100) NOT NULL,
  `loaded` varchar(100) NOT NULL,
  `destination` varchar(100) NOT NULL,
  `escort` varchar(100) NOT NULL,
  `date` date NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=7 ;

--
-- Dumping data for table `haulage`
--

INSERT INTO `haulage` (`id`, `lorry`, `driver`, `loaded`, `destination`, `escort`, `date`) VALUES
(5, '909888', 'ladi', '50', 'lagos', 'ayo', '2015-05-10');

-- --------------------------------------------------------

--
-- Table structure for table `history`
--

CREATE TABLE IF NOT EXISTS `history` (
  `history_id` int(11) NOT NULL AUTO_INCREMENT,
  `date` datetime NOT NULL,
  `action` varchar(100) NOT NULL,
  `data` varchar(100) NOT NULL,
  PRIMARY KEY (`history_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=336 ;

--
-- Dumping data for table `history`
--

INSERT INTO `history` (`history_id`, `date`, `action`, `data`) VALUES
(205, '2016-06-11 10:45:56', 'Logout', 'owoyemi richard'),
(206, '2016-06-11 10:46:08', 'Login', 'owoyemi richard'),
(207, '2016-06-11 12:10:50', 'added buy details for Mandela Mack', 'owoyemi richard'),
(208, '2016-06-11 13:32:41', 'Logout', 'owoyemi richard'),
(209, '2016-06-11 13:32:54', 'Login', 'owoyemi richard'),
(210, '2016-06-11 17:29:06', 'Add staff', 'owoyemi richard'),
(211, '2016-06-11 17:44:21', 'Login', 'owoyemi richard'),
(212, '2016-06-11 20:33:13', 'added buy details for  ', 'owoyemi richard'),
(213, '2016-06-11 20:43:33', 'added payment details for  ', 'owoyemi richard'),
(214, '2016-06-11 20:44:00', 'added payment details for  ', 'owoyemi richard'),
(215, '2016-06-11 20:44:27', 'added payment details for  ', 'owoyemi richard'),
(216, '2016-06-11 20:45:52', 'added payment details for  ', 'owoyemi richard'),
(217, '2016-06-11 20:48:26', 'added payment details for ayo', 'owoyemi richard'),
(218, '2016-06-11 20:50:54', 'added payment details for ayo', 'owoyemi richard'),
(219, '2016-06-11 20:52:46', 'added payment details for ayo', 'owoyemi richard'),
(220, '2016-06-11 20:54:51', 'Logout', 'owoyemi richard'),
(221, '2016-06-11 21:02:53', 'Login', 'owoyemi richard'),
(222, '2016-06-11 21:13:14', 'Logout', 'owoyemi richard'),
(223, '2016-06-11 21:13:25', 'Login', 'adebayo kelvin'),
(224, '2016-06-11 21:36:08', 'Login', 'owoyemi richard'),
(225, '2016-06-11 21:36:33', 'Delete staff', 'owoyemi richard'),
(226, '2016-06-11 21:36:38', 'Delete staff', 'owoyemi richard'),
(227, '2016-06-11 21:36:44', 'Delete staff', 'owoyemi richard'),
(228, '2016-06-11 21:38:51', 'Add staff', 'owoyemi richard'),
(229, '2016-06-11 21:40:42', 'Add staff', 'owoyemi richard'),
(230, '2016-06-11 21:42:16', 'Add staff', 'owoyemi richard'),
(231, '2016-06-11 21:43:46', 'Add staff', 'owoyemi richard'),
(232, '2016-06-11 21:47:13', 'Add staff', 'owoyemi richard'),
(233, '2016-06-11 21:49:01', 'Add staff', 'owoyemi richard'),
(234, '2016-06-11 21:51:18', 'Add staff', 'owoyemi richard'),
(235, '2016-06-11 21:53:33', 'Add staff', 'owoyemi richard'),
(236, '2016-06-11 21:55:40', 'Add staff', 'owoyemi richard'),
(237, '2016-06-11 21:56:19', 'Edit staff Details', 'owoyemi richard'),
(238, '2016-06-11 21:56:46', 'Edit staff Details', 'owoyemi richard'),
(239, '2016-06-11 21:59:20', 'Add staff', 'owoyemi richard'),
(240, '2016-06-11 22:01:42', 'Add staff', 'owoyemi richard'),
(241, '2016-06-11 22:02:18', 'Delete Customer', 'owoyemi richard'),
(242, '2016-06-11 22:02:24', 'Delete Customer', 'owoyemi richard'),
(243, '2016-06-11 22:02:30', 'Delete Customer', 'owoyemi richard'),
(244, '2016-06-11 22:02:36', 'Delete Customer', 'owoyemi richard'),
(245, '2016-06-11 22:02:41', 'Delete Customer', 'owoyemi richard'),
(246, '2016-06-11 22:04:10', 'Add Customer', 'owoyemi richard'),
(247, '2016-06-11 22:10:03', 'Add Customer', 'owoyemi richard'),
(248, '2016-06-11 22:12:42', 'Add Customer', 'owoyemi richard'),
(249, '2016-06-11 22:15:00', 'Edit staff Details', 'owoyemi richard'),
(250, '2016-06-11 22:15:37', 'Edit staff Details', 'owoyemi richard'),
(251, '2016-06-11 22:21:31', 'Add Customer', 'owoyemi richard'),
(252, '2016-06-11 22:33:15', 'Add Customer', 'owoyemi richard'),
(253, '2016-06-11 22:34:56', 'Add Customer', 'owoyemi richard'),
(254, '2016-06-11 22:36:00', 'Add Customer', 'owoyemi richard'),
(255, '2016-06-11 22:36:24', 'Edit Customer Details', 'owoyemi richard'),
(256, '2016-06-11 22:36:31', 'Edit Customer Details', 'owoyemi richard'),
(257, '2016-06-11 22:40:23', 'Edit Customer Details', 'owoyemi richard'),
(258, '2016-06-11 22:43:20', 'Edit Customer Details', 'owoyemi richard'),
(259, '2016-06-11 22:43:57', 'Edit Customer Details', 'owoyemi richard'),
(260, '2016-06-11 22:45:20', 'Edit Customer Details', 'owoyemi richard'),
(261, '2016-06-11 22:47:32', 'Edit Customer Details', 'owoyemi richard'),
(262, '2016-06-11 22:49:57', 'added buy details for Stephen Aina', 'owoyemi richard'),
(263, '2016-06-11 22:52:32', 'Login', 'owoyemi richard'),
(264, '2016-06-11 22:55:13', 'added buy details for Olateru Christiana', 'owoyemi richard'),
(265, '2016-06-11 22:57:32', 'added buy details for Olabimtan Stella', 'owoyemi richard'),
(266, '2016-06-11 23:03:12', 'added buy details for Samuel Sulieman', 'owoyemi richard'),
(267, '2016-06-11 23:07:45', 'Login', 'owoyemi richard'),
(268, '2016-06-11 23:09:02', 'Login', 'owoyemi richard'),
(269, '2016-06-11 23:11:02', 'Login', 'owoyemi richard'),
(270, '2016-06-11 23:13:00', 'Login', 'owoyemi richard'),
(271, '2016-06-12 08:00:39', 'Logout', 'owoyemi richard'),
(272, '2016-06-12 08:10:03', 'Login', 'owoyemi richard'),
(273, '2016-06-12 09:04:37', 'added buy details for  ', 'owoyemi richard'),
(274, '2016-06-12 09:16:24', 'Add Customer', 'owoyemi richard'),
(275, '2016-06-12 09:18:21', 'Add Customer', 'owoyemi richard'),
(276, '2016-06-12 09:19:20', 'Add Customer', 'owoyemi richard'),
(277, '2016-06-12 09:22:23', 'Add Customer', 'owoyemi richard'),
(278, '2016-06-12 09:29:19', 'added buy details for  ', 'owoyemi richard'),
(279, '2016-06-12 10:04:15', 'Login', 'owoyemi richard'),
(280, '2016-06-12 10:10:15', 'Login', 'owoyemi richard'),
(281, '2016-06-12 10:11:19', 'Login', 'adebayo kelvin'),
(282, '2016-06-12 10:26:43', 'Login', 'adebayo kelvin'),
(283, '2016-06-12 11:55:36', 'Logout', 'adebayo kelvin'),
(284, '2016-06-12 11:55:56', 'Login', 'owoyemi richard'),
(285, '2016-06-12 11:58:18', 'Logout', 'owoyemi richard'),
(286, '2016-06-12 11:58:42', 'Login', 'adebayo kelvin'),
(287, '2016-06-12 12:01:52', 'Logout', 'adebayo kelvin'),
(288, '2016-06-12 12:02:30', 'Login', 'owoyemi richard'),
(289, '2016-06-12 12:02:41', 'Logout', 'owoyemi richard'),
(290, '2016-06-12 12:03:55', 'Login', 'owoyemi richard'),
(291, '2016-06-12 12:34:38', 'Login', 'owoyemi richard'),
(292, '2016-06-12 12:46:07', 'Login', 'owoyemi richard'),
(293, '2016-06-12 13:54:45', 'Add Customer', 'owoyemi richard'),
(294, '2016-06-12 13:56:07', 'Delete Customer', 'owoyemi richard'),
(295, '2016-06-12 13:56:36', 'Add Customer', 'owoyemi richard'),
(296, '2016-06-12 13:57:57', 'Delete Customer', 'owoyemi richard'),
(297, '2016-06-12 13:58:15', 'Add Customer', 'owoyemi richard'),
(298, '2016-06-12 13:59:11', 'Add staff', 'owoyemi richard'),
(299, '2016-06-12 14:06:44', 'Edit Buy Details', 'owoyemi richard'),
(300, '2016-06-12 14:07:22', 'Edit Buy Details', 'owoyemi richard'),
(301, '2016-06-12 14:09:01', 'Edit Buy Details', 'owoyemi richard'),
(302, '2016-06-12 14:13:34', 'Delete buy', 'owoyemi richard'),
(303, '2016-06-12 14:14:08', 'Delete buy', 'owoyemi richard'),
(304, '2016-06-12 14:14:30', 'Edit Buy Details', 'owoyemi richard'),
(305, '2016-06-12 14:14:42', 'Delete buy', 'owoyemi richard'),
(306, '2016-06-12 14:18:23', 'Edit Haulage Details', 'owoyemi richard'),
(307, '2016-06-12 14:19:19', 'Delete Haulage', 'owoyemi richard'),
(308, '2016-06-12 14:21:15', 'Edit Sundry Details', 'owoyemi richard'),
(309, '2016-06-12 14:21:35', 'added sundry details for  ', 'owoyemi richard'),
(310, '2016-06-12 14:21:43', 'added sundry details for  ', 'owoyemi richard'),
(311, '2016-06-12 14:25:09', 'added sundry details for  ', 'owoyemi richard'),
(312, '2016-06-12 14:29:26', 'added sundry details for  ', 'owoyemi richard'),
(313, '2016-06-12 14:30:11', 'Login', 'owoyemi richard'),
(314, '2016-06-12 14:30:36', 'added sundry details for  ', 'owoyemi richard'),
(315, '2016-06-12 14:31:36', 'added sundry details on 2016-05-12', 'owoyemi richard'),
(316, '2016-06-12 14:33:58', 'added sundry details on', 'owoyemi richard'),
(317, '2016-06-12 14:35:18', 'added sundry details on 2016-05-12', 'owoyemi richard'),
(318, '2016-06-12 14:35:32', 'Edit Sundry Details', 'owoyemi richard'),
(319, '2016-06-12 14:43:39', 'Delete Sundry', 'owoyemi richard'),
(320, '2016-06-12 14:43:57', 'added sundry details on 2016-06-12', 'owoyemi richard'),
(321, '2016-06-12 14:48:01', 'Edit Payment Details', 'owoyemi richard'),
(322, '2016-06-12 14:51:20', 'Delete Payment', 'owoyemi richard'),
(323, '2016-06-12 23:43:57', 'Login', 'owoyemi richard'),
(324, '2016-06-13 00:00:28', 'Edit staff Details', 'owoyemi richard'),
(325, '2016-06-13 00:54:32', 'added buy details for idowu rerwerw', 'owoyemi richard'),
(326, '2016-06-13 01:18:18', 'added buy details for Olateru Christiana', 'owoyemi richard'),
(327, '2016-06-13 01:18:36', 'added buy details for  ', 'owoyemi richard'),
(328, '2016-06-13 01:19:16', 'added buy details for Olabimtan Stella', 'owoyemi richard'),
(329, '2016-06-13 01:19:33', 'added buy details for Olateru Christiana', 'owoyemi richard'),
(330, '2016-06-13 01:26:39', 'added buy details for Samuel Sulieman', 'owoyemi richard'),
(331, '2016-06-13 01:26:58', 'added buy details for Olateru Christiana', 'owoyemi richard'),
(332, '2016-06-13 01:27:14', 'added buy details for adebayo Christiana', 'owoyemi richard'),
(333, '2016-06-13 01:27:33', 'added buy details for Shonekan Olasunkanmi', 'owoyemi richard'),
(334, '2016-06-13 01:27:52', 'added buy details for Stephen Aina', 'owoyemi richard'),
(335, '2016-06-13 01:28:29', 'added buy details for  ', 'owoyemi richard');

-- --------------------------------------------------------

--
-- Table structure for table `payment`
--

CREATE TABLE IF NOT EXISTS `payment` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `date` date NOT NULL,
  `name` varchar(100) NOT NULL,
  `account` int(100) NOT NULL,
  `amount` int(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `payment`
--

INSERT INTO `payment` (`id`, `date`, `name`, `account`, `amount`) VALUES
(1, '2016-06-12', 'Afolabi Jesusope', 12983749, 1000000);

-- --------------------------------------------------------

--
-- Table structure for table `staff`
--

CREATE TABLE IF NOT EXISTS `staff` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `staff_id` varchar(4) NOT NULL,
  `name` varchar(100) NOT NULL,
  `gender` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `home` varchar(111) NOT NULL,
  `phone` int(11) NOT NULL,
  `account` varchar(10) NOT NULL,
  `guarantor` varchar(100) NOT NULL,
  `date` varchar(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=24 ;

--
-- Dumping data for table `staff`
--

INSERT INTO `staff` (`id`, `staff_id`, `name`, `gender`, `email`, `home`, `phone`, `account`, `guarantor`, `date`) VALUES
(12, '002', 'Kole Michael', '', 'kole@yahoo.com', 'dsds', 2147483647, '0012983749', 'Mrs.Olorunfemi', '2014-04-09'),
(13, '004', 'Sola Bademosi', '', 'sola@yahoo.com', 'no 12 soriyan street', 2147483647, '0098735295', 'Mr.Ibitoye', '2012-02-07'),
(14, '005', 'Kenneth Manner', '', 'kenneth@yahoo.com', 'no 4 gbera street', 2147483647, '0023984738', 'Mr. stanley', '2014-04-09'),
(15, '009', 'Mandela coker', '', 'mandela@yahoo.com', 'no 5 alagbe street', 2147483647, '0013458206', 'Mr. sunday', '2012-02-07'),
(16, '010', 'Ayo Julius', '', 'ayo@yahoo.com', 'no 6 fadaka street', 2147483647, '0198734021', 'Mr. ismail', '2011-01-07'),
(17, '011', 'Ismail Olaiya', '', 'olaiya@yahoo.com', 'no 2 soneka street', 2147483647, '1028392102', 'Mr. ismail', '2015-02-10'),
(18, '012', 'Joshua Soko', '', 'soko@yahoo.com', 'no 2 babiala street', 2147483647, '0099872192', 'Mr Ibitoye', '2013-03-10'),
(19, '014', 'Prosper Orisan', '', 'prosper@yahoo.com', 'no 132 kogbe street', 2147483647, '0032871892', 'Mrs. Olorunfemi', '2012-02-07'),
(20, '015', 'Kola Strauss', '', 'kola@yahoo.com', 'no 98 fadaka street', 2147483647, '0145872398', 'Mr Ibitoye', '2010-03-08'),
(21, '018', 'Ayobami Joshua', '', 'ayobami@yahoo.com', 'no 5 femi-bade street', 2147483647, '0023498392', 'Mrs. Emuoyibofarhe', '2013-03-08'),
(22, '020', 'Afolabi Jesusope', '', 'folabi@yahoo.com', 'no 43 stephen street', 2147483647, '0549201392', 'Mr.Olam', '2007-04-08'),
(23, '123', 'Afolabi Jesusope', 'Male', 'ayo@yahoo.com', 'dsds', 2147483647, '0012983749', 'bhubjhnjhn', '2016-09-15');

-- --------------------------------------------------------

--
-- Table structure for table `sundry`
--

CREATE TABLE IF NOT EXISTS `sundry` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `date` date NOT NULL,
  `sundry_bags` varchar(100) NOT NULL,
  `recovery` varchar(100) NOT NULL,
  `short_weight` varchar(100) NOT NULL,
  `final_weight` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Dumping data for table `sundry`
--

INSERT INTO `sundry` (`id`, `date`, `sundry_bags`, `recovery`, `short_weight`, `final_weight`) VALUES
(2, '2016-05-12', '300', '30', '40', '80'),
(3, '2016-06-12', '300', '30', '54', '66');

-- --------------------------------------------------------

--
-- Table structure for table `transaction_history`
--

CREATE TABLE IF NOT EXISTS `transaction_history` (
  `transaction_history_id` int(11) NOT NULL AUTO_INCREMENT,
  `item_id` int(11) NOT NULL,
  `action` varchar(100) NOT NULL,
  `client_id` int(11) NOT NULL,
  `release_id` int(11) NOT NULL,
  `admin_name` varchar(100) NOT NULL,
  `date_added` datetime NOT NULL,
  PRIMARY KEY (`transaction_history_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=137 ;

--
-- Dumping data for table `transaction_history`
--

INSERT INTO `transaction_history` (`transaction_history_id`, `item_id`, `action`, `client_id`, `release_id`, `admin_name`, `date_added`) VALUES
(45, 2, 'Borrowed', 1, 11, 'John Doe', '2016-02-02 21:29:38'),
(46, 1, 'Borrowed', 1, 12, 'John Doe', '2016-02-02 21:29:49'),
(47, 3, 'Borrowed', 1, 13, 'John Doe', '2016-02-02 21:30:08'),
(48, 2, 'Borrowed', 1, 14, 'John Doe', '2016-02-02 21:30:27'),
(49, 3, 'Borrowed', 1, 1, 'John Doe', '2016-02-02 21:31:41'),
(50, 2, 'Borrowed', 1, 2, 'John Doe', '2016-02-02 21:32:12'),
(51, 2, 'Borrowed', 1, 3, 'John Doe', '2016-02-02 21:33:02'),
(52, 2, 'Borrowed', 1, 4, 'John Doe', '2016-02-02 21:33:56'),
(53, 3, 'Borrowed', 1, 5, 'John Doe', '2016-02-02 21:34:37'),
(54, 3, 'Borrowed', 1, 6, 'John Doe', '2016-02-02 21:34:53'),
(55, 2, 'Borrowed', 1, 7, 'John Doe', '2016-02-02 21:35:04'),
(56, 3, 'Borrowed', 1, 8, 'John Doe', '2016-02-02 21:37:32'),
(57, 2, 'Borrowed', 2, 9, 'John Doe', '2016-02-02 21:37:53'),
(58, 1, 'Borrowed', 1, 10, 'John Doe', '2016-02-02 21:38:07'),
(59, 1, 'Borrowed', 2, 11, 'John Doe', '2016-02-02 21:41:18'),
(60, 2, 'Borrowed', 1, 12, 'John Doe', '2016-02-02 21:42:10'),
(61, 3, 'Borrowed', 1, 13, 'John Doe', '2016-02-02 21:45:12'),
(62, 1, 'Borrowed', 1, 14, 'John Doe', '2016-02-02 21:46:35'),
(63, 2, 'Borrowed', 2, 15, 'John Doe', '2016-02-02 21:46:50'),
(64, 1, 'Borrowed', 2, 16, 'John Doe', '2016-02-02 21:47:16'),
(65, 3, 'Borrowed', 1, 1, 'John Doe', '2016-02-02 21:48:10'),
(66, 4, 'Borrowed', 1, 1, 'John Doe', '2016-02-02 21:48:10'),
(67, 1, 'Borrowed', 1, 1, 'John Doe', '2016-02-02 21:48:11'),
(68, 3, 'Borrowed', 1, 1, 'John Doe', '2016-02-02 22:11:09'),
(69, 4, 'Borrowed', 1, 2, 'John Doe', '2016-02-02 22:11:23'),
(70, 1, 'Borrowed', 1, 3, 'John Doe', '2016-02-02 22:11:29'),
(71, 1, 'Borrowed', 1, 4, 'John Doe', '2016-02-02 22:11:37'),
(72, 3, 'Borrowed', 1, 5, 'John Doe', '2016-02-02 22:11:49'),
(73, 1, 'Borrowed', 1, 5, 'John Doe', '2016-02-02 22:11:50'),
(74, 2, 'Borrowed', 1, 5, 'John Doe', '2016-02-02 22:11:50'),
(75, 3, 'Borrowed', 1, 1, 'John Doe', '2016-02-02 22:14:06'),
(76, 2, 'Borrowed', 1, 2, 'John Doe', '2016-02-02 22:14:22'),
(77, 3, 'Borrowed', 1, 3, 'John Doe', '2016-02-02 22:14:49'),
(78, 2, 'Borrowed', 1, 4, 'John Doe', '2016-02-02 22:15:04'),
(79, 3, 'Borrowed', 1, 5, 'John Doe', '2016-02-02 22:15:17'),
(80, 3, 'Borrowed', 1, 6, 'John Doe', '2016-02-02 22:15:57'),
(81, 2, 'Borrowed', 1, 7, 'John Doe', '2016-02-02 22:16:25'),
(82, 3, 'Borrowed', 1, 8, 'John Doe', '2016-02-02 22:16:41'),
(83, 3, 'Borrowed', 1, 9, 'John Doe', '2016-02-02 22:18:01'),
(84, 3, 'Borrowed', 1, 10, 'John Doe', '2016-02-02 22:18:57'),
(85, 3, 'Borrowed', 1, 11, 'John Doe', '2016-02-02 22:19:45'),
(86, 1, 'Borrowed', 1, 12, 'John Doe', '2016-02-02 22:20:01'),
(87, 2, 'Borrowed', 1, 13, 'John Doe', '2016-02-02 22:20:11'),
(88, 3, 'Borrowed', 1, 1, 'John Doe', '2016-02-02 22:47:12'),
(89, 3, 'Borrowed', 1, 2, 'John Doe', '2016-02-02 22:49:10'),
(90, 1, 'Borrowed', 1, 1, 'John Doe', '2016-02-02 23:07:39'),
(91, 3, 'Borrowed', 1, 1, 'John Doe', '2016-02-02 23:09:20'),
(92, 2, 'Borrowed', 1, 2, 'John Doe', '2016-02-02 23:09:41'),
(93, 3, 'Borrowed', 2, 3, 'John Doe', '2016-02-02 23:10:15'),
(94, 1, 'Borrowed', 2, 3, 'John Doe', '2016-02-02 23:10:15'),
(95, 2, 'Borrowed', 2, 3, 'John Doe', '2016-02-02 23:10:16'),
(96, 3, 'Borrowed', 1, 4, 'John Doe', '2016-02-02 23:11:38'),
(97, 0, 'Borrowed', 1, 5, 'John Doe', '2016-02-02 23:12:29'),
(98, 1, 'Borrowed', 2, 6, 'John Doe', '2016-02-02 23:16:49'),
(99, 3, 'Borrowed', 1, 7, 'John Doe', '2016-02-02 23:18:57'),
(100, 2, 'Borrowed', 2, 8, 'John Doe', '2016-02-02 23:19:46'),
(101, 1, 'Borrowed', 1, 9, 'John Doe', '2016-02-02 23:20:00'),
(102, 4, 'Borrowed', 1, 1, 'John Doe', '2016-02-02 23:21:50'),
(103, 3, 'Borrowed', 2, 1, 'John Doe', '2016-02-02 23:23:00'),
(104, 3, 'Borrowed', 2, 2, 'John Doe', '2016-02-02 23:24:18'),
(105, 1, 'Borrowed', 1, 3, 'John Doe', '2016-02-02 23:25:22'),
(106, 3, 'Borrowed', 1, 4, 'John Doe', '2016-02-02 23:27:11'),
(107, 1, 'Borrowed', 1, 4, 'John Doe', '2016-02-02 23:27:11'),
(108, 3, 'Borrowed', 1, 5, 'John Doe', '2016-02-02 23:28:51'),
(109, 1, 'Borrowed', 1, 5, 'John Doe', '2016-02-02 23:28:52'),
(110, 3, 'Borrowed', 1, 6, 'John Doe', '2016-02-02 23:31:48'),
(111, 1, 'Borrowed', 1, 6, 'John Doe', '2016-02-02 23:31:49'),
(112, 3, 'Borrowed', 1, 7, 'John Doe', '2016-02-02 23:34:02'),
(113, 3, 'Borrowed', 1, 8, 'John Doe', '2016-02-02 23:34:34'),
(114, 1, 'Borrowed', 1, 9, 'John Doe', '2016-02-02 23:36:58'),
(115, 3, 'Borrowed', 1, 10, 'John Doe', '2016-02-02 23:37:45'),
(116, 3, 'Borrowed', 1, 11, 'John Doe', '2016-02-02 23:39:20'),
(117, 3, 'Borrowed', 1, 12, 'John Doe', '2016-02-02 23:40:01'),
(118, 1, 'Borrowed', 1, 12, 'John Doe', '2016-02-02 23:40:01'),
(119, 3, 'Borrowed', 2, 13, 'John Doe', '2016-02-02 23:41:13'),
(120, 1, 'Borrowed', 2, 13, 'John Doe', '2016-02-02 23:41:14'),
(121, 2, 'Borrowed', 2, 13, 'John Doe', '2016-02-02 23:41:15'),
(122, 3, 'Borrowed', 1, 14, 'John Doe', '2016-02-02 23:44:27'),
(123, 3, 'Borrowed', 1, 15, 'John Doe', '2016-02-02 23:44:54'),
(124, 3, 'Borrowed', 1, 16, 'John Doe', '2016-02-02 23:45:13'),
(125, 1, 'Borrowed', 1, 16, 'John Doe', '2016-02-02 23:45:14'),
(126, 3, 'Borrowed', 1, 17, 'John Doe', '2016-02-02 23:45:37'),
(127, 1, 'Borrowed', 1, 17, 'John Doe', '2016-02-02 23:45:37'),
(128, 3, 'Borrowed', 1, 1, 'John Doe', '2016-02-02 23:47:55'),
(129, 3, 'Borrowed', 1, 2, 'John Doe', '2016-02-02 23:51:21'),
(130, 3, 'Borrowed', 1, 3, 'John Doe', '2016-02-02 23:51:57'),
(131, 3, 'Borrowed', 1, 1, 'John Doe', '2016-02-03 00:04:34'),
(132, 1, 'Borrowed', 1, 1, 'John Doe', '2016-02-03 00:04:35'),
(133, 3, 'Borrowed', 1, 1, 'John Doe', '2016-02-03 00:11:59'),
(134, 1, 'Borrowed', 1, 1, 'John Doe', '2016-02-03 00:11:59'),
(135, 3, 'Borrowed', 1, 2, 'John Doe', '2016-02-03 00:12:35'),
(136, 4, 'Borrowed', 1, 1, 'John Doe', '2016-02-03 22:14:46');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE IF NOT EXISTS `user` (
  `user_id` int(11) NOT NULL AUTO_INCREMENT,
  `firstname` varchar(100) NOT NULL,
  `middlename` varchar(100) NOT NULL,
  `lastname` varchar(100) NOT NULL,
  `username` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  `user_added` datetime NOT NULL,
  PRIMARY KEY (`user_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`user_id`, `firstname`, `middlename`, `lastname`, `username`, `password`, `user_added`) VALUES
(3, 'owoyemi', '', 'richard', 'admin', 'admin', '2016-06-10 18:54:31'),
(4, 'adebayo', '', 'kelvin', 'kelly', 'kelly', '2016-06-10 20:10:24');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
