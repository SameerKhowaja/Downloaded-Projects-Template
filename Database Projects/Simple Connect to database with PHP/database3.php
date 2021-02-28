



<html lang="en">

<head>

	<meta charset="utf-8" />
	
	<title>Medical Store</title>

	<link rel="stylesheet" href="styles.css" type="text/css" media="screen" />
	<link rel="stylesheet" type="text/css" href="print.css" media="print" />
</head>




<body>

 
<div id="wrapper">

         <header>
		 
             
			
		 </header>
	
	<nav>
		<div class="menu">
			<ul>
				<li><a href="index.php">HOME</a></li>
				<li><a href="about.php">ABOUT US </a></li>
				<li><a href="r.php">REGISTRATION</a></li>
			  
		    	<li><a href="c.php">CONTACT US</a></li>
			</ul>
		</div>
	</nav>
	
	<section id="main">
	
			<section id="content">
			
<?php 

$vart=mysql_connect('localhost','root','');
mysql_select_db('order');

$category=$_POST['category'];
$medicine=$_POST['medicine'];

if($category && $medicine){

echo "<center><h1>Your Order is Recommented in 24 hours </h1></font> </center>";

}
else{

echo "<center><h1>Order UnProcessed</h1></center>";
echo "<center><h3>Please Fill the All Fields </h3></center>";
}

$var="insert into orderonline(category,medicine) values('$category','$medicine')";
mysql_query($var);




mysql_close($vart);
?>
      








  		
				
				
					</section>

		<aside id="sidebar">
				
				
				
				

				<h3>Current News</h3>
					<center>
					<marquee height="80" direction="up" behavior="scroll"   scrollamount="2">
                        As every time it is not possible for the customer 
						to carry the prescribed medicines with them. 
						Taking an account of that,
						Medicine 2 Home provide door to door facility,
						i.e. you just order the list of
						medicines and you will get home delivery.
					   </marquee>
					   </center>
					<ul>
					   
					</ul>
				

				<h3>Connect With Us</h3>
					<ul>
					     Free Home Delivery <br><br>
						  0222932132 <br>
						  <br><img src="s.png"   width="200"  height="100"/>
						<br>
						<li><a href="https://twitter.com/">Twitter</a></li><br>
						<li><a href="https://www.facebook.com/">Face book</a></li><br>
					</ul>

		</aside>
	</section>
	
		<footer>
		<section id="footer-area">

			<section id="footer-outer-block">
					<aside class="footer-segment">
							<h4>Medicines</h4>
								<ul>
									<li>Sexual Health</li>
									<li>Cholesterol Reducers</li>
									<li>Muscle Relaxant</li>
									<li>Parkinson's</li>
									<li>Nausea / Vomiting</li>
								</ul>
					</aside>

					<aside class="footer-segment">
							<br>
							<br>
								<ul>
									<li>Hair Loss</li>
									<li>Pain Relief</li>
									<li>Alzheimer</li>
									<li>Bacterial infection</li>
									<li>High Blood Pressure</li>
								</ul>
					</aside>

					<aside class="footer-segment">
							     <br>
								 <br>
								<ul>
									<li>Prostate</li>
									<li>Thyroid</li>
									<li>Urinary Disorders</li>
									<li>Migraine</li>
									<li>Hansen Disease</li>
								</ul>					</aside>
					
		

			</section>
		</section>
	</footer>
	
</div>
<p id="sidetab"><a href=""></a></p>
</body>

</html>









