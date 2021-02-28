-- phpMyAdmin SQL Dump
-- version 4.4.11
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: May 25, 2016 at 12:15 PM
-- Server version: 5.6.27-2
-- PHP Version: 5.6.17-1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `student`
--

-- --------------------------------------------------------

--
-- Table structure for table `auto_id_generate`
--

CREATE TABLE IF NOT EXISTS `auto_id_generate` (
  `id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `sex` varchar(100) NOT NULL,
  `college_id` varchar(100) NOT NULL,
  `program` varchar(100) NOT NULL,
  `uid` int(11) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `auto_id_generate`
--

INSERT INTO `auto_id_generate` (`id`, `name`, `sex`, `college_id`, `program`, `uid`) VALUES
(1, 'Abebe Sharew', 'M', 'IOT', 'R', 1),
(2, 'Bereket Alayu', 'F', 'IOT', 'S', 1),
(3, 'Dejene Techane', 'M', 'IOT', 'E', 1),
(4, 'Geteye Zigale', 'M', 'IOT', 'S', 1),
(5, 'Girma Elias', 'M', 'IOT', 'E', 1),
(6, 'Girmachew Gulint', 'M', 'IOT', 'S', 1),
(7, 'Misrak Abebe', 'F', 'IOT', 'S', 1),
(8, 'Tizita Taye', 'F', 'IOT', 'E', 1),
(9, 'Yichalewale Tessema', 'M', 'IOT', 'R', 1),
(10, 'Yigezu Agonafer', 'M', 'IOT', 'R', 1);

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE IF NOT EXISTS `user` (
  `uid` int(11) NOT NULL,
  `username` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  `role` varchar(100) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`uid`, `username`, `password`, `role`) VALUES
(1, 'deje', '4fff6d7810dd15a3d6e0c3aec91bf46a', 'Administrator');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `auto_id_generate`
--
ALTER TABLE `auto_id_generate`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`uid`),
  ADD UNIQUE KEY `username` (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `auto_id_generate`
--
ALTER TABLE `auto_id_generate`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=11;
--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `uid` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=2;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
