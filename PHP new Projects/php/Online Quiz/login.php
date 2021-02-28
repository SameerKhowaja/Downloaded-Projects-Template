<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<link rel="stylesheet"type="text/css" media="all" href="mystyle.css">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>LOG IN['ADMIN']</title>
</head>
<style>font{
	font-family:Segoe, "Segoe UI", "DejaVu Sans", "Trebuchet MS", Verdana, sans-serif;}</style>

<body>
<form method="post">
<div style="background:#993; padding:7px; margin-left:30%; margin-right:30%;">


<?php
include('config.php');
if(isset($_POST['send'])){
	$use=$_POST['usern'];
	$passw=$_POST['passw'];
	$result=mysql_query("SELECT * from user where Username='$use' and Password='$passw'");
	$row=mysql_fetch_array($result); 
	$count=mysql_num_rows($result);

if($count==1){
	session_start();
	$_SESSION['ID']=$row['ID'];

header('location:view.php');
	
	
	}
	else{
		echo'<s>INVALID USERNAME AND PASSWORD</s>';
		}

	
	}
 ?>
 <br />
<font>USERNAME<br /><input type="text" name="usern" width="50%"/></font><br />
<font>PASSWORD<br/><input type="password" name="passw" width="50%"/></font><br />

<matt><input type="submit" value="Log-in" name="send"/></matt>
</div>
</form>
</body>

</html>