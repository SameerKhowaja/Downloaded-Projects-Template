<?php

/* 
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
//connectoin


$host = 'localhost';
$username = 'root';
$password = '';
$database = 'admin_opac';

$mysqli = mysqli_connect($host,$username,$password,$database);

if (mysqli_connect_errno($mysqli)) {
   trigger_error('Database connection failed: '  . mysqli_connect_error(), E_USER_ERROR);
}

/**new books
function new_books(){
    
    //$all_books = mysql_query("SELECT * FROM books") or die(mysql_error());
$query = "SELECT * FROM books";
$result = mysqli_query($mysqli, $query) or trigger_error("Query Failed! SQL: $query - Error: ". mysqli_error($mysqli), E_USER_ERROR);

if($result) {
	while($row = mysqli_fetch_assoc($result)) {
		echo'Tito'. $row['title'] . '<br>';	
	}
} 

mysqli_close($mysqli);
    
    
    
    
}

