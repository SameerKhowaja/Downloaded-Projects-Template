<?php 

include('include/database.php');
include('session.php');

$get_id=$_GET['id'];

$history_record=mysql_query("select * from user where user_id=$id_session");
$row=mysql_fetch_array($history_record);
$user=$row['firstname']." ".$row['lastname'];
$user_access = $row['access'];
if($user_access = 'admin'){
mysql_query("INSERT INTO history (date,action,data) VALUES (NOW(),'Delete staff','$user')")or die(mysql_error());

mysql_query("delete from staff where id = '$get_id' ")or die(mysql_error());

header('location:staff.php');}
else{
	echo "<script> alert('Action Denied for user. Please login as admin'); window.location = 'home.php'; </script>";
}
?>