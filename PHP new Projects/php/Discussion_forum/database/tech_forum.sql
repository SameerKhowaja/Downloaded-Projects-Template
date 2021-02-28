-- phpMyAdmin SQL Dump
-- version 2.8.1
-- http://www.phpmyadmin.net
-- 
-- Host: localhost
-- Generation Time: May 10, 2016 at 06:10 PM
-- Server version: 5.0.22
-- PHP Version: 5.1.4
-- 
-- Database: `tech_forum`
-- 

-- --------------------------------------------------------

-- 
-- Table structure for table `answer`
-- 

CREATE TABLE `answer` (
  `answer_id` int(11) NOT NULL auto_increment,
  `replied` int(11) NOT NULL,
  `question_id` varchar(50) NOT NULL,
  `answer_detail` varchar(2000) NOT NULL,
  `datetime` timestamp NOT NULL default CURRENT_TIMESTAMP,
  `user_id` int(11) NOT NULL,
  `like` int(20) NOT NULL,
  PRIMARY KEY  (`answer_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=49 ;

-- 
-- Dumping data for table `answer`
-- 

INSERT INTO `answer` VALUES (4, 0, '13', 'this is mehuls answer 1.... to the above asked question....', '2012-04-04 09:45:49', 0, 0);
INSERT INTO `answer` VALUES (5, 0, '13', 'rgua ua nt BIRWGEA baWEQWEHkah', '2012-04-05 14:44:56', 0, 0);
INSERT INTO `answer` VALUES (6, 0, '12', 'using the connectivity query', '2012-04-06 09:49:11', 8, 0);
INSERT INTO `answer` VALUES (7, 0, '14', 'the various stages are \r\nNew,Ready,Running,Blocked,Terminate', '2012-04-07 10:33:43', 9, 2);
INSERT INTO `answer` VALUES (8, 0, '16', 'In the star topology there is a centralized hub. The communication between various nodes through the hub.\r\nIn this type of network there is a bottleneck of the centralized hub.It is widely used in LAN connection.', '2012-04-08 09:14:09', 9, 0);
INSERT INTO `answer` VALUES (9, 0, '16', 'In the star topology there is a centralized hub. The communication between various nodes through the hub.\r\nIn this type of network there is a bottleneck of the centralized hub.It is widely used in LAN connection.', '2012-04-09 16:45:22', 9, 0);
INSERT INTO `answer` VALUES (11, 0, '17', 'You can do it withing Borland or VC++ IDE & Compiler.', '2012-04-11 04:15:51', 8, 0);
INSERT INTO `answer` VALUES (12, 0, '17', 'this is reply 1. and this reply is not 2nd...', '2012-04-13 06:49:44', 8, 0);
INSERT INTO `answer` VALUES (13, 0, '17', 'scheduling algorithm is carried out by various methods such as first come first schedule,round robin scheduling,etc;', '2012-04-11 16:33:46', 8, 0);
INSERT INTO `answer` VALUES (15, 0, '17', 'It has many method to explain the sheduling ', '2012-04-12 23:18:28', 12, 0);
INSERT INTO `answer` VALUES (16, 0, '21', 'swing is swing and applet is not swing.', '2012-04-13 15:20:50', 17, 0);
INSERT INTO `answer` VALUES (17, 0, '17', 'scheduling is....', '2012-04-18 14:49:44', 8, 0);
INSERT INTO `answer` VALUES (18, 0, '11', 'i got the answer', '2012-04-18 16:06:22', 9, 0);
INSERT INTO `answer` VALUES (20, 0, '12', 'connectivity with use of execute query and non-execute query\r\n', '2012-04-19 05:27:14', 8, 0);
INSERT INTO `answer` VALUES (21, 0, '17', '\r\n', '2012-04-21 15:30:38', 8, 0);
INSERT INTO `answer` VALUES (22, 0, '29', 'the thread is sub process...', '2012-04-24 17:41:23', 30, 0);
INSERT INTO `answer` VALUES (23, 0, '29', 'are vah', '2012-04-24 17:54:00', 8, 0);
INSERT INTO `answer` VALUES (24, 0, '31', '>This problem is faced with several of people all you have to do is make it stop doing MIME sniffing. You can disable this MIME sniffing by selecting IE the go to tools then to internet options then click custom level after that select Miscellaneous section. After that scroll down in this section then check enable underâ€ open files based on content, not the file extensionâ€', '2012-04-25 16:48:39', 12, 0);
INSERT INTO `answer` VALUES (25, 0, '32', 'The problem was with the theme. Actually it was customized video game theme that was causing the error. Now its working proper.', '2012-04-25 16:49:35', 12, 0);
INSERT INTO `answer` VALUES (26, 0, '32', 'Can you post a screenshot of the problem ? Even I had never seen such problem that notifications turned black. If possible post the screenshot so that I can see what type of pop message in black color is coming in laptop. Till than you can try setting some another them and see if it works. Hope it will work.', '2012-04-25 16:50:25', 9, 0);
INSERT INTO `answer` VALUES (27, 0, '33', 'As i have doubt if you could reset it from the safe mode. But you can surely do it with the help of an application called "Windows Password Key". Here is the step by step process for doing the same:\r\n\r\n\r\nâ€¢	Download Windows Password key from http://www.lostwindowspassword.com/downloads/Windows_Password_Key_Standard_Demo.exe.\r\nâ€¢	Install it on any other PC that you can access easily.\r\nâ€¢	Now you need to burn a bootable CD/DVD Or better create a USB Flash Drive.\r\nâ€¢	Connect this USB or insert bootable DVD to your Windows 8 system and recover the password.\r\nThats it. \r\n', '2012-04-25 16:50:59', 9, 0);
INSERT INTO `answer` VALUES (28, 0, '34', 'C:WindowsSystem32shutdown.exe -s -t 0 -f', '2012-04-25 16:54:52', 9, 0);
INSERT INTO `answer` VALUES (29, 0, '35', 'I have read your question and I would keen to tell you that you can use Mozilla Firefox 10 in Linux-32 bit but before you do that you have to visit official site of the Mozilla Firefox. After that you need to select system and language below download option and then choose Linux installed and download that in your machine. Now you have to install it in your machine. I guess this will bring an end to your problem.', '2012-04-25 17:07:16', 12, 0);
INSERT INTO `answer` VALUES (30, 0, '36', 'Hi friends, as o know there are many users who are really in need of the Google chrome themes but are unable to install the same. So I have started this thread to give you people a fair idea regarding the same. So now to install the theme you just need to follow the below mentioned steps:\r\n\r\nStep 1: Start Google Chrome and go to this web address . Google runs its own themes, in fact online.\r\n\r\nStep 2: Navigate in the themes and click Apply Theme, once it is selected.\r\n\r\nStep 3: Downloading and installation are automatic, and your theme is applied instantly. However, you can cancel it by clicking the Cancel button in the upper right of the browser!', '2012-04-25 17:16:37', 9, 0);
INSERT INTO `answer` VALUES (31, 0, '37', 'Happili.com is deeply infiltrated into victimsâ€™ system. To remove Happili.com, please follow below instruction:\r\n1.       reboot your system into safe mode with networking;\r\n2.       download Anvi Smart Defender and install it;\r\n3.       Fully scan your computer;\r\n4.       delete Happili.com Redirect Virus related file:\r\nQuote\r\n    * %AllUsersProfile%{random}\r\n    * %AllUsersProfile%{random}*.lnk\r\n    * HKEY_CURRENT_USERSoftwareMicrosoftWindowsCurrentVersionRunOnce [RANDOM]\r\n    * HKEY_CURRENT_USERSoftwareMicrosoftWindowsCurrentVersionRun [RANDOM]\r\n    * HKEY_LOCAL_MACHINESOFTWAREMicrosoftWindowsCurrentVersionRun [RANDOM].exe\r\n    * HKEY_CURRENT_USERSoftware[RANDOM]\r\n5.  restart your computer;\r\n', '2012-04-25 17:27:26', 15, 0);
INSERT INTO `answer` VALUES (32, 0, '38', 'The Google Redirect Virus is a real and serious threat to PCs around the world.  The main symptom of this virus is that the search results of Google users will be diverted, and instead of being directed to legitimate sites will redirect to malicious websites distributing spyware to sell rogue security tools and distribution of viruses and infections.  The Google Redirect Virus is hidden in your PC, and once activated will make it nearly impossible for the user to use any search engine. What makes Google Redirect Virus hijackers even more dangerous than a normal search engine is the fact that you can use up to 100% of system resources, making the system almost impossible to operate.  Google Redirect Virus will also create a backdoor on the system that other types of malware that exploit the system for easy entry.\r\n\r\nAlthough it is popularly referred to by the title of the virus, the virus is more skillfully Google Redirect classified as a rootkit or Trojan.  This threat is caused by several types of TDSS rootkit, some of which goes by the name of: \r\nâ€¢	Alureon \r\nâ€¢	Tidserv \r\nâ€¢	Backdoor.Tidserv \r\nâ€¢	Trojan: WinNT / Alureon.D \r\nâ€¢	TrojanSpy: Win32/Chadem.A and many other\r\nGoogle Redirect Virus blocks ads and Google search pages show random ads that contain dubious and link spammers and malware sites.  In fact, Google search results are hijacked, making it impossible for the user to perform an online search.After the user is redirected to a website unrelated to their initial research, some websites you can use to generate false traffic to increase their payments to affiliate marketing, while others attempt to trick you to buy harmful rogue security tools. Another big problem with Google Redirect Virus is that you can hide from security tools installed.  It will not be picked up by many security tools, and then the user may find it difficult to detect and remove Google Redirect virus from the system.  It does this by injecting the same memory and processes to enabl', '2012-04-25 17:30:56', 15, 4);
INSERT INTO `answer` VALUES (37, 0, '39', 'As for a listing on a wired network, it needs to be physically connected by Wi-Fi, anyone within range of the network can potentially connect to it.  And this is even more annoying than the intruder may not be visible: this can be a neighbor, passing in the street, in short, anyone.  Then he is free to browse the hard drive of your PC connected to the unprotected or using your Internet inappropriately, you yourself are responsible for the acts he might commit.  Fortunately, it is possible to prevent this. \r\n\r\nThe default settings for access points and wireless routers are not secure and allow anyone to connect to your network.  Thus, the majority of users switching to Wi-Fi, seeing that the wireless works straight start, do not go further and do not seek to secure it, which is extremely risky.  Here is how to properly configure your Wi-Fi to make it safer.\r\n\r\nIn our example, we used Orange Livebox. However, the features and options listed are present in most of the box, routers and access points Wi-Fi market.  Do not hesitate to refer to your hardware documentation for more information and find out how to access a specific feature.\r\n', '2012-04-25 17:45:57', 9, 0);
INSERT INTO `answer` VALUES (40, 0, '40', 'If your broadband connection is slower than it should be, it may be due to the configuration of your network or computer.  If you tell your company that your Internet connection is slow, probably say that the problem is on your computer and will not be responsible.  This guide will show you what you can do to improve the speed of your connection. Before making any changes to your settings, turn off the router or access point to Internet and back on.  Sometimes the connection can be slow due to a failure point in the output device to the Internet. ', '2012-04-25 17:53:40', 15, 0);
INSERT INTO `answer` VALUES (41, 0, '14', 'thre are 5 stages witch are ready,running,wait,block,release ', '2012-04-26 15:55:00', 15, 6);
INSERT INTO `answer` VALUES (42, 0, '14', '1.ready\r\n2.running\r\n3.wait\r\n4.block\r\n5.release', '2012-04-26 15:56:15', 8, 9);
INSERT INTO `answer` VALUES (43, 0, '7', 'jjjjjjj', '2012-04-27 07:44:09', 8, 0);
INSERT INTO `answer` VALUES (44, 0, '41', 'THIS HAS FIVE STAPE', '2012-04-27 09:06:41', 8, 1);
INSERT INTO `answer` VALUES (45, 0, '39', 'ddddddddd', '2015-10-25 10:11:16', 8, 0);
INSERT INTO `answer` VALUES (46, 0, '39', 'dfdfdf', '2015-10-25 10:11:31', 8, 0);
INSERT INTO `answer` VALUES (47, 0, '42', 'Rasmus Lerdorfffffffff', '2015-10-25 10:12:40', 8, 0);
INSERT INTO `answer` VALUES (48, 0, '43', 'hallo', '2016-04-29 22:22:05', 5, 0);

-- --------------------------------------------------------

-- 
-- Table structure for table `chat`
-- 

CREATE TABLE `chat` (
  `chatdetail_id` int(11) NOT NULL auto_increment,
  `cdatetime` timestamp NOT NULL default CURRENT_TIMESTAMP,
  `message` varchar(1000) NOT NULL,
  `user_id` int(11) NOT NULL,
  `chat_id` int(11) NOT NULL,
  PRIMARY KEY  (`chatdetail_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=41 ;

-- 
-- Dumping data for table `chat`
-- 

INSERT INTO `chat` VALUES (13, '2012-04-17 17:28:03', 'hi fabin im hardik', 8, 5);
INSERT INTO `chat` VALUES (14, '2012-04-17 17:28:22', 'ka vikla', 8, 6);
INSERT INTO `chat` VALUES (15, '2012-04-17 17:41:26', 'hi', 9, 5);
INSERT INTO `chat` VALUES (16, '2012-04-17 17:42:12', 'how r u', 9, 5);
INSERT INTO `chat` VALUES (17, '2012-04-17 17:42:55', 'hello', 9, 5);
INSERT INTO `chat` VALUES (18, '2012-04-17 17:43:32', 'hi', 9, 5);
INSERT INTO `chat` VALUES (19, '2012-04-17 17:43:52', 'kaise ho ?', 9, 5);
INSERT INTO `chat` VALUES (20, '2012-04-17 17:43:58', 'm fine', 9, 5);
INSERT INTO `chat` VALUES (21, '2012-04-17 17:44:36', 'this is hardik', 9, 5);
INSERT INTO `chat` VALUES (22, '2012-04-17 17:46:39', 'now its fine', 9, 5);
INSERT INTO `chat` VALUES (23, '2012-04-17 17:46:49', 'hardik here', 8, 5);
INSERT INTO `chat` VALUES (24, '2012-04-18 12:37:31', 'shu karo 6o', 5, 7);
INSERT INTO `chat` VALUES (25, '2012-04-18 12:41:37', 'are hardik hu hato ato', 12, 8);
INSERT INTO `chat` VALUES (26, '2012-04-18 12:46:28', 'are shu photo mast mukyo 6e', 8, 9);
INSERT INTO `chat` VALUES (27, '2012-04-19 15:12:32', 'are dipak avyo 6e ', 12, 8);
INSERT INTO `chat` VALUES (28, '2012-04-21 14:53:43', 'hi\r\n', 8, 10);
INSERT INTO `chat` VALUES (32, '2012-04-24 11:12:28', 'aaaaaaa', 5, 13);
INSERT INTO `chat` VALUES (35, '2012-04-24 17:52:42', 'shu bhai', 30, 16);
INSERT INTO `chat` VALUES (36, '2012-04-26 16:08:05', 'what is message passing system in the distributed application?', 9, 17);
INSERT INTO `chat` VALUES (37, '2012-04-26 16:09:39', 'why synchronization require in the distributed system? ', 9, 18);
INSERT INTO `chat` VALUES (38, '2012-04-27 07:46:00', 'how is your work going on?\r\n', 8, 19);
INSERT INTO `chat` VALUES (39, '2015-10-25 10:08:31', 'ddddddddd', 5, 20);
INSERT INTO `chat` VALUES (40, '2016-03-11 23:46:57', 'hey Mr', 5, 21);

-- --------------------------------------------------------

-- 
-- Table structure for table `chatmaster`
-- 

CREATE TABLE `chatmaster` (
  `chat_id` int(11) NOT NULL auto_increment,
  `user_id_from` int(11) NOT NULL,
  `user_id_to` int(11) NOT NULL,
  PRIMARY KEY  (`chat_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=22 ;

-- 
-- Dumping data for table `chatmaster`
-- 

INSERT INTO `chatmaster` VALUES (5, 8, 9);
INSERT INTO `chatmaster` VALUES (6, 8, 12);
INSERT INTO `chatmaster` VALUES (7, 5, 8);
INSERT INTO `chatmaster` VALUES (8, 12, 8);
INSERT INTO `chatmaster` VALUES (9, 8, 5);
INSERT INTO `chatmaster` VALUES (10, 8, 9);
INSERT INTO `chatmaster` VALUES (11, 8, 5);
INSERT INTO `chatmaster` VALUES (12, 8, 5);
INSERT INTO `chatmaster` VALUES (13, 5, 8);
INSERT INTO `chatmaster` VALUES (14, 5, 8);
INSERT INTO `chatmaster` VALUES (15, 29, 8);
INSERT INTO `chatmaster` VALUES (16, 30, 5);
INSERT INTO `chatmaster` VALUES (17, 9, 15);
INSERT INTO `chatmaster` VALUES (18, 9, 12);
INSERT INTO `chatmaster` VALUES (19, 8, 15);
INSERT INTO `chatmaster` VALUES (20, 5, 8);
INSERT INTO `chatmaster` VALUES (21, 5, 32);

-- --------------------------------------------------------

-- 
-- Table structure for table `question`
-- 

CREATE TABLE `question` (
  `question_id` int(11) NOT NULL auto_increment,
  `heading` varchar(50) NOT NULL,
  `question_detail` varchar(2000) NOT NULL,
  `datetime` timestamp NOT NULL default CURRENT_TIMESTAMP,
  `user_id` int(11) NOT NULL,
  `subtopic_id` int(11) NOT NULL,
  `views` int(11) NOT NULL,
  PRIMARY KEY  (`question_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=44 ;

-- 
-- Dumping data for table `question`
-- 

INSERT INTO `question` VALUES (7, 'table connectivity', 'query of the connecting table with form?', '2012-04-11 12:42:44', 8, 7, 10);
INSERT INTO `question` VALUES (8, 'Window Xp', 'how to debbuge the ble screen error?', '2012-04-11 03:25:00', 8, 5, 1);
INSERT INTO `question` VALUES (9, 'Window vista', 'hot to change the administrator password from cmd?', '2012-04-03 20:51:44', 8, 5, 0);
INSERT INTO `question` VALUES (10, 'Window 7', 'how to make uninstall set up? ', '2012-04-05 05:24:42', 8, 5, 3);
INSERT INTO `question` VALUES (11, 'linux', 'how to use the live source of l\r\n', '2012-04-07 03:51:42', 9, 5, 6);
INSERT INTO `question` VALUES (12, 'connectivity', 'how to connect form with database?', '2012-04-09 12:01:36', 8, 2, 5);
INSERT INTO `question` VALUES (14, 'Thread life cycle', 'What are the different stages of thread life cycle?\r\n', '2012-04-10 02:04:43', 9, 12, 189);
INSERT INTO `question` VALUES (15, 'applet controls ', 'how to create simple applet program? ', '2012-04-12 15:02:44', 9, 13, 6);
INSERT INTO `question` VALUES (16, 'STAR topology', 'how connection established in the star topology?\r\n', '2012-04-27 01:14:01', 9, 17, 1);
INSERT INTO `question` VALUES (17, 'Scheduling', 'Hello,\r\n\r\nI want to create a program that supports multi-threading with scheduling. The program must', '2012-04-17 18:41:54', 8, 12, 79);
INSERT INTO `question` VALUES (18, 'Sheduling algorithm', 'Explain the various scheduling algorithm?\r\n', '2012-04-11 16:13:25', 8, 0, 0);
INSERT INTO `question` VALUES (19, 'Sheduling algorithm', 'Explain the various scheduling algorithm?\r\n', '2012-04-11 16:13:54', 8, 0, 1);
INSERT INTO `question` VALUES (20, 'scheduling algorithm', 'Explain various scheduling algorithm used in the cpu scheduling?', '2012-04-11 16:18:47', 8, 12, 9);
INSERT INTO `question` VALUES (21, 'Swing Applet', 'I want to know the difference between normal Applet and Swing Applet.....\r\n\r\nAnd I also want to know', '2012-04-13 15:13:35', 16, 13, 12);
INSERT INTO `question` VALUES (22, 'Applet Class', 'What is applet class ?', '2012-04-13 16:13:37', 26, 13, 2);
INSERT INTO `question` VALUES (23, 'what is applet ?', 'what is applet ?\r\n\r\nIs it as class or package ?', '2012-04-13 16:18:45', 27, 13, 4);
INSERT INTO `question` VALUES (24, 'a', '', '2012-04-21 15:53:31', 8, 12, 0);
INSERT INTO `question` VALUES (25, 'thread ', 'explain the  various stages of thread', '2012-04-22 08:39:06', 8, 12, 6);
INSERT INTO `question` VALUES (26, '', '', '2012-04-24 07:15:11', 8, 12, 0);
INSERT INTO `question` VALUES (27, 'a', '', '2012-04-24 07:15:33', 8, 12, 0);
INSERT INTO `question` VALUES (28, 'a', '', '2012-04-24 07:17:32', 8, 12, 0);
INSERT INTO `question` VALUES (29, 'what', 'what is what', '2012-04-24 17:18:15', 28, 12, 7);
INSERT INTO `question` VALUES (30, 'What is thread ?', 'What is thread ?', '2012-04-24 17:38:03', 29, 12, 1);
INSERT INTO `question` VALUES (31, 'window 7', 'Windows 7, how can I open .jnlp extension in Internet Explorer 9?', '2012-04-25 16:25:05', 8, 12, 5);
INSERT INTO `question` VALUES (32, 'window vista', 'Unable to see taskbar notifications in Windows Vista SP2?', '2012-04-25 16:26:24', 8, 12, 5);
INSERT INTO `question` VALUES (33, 'window 8', 'How can i recover lost windows 8 Administrator password?', '2012-04-25 16:27:06', 8, 12, 4);
INSERT INTO `question` VALUES (34, 'windows 8', ' How to easily Shutdown Windows 8 Consumer preview?', '2012-04-25 16:52:35', 8, 12, 4);
INSERT INTO `question` VALUES (35, 'Mozila Browser', 'Operate Mozilla Firefox 10 in linux-32 Bit?', '2012-04-25 17:05:47', 9, 18, 11);
INSERT INTO `question` VALUES (36, 'Google Chrome Browser', 'How to install Google chrome themes?', '2012-04-25 17:14:33', 12, 18, 7);
INSERT INTO `question` VALUES (37, 'Happili ', 'How to remove Happili redirecting virus?', '2012-04-25 17:24:11', 9, 19, 22);
INSERT INTO `question` VALUES (38, 'Google Redirect Virus', 'How to remove Google redirect virus from Web browser?', '2012-04-25 17:29:52', 9, 19, 15);
INSERT INTO `question` VALUES (39, 'Secure Wi-Fi', 'Tips to create secure Wi-Fi', '2012-04-25 17:45:07', 15, 20, 8);
INSERT INTO `question` VALUES (40, 'Connection speed', 'How to increase the speed of your broadband connection?', '2012-04-25 17:53:08', 9, 20, 2);
INSERT INTO `question` VALUES (41, 'THREADING', 'WHAT IS THREADING?', '2012-04-27 09:05:09', 32, 12, 12);
INSERT INTO `question` VALUES (42, 'Who is the father of php', 'Any one tell me who is the father of php ???????', '2015-10-25 10:12:11', 8, 12, 2);
INSERT INTO `question` VALUES (43, 'THREADERS', 'WHAT DO WE BENEFIT FROM THREADERS', '2016-04-27 09:27:28', 41, 0, 5);

-- --------------------------------------------------------

-- 
-- Table structure for table `subtopic`
-- 

CREATE TABLE `subtopic` (
  `subtopic_id` int(11) NOT NULL auto_increment,
  `subtopic_name` varchar(50) NOT NULL,
  `subtopic_description` varchar(500) NOT NULL,
  `s_status` varchar(20) NOT NULL,
  `topic_id` int(11) NOT NULL,
  PRIMARY KEY  (`subtopic_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=21 ;

-- 
-- Dumping data for table `subtopic`
-- 

INSERT INTO `subtopic` VALUES (2, 'php', 'web', 'tr', 10);
INSERT INTO `subtopic` VALUES (3, 'connectivity', 'data table', 'ss', 11);
INSERT INTO `subtopic` VALUES (4, 'html', 'web page design', 'ss', 13);
INSERT INTO `subtopic` VALUES (6, 'Threading', 'Info about Thread & Runnable', 'tr', 7);
INSERT INTO `subtopic` VALUES (7, 'file management', 'exception handling', 'tr', 8);
INSERT INTO `subtopic` VALUES (8, 'i/o management', 'data string handler', 'tr', 8);
INSERT INTO `subtopic` VALUES (11, 'Move', 'how to move file from one location to another', 'tr', 13);
INSERT INTO `subtopic` VALUES (12, 'Threading', 'About Thread Life Cycle', 'true', 17);
INSERT INTO `subtopic` VALUES (13, 'applet controls', 'discussion of the controls of applet', 'true', 18);
INSERT INTO `subtopic` VALUES (14, 'ExecutingQuery in sql', 'types of sql queries', 'true', 19);
INSERT INTO `subtopic` VALUES (15, 'Non Executing Query', 'Select Query', 'tr', 19);
INSERT INTO `subtopic` VALUES (16, '8085 processor', 'block diagram discription', 'tr', 21);
INSERT INTO `subtopic` VALUES (17, 'network types', 'types of topologies', 'tr', 22);
INSERT INTO `subtopic` VALUES (18, 'Application Related', 'Any querys Related Apps', 'tr', 23);
INSERT INTO `subtopic` VALUES (19, 'Virus Solution', 'How we solve virus problems', 'tr', 24);
INSERT INTO `subtopic` VALUES (20, 'Network Related', 'Network Related Querys', 'tr', 25);

-- --------------------------------------------------------

-- 
-- Table structure for table `topic`
-- 

CREATE TABLE `topic` (
  `topic_id` int(11) NOT NULL auto_increment,
  `topic_name` varchar(50) NOT NULL,
  `topic_type` varchar(50) NOT NULL,
  PRIMARY KEY  (`topic_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=27 ;

-- 
-- Dumping data for table `topic`
-- 

INSERT INTO `topic` VALUES (17, 'Operating System', 'Threading');
INSERT INTO `topic` VALUES (18, 'Applet', 'JAVA');
INSERT INTO `topic` VALUES (19, 'Php Database connectivity', 'PHP');
INSERT INTO `topic` VALUES (21, 'Microprocessor', 'Processor');
INSERT INTO `topic` VALUES (23, 'Applications', 'Os Applications');
INSERT INTO `topic` VALUES (24, 'Virus', 'Virus solution');
INSERT INTO `topic` VALUES (25, 'Networks', 'Networks Related Querys');
INSERT INTO `topic` VALUES (26, 'projects', 'proposals and concept papers');

-- --------------------------------------------------------

-- 
-- Table structure for table `user`
-- 

CREATE TABLE `user` (
  `user_id` int(11) NOT NULL auto_increment,
  `country` varchar(50) NOT NULL,
  `state` varchar(50) NOT NULL,
  `address` varchar(500) NOT NULL,
  `user_type` varchar(50) NOT NULL,
  `username` varchar(50) default NULL,
  `fullname` varchar(50) default NULL,
  `password` varchar(50) default NULL,
  `user_acc_active` tinyint(1) default NULL,
  `dob` date NOT NULL,
  `e_mail` varchar(100) default NULL,
  `gender` varchar(20) NOT NULL,
  `uimg` varchar(255) NOT NULL,
  `isuser` tinyint(1) NOT NULL,
  PRIMARY KEY  (`user_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=42 ;

-- 
-- Dumping data for table `user`
-- 

INSERT INTO `user` VALUES (5, 'U.S.A', 'ahmedabad', '-', 'admin', 'admin', 'administrator', '12345', NULL, '2012-04-17', 'admin@gmail.com', '1', 'ups/admin.jpg', 0);
INSERT INTO `user` VALUES (33, 'Bugujju', 'ups/', 'kampala', 'user', 'amos', 'ak amos', '12345', NULL, '2000-03-13', 'amos@gmail.com', '1', 'ups/12535834_1730203970542411_1822139480_n_0000004097.jpg', 0);
INSERT INTO `user` VALUES (35, 'mukono', 'mukono', 'Turkmenistan', 'user', 'A53530', 'mutyaba', 'mutyaba', NULL, '1999-10-10', 'mutyaba@gmail.com', 'male', '', 0);
INSERT INTO `user` VALUES (36, 'mukono', 'bugujju', 'Turkmenistan', 'user', 'A53530', 'MUTYABA', 'mutyaba', NULL, '1990-10-10', 'mutyaba@gmail.com', 'male', '', 0);
INSERT INTO `user` VALUES (38, 'mukono', 'bugujju', 'Uganda', 'user', 'A53530', 'MUTYABA', 'mutyaba', NULL, '1990-10-10', 'mutyaba@gmail.com', 'male', '', 0);
INSERT INTO `user` VALUES (39, 'bugujju', 'mukono', 'Uganda', 'user', 'A53531', 'bugule', 'password', NULL, '1999-10-23', 'mike@gmail.com', 'male', '', 0);
INSERT INTO `user` VALUES (40, 'bugujju', 'mukono', 'Uganda', 'user', 'A54540', 'mukisa', 'mukisa', NULL, '1994-10-02', 'mukisa@gmail.com', 'male', '', 1);
INSERT INTO `user` VALUES (41, 'agape', 'bugujju', 'Turkey', 'user', 'A54541', 'TESTERS', 'TEST123', NULL, '1997-10-10', 'test@gmail.com', 'male', '', 0);