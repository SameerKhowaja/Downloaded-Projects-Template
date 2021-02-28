<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">

<?php include ('head.php'); ?>
<body>
<div id="container">
	<img src="images/banner.jpg" height=20>


			<div class="nav">
				<ul>
					<a href="index.php"><li class="active"><i class="icon-home icon-large"> </i> Home</li></a>
				
					<a href="adminlog.php"><li><i class="icon-lock icon-large"> </i> Admin Login</li></a>
					<a href="interface.php"><li><i class="icon-lock icon-large"> </i> Students Login</li></a>
					<a href="AdminBursar.php"><li><i class="icon-lock icon-large"></i> Staff Login</li></a>
				<ul>
			</div>
		
		<div id="content">
				
		<!--diapo-->
		<br>
		<div class="alert alert-success">
			<strong>WELCOME</strong> To St. Lukes Boys High SchoolStudents' Finance Management System
				<div class="pull-right">
								<i class="icon-calendar icon-large"></i>
								<?php
								$Today = date('y:m:d');
								$new = date('l, F d, Y', strtotime($Today));
								echo $new;
								?>
			</div>
			</div>
</body>
</html>