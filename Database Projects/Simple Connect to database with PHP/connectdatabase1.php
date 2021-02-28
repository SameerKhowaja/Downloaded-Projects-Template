<center>
<?php

	$conn=mysql_connect('localhost', 'root', '');
	
	
	if($conn) {
		echo "Connect Successfully!";
	}
	else {
		die ('Could not connect'.mysql_error());
	}

?>
</center>