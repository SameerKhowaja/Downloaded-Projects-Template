<?php 
	mysql_select_db('bankdb', @mysql_connect("localhost", "root", "")) or die ('cannot connect to database' . mysql_error());
?>