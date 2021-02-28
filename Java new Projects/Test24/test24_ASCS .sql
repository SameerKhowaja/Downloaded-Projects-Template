-- MySQL Administrator dump 1.4
--
-- ------------------------------------------------------
-- Server version	5.0.41-community-nt


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


--
-- Create schema test_24
--

CREATE DATABASE IF NOT EXISTS test_24;
USE test_24;

--
-- Definition of table `product`
--

DROP TABLE IF EXISTS `product`;
CREATE TABLE `product` (
  `p_id` int(10) unsigned NOT NULL auto_increment,
  `pname` varchar(45) NOT NULL,
  `qty` int(10) unsigned NOT NULL default '0',
  PRIMARY KEY  USING BTREE (`p_id`,`pname`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `product`
--

/*!40000 ALTER TABLE `product` DISABLE KEYS */;
INSERT INTO `product` (`p_id`,`pname`,`qty`) VALUES 
 (1,'A',10),
 (2,'Computer',11),
 (3,'Speaker',9),
 (4,'Mouse',5),
 (5,'Keyboard',0);
/*!40000 ALTER TABLE `product` ENABLE KEYS */;


--
-- Definition of table `purchase`
--

DROP TABLE IF EXISTS `purchase`;
CREATE TABLE `purchase` (
  `pur_id` int(10) unsigned NOT NULL auto_increment,
  `p_id` int(10) unsigned NOT NULL,
  `price` double NOT NULL,
  `pdate` date NOT NULL,
  `qty` int(10) unsigned NOT NULL,
  PRIMARY KEY  (`pur_id`),
  KEY `FK_purchase_pid` (`p_id`),
  CONSTRAINT `FK_purchase_pid` FOREIGN KEY (`p_id`) REFERENCES `product` (`p_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `purchase`
--

/*!40000 ALTER TABLE `purchase` DISABLE KEYS */;
INSERT INTO `purchase` (`pur_id`,`p_id`,`price`,`pdate`,`qty`) VALUES 
 (1,1,200,'2015-04-05',2),
 (2,1,200,'2015-04-05',2),
 (3,2,20000,'2015-08-06',3),
 (4,1,250,'2015-08-06',3),
 (5,2,25000,'2015-06-04',1),
 (6,3,1000,'2025-12-20',5),
 (7,3,1500,'2019-02-20',5),
 (8,2,20000,'2020-02-20',2),
 (9,2,40000,'2020-02-20',8),
 (10,1,2000,'2020-02-20',4),
 (11,4,3000,'2001-01-20',5),
 (12,1,2000,'2021-02-20',1),
 (13,1,2000,'2024-02-20',1),
 (14,1,4000,'2024-02-20',2);
/*!40000 ALTER TABLE `purchase` ENABLE KEYS */;


--
-- Definition of trigger `before_purchase`
--

DROP TRIGGER /*!50030 IF EXISTS */ `before_purchase`;

DELIMITER $$

CREATE DEFINER = `root`@`localhost` TRIGGER `before_purchase` BEFORE INSERT ON `purchase` FOR EACH ROW BEGIN
update product
set qty=qty+new.qty
where p_id=new.p_id;
END $$

DELIMITER ;

--
-- Definition of table `sale`
--

DROP TABLE IF EXISTS `sale`;
CREATE TABLE `sale` (
  `s_id` int(10) unsigned NOT NULL auto_increment,
  `p_id` int(10) unsigned NOT NULL,
  `price` double NOT NULL,
  `sdate` date NOT NULL,
  `qty` int(10) unsigned NOT NULL,
  PRIMARY KEY  (`s_id`),
  KEY `FK_sale_pid` (`p_id`),
  CONSTRAINT `FK_sale_pid` FOREIGN KEY (`p_id`) REFERENCES `product` (`p_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `sale`
--

/*!40000 ALTER TABLE `sale` DISABLE KEYS */;
INSERT INTO `sale` (`s_id`,`p_id`,`price`,`sdate`,`qty`) VALUES 
 (1,1,200,'2015-04-05',1),
 (2,1,2000,'2021-02-20',1),
 (3,1,2000,'2024-02-20',1),
 (4,1,4000,'2024-02-20',2),
 (5,2,7500,'2024-02-20',1),
 (6,2,15000,'2024-02-20',2),
 (7,3,300,'2024-02-20',1);
/*!40000 ALTER TABLE `sale` ENABLE KEYS */;


--
-- Definition of trigger `before_sale`
--

DROP TRIGGER /*!50030 IF EXISTS */ `before_sale`;

DELIMITER $$

CREATE DEFINER = `root`@`localhost` TRIGGER `before_sale` BEFORE INSERT ON `sale` FOR EACH ROW BEGIN
update product
set qty=qty-new.qty
where p_id=new.p_id;
END $$

DELIMITER ;

--
-- Definition of function `getProductId`
--

DROP FUNCTION IF EXISTS `getProductId`;

DELIMITER $$

/*!50003 SET @TEMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER' */ $$
CREATE DEFINER=`root`@`localhost` FUNCTION `getProductId`(product_name varchar(45)) RETURNS int(11)
BEGIN
return (select p_id from product where pname=product_name);
END $$
/*!50003 SET SESSION SQL_MODE=@TEMP_SQL_MODE */  $$

DELIMITER ;

--
-- Definition of procedure `listProduct`
--

DROP PROCEDURE IF EXISTS `listProduct`;

DELIMITER $$

/*!50003 SET @TEMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER' */ $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `listProduct`()
BEGIN
select pname from product;
END $$
/*!50003 SET SESSION SQL_MODE=@TEMP_SQL_MODE */  $$

DELIMITER ;

--
-- Definition of procedure `saveProduct`
--

DROP PROCEDURE IF EXISTS `saveProduct`;

DELIMITER $$

/*!50003 SET @TEMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER' */ $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `saveProduct`(productname varchar(45))
BEGIN
insert into product(pname) values(productname);
END $$
/*!50003 SET SESSION SQL_MODE=@TEMP_SQL_MODE */  $$

DELIMITER ;

--
-- Definition of procedure `save_purchase`
--

DROP PROCEDURE IF EXISTS `save_purchase`;

DELIMITER $$

/*!50003 SET @TEMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER' */ $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `save_purchase`(in id int,in price double,in dt date,in qt int)
BEGIN
insert into purchase(p_id, price, pdate, qty) values(id,price,dt,qt);
END $$
/*!50003 SET SESSION SQL_MODE=@TEMP_SQL_MODE */  $$

DELIMITER ;

--
-- Definition of procedure `save_sale`
--

DROP PROCEDURE IF EXISTS `save_sale`;

DELIMITER $$

/*!50003 SET @TEMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER' */ $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `save_sale`(in id int,in price double,in dt date,in qt int)
BEGIN
insert into sale(p_id, price, sdate, qty) values(id,price,dt,qt);
END $$
/*!50003 SET SESSION SQL_MODE=@TEMP_SQL_MODE */  $$

DELIMITER ;

--
-- Definition of procedure `view_product`
--

DROP PROCEDURE IF EXISTS `view_product`;

DELIMITER $$

/*!50003 SET @TEMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER' */ $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `view_product`()
BEGIN

select pname,qty from product;

END $$
/*!50003 SET SESSION SQL_MODE=@TEMP_SQL_MODE */  $$

DELIMITER ;

--
-- Definition of procedure `view_product_price`
--

DROP PROCEDURE IF EXISTS `view_product_price`;

DELIMITER $$

/*!50003 SET @TEMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER' */ $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `view_product_price`()
BEGIN
select product.pname,(sum(purchase.price)/sum(purchase.qty)) as Price from test_24.purchase inner join test_24.product on purchase.p_id=product.p_id group by purchase.p_id;
END $$
/*!50003 SET SESSION SQL_MODE=@TEMP_SQL_MODE */  $$

DELIMITER ;



/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
