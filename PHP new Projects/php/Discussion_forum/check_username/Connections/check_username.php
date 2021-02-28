<?php
# FileName="Connection_php_mysql.htm"
# Type="MYSQL"
# HTTP="true"
$hostname_check_username = "localhost";
$database_check_username = "check_username";
$username_check_username = "root";
$password_check_username = "";
$check_username = mysql_pconnect($hostname_check_username, $username_check_username, $password_check_username) or trigger_error(mysql_error(),E_USER_ERROR); 
?>