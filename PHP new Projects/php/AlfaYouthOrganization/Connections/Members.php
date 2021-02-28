<?php
# FileName="Connection_php_mysql.htm"
# Type="MYSQL"
# HTTP="true"
$hostname_Members = "localhost";
$database_Members = "alfaregistration";
$username_Members = "root";
$password_Members = "";
$Members = @mysql_pconnect($hostname_Members, $username_Members, $password_Members) or trigger_error(mysql_error(),E_USER_ERROR); 
?>