<?php

// This is a sample code in case you wish to check the username from a mysql db table

if(isSet($_POST['username']))
{
$username = $_POST['username'];

include("dbcon.php");

$sql_check = mysql_query("SELECT user FROM {$prefix}users WHERE user='$username'");

if(mysql_num_rows($sql_check))
{
echo '<font color="red" style="margin-left:10px; font-size:14px;"> Username <STRONG>'.$username.'</STRONG> is already taken. Please Try Another One!</font>';
}
else
{
echo 'OK';
}

}

?>