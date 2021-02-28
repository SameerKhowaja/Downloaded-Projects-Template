<?php
if (!isset($_SESSION)) {
  session_start();
}
$MM_authorizedUsers = "1";
$MM_donotCheckaccess = "false";

// *** Restrict Access To Page: Grant or deny access to this page
function isAuthorized($strUsers, $strGroups, $UserName, $UserGroup) { 
  // For security, start by assuming the visitor is NOT authorized. 
  $isValid = False; 

  // When a visitor has logged into this site, the Session variable MM_Username set equal to their username. 
  // Therefore, we know that a user is NOT logged in if that Session variable is blank. 
  if (!empty($UserName)) { 
    // Besides being logged in, you may restrict access to only certain users based on an ID established when they login. 
    // Parse the strings into arrays. 
    $arrUsers = Explode(",", $strUsers); 
    $arrGroups = Explode(",", $strGroups); 
    if (in_array($UserName, $arrUsers)) { 
      $isValid = true; 
    } 
    // Or, you may restrict access to only certain users based on their username. 
    if (in_array($UserGroup, $arrGroups)) { 
      $isValid = true; 
    } 
    if (($strUsers == "") && false) { 
      $isValid = true; 
    } 
  } 
  return $isValid; 
}

$MM_restrictGoTo = "Login.php";
if (!((isset($_SESSION['MM_Username'])) && (isAuthorized("",$MM_authorizedUsers, $_SESSION['MM_Username'], $_SESSION['MM_UserGroup'])))) {   
  $MM_qsChar = "?";
  $MM_referrer = $_SERVER['PHP_SELF'];
  if (strpos($MM_restrictGoTo, "?")) $MM_qsChar = "&";
  if (isset($_SERVER['QUERY_STRING']) && strlen($_SERVER['QUERY_STRING']) > 0) 
  $MM_referrer .= "?" . $_SERVER['QUERY_STRING'];
  $MM_restrictGoTo = $MM_restrictGoTo. $MM_qsChar . "accesscheck=" . urlencode($MM_referrer);
  header("Location: ". $MM_restrictGoTo); 
  exit;
}
?>
<!doctype html>
<html>
<head>
<title>  </title>
<link rel="stylesheet" type="text/css" href="css/style.css"/>
<script src="SpryAssets/SpryValidationTextField.js" type="text/javascript"></script>
<link href="SpryAssets/SpryValidationTextField.css" rel="stylesheet" type="text/css">
</head>
<header class="mainlogo">
<img src="images/header.png" class="logo" />
</header>
<header class="mainheader">
<nav align="center">
<ul>
<li> <a href="index.php"> Home</a></li>
<li><a href="Vision2020.php">Vision2020 </a></li>
<li id="phones"><a href="MicroFinance.php"> Micro-Finance</a></li>
<li><a href="Forums.php"> Forums</a></li>
<li><a href="Partnership.php"> Partnership</a></li>
<li id= "about"><a href="About Us.php"> About us</a></li>
<li id= "about"><a href="Contact Us.php"> Contact Us</a></li>
<li id= "about"><a href="Downloads.php"> Downloads</a></li>
<li><a href="UserRegistration.php">Register </a></li>
<li id= "about"><a href="Login.php">Login </a></li>
</ul>
</nav>
<form class="search">
<input type="text" placeholder="Search..."/>
</form>
</header>
</div>
<div class="body">
<body>
<p>&nbsp;</p>
<p>&nbsp;</p>
<form action="" method="post" name="CPForm" id="CPForm">
  <h6>Admin</h6>
  <h6>&nbsp;</h6>
  <h6>&nbsp;</h6>
  <h6><a href="ManageUsers.php">ManageUsers</a>&nbsp; |&nbsp; <a href="Logout.php">Log out</a></h6>
</form>
</div>

<p>&nbsp;</p>
<p>&nbsp; </p>
<script type="text/javascript">


  </script>
</body>
</html>

