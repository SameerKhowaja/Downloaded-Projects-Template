<?php include 'config.php' ?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <title>Sunbeth Management System</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="Charisma, a fully featured, responsive, HTML5, Bootstrap admin template.">
    <meta name="author" content="Owoyemi Richard">

    <!-- The styles -->
    <link id="bs-css" href="css/bootstrap-cerulean.min.css" rel="stylesheet">

    <link href="css/charisma-app.css" rel="stylesheet">
    <link href='bower_components/fullcalendar/dist/fullcalendar.css' rel='stylesheet'>
    <link href='bower_components/fullcalendar/dist/fullcalendar.print.css' rel='stylesheet' media='print'>
    <link href='bower_components/chosen/chosen.min.css' rel='stylesheet'>
    <link href='bower_components/colorbox/example3/colorbox.css' rel='stylesheet'>
    <link href='bower_components/responsive-tables/responsive-tables.css' rel='stylesheet'>
    <link href='bower_components/bootstrap-tour/build/css/bootstrap-tour.min.css' rel='stylesheet'>
    <link href='css/jquery.noty.css' rel='stylesheet'>
    <link href='css/noty_theme_default.css' rel='stylesheet'>
    <link href='css/elfinder.min.css' rel='stylesheet'>
    <link href='css/elfinder.theme.css' rel='stylesheet'>
    <link href='css/jquery.iphone.toggle.css' rel='stylesheet'>
    <link href='css/uploadify.css' rel='stylesheet'>
    <link href='css/animate.min.css' rel='stylesheet'>

    <!-- jQuery -->
    <script src="bower_components/jquery/jquery.min.js"></script>

    
    <link rel="shortcut icon" href="img/favicon.ico">

</head>

<body <?php if(isset($page) && $page == 'login'){echo 'class="login_body"';}?>>
<?php require ('include/database.php'); ?>
<?php require ('session.php'); ?>
<?php if (!isset($no_visible_elements) || !$no_visible_elements) { ?>
    <!-- topbar starts -->
    <div class="navbar navbar-default" role="navigation">

        <div class="navbar-inner">
            <button type="button" class="navbar-toggle pull-left animated flip">
                <span class="sr-only">Toggle navigation</span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
            </button>
            <a class="navbar-brand" href="home.php"> <img alt="Charisma Logo" src="img/logo20.png" class="hidden-xs"/>
                <span>SUNBETH IMS</span></a>

            <!-- user dropdown starts -->
            <div class="btn-group pull-right">
<?php
	include('include/database.php');
	$user_query=mysql_query("select *  from user where user_id='$id_session'")or die(mysql_error());
	$row=mysql_fetch_array($user_query); 
	$user_access = $row['access'];
	{
?>
                <button class="btn btn-default dropdown-toggle" data-toggle="dropdown">
                    <i class="glyphicon glyphicon-user"></i><span class="hidden-sm hidden-xs"> <?php echo $row['firstname']; ?></span>
                    <span class="caret"></span>
                </button>

<?php } ?>
                <ul class="dropdown-menu">
                    <!---<li><a href="#">Profile</a></li>
                    <li class="divider"></li>-->
                    <li><a href="logout.php"><i class="glyphicon glyphicon-off"></i> Logout</a></li>
                </ul>
            </div>

        </div>
    </div>
    <!-- topbar ends -->
<?php } ?>
<div class="ch-container">
    <div class="row">
        <?php if (!isset($no_visible_elements) || !$no_visible_elements) { ?>

        <!-- left menu starts -->
        <div class="col-sm-2 col-lg-2">
            <div class="sidebar-nav">
                <div class="nav-canvas">
                    <div class="nav-sm nav nav-stacked">

                    </div>
                    <ul class="nav nav-pills nav-stacked main-menu">
                        <li class="nav-header">Main</li>
                        <li><a class="ajax-link" href="home.php"><i class="glyphicon glyphicon-home"></i><span> Home</span></a></li>
                        <li class="accordion">
                            <a href="#"><i class="glyphicon glyphicon-th-list"></i><span> Masterfile</span></a>
                            <ul class="nav nav-pills nav-stacked">
								<li><a class="ajax-link" href="staff.php"><i class="glyphicon glyphicon-chevron-right"></i><span> Staff</span></a></li>
								<li><a class="ajax-link" href="customer.php"><i class="glyphicon glyphicon-chevron-right"></i><span> Customer</span></a></li>
								<li><a class="ajax-link" href="user.php"><i class="glyphicon glyphicon-chevron-right"></i><span> Admin Account</span></a></li>
                            </ul>
                        </li>
                        <li class="accordion">
                            <a href="#"><i class="glyphicon glyphicon-th-list"></i><span> Transaction</span></a>
                            <ul class="nav nav-pills nav-stacked">
								<li><a class="ajax-link" href="buy.php"><i class="glyphicon glyphicon-chevron-right"></i><span> Buying</span></a></li>
								<li><a class="ajax-link" href="haulage.php"><i class="glyphicon glyphicon-chevron-right"></i><span> Haulage</span></a></li>
								<li><a class="ajax-link" href="sundry.php"><i class="glyphicon glyphicon-chevron-right"></i><span> Sundry</span></a></li>
								<li><a class="ajax-link" href="payment.php"><i class="glyphicon glyphicon-chevron-right"></i><span> Payment</span></a></li>
                            </ul>
                        </li>
                        <li class="accordion">
                            <a href="#"><i class="glyphicon glyphicon-th-list"></i><span> Record</span></a>
                            <ul class="nav nav-pills nav-stacked">
								<li><a class="ajax-link" href="list_of_staff.php"><i class=" glyphicon glyphicon-chevron-right"></i><span> List of Staff</span></a></li>
								<li><a class="ajax-link" href="list_of_customer.php"><i class=" glyphicon glyphicon-chevron-right"></i><span> List of Customer</span></a></li>
								<li><a class="ajax-link" href="list_of_buy.php"><i class=" glyphicon glyphicon-chevron-right"></i><span> List of Buying</span></a></li>
								<li><a class="ajax-link" href="list_of_haulage.php"><i class=" glyphicon glyphicon-chevron-right"></i><span> List of Haulage</span></a></li>
								<li><a class="ajax-link" href="list_of_sundry.php"><i class=" glyphicon glyphicon-chevron-right"></i><span> List of Sundry</span></a></li>
								<li><a class="ajax-link" href="list_of_payment.php"><i class=" glyphicon glyphicon-chevron-right"></i><span> List of Payment</span></a></li>
                            </ul>
                        </li>
						<li><a class="ajax-link" href="history.php"><i class="glyphicon glyphicon-bookmark"></i><span> History Log</span></a></li>
						

                </div>
            </div>
        </div>
        

        <div id="content" class="col-lg-10 col-sm-10">
            <!-- content starts -->
            <?php } ?>
