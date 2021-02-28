<?php
$host="localhost";
		$uname="root";
		$pas="";
		$db_name="fpms";
		$tbl_name="staff";
		
		@mysql_connect("$host","$uname","$pas") or die ("cannot connect");
		mysql_select_db("$db_name") or die ("cannot select db");
		?>