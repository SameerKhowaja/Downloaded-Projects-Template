<?php
include('includes/dbcon.php');
$id=$_GET['id'];
mysql_query("DELETE FROM books where accession_no='$id'")or die(mysql_error());
header('location:books.php');
?>