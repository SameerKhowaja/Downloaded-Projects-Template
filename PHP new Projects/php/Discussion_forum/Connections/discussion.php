<?php
# FileName="Connection_php_mysql.htm"
# Type="MYSQL"
# HTTP="true"
$hostname_discussion = "localhost";
$database_discussion = "tech_forum";
$username_discussion = "root";
$password_discussion = "";
$discussion = mysql_pconnect($hostname_discussion, $username_discussion, $password_discussion) or trigger_error(mysql_error(),E_USER_ERROR); 
?>