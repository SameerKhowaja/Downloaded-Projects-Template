<!DOCTYPE html>

<html lang='en'>
<head>
    <meta charset="UTF-8" /> 
    <title>
        TIME LOG
    </title>
    <?php
	//Start session
	session_start();	
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
	color: #F00;
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

<div id="wrapper">

	<form name="login-form" class="login-form" action="login_exec.php" method="post">
	
		<div class="header">
		<h1>TIME LOG</h1>
        
        <div>
<img src="dg8.gif" name="hr1"><img 
src="dg8.gif" name="hr2"><img 
src="dgc.gif"><img 
src="dg8.gif" name="mn1"><img 
src="dg8.gif" name="mn2"><img 
src="dgc.gif"><img 
src="dg8.gif" name="se1"><img 
src="dg8.gif" name="se2"><img 
src="dgam.gif" name="ampm"></div>

<script type="text/javascript">
// (c) 2000-2014 ricocheting.com
dg = new Array();
dg[0]=new Image();dg[0].src="dg0.gif";
dg[1]=new Image();dg[1].src="dg1.gif";
dg[2]=new Image();dg[2].src="dg2.gif";
dg[3]=new Image();dg[3].src="dg3.gif";
dg[4]=new Image();dg[4].src="dg4.gif";
dg[5]=new Image();dg[5].src="dg5.gif";
dg[6]=new Image();dg[6].src="dg6.gif";
dg[7]=new Image();dg[7].src="dg7.gif";
dg[8]=new Image();dg[8].src="dg8.gif";
dg[9]=new Image();dg[9].src="dg9.gif";
dgam=new Image();dgam.src="dgam.gif";
dgpm=new Image();dgpm.src="dgpm.gif";

function dotime(){ 
	var d=new Date();
	var hr=d.getHours(),mn=d.getMinutes(),se=d.getSeconds();

	// set AM or PM
	document.ampm.src=((hr<12)?dgam.src:dgpm.src);

	// adjust from 24hr clock
	if(hr==0){hr=12;}
	else if(hr>12){hr-=12;}

	document.hr1.src = getSrc(hr,10);
	document.hr2.src = getSrc(hr,1);
	document.mn1.src = getSrc(mn,10);
	document.mn2.src = getSrc(mn,1);
	document.se1.src = getSrc(se,10);
	document.se2.src = getSrc(se,1);
}

function getSrc(digit,index){
	return dg[(Math.floor(digit/index)%10)].src;
}

window.onload=function(){
	dotime();
	setInterval(dotime,1000);
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
