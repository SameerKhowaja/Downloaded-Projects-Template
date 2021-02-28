<?php require_once('Connections/discussion.php'); ?>
<?php
mysql_select_db($database_discussion, $discussion);
$query_Recordset1 = "SELECT * FROM `user`";
$Recordset1 = mysql_query($query_Recordset1, $discussion) or die(mysql_error());
$row_Recordset1 = mysql_fetch_assoc($Recordset1);
$totalRows_Recordset1 = mysql_num_rows($Recordset1);

mysql_select_db($database_discussion, $discussion);
$query_Recordset2 = "SELECT * FROM `user`";
$Recordset2 = mysql_query($query_Recordset2, $discussion) or die(mysql_error());
$row_Recordset2 = mysql_fetch_assoc($Recordset2);
$totalRows_Recordset2 = mysql_num_rows($Recordset2);
  
ob_start();
require("utility.php"); ?>
<?php
$u_name=$_POST['username'];
$f_name=$_POST['fullname'];
$pwd=$_POST['password'];
$e_mail=$_POST['e_mail'];
$gender=$_POST['gender'];
$dob=$_POST['dob'];
$state=$_POST['state'];
$utype=$_POST['usertype'];
$count=$_POST['country'];
$add=$_POST['address'];


/*$ima = $_FILES['ima']['name'];
$imup=$_FILES['ima']['tmp_name'];

$path="ups/$ima";
move_uploaded_file($imup, $path);
*/

//$image = chunk_split(base64_encode(file_get_contents( $imup )));


$sql=" INSERT INTO user (username,fullname,password,e_mail,gender,dob,user_type,state,address,country) values ('$u_name','$f_name','$pwd','$e_mail','$gender','$dob','$utype','$add','$count','$state')";

$result=ExecuteNonQuery ($sql);

if($result)
{
	header("location:notification.php");
}
else
{
		header("location:register.php");
}

mysql_free_result($Recordset1);

mysql_free_result($Recordset2);
?>