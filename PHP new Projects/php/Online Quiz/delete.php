<?php

include ('config.php');//connection
session_start();
if(!isset($_SESSION['ID'])){
header('location:login.php');
}

$id=$_GET['id'];//GET the parameter passed by view.php


$res=mysql_query("update person set Deleted=0 WHERE id='$id'");
if($res){
	echo "<script language='javascript' type='text/javascript'>alert('Successfully Deleted!'); history.back();</script>";
	
	
	}