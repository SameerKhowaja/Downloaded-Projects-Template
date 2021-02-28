-- phpMyAdmin SQL Dump
-- version 4.1.6
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Nov 23, 2015 at 10:39 PM
-- Server version: 5.6.16
-- PHP Version: 5.5.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `ems`
--

-- --------------------------------------------------------

--
-- Table structure for table `activity_log`
--

CREATE TABLE IF NOT EXISTS `activity_log` (
  `activity_log_id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(100) NOT NULL,
  `date` varchar(100) NOT NULL,
  `action` varchar(100) NOT NULL,
  PRIMARY KEY (`activity_log_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `contact`
--

CREATE TABLE IF NOT EXISTS `contact` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `user_id` int(11) NOT NULL,
  `name` varchar(120) NOT NULL,
  `number` varchar(15) NOT NULL,
  `mobile` varchar(120) NOT NULL,
  `email` varchar(250) NOT NULL,
  `work` text NOT NULL,
  `address` varchar(120) NOT NULL,
  `school` varchar(120) NOT NULL,
  `pix` varchar(120) NOT NULL,
  `group` varchar(120) NOT NULL,
  `note` text NOT NULL,
  `time_add` varchar(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=8 ;

--
-- Dumping data for table `contact`
--

INSERT INTO `contact` (`id`, `user_id`, `name`, `number`, `mobile`, `email`, `work`, `address`, `school`, `pix`, `group`, `note`, `time_add`) VALUES
(6, 223, 'zak', '0722953942', '0722953942', 'isaactsienyane@gmail.com', '0129456941', '7888 phase 4,Morula view,Mabopane', '0178289421', 'admin/uploads/1190_File_IMG_20140511_115817.jpg', 'Family', 'my bro', '2015-10_08 : 10:54'),
(7, 224, 'Letlhogile Tsienyane', '0722953942', '0722953942', 'isaactsienyane@gmail.com', '0151315444', '7888 phase 4,Morula view,Mabopane', '0212513125', 'admin/uploads/9254_File_img-20150907-wa0004-001.jpg', 'Friends', 'web developer in the making', '2015-10_08 : 11:03');

-- --------------------------------------------------------

--
-- Table structure for table `content`
--

CREATE TABLE IF NOT EXISTS `content` (
  `content_id` int(11) NOT NULL AUTO_INCREMENT,
  `title` varchar(100) NOT NULL,
  `content` mediumtext NOT NULL,
  PRIMARY KEY (`content_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=15 ;

--
-- Dumping data for table `content`
--

INSERT INTO `content` (`content_id`, `title`, `content`) VALUES
(1, 'Mission', 'Your private,secure & beautiful online diary.'),
(2, 'Vision', 'We will keep the site as secure as possible but please be careful with your personal information.'),
(3, 'History', ''),
(4, 'Footer', '<p style="text-align:center">Online Diary Managenment System</p>\n\n<p style="text-align:center">All Rights Reserved &reg;2013</p>\n'),
(5, 'Upcoming Events', ''),
(6, 'Title', '<p><span style="font-family:trebuchet ms,geneva">Online Diary Management System</span></p>\n'),
(7, 'News', ''),
(8, 'Announcements', ''),
(10, 'Calendar', ''),
(11, 'Directories', ''),
(12, 'president', ''),
(13, 'motto', ''),
(14, 'Campuses', '');

-- --------------------------------------------------------

--
-- Table structure for table `event`
--

CREATE TABLE IF NOT EXISTS `event` (
  `event_id` int(11) NOT NULL AUTO_INCREMENT,
  `user_id` int(11) NOT NULL,
  `event_title` varchar(100) NOT NULL,
  `note` text NOT NULL,
  `date_start` varchar(100) NOT NULL,
  `date_end` varchar(100) NOT NULL,
  PRIMARY KEY (`event_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `files`
--

CREATE TABLE IF NOT EXISTS `files` (
  `file_id` int(11) NOT NULL AUTO_INCREMENT,
  `floc` varchar(500) NOT NULL,
  `fdatein` varchar(200) NOT NULL,
  `fdesc` varchar(100) NOT NULL,
  `user_id` int(11) NOT NULL,
  `share_id` int(11) NOT NULL,
  `fname` varchar(100) NOT NULL,
  `uploaded_by` varchar(100) NOT NULL,
  PRIMARY KEY (`file_id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=142 ;

--
-- Dumping data for table `files`
--

INSERT INTO `files` (`file_id`, `floc`, `fdatein`, `fdesc`, `user_id`, `share_id`, `fname`, `uploaded_by`) VALUES
(138, 'admin/uploads/2711_File_goods clearance(part).docx', '2014-07-30 15:28:00', 'project material for goods clearance system', 111, 249, 'Good clearance system', 'Mark Isay'),
(139, 'admin/uploads/6230_File_banking.png', '2014-09-04 07:54:15', 'image', 221, 111, 'pix', 'Grace Amaka'),
(140, 'admin/uploads/7518_File_img-20150907-wa0004-001.jpg', '2015-10-08 10:55:42', 'my brother''s graduation', 223, 0, 'abuti', 'naledimolefe'),
(141, 'admin/uploads/7777_File_IMG-20150907-WA0011.jpg', '2015-10-08 11:01:35', 'He made us proud', 224, 0, 'zak', 'Tshiamomolefe');

-- --------------------------------------------------------

--
-- Table structure for table `group`
--

CREATE TABLE IF NOT EXISTS `group` (
  `id` int(4) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `group`
--

INSERT INTO `group` (`id`, `name`) VALUES
(1, 'Family'),
(2, 'Friends');

-- --------------------------------------------------------

--
-- Table structure for table `message`
--

CREATE TABLE IF NOT EXISTS `message` (
  `message_id` int(11) NOT NULL AUTO_INCREMENT,
  `reciever_id` int(11) NOT NULL,
  `content` varchar(400) NOT NULL,
  `date_sended` varchar(100) NOT NULL,
  `sender_id` int(11) NOT NULL,
  `reciever_name` varchar(50) NOT NULL,
  `sender_name` varchar(200) NOT NULL,
  `message_status` varchar(100) NOT NULL,
  PRIMARY KEY (`message_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=17 ;

--
-- Dumping data for table `message`
--

INSERT INTO `message` (`message_id`, `reciever_id`, `content`, `date_sended`, `sender_id`, `reciever_name`, `sender_name`, `message_status`) VALUES
(14, 222, 'hi bro,have I told u I love u latetly!!', '2015-10-08 10:55:08', 223, '222', 'naledi molefe', ''),
(15, 0, 'Lol engrish sisi', '2015-10-08 10:58:37', 222, '', 'isaac Tsienynae', ''),
(16, 222, 'Yo bro this website is great hey,keep it up and you will be a great  developer soon!', '2015-10-08 11:01:08', 224, '222', 'Tshiamo molefe', '');

-- --------------------------------------------------------

--
-- Table structure for table `message_sent`
--

CREATE TABLE IF NOT EXISTS `message_sent` (
  `message_sent_id` int(11) NOT NULL AUTO_INCREMENT,
  `reciever_id` int(11) NOT NULL,
  `content` varchar(400) NOT NULL,
  `date_sended` varchar(100) NOT NULL,
  `sender_id` int(11) NOT NULL,
  `reciever_name` varchar(100) NOT NULL,
  `sender_name` varchar(100) NOT NULL,
  PRIMARY KEY (`message_sent_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=19 ;

--
-- Dumping data for table `message_sent`
--

INSERT INTO `message_sent` (`message_sent_id`, `reciever_id`, `content`, `date_sended`, `sender_id`, `reciever_name`, `sender_name`) VALUES
(17, 222, 'hi bro,have I told u I love u latetly!!', '2015-10-08 10:55:08', 223, '222', 'naledi molefe'),
(18, 222, 'Yo bro this website is great hey,keep it up and you will be a great  developer soon!', '2015-10-08 11:01:08', 224, '222', 'Tshiamo molefe');

-- --------------------------------------------------------

--
-- Table structure for table `notification`
--

CREATE TABLE IF NOT EXISTS `notification` (
  `notification_id` int(11) NOT NULL AUTO_INCREMENT,
  `notification` varchar(100) NOT NULL,
  `date_of_notification` varchar(50) NOT NULL,
  `link` varchar(100) NOT NULL,
  PRIMARY KEY (`notification_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=15 ;

--
-- Dumping data for table `notification`
--

INSERT INTO `notification` (`notification_id`, `notification`, `date_of_notification`, `link`) VALUES
(3, 'Add Annoucements', '2014-01-17 14:36:32', 'announcements_student.php'),
(14, 'Add Downloadable Materials file name <b>q</b>', '2014-02-21 16:52:30', 'downloadable_student.php');

-- --------------------------------------------------------

--
-- Table structure for table `notification_read`
--

CREATE TABLE IF NOT EXISTS `notification_read` (
  `notification_read_id` int(11) NOT NULL AUTO_INCREMENT,
  `student_id` int(11) NOT NULL,
  `student_read` varchar(50) NOT NULL,
  `notification_id` int(11) NOT NULL,
  PRIMARY KEY (`notification_read_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `student_backpack`
--

CREATE TABLE IF NOT EXISTS `student_backpack` (
  `file_id` int(11) NOT NULL AUTO_INCREMENT,
  `floc` varchar(100) NOT NULL,
  `fdatein` varchar(100) NOT NULL,
  `fdesc` varchar(100) NOT NULL,
  `user_id` int(11) NOT NULL,
  `fname` varchar(100) NOT NULL,
  PRIMARY KEY (`file_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `tbluser`
--

CREATE TABLE IF NOT EXISTS `tbluser` (
  `user_id` int(11) NOT NULL AUTO_INCREMENT,
  `e_id` int(100) NOT NULL,
  `firstname` varchar(100) NOT NULL,
  `lastname` varchar(100) NOT NULL,
  `username` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  `location` varchar(100) NOT NULL,
  `status` varchar(100) NOT NULL,
  `about` varchar(400) NOT NULL,
  PRIMARY KEY (`user_id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=23123 ;

--
-- Dumping data for table `tbluser`
--

INSERT INTO `tbluser` (`user_id`, `e_id`, `firstname`, `lastname`, `username`, `password`, `location`, `status`, `about`) VALUES
(23121, 23121, 'Jahangir', 'Alam', 'jahangir', '1111', 'uploads/jahangir.jpg', 'Registred', 'Accountant'),
(23122, 23122, 'Minhaz', 'Mamun', 'minhaz', '1111', 'uploads/minhaz.jpg', 'Registred', 'Programmer');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE IF NOT EXISTS `users` (
  `user_id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  `firstname` varchar(100) NOT NULL,
  `lastname` varchar(100) NOT NULL,
  PRIMARY KEY (`user_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=16 ;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`user_id`, `username`, `password`, `firstname`, `lastname`) VALUES
(15, 'admin', 'admin', 'admin', 'admin');

-- --------------------------------------------------------

--
-- Table structure for table `user_backpack`
--

CREATE TABLE IF NOT EXISTS `user_backpack` (
  `file_id` int(11) NOT NULL AUTO_INCREMENT,
  `floc` varchar(100) NOT NULL,
  `fdatein` varchar(100) NOT NULL,
  `fdesc` varchar(100) NOT NULL,
  `user_id` int(11) NOT NULL,
  `fname` varchar(100) NOT NULL,
  PRIMARY KEY (`file_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `user_log`
--

CREATE TABLE IF NOT EXISTS `user_log` (
  `user_log_id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(25) NOT NULL,
  `login_date` varchar(30) NOT NULL,
  `logout_date` varchar(30) NOT NULL,
  `user_id` int(11) NOT NULL,
  PRIMARY KEY (`user_log_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=84 ;

--
-- Dumping data for table `user_log`
--

INSERT INTO `user_log` (`user_log_id`, `username`, `login_date`, `logout_date`, `user_id`) VALUES
(1, 'admin', '2013-11-01 11:57:33', '2013-11-18 10:33:54', 10),
(83, 'admin', '2014-06-15 12:31:51', '', 15);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
