<?php
	session_start();
	
	require 'database.php';
	
	if( isset($_SESSION['user_id'])) {
		
		$records = $conn->prepare('SELECT id, name, fathername,number, email, password FROM users WHERE id = :id');
		$records->bindParam(':id', $_SESSION['user_id']);
		$records->execute();
		$results = $records->fetch(PDO::FETCH_ASSOC);
		
		$user = NULL;
		
		if( count($results) > 0) {
			$user = $results;
		}
	}
?>

<!DOCTYPE html>
<html>
<head>
	<title>Welcome to your Web App</title>
	<link rel="stylesheet" type="text/css" href="assets/css/style.css">
	<link href='http://fonts.googleapis.com/css?family=Comfortaa' rel='stylesheet' type='text/css'>
</head>

<body>

	<div class="header">
		<a href="index.php">Created By <b>Sameer Khowaja</b></a>
	</div>
	<br />
	<br />
	<br />
	
	<h1>Please Click on Register for Registration</h1>
	<a href="register.php">Register</a>
	

	
	<!--Link : https://www.youtube.com/watch?v=bjT5PJn0Mu8 -->
	
</body>

</html>