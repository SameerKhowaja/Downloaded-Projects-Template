<?php 
include('header.php');
?>
<body>
<div class="container">
<script type="text/javascript">
jQuery(document).ready( function () {
$(".form2").hide();

$("#click").click( function() {

$(".form1").hide();
$(".form2").fadeIn("slow");

	});
	
	$("#click1").click( function() {

$(".form2").hide();
$(".form1").fadeIn("slow");

	});
	


	});
</script>
<br><br>

    <form class="form-horizontal">
	
	<div class="form1">
    <div class="control-group">
    <label class="control-label" for="inputEmail">FirstName</label>
    <div class="controls">
    <input type="text" id="inputEmail" placeholder="FirstName" required>
    </div>
    </div>
    <div class="control-group">
    <label class="control-label" for="inputPassword">LastName</label>
    <div class="controls">
    <input type="text" id="inputPassword" placeholder="LastName" required>
    </div>
    </div>
	  <div class="control-group">
    <label class="control-label" for="inputPassword">MiddleName</label>
    <div class="controls">
    <input type="text" id="inputPassword" placeholder="MiddleName" required>
    </div>
    </div>
	  <div class="control-group">
    <label class="control-label" for="inputPassword">Address</label>
    <div class="controls">
    <input type="text" id="inputPassword" placeholder="Address" required>
    </div>
    </div>
	
	 <div class="control-group">
    <label class="control-label" for="inputEmail">Username</label>
    <div class="controls">
    <input type="text" id="inputEmail" placeholder="Username" required>
    </div>
    </div>
    <div class="control-group">
    <label class="control-label" for="inputPassword">Password</label>
    <div class="controls">
    <input type="password" id="inputPassword" placeholder="Password" required>
    </div>
    </div>
	
    <div class="control-group">
    <div class="controls">

    <button type="submit" class="btn btn-info">Sign Up</button>
    </div>
    </div>
	<a href="#" id="click">Click Here to login</a>
	</div>
	
	
	<div class="form2">
    <div class="control-group">
    <label class="control-label" for="inputEmail">Username</label>
    <div class="controls">
    <input type="text" id="inputEmail" placeholder="Username" required>
    </div>
    </div>
    <div class="control-group">
    <label class="control-label" for="inputPassword">Password</label>
    <div class="controls">
    <input type="password" id="inputPassword" placeholder="Password" required>
    </div>
    </div>
	
    <div class="control-group">
    <div class="controls">
    <label class="checkbox">
    <input type="checkbox" required> Remember me
    </label>
    <button type="submit" class="btn btn-success">Login</button>
    </div>
    </div>
		<a href="#" id="click1"> Click Here to Sign Up</a>
	</div>
	
    </form>






</div>
</body>
</html>