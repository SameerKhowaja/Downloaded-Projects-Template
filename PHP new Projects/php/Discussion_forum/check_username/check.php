<?php
$con=mysqli_connect("localhost","root","","check_username");
	if (mysqli_connect_errno()){
    	echo "Failed to connect to MySQL: " . mysqli_connect_error();
    }
	
	if(isset($_REQUEST['username'])){
		$username = $_REQUEST['username'];
		
		$query = mysqli_query($con, "SELECT username FROM users WHERE username = '$username'");
		$num_rows = mysqli_num_rows($query);
		
		if($username == NULL)
			echo "";
		else if(strlen($username)<=3)
			echo "Username too short!";
		else{
			if ($num_rows == 0)
				echo "Username is not available!";
			else if ($num_rows == 1)
				echo "Username is Available!";
		}
	}
?>