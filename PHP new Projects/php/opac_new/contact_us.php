<?php
/**
 * Created by PhpStorm.
 * User: Moddy
 * Date: 17/01/2016
 * Time: 14:30
 */
 include("includes/connection.php");
?>
<?php $page="contact_us"; ?>
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
		<section class="contact_us_container">
			<div class="container">
				<div class="row">
					<div class="col-lg-12 col-md-12 col-sm-12 col-xs-12" style="text-align:center;"> <!-- section title -->
						<h2>Get In Touch With Us</h2>
						<p>You can talk to our online representative at any time. Please use our Live Chat System on our website or <br>
						Fill up below instant messaging programs.</p>
					</div> <!-- End section title -->
					<div class="col-lg-8 col-md-8 col-sm-12 col-xs-12 form_holder"> <!-- form holder -->
						<form action="includes/sendemail.php" class="contact-form">
							<input class="form-control name" type="text" name="name" placeholder="Your Name">
							<input class="form-control email" type="email" name="email" placeholder="Your Email">
						    <input class="form-control" type="text" name="subject" placeholder="Subject">
						    <textarea name="message" placeholder="Message"></textarea>
						    <button type="submit" class="submit">submit now <i class="fa fa-arrow-circle-right"></i></button>
						</form> <!-- End form holder -->
					</div>
                                        <span class="clear_fix"></span>
					<div class="col-lg-4 col-md-4 col-sm-12 col-xs-12 pull-right address">
						<address>
							<div class="icon_holder float_left"><span class="icon icon-Pointer"></span></div>
							<div class="address_holder float_left">JKUAT Karen Campus <br> PO Box 62000 - 00100 <br>Nairobi</div>
						</address>
						<address class="clear_fix">
							<div class="icon_holder float_left"><span class="icon icon-Plaine"></span></div>
							<div class="address_holder float_left">faithkioko@gmail.com <br>faith.kioko@yahoo.com</div>
						</address>
						<address class="clear_fix">
							<div class="icon_holder float_left"><span class="icon icon-Phone2"></span></div>
							<div class="address_holder float_left">+ 254 715 954909 <br> + 254 715 954909</div>
						</address>
					</div>
				</div>
			</div>
		</section>
        <span class="clear_fix"></span>
<!-- ======= /Banner ======= -->
<!--====Footer===-->
<?php require"includes/footer.php"; ?>
<!--==./Footer==-->
</body>
</html>

