<?php
	
	session_start();
	
	if( isset($_SESSION['user_id'])) {
		header("Location:main.php");
	}
	
	require 'database.php';
	
	$message = '';

	if(!empty($_POST['name']) && !empty($_POST['fathername']) && !empty($_POST['number']) && !empty($_POST['email']) && !empty($_POST['password'])):
		
		// Enter the new users in the database
		$sql = "INSERT INTO users (name, fathername, number, email, password) VALUE (:name, :fathername, :number, :email, :password)";
		$stmt = $conn->prepare($sql);
		
		$stmt->bindParam(':name', $_POST['name']);
		$stmt->bindParam(':fathername', $_POST['fathername']);
		$stmt->bindParam(':number', $_POST['number']);
		$stmt->bindParam(':email', $_POST['email']);
		$stmt->bindParam(':password', password_hash($_POST['password'], PASSWORD_BCRYPT));
		
		if( $stmt->execute() ):
			$message = 'Successfully created new user';
		else:
			$message = 'Sorry there must have been an issue creating your account';
		endif;
		
	endif;

?>

<!DOCTYPE html>
<html>
<head>
	<title>Register Below</title>
	
	<link rel="stylesheet" type="text/css" href="assets/css/style.css">
	<link href='http://fonts.googleapis.com/css?family=Comfortaa' rel='stylesheet' type='text/css'>

</head>

<body>

	<div class="header">
		<a href="index.php">Created By <b>Sameer Khowaja</b></a>
	</div>
	
	<?php  if(!empty($message)): ?>
		<p><?= $message ?></p>
	<?php endif; ?>
	
	<h1>Registration</h1>
	
	
	<form action="register.php" method="POST">
	
		<input type="text" placeholder="Name" name="name">
		<input type="text" placeholder="Father Name" name="fathername">
		<input type="text" placeholder="Mobile Number" name="number">
		<input type="text" placeholder="Email" name="email">
		<input type="password" placeholder="Password" name="password">
		
		<input type="submit">
		
	</form>
	
	
	
	
</body>
</html>