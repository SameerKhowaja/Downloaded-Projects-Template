<?php
//Start session
session_start();
//Check whether the session variable SESS_MEMBER_ID is present or not
if (!isset($_SESSION['staff']) ||(trim ($_SESSION['staff']) == '')) {
	header("location:".host()."../index.php");
    exit();
}
$session_id=$_SESSION['staff'];

$staff_query = mysql_query("select * from staff where staff_id = '$session_id'")or die(mysql_error());
$staff_row = mysql_fetch_array($staff_query);
$staff_fullname =$staff_row['firstname']." ".$staff_row['lastname'];
?>