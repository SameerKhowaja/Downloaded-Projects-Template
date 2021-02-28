<?php require_once('Connections/Members.php'); ?>
<?php
if (!function_exists("GetSQLValueString")) {
function GetSQLValueString($theValue, $theType, $theDefinedValue = "", $theNotDefinedValue = "") 
{
  if (PHP_VERSION < 6) {
    $theValue = get_magic_quotes_gpc() ? stripslashes($theValue) : $theValue;
  }

  $theValue = function_exists("mysql_real_escape_string") ? mysql_real_escape_string($theValue) : mysql_escape_string($theValue);

  switch ($theType) {
    case "text":
      $theValue = ($theValue != "") ? "'" . $theValue . "'" : "NULL";
      break;    
    case "long":
    case "int":
      $theValue = ($theValue != "") ? intval($theValue) : "NULL";
      break;
    case "double":
      $theValue = ($theValue != "") ? doubleval($theValue) : "NULL";
      break;
    case "date":
      $theValue = ($theValue != "") ? "'" . $theValue . "'" : "NULL";
      break;
    case "defined":
      $theValue = ($theValue != "") ? $theDefinedValue : $theNotDefinedValue;
      break;
  }
  return $theValue;
}
}
?>
<?php
// *** Validate request to login to this site.
if (!isset($_SESSION)) {
  session_start();
}

$loginFormAction = $_SERVER['PHP_SELF'];
if (isset($_GET['accesscheck'])) {
  $_SESSION['PrevUrl'] = $_GET['accesscheck'];
}

if (isset($_POST['Username'])) {
  $loginUsername=$_POST['Username'];
  $password=$_POST['password'];
  $MM_fldUserAuthorization = "UserLevel";
  $MM_redirectLoginSuccess = "Donate.php";
  $MM_redirectLoginFailed = "UserRegistration.php";
  $MM_redirecttoReferrer = true;
  mysql_select_db($database_Members, $Members);
  	
  $LoginRS__query=sprintf("SELECT UserName, Password, UserLevel FROM members WHERE UserName=%s AND Password=%s",
  GetSQLValueString($loginUsername, "text"), GetSQLValueString($password, "text")); 
   
  $LoginRS = mysql_query($LoginRS__query, $Members) or die(mysql_error());
  $loginFoundUser = mysql_num_rows($LoginRS);
  if ($loginFoundUser) {
    
    $loginStrGroup  = mysql_result($LoginRS,0,'UserLevel');
    
	if (PHP_VERSION >= 5.1) {session_regenerate_id(true);} else {session_regenerate_id();}
    //declare two session variables and assign them
    $_SESSION['MM_Username'] = $loginUsername;
    $_SESSION['MM_UserGroup'] = $loginStrGroup;	      

    if (isset($_SESSION['PrevUrl']) && true) {
      $MM_redirectLoginSuccess = $_SESSION['PrevUrl'];	
    }
    header("Location: " . $MM_redirectLoginSuccess );
  }
  else {
    header("Location: ". $MM_redirectLoginFailed );
  }
}
?>
<!doctype html>
<html>
<head>
<title>AYO|Login</title>
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
</header>
</div>
<div><form class="search">
<input type="text" placeholder="Search..."/>
</form></div>
<div class="body">
<body>
<br>
<div class="content">
  <div class="title"><h3 align="center">Login</h3></div>


<form ACTION="<?php echo $loginFormAction; ?>" method="POST" name="LoginForm" id="LoginForm">
  <table width="605" border="0">
    <tr>
      <td width="599"><h6><span id="sprytextfield2">
        <label for="Username"></label>
        User Name:<br>
        <br>
  <input name="Username" type="text" class="styletxtfield" id="Username">
      </span></h6>
      <span><span class="textfieldRequiredMsg">A value is required.</span></span></td>
    </tr>
    <tr>
      <td>&nbsp;</td>
    </tr>
    <tr>
      <td><h6><span id="sprytextfield3">Password:<br>
        <br>
  <input name="password" type="password" class="styletxtfield" id="password">
      </span></h6>
      <span><span class="textfieldRequiredMsg">A value is required.</span></span></td>
    </tr>
    <tr>
      <td>&nbsp;</td>
    </tr>
    <tr>
      <td><input type="submit" name="loginbtn" id="loginbtn" value="Login"></td>
    </tr>
    <tr>
      <td>&nbsp;</td>
    </tr>
  </table>
</form>
</div>

<script type="text/javascript">

var sprytextfield2 = new Spry.Widget.ValidationTextField("sprytextfield2");
var sprytextfield3 = new Spry.Widget.ValidationTextField("sprytextfield3");
</script>
</div>
<div class="sidebarright">
<div class="title"><h3 align="center">Links</h3></div>
</div><br>
<div class="sidebarright1">
<div class="title"><h3 align="center">Links</h3></div>
</div> <br>
<div class="sidebarright2">
<div class="title"><h3 align="center">Links</h3></div>
</div><br>


</div>

<div class="footer">

<div class="contact">
<p><h3>Contacts</h3></p>
<p><h4>Mobile:020-8146838</h4></p>
<p><h4>Email:<a href="#"> alfayouthg@yahoo.com </a> </p></h4>
</div>

<div class="copyright">
<h2> &copy;Alfa Youth Organization 2015</h2><br>
<h2>Designed by | <a href="#">GBS Digitech Ltd</a></h2>
</div>
<div class="social">
<h2>Follow Us :</h2> <br>
<a href="#"><img src="images/facebook.png" height="57" /></a>
<a href="#"><img src="images/twitter.png" height="57" /></a>
<a href="#"><img src="images/linkedin.png" height="57" /></a>
<a href="#"><img src="images/youtube.png" height="57" /></a>
<a href="#"><img src="images/gmail.png" height="57" /></a>
</div>
</div>
</body>
</html>

