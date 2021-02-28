<!DOTYPE html>
<html lang="en">
<head>

<?php include ("dbconn.php"); ?>
	<meta charset="utf-8">
	<title>OLS for CHMSC Researchers</title>
	<link rel="stylesheet" type="text/css" href="css/style.css">
	<link rel="stylesheet" type="text/css" href="css/bootstrap.css">
	<link rel="stylesheet" type="text/css" href="css/bootstrap-responsive.css">
	<link rel="stylesheet" href="css/font-awesome.min.css">
	
	
<!--[if !IE]><!--><script type='text/javascript' src='scripts/jquery.mobile-1.0rc2.customized.min.js'></script><!--<![endif]-->
<script type='text/javascript' src='scripts/jquery.easing.1.3.js'></script> 
<script type='text/javascript' src='scripts/jquery.hoverIntent.minified.js'></script> 



	
	<!-- Evo slider-->
 
	
	<!-- Evo slider-->
<script type="text/javascript" src="js/jquery-1.7.2.min.js"></script>
    <link href="css/style_1.css" rel="stylesheet" media="screen">
  
	<link rel="Stylesheet" type="text/css" href="css/default/reset.css" />
    <link rel="Stylesheet" type="text/css" href="css/evoslider.css" />
    <link rel="Stylesheet" type="text/css" href="css/default/default.css" />   
    <script type="text/javascript" src="js/jquery.evoslider.lite-1.1.0.js"></script>   
	        
	<style>
		body{
		background:#E9EAED;
		}
		
	</style>
</head>
		

<body>
	
	<div id="container">
	<img src="images/banner.jpg" class="banner">

			<div class="nav">
				<ul>
					<a href="index.php"><li><i class="icon-home icon-large"> </i> Home</li></a>
					<a href="whats_new.php"><li><i class="icon-list-alt icon-large"> </i> What's New?</li></a>
					<a href="about.php"><li><i class="icon-folder-open icon-large"> </i> About Us</li></a>
					<li class="active"><i class="icon-large icon-exclamation-sign"></i> Help</li>
				<ul>
			</div>
	
	
		<div class="alert alert-success">
			<strong>WELCOME</strong> to Online Public Access Catalog for CHMSC Researches!
				<div class="pull-right">
								<i class="icon-calendar icon-large"></i>
								<?php
								$Today = date('y:m:d');
								$new = date('l, F d, Y', strtotime($Today));
								echo $new;
								?>
			</div>
			</div>
	<div class="content-left">
		<font style=" color:darkblue; font:bold 24px 'cambria';">
						<i class="icon icon-exclamation"></i> Help</font><hr style="margin:8px; border-bottom:1px solid #ccc;">
						
							<div class="serts">
							<form method="post" action="search.php"><br>
							<div style="font:bold 15px 'arial';">Seach Here: </div>
								<input class="serts" type="search" name="search" style="text-align:center;" placeholder="Search by Title, Year, Author.......">
							</form>
					</div>
					<div class="text">
						  Searching for Theses and Capstones can be as simple as you wish. 
					
						  You can simply type a word or phrase and click Search, <br>or you can search by author, title, location, or other characteristics and combine search terms.
						<br>
						<br>
					<font style=" color:#000; font:bold 24px 'cambria';">
						<i class="icon icon-exclamation"></i> " Title "</font>	<br>
						When searching for a specific title, enter the complete title:<br>
					<strong>Microeconomics: a contemporary introduction</strong><br>
					or just keywords within the title: <br>
					<strong>Microeconomics or contemporary introduction</strong>
					
										
											<br>
											<br>
										<font style=" color:#000; font:bold 24px 'cambria';">
											<i class="icon icon-exclamation"></i> " Author "</font>	<br>
											For personal author search, enter the full name of the author in order:<br>
					<strong>Kelly, William</strong><br>
					or just keywords within the name of author:<br> 
					<strong>Kelly or William</strong>
										
											</div><br>
</div>



				
				
	
	
		
		
		
		
	
	
		
		

<footer>
<center>Copyright &copy; Carlos Hilado Memorial State College | All Rights Reserved 2015 </center>
</footer>		
	</div><!-- end container --->

</body>

<?php include('scripts.php'); ?>
</html>