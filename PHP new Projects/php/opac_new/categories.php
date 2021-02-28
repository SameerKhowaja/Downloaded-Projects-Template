<?php
/**
 * Created by PhpStorm.
 * User: Moddy
 * Date: 17/01/2016
 * Time: 14:30
 */
 include("includes/connection.php");
?>
<?php $page="dashboard"; ?>
<!DOCTYPE html>
<html lang="en" class="app">
<!DOCTYPE html>
<html lang="en">
	<head>
		<meta charset="UTF-8">

		<!-- For IE -->
		<meta http-equiv="X-UA-Compatible" content="IE=edge">

		<!-- For Resposive Device -->
		<meta name="viewport" content="width=device-width, initial-scale=1.0">

		<title>Me-Financial</title>
    <?php require"includes/header.php"; ?>
    <!--[if lt IE 9]> <script src="js/ie/html5shiv.js"></script> <script src="js/ie/respond.min.js"></script> <script src="js/ie/excanvas.js"></script> <![endif]-->
</head>
<body class="home">
<!-- =======Header ======= -->
		<?php require"includes/header_info.php"; ?>
<!-- ======= /Header ======= -->
<!-- ======= mainmenu-area section ======= -->
		<?php require"includes/menu.php"; ?>
<!-- ======= /mainmenu-area section ======= -->
<!-- ======= revolution slider section ======= -->
	<!-- ======= Banner ======= -->
		<section class="history_sec">
			<div class="container">
				<div class="row">
					<div class="col-lg-7 col-md-7 col-sm-12 col-xs-12 left-side">
						<h2>Our Histroy</h2>
						<p>Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium dolore mque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi archi- tecto beatae vitae dict eaque ipsa quae ab illo inventore veritatis et quasi Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium dolore mque laudantium, totam rem aperiam, eaque ipsa quae abarchitecto.</p>
						<ul>
							<li><a href=""><i class="fa fa-angle-right"></i>&nbsp;&nbsp;Financial Managment and Consulting</a></li>
							<li><a href=""><i class="fa fa-angle-right"></i>&nbsp;&nbsp;Advice and Assistance Investing</a></li>
							<li><a href=""><i class="fa fa-angle-right"></i>&nbsp;&nbsp;Comprehensive Support for Your Business</a></li>
						</ul>
					</div>
					<div class="col-lg-5 col-md-5 col-xs-12 col-sm-12 right_side">
						<img class="img-responsive" src="images/about/1.jpg" alt="image">
						<h3>Company Mission </h3>
						<p>Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium dolore mque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto </p>
					</div>
				</div>
			</div>
		</section>
<!-- ======= /Banner ======= -->
<!--====Footer===-->
<?php require"includes/footer.php"; ?>
<!--==./Footer==-->
</body>
</html>

