<?php
require_once('connection.php');
require_once('auth.php');
$id=$_SESSION['SESS_MEMBER_ID'];
$result3 = mysql_query("SELECT * FROM tbluser where user_id='$id'");
while($row3 = mysql_fetch_array($result3))
{ 
$eid=$row3['e_id'];
$firstname=$row3['firstname'];
$lastname=$row3['lastname'];
$location=$row3['location'];

}
?>




<!DOCTYPE html>

<html lang='en'>
<head>
    <meta charset="UTF-8" /> 
    <title>
        TIME LOG
    </title>
    <?php
	//Start session
		
	//Unset the variables stored in session
	unset($_SESSION['SESS_MEMBER_ID']);
	unset($_SESSION['SESS_FIRST_NAME']);
	unset($_SESSION['SESS_LAST_NAME']);
?>

    <link rel="stylesheet" type="text/css" href="style.css" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<style type="text/css">
body,td,th {
	font-family: HelveticaNeue-Light, "Helvetica Neue Light", "Helvetica Neue", Helvetica, Arial, "Lucida Grande", sans-serif;
	color: #000;
	font-size: 24;
	font-weight: bold;
}

.blink_text {
-webkit-animation-name: blinker;
-webkit-animation-duration: 1s;
-webkit-animation-timing-function: linear;
-webkit-animation-iteration-count: infinite;

-moz-animation-name: blinker;
-moz-animation-duration: 1s;
-moz-animation-timing-function: linear;
-moz-animation-iteration-count: infinite;

 animation-name: blinker;
 animation-duration: 1s;
 animation-timing-function: linear;
 animation-iteration-count: infinite;

 color:#F00;
 font-size:16px;
}

@-moz-keyframes blinker {  
 0% { opacity: 1.0; }
 50% { opacity: 0.0; }
 100% { opacity: 1.0; }
 }

@-webkit-keyframes blinker {  
 0% { opacity: 1.0; }
 50% { opacity: 0.0; }
 100% { opacity: 1.0; }
 }

@keyframes blinker {  
 0% { opacity: 1.0; }
 50% { opacity: 0.0; }
 100% { opacity: 1.0; }
 }

</style>
</head>
<body>

<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<div class="login-form">
<table align="center" width="500" height="129" border="2" bordercolor="#000000" cellspacing="1" cellpadding="1">
  <tr>
    <td><img src="<?php echo $location ?>" width="129" height="129" alt="no image found"/></td>
    <td><p align="justify">Welcome Mr. <?php echo $firstname ?> <?php echo $lastname ?>. </p>
      <p align="justify">You have Just Loging at <?php echo date('Y-m-d H:i:s'); ?>. </p>
      <p align="justify">Thank You. Have a Nice Day </p></td>
  </tr>
</table>
</div>
<div id="wrapper">

	<form name="login-form" class="login-form" action="login_exec.php" method="post">
	
		<div class="header">
		<h1 align="center">TIME LOG</h1>
        
         <?php
			if( isset($_SESSION['ERRMSG_ARR']) && is_array($_SESSION['ERRMSG_ARR']) && count($_SESSION['ERRMSG_ARR'])>0 ) {
			echo '<ul class="err">';
			foreach($_SESSION['ERRMSG_ARR'] as $msg) {
				echo '<li>',$msg,'</li>'; 
				}
			echo '</ul>';
			unset($_SESSION['ERRMSG_ARR']);
			}
		?>    
		
       <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>
<div id="time"></div>

<script type="text/javascript">
$(document).ready(function()
{
var d = new Date();
var month = d.getMonth(); //Removed +1
var day = d.getDate();
var year = d.getFullYear();
var months = ['January','February','March','April','May','June','July','August','Septempber','October','November','December'];
var minutes = d.getMinutes().toString().length == 1 ? '0'+d.getMinutes() : d.getMinutes();
var hours = d.getHours().toString().length == 1 ? '0'+d.getHours() : d.getHours();
var ampm = d.getHours() >= 12 ? '<sup>PM<sup>' : '<sup>AM<sup>';
document.getElementById("time").innerHTML = d.getDate() + ' ' + months[month]+' '+d.getFullYear()+' '+hours +':'+minutes + ' ' + ampm;
});

</script>
<script language="javascript">
function submit_OnClick() {
    document.getElementById("clientDate").value =  currentdate.getDate() + "/"
            + (currentdate.getMonth()+1)  + "/" 
            + currentdate.getFullYear() + " @ "  
            + currentdate.getHours() + ":"  
            + currentdate.getMinutes() + ":" 
            + currentdate.getSeconds();
     }
</script>   
        
   
        
        
		<p>&nbsp;</p>
        <span class="blink_text">PLEASE ENTER YOUR ID</span>
		
        
      </div>
	
		<div class="content">
         <input name="userid" type="text" class="input username" value="" placeholder="User ID" autofocus required>
		<div class="user-icon"></div>
        
				
  </div>

		<div class="footer">
		<input type="submit" name="submit" value="ENTER" class="button" />
		</div>
	
	</form>

</div>
<div class="gradient"></div>


</body>
</html>
