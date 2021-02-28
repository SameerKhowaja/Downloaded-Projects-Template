<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>Online Quiz</title>
<link rel="stylesheet"type="text/css" media="all" href="mystyle.css">
</head>

<body>
<div class="main">

 <div class="menu">
 
 <li><a href="high.php">Highest Score</a> </li>	
 <li> <a href="rev.php"> Reviewers </a> </li>
 <li> <a href="Results.php"> Results </a> </li>
 <li> <a href="ViewPass.php"> Passers</a> </li>
 <li> <a href="login.php">Log-in as admin</a> <li>
 </div>
 
 
   <div style="margin-left:80px; margin-right:80px"> <img src="images/cute-frog-wallpaper-for-iphone-v904.png" width="100%" height="100%"/></div>
	<div class="left">
<form method="post" action="Upload.php" enctype="multipart/form-data">
<div style="clear:both"></div>
 <div class="reg">
 <div id="one">
Firstname <br/><input type="text" name="fname" required><br/>
Lastname  <br/><input type="text" name="lname" required><br/>
Middlename<br/><input type="text" name="mname"  required>
</div>

<div id="two">
Address <br/><input type="text" name="address" required><br/>
Gender <br/><select name="gender">
<option value="----">---------</option>
<option value="FEMALE">FEMALE</option>
<option value="MALE">MALE</option>
</select>
</div>

<div id="three">
Age <br/>
<input type="number" name="age" required min="18" max="100"><br/>
Choose picture<br/>
<input type="file" title="SELECT YOUR PROFILE PICTURE" name="imagesee"/><br/><br/>

<input type="submit" value="S U B M I T" name="send" id="myButton"/>
</div>



</div>
	</div>
    <div style="clear:both"></div>
			
	<div class="right">

		<?php include 'question.php';?>
	</div>
<div style="clear:both"></div>
</div>
</form>

</body>
</html>