<?php 

include('include/database.php');
include('session.php');

$get_id=$_GET['id'];

$history_record=mysql_query("select * from user where user_id=$id_session");
$row=mysql_fetch_array($history_record);
$user=$row['firstname']." ".$row['lastname'];
mysql_query("INSERT INTO history (date,action,data) VALUES (NOW(),'Delete buy','$user')")or die(mysql_error());

mysql_query("delete from buy where buy_id = '$get_id' ")or die(mysql_error());

header('location:buy.php');
?>