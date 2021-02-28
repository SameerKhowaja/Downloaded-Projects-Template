<center>

<html>

<h1><i>Form</i> </h1>

<form method="POST">

<table>

<tr>
<td>
Name:
</td>
<td>
<input type="text" name="name"/>
</td>
</tr>

<tr>
<td>
Email Id:
</td>
<td>
<input type="text" name="email"/>
</td>
</tr>

<tr>
<td>
Mobile:
</td>
<td>
<input type="text" name="mobile"/>
</td>
</tr>

<tr>
<td>
Password:
</td>
<td>
<input type="text" name="pass"/>
</td>
</tr>

<tr>
<td>
<input type="submit" name="sub" value="Submit"/>
</td>
<td>
<input type="submit" name="res" value="Reset"/>
</td>
</tr>

</table>

</form>

</html>

<?php

	$conn=mysql_connect('localhost', 'root', '');
	mysql_select_db('demophp');
	
	$name=$_POST['name'];
	$email=$_POST['email'];
	$mob=$_POST['mobile'];
	$pa=$_POST['pass'];
	
	$con="insert into userinfo(name, email, mobile, pass) values('$name', '$email', '$mob', '$pa')";
	
	$var = mysql_query($con);
	
         if($var>0) {
	echo "Record Submit";
	}
	
      else {
		echo "Connection Failed";
	}
	
	mysql_close($conn);

?>
</center>