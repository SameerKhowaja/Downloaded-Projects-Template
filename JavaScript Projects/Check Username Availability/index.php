<!DOCTYPE html>
<html>
<head>
    <title>Username Availability</title>
    <script src="js/jquery.js" type="text/javascript"></script>
	<script src="js/settings.js" type="text/javascript"></script>
<script type="text/javascript">
pic1 = new Image(16, 16); 
pic1.src = "loader.gif";

$(document).ready(function(){

$("#username").change(function() { 

var usr = $("#username").val();

if(usr.length >= 3)
{
$("#status").html('<img src="loader.gif" align="absmiddle">&nbsp;Checking availability...');

    $.ajax({  
    type: "POST",  
    url: "check.php",  
    data: "username="+ usr,  
    success: function(msg){  
   
   $("#status").ajaxComplete(function(event, request, settings){ 

	if(msg == 'OK')
	{ 
        $("#username").removeClass('object_error'); // if necessary
		$("#username").addClass("object_ok");
		$(this).html('&nbsp;<img src="check.jpg" style="width:25px;" align="absmiddle"> <font color="Green" style="font-size:14px;"> Available! </font>  ');
	}  
	else  
	{  
		$("#username").removeClass('object_ok'); // if necessary
		$("#username").addClass("object_error");
		$(this).html(msg);
	}  
   
   });

 } 
   
  }); 

}
else
	{
	$("#status").html('<font color="red" style="font-size:14px; margin-left:5px;">The username should have at least <strong>3</strong> characters.</font>');
	$("#username").removeClass('object_ok'); // if necessary
	$("#username").addClass("object_error");
	}

});

});

//-->
</script>

<style type="text/css">
body{
font-family:sans-serif;
font-size:18px;
}
</style>
	  
  </head>
  
  <body>
  <br>
	<form>
		Username<br>
        <input id="username"  type="text" name="username" onkeyup="twitter.updateUrl(this.value)" placeholder="Username" style="float:left; border-radius:3px; padding:5px;" /><br>
	  <div id="status" style="float:left; margin-top:-20px;"></div>
		  <br>
		 Password<br>
	   <input type="text" name="password" placeholder="Password" style="border-radius:3px; padding:5px; float:left; clear:both;" /><br><br>
	   <input type="button" name="submit" value="Register" style="padding:5px;">
    </form>     

  </body>
  </html>