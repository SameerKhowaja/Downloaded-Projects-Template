<?php
function doChangePassword()
{
	// if we found an error save the error message in this variable
	$errorMessage = '';
	
	$userName = $_POST['username'];
	$email = $_POST['email'];
	$uType    = $_POST['usertype'];
	// first, make sure the username & password are not empty
	if ($userName == '') {
		$errorMessage = 'You must enter your username';
	} else if ($email == '') {
		$errorMessage = 'You must enter the Email';
	} else {
		
		//check if user is customer
		if($uType == 'user')
		{
			$sql = "SELECT  username, password
					FROM user
					WHERE username = '$userName' AND e_mail = '$email'";
			$result = mysql_query($sql);
			if (mysql_num_rows($result) == 1) {
				$row = mysql_fetch_assoc($result);
				$npass = $row['password'];
				$errorMessage = "Your password is $npass. You can <a href='index.php'>Login Now</a>.";	
			}else {
				$errorMessage = "You are not a Valid User.";
			}
					
		}//if
		elseif($uType == 'admin')
		{
			$sql = "SELECT   username, password
					FROM user
					WHERE username = '$userName' AND e_mail = '$email'";
			$result = mysql_query($sql);
			if (mysql_num_rows($result) == 1) {
				$row = mysql_fetch_assoc($result);
				$npass = $row['password'];
				$errorMessage = "Your password is $npass. You can <a href='index.php'>Login Now</a>.";
			}else {
				$errorMessage = "You are not a Valid Administrator.";
			}		
		}
				
			
	}//else
	return $errorMessage;
}
?>