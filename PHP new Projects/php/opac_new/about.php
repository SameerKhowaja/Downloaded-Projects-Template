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
						<p>An online library catalog is an electronic bibliographic database that describes the books, videotapes, periodicals, etc. carried by a particular library.

The online library catalog evolved from a printed source, the library card catalog. Before the advent of online catalogs, library catalogs were pieces of furniture that contained numerous small drawers. In these drawers were contained the records of particular items in the library.

These records were printed on small 3"X5" cards and each element of that record had an individual card produced for it. So for each item in the library there was:

a card for the author
a card for the title
and cards for each individual subject heading
A copy of John Grisham's The Firm might have four different cards filed in the different catalog areas: one for the author's name, one for the title, and one for each subject heading, like those below.

You could only search one element at a time and this could take quite a bit of time from your schedule. Very few libraries in Georgia have card catalogs anymore, but you might see the chest of small drawers hidden in a dark corner in some libraries.</p>
						
					</div>
					<div class="col-lg-5 col-md-5 col-xs-12 col-sm-12 right_side">
						<img class="img-responsive" src="images/about/1.jpg" alt="image">
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

