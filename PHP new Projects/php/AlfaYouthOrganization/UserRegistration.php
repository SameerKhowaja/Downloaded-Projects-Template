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

$editFormAction = $_SERVER['PHP_SELF'];
if (isset($_SERVER['QUERY_STRING'])) {
  $editFormAction .= "?" . htmlentities($_SERVER['QUERY_STRING']);
}

if ((isset($_POST["MM_insert"])) && ($_POST["MM_insert"] == "RegistrationForm")) {
  $insertSQL = sprintf("INSERT INTO members (FirstName, LastName, UserName, Email, Password) VALUES (%s, %s, %s, %s, %s)",
                       GetSQLValueString($_POST['fname'], "text"),
                       GetSQLValueString($_POST['lname'], "text"),
                       GetSQLValueString($_POST['uname'], "text"),
                       GetSQLValueString($_POST['Email'], "text"),
                       GetSQLValueString($_POST['password'], "text"));

  mysql_select_db($database_Members, $Members);
  $Result1 = mysql_query($insertSQL, $Members) or die(mysql_error());

  $insertGoTo = "Login.php";
  if (isset($_SERVER['QUERY_STRING'])) {
    $insertGoTo .= (strpos($insertGoTo, '?')) ? "&" : "?";
    $insertGoTo .= $_SERVER['QUERY_STRING'];
  }
  header(sprintf("Location: %s", $insertGoTo));
}

mysql_select_db($database_Members, $Members);
$query_Registration = "SELECT * FROM members";
$Registration = mysql_query($query_Registration, $Members) or die(mysql_error());
$row_Registration = mysql_fetch_assoc($Registration);
$totalRows_Registration = mysql_num_rows($Registration);


?>
<!doctype html>
<html>
<head>
<title>AYO|Registration</title>
<link rel="stylesheet" type="text/css" href="css/style.css"/>
<script src="SpryAssets/SpryValidationTextField.js" type="text/javascript"></script>
<link href="SpryAssets/SpryValidationTextField.css" rel="stylesheet" type="text/css">
<style type="text/css">
#RegistrationForm table tr td h6 #sprytextfield1 strong {
	color: #000;
	font-size: larger;
}
#RegistrationForm table tr td h6 #sprytextfield1 strong {
	color: #000;
}
#RegistrationForm table tr td h6 #sprytextfield1 strong {
	color: #000;
}
</style>
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
<div class="title"><h3 align="center">Register Here!!</h3></div>
<form action="<?php echo $editFormAction; ?>" method="POST" name="RegistrationForm" id="RegistrationForm">
  <table width="614" border="0">
    <tr>
      <td width="608"><h6>First Name:</h6>
        <h6><span id="sprytextfield1">
          <input name="fname" type="text" class="styletxtfield" id="fname">
      </span></h6>
      <span><span class="textfieldRequiredMsg">A value is required.</span></span></td>
    </tr>
    <tr>
      <td>&nbsp;</td>
    </tr>
    <tr>
      <td><h6><span id="sprytextfield2">
        <label for="lname"></label>
        Last Name:<br>
        <input name="lname" type="text" class="styletxtfield" id="lname">
      </span></h6>
      <span><span class="textfieldRequiredMsg">A value is required.</span></span></td>
    </tr>
    <tr>
      <td>&nbsp;</td>
    </tr>
    <tr>
      <td><h6><span id="sprytextfield3">
        <label for="Email"></label>
        Email:
        <br>
        <input name="Email" type="text" class="styletxtfield" id="Email">
        <span class="textfieldInvalidFormatMsg">Invalid format.</span></span></h6>
      <span><span class="textfieldRequiredMsg">A value is required.</span></span></td>
    </tr>
    <tr>
      <td>&nbsp;</td>
    </tr>
    <tr>
      <td><h6><span id="sprytextfield4">
        <label for="uname"></label>
        User Name:
        <br>
  <input name="uname" type="text" class="styletxtfield" id="uname">
      </span></h6>
      <span><span class="textfieldRequiredMsg">A value is required.</span></span></td>
    </tr>
    <tr>
      <td>&nbsp;</td>
    </tr>
    <tr>
      <td><h6><span id="sprytextfield5">
        <label for="password"></label>
        Password:
        <br>
  <input name="password" type="password" class="styletxtfield" id="password">
      </span></h6>
      <span><span class="textfieldRequiredMsg">A value is required.</span></span></td>
    </tr>
    <tr>
      <td>&nbsp;</td>
    </tr>
    <tr>
      <td><input type="submit" name="submitForm" id="submitForm" value="Register"></td>
    </tr>
    <tr>
      <td>&nbsp;</td>
    </tr>
  </table>
  <input type="hidden" name="MM_insert" value="RegistrationForm">
</form>
<script type="text/javascript">
var sprytextfield1 = new Spry.Widget.ValidationTextField("sprytextfield1");
var sprytextfield2 = new Spry.Widget.ValidationTextField("sprytextfield2");
var sprytextfield3 = new Spry.Widget.ValidationTextField("sprytextfield3", "email");
var sprytextfield4 = new Spry.Widget.ValidationTextField("sprytextfield4");
var sprytextfield5 = new Spry.Widget.ValidationTextField("sprytextfield5");
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

</div>
</body>
</html>
<?php
mysql_free_result($Registration);
?>
