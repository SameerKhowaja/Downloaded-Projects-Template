




<link rel="stylesheet"type="text/css" media="all" href="matstyle.css">

<?php
include ('config.php');//connection

session_start();
if(!isset($_SESSION['ID'])){
header('location:login.php');
}
$id=$_GET['id'];//GET the parameter passed by view.php


$res=mysql_query("SELECT * FROM person WHERE ID='$id'");//select the specific record to be edit


$row=mysql_fetch_array($res);?>

 <body>
      <div class="body">


<div id="pageWrapper">
  <img src="images/landscapeq.gif">
<div id="header">
  <h1 id="blogTitle"></h1>

</div> </div> 
 <div class="space"><a href="#">&nbsp;&nbsp;&nbsp;&nbsp;Home&nbsp;&nbsp;&nbsp;&nbsp;</a>
 <a href="#">&nbsp;Contact Us&nbsp;</a>
 <a href="#"> &nbsp;&nbsp;&nbsp;&nbsp; About Us &nbsp;&nbsp;&nbsp;&nbsp; </a>
 <a href="#">&nbsp;&nbsp;&nbsp;&nbsp;Help&nbsp;&nbsp;&nbsp;&nbsp;</a>
 <a href="#">Terms and Conditions</a>
 <a href="#"> &nbsp;&nbsp;Customer Care &nbsp;&nbsp; </a>
 <a href="#">&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; Share&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</a>
 <a href="#">&nbsp;&nbsp;&nbsp; &nbsp; Like Us&nbsp;&nbsp;&nbsp; &nbsp; </a>

 </div>  
	 
 <div class="menu">
 
 <li><a href="high.php">Highest Score</a> </li>	
 <li> <a href="rev.php"> Reviewers </a> </li>
 <li> <a href="Results.php"> Results </a> </li>
 <li> <a href="ViewPass.php"> Passers</a> </li>
 <li> <a href="login.php">Log-in <img src="images/icon_users.png" width="28" height="18"></a> <li>
 <marquee direction="left" behavior="alternate"><img src="images/star.gif"><marquee direction="up" width="50"><img src="images/star.gif"></marquee><img src="images/star.gif"></marquee>
  <marquee direction="left" behavior="alternate"><img src="images/star.gif"><marquee direction="up" width="50"><img src="images/star.gif"></marquee><img src="images/star.gif"></marquee>
  <marquee direction="right" behavior="alternate"><img src="images/star.gif"><marquee direction="down" width="50"><img src="images/star.gif" width="45" height="10"></marquee></marquee>
  <marquee direction="right" behavior="alternate"><img src="images/star.gif"><marquee direction="down" width="50" height="1000"><img src="images/star.gif"></marquee></marquee>
 <marquee direction="left" behavior="alternate"><img src="images/star.gif"><marquee direction="up" width="50" height="330"><img src="images/star.gif"></marquee></marquee>
 </div>
 <form method="post" action="Upload_Update.php?id=<?php echo $row['ID']; ?>" enctype="multipart/form-data">
 <div class="reg">

<div class="head"><input type="file" title="SELECT YOUR PROFILE PICTURE" name="imagesee" value="<?php echo $row['Imagename'];?>" /><br/>
<input type="text" name="fname" required value="<?php echo $row['Firstname']; ?>"/>
<input type="text" name="lname" required value="<?php echo $row['Lastname']; ?>"/>
<input type="text" name="mname" required value="<?php echo $row['Middlename']; ?>"/><br/>
<b><li>FIRST NAME</li></b>
<b><li>LAST NAME</li></b>
<b><li>MIDDLE NAME</li></b>
<hr/><br/></div>

<div class="head">
<input type="text" name="address" required value="<?php echo $row['Address']; ?>"/>
<select name="gender">
<option hidden value="<?php echo $row['Gender']?>"> <?php echo $row['Gender'];?> </option>
<option value="----">----</option>
<option value="FEMALE">FEMALE</option>
<option value="MALE">MALE</option>
</select>

<input type="number" name="age" min="18" max="100" required value="<?php echo $row['Age']; ?>"/><br/>
<b><li>ADDRESS&nbsp;&nbsp;&nbsp;&nbsp;</li></b>
<b><li>GENDER &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</li></b>
<b><li>AGE</li></b>
<br/><hr/>
</div>
	<div class="flip3D">
  <div class="back">
 
 <font>1.)Nuclear power must be unfavorable because the waste from nuclear reactions is highly fatal.
</font>
<div class="res">
<li><input type="radio"name="a" value="c"/>anything that has ill-effects on the ecosystem must be prohibited</li>
<li><input type="radio"name="a"/>waste from nuclear reactors can be disposed safely and efficiently</li>
<li><input type="radio"name="a"/>measures taken to control and dispose of waste from nuclear reactors have been fruitless</li>
<li><input type="radio"name="a" value="w" id="w" checked/></li>
</div>
</div> 
  <div class="front"><center>Question no.1<br/><b>ENVIRONMENTAL ISSUES</b></center><marquee direction="left" behavior="alternate"><marquee direction="up" width="60"><img src="images/star.gif"></marquee></marquee></div>
  
</div>

<!--------------------------------->
<!--------------------------------->
 	<div class="flip3D">
  <div class="back">
 <font>2.)Chlorofluorocarbons are popular as propellants and solvents because they are
</font>
<div class="res">
<li><input type="radio"name="b" value="c"/>reactive	</li>
<li><input type="radio"name="b"/> stable</li>
<li><input type="radio"name="b"/> biodegradable</li>
<li><input type="radio"name="b" value="w" id="w" checked/></li>

</div>
</div> 
  <div class="front"><center>Question no.2<br/><b>ENVIRONMENTAL ISSUES</b></center><marquee direction="left" behavior="alternate"><marquee direction="up" width="60"><img src="images/star.gif"></marquee></marquee></div>
</div>

 
<!--------------------------------->
<!--------------------------------->
 	<div class="flip3D">
  <div class="back">
 <font>3.)Monoculture cropping or planting a single crop in a large area is not advisable because it-
</font>
<div class="res">
<li><input type="radio"name="c" value="c"/>promotes pest infestation</li>
<li><input type="radio"name="c"/>requires less fertilizer</li>
<li><input type="radio"name="c"/>lowers the water table</li>
<li><input type="radio"name="c" value="w" id="w" checked/></li>
 &nbsp;
</div>
</div> 
  <div class="front"><center>Question no.3<br/><b>ENVIRONMENTAL ISSUES</b></center><marquee direction="left" behavior="alternate"><marquee direction="up" width="60"><img src="images/star.gif"></marquee></marquee></div>
</div>
 &nbsp;
 </center>
<!--------------------------------->

<!--------------------------------->
 	<div class="flip3D">
  <div class="back">
 <font>4.)Which of the following is the major cause of coral-reef destruction?
</font>
<div class="res">
<li><input type="radio"name="d"/>Dynamite fishing</li>
<li><input type="radio"name="d" />sewerage pollution</li>
<li><input type="radio"name="d" value="c"/>moro-ami</li>
<li><input type="radio"name="d" value="w" id="w" checked/></li>
 &nbsp;
</div>
</div> 
  <div class="front"><center>Question no.4<br/><b>ENVIRONMENTAL ISSUES</b></center></div>
</div>
 &nbsp;
 
<!--------------------------------->

<!--------------------------------->
 	<div class="flip3D">
  <div class="back">
 <font>5.)Putting up dams along rivers negatively affect on marine fishes because 
</font>
<div class="res">
<li><input type="radio"name="e"/>less water will flow to sea</li>
<li><input type="radio"name="e" />less minerals will flow to sea</li>
<li><input type="radio"name="e" value="c"/>some marine fishes spends part of their life cycle upstreams</li>
<li><input type="radio"name="e" value="w" id="w" checked/></li>
 &nbsp;
</div>
</div> 
  <div class="front"><center>Question no.5<br/><b>ENVIRONMENTAL ISSUES</b></center></div>
</div>
 &nbsp;
 
<!--------------------------------->
<!--------------------------------->
 	<div class="flip3D">
  <div class="back">
 <font>6.)The government is established for the furtherance and guarantees of certain inalienabale human rights.

</font>
<div class="res">
<li><input type="radio"name="f"/>proclamation</li>
<li><input type="radio"name="f"/>prohibition</li>
<li><input type="radio"name="f" value="c"/>preservation</li>
<li><input type="radio"name="f" value="w" id="w" checked/></li>
 &nbsp;
</div>
</div> 
  <div class="front"><center>Question no.6<br/><b>ENVIRONMENTAL ISSUES</b></center></div>
</div>
 &nbsp;
 
<!--------------------------------->
<!--------------------------------->
 	<div class="flip3D">
  <div class="back">
 <font>7.)At present, how many percent of the population of the Philippines are aliens?

</font>
<div class="res">
<li><input type="radio"name="g" value="c"/>30%
</li>
<li><input type="radio"name="g"/>40%</li>
<li><input type="radio"name="g"/>70%</li>
<li><input type="radio"name="g" value="w" id="w" checked/></li>
 &nbsp;
</div>
</div> 
  <div class="front"><center>Question no.7<br/><b>CURRENT EVENTS</b></center></div>
</div>
 &nbsp;
 
<!--------------------------------->
<!--------------------------------->
 	<div class="flip3D">
  <div class="back">
 <font>8.)What project of the DENR that includes the protection of Industrial pollution of     our Environment?

</font>
<div class="res">
<li><input type="radio"name="h"/>Bantay Kalikasan</li>
<li><input type="radio"name="h"/>Bantay Dagat</li>
<li><input type="radio"name="h" value="c"/>Solid Waste Management</li>
<li><input type="radio"name="h" value="w" id="w" checked/></li>
 &nbsp;
</div>
</div> 
  <div class="front"><center>Question no.8<br/><b>CURRENT EVENTS</b></center></div>
</div>
 &nbsp;
 
<!--------------------------------->
<!--------------------------------->
 	<div class="flip3D">
  <div class="back">
 <font>9.)What government agency thus the status of government employee in the free voluntary services belong?

</font>
<div class="res">
<li><input type="radio"name="i"/> Municipal</li>
<li><input type="radio"name="i"/>Secretary</li>
<li><input type="radio"name="i" value="c"/>Barangay</li>
<li><input type="radio"name="i" value="w" id="w" checked/></li>
 &nbsp;
</div>
</div> 
  <div class="front"><center>Question no.9<br/><b>CURRENT EVENTS</b></center></div>
</div>
 &nbsp;
 
<!--------------------------------->
<!--------------------------------->
 	<div class="flip3D">
  <div class="back">
 <font>10.)Mitch is probably a pianist. She can really stretch her hand and fingers.

</font>
<div class="res">
<li><input type="radio"name="j"/>only people with big hands and long fingers can be pianist.</li>
<li><input type="radio"name="j"/>playing the piano helps Mitch stretch her hands and fingers</li>
<li><input type="radio"name="j" value="c"/>stretching helps pianist perform</li>
<li><input type="radio"name="j" value="w" id="w" checked/></li>
 &nbsp;
</div>
</div> 
  <div class="front"><center>Question no.10<br/><b>LOGICAL ANALYSIS</b></center></div>
</div>
 &nbsp;
 
<!--------------------------------->

<!--------------------------------->
 	<div class="flip3D">
  <div class="back">
 <font>11.)Chris is a responsible man, He takes good care of his family.

</font>
<div class="res">
<li><input type="radio"name="k"/>taking good care of the family is the responsibility of men</li>
<li><input type="radio"name="k"/>responsible men take good care of their families</li>
<li><input type="radio"name="k" value="c"/>the family is responsible for taking care of men</li>
<li><input type="radio"name="k" value="w" id="w" checked/></li>
 &nbsp;
</div>
</div> 
  <div class="front"><center>Question no.11<br/><b>LOGICAL ANALYSIS</b></center></div>
</div>
 &nbsp;
 
<!--------------------------------->
<!--------------------------------->
 	<div class="flip3D">
  <div class="back">
 <font>12.)All flowers are fragrant. Some flowers are brightly colored. The gumamela is a kind of flower, the sabila is not a kind of flower.

</font>
<div class="res">
<li><input type="radio"name="l" value="c"/>some brightly colored flowers are fragrant</li>
<li><input type="radio"name="l"/>the sabila is not brightly colored</li>
<li><input type="radio"name="l"/>the sabila is not fragrant</li>
<li><input type="radio"name="l" value="w" id="w" checked/></li>
 &nbsp;
</div>
</div> 
  <div class="front"><center>Question no.12<br/><b>LOGICAL ANALYSIS</b></center></div>
</div>
 &nbsp;
 
<!--------------------------------->

<!--------------------------------->
 	<div class="flip3D">
  <div class="back">
 <font>13.)They were able to WEATHER the storm.

</font>
<div class="res">
<li><input type="radio"name="m"/>reached home safely</li>
<li><input type="radio"name="m" value="c"/>survived the crisis</li>
<li><input type="radio"name="m"/>predicted the calamity</li>
<li><input type="radio"name="m" value="w" id="w" checked/></li>
 &nbsp;
</div>
</div> 
  <div class="front"><center>Question no.13<br/><b>IDIOMATIC EXPRESSIONS</b></center></div>
</div>
 &nbsp;
 
<!--------------------------------->

<!--------------------------------->
 	<div class="flip3D">
  <div class="back">
 <font>14.)TRUST men and they will be true to you.

</font>
<div class="res">
<li><input type="radio"name="n" value="c"/>a man is loyal in whom confidence had been placed</li>
<li><input type="radio"name="n"/>man must trust you to be faithful to you</li>
<li><input type="radio"name="n"/>a secret is a test of friendship</li>
<li><input type="radio"name="n" value="w" id="w" checked/></li>
 &nbsp;
</div>
</div> 
  <div class="front"><center>Question no.14<br/><b>IDIOMATIC EXPRESSIONS</b></center></div>
</div>
 &nbsp;
 
<!--------------------------------->
<!--------------------------------->
 	<div class="flip3D">
  <div class="back">
 <font>15.)Paddle your own CANOE.

</font>
<div class="res">
<li><input type="radio"name="o"/>earn his own money</li>
<li><input type="radio"name="o" value="c"/>learn from his mistakes</li>
<li><input type="radio"name="o"/>be self-reliant</li>
<li><input type="radio"name="o" value="w" id="w" checked/></li>
 &nbsp;
</div>
</div> 
  <div class="front"><center>Question no.15<br/><b>IDIOMATIC EXPRESSIONS</b></center></div>
</div>
 &nbsp;
 
<!--------------------------------->

<!--------------------------------->
 	<div class="flip3D">
  <div class="back">
 <font>16.)What is the greatest numerical value?

</font>
<div class="res">
<li><input type="radio"name="p"/>3/8	</li>
<li><input type="radio"name="p"/>5/6</li>
<li><input type="radio"name="p" value="c"/>3/4 </li>
<li><input type="radio"name="p" value="w" id="w" checked/></li>
 &nbsp;
</div>
</div> 
  <div class="front"><center>Question no.16<br/><b>PROBLEM SOLVING</b></center></div>
</div>
 &nbsp;
 
<!--------------------------------->

<!--------------------------------->
 	<div class="flip3D">
  <div class="back">
 <font>17.)What is the standard numerical value for 3.54 x 10 the 5th  power?


</font>
<div class="res">
<li><input type="radio"name="q"/>35, 400	</li>
<li><input type="radio"name="q"/>0.000354</li>
<li><input type="radio"name="q" value="c"/>354, 0000</li>
<li><input type="radio"name="q" value="w" id="w" checked/></li>
 &nbsp;
</div>
</div> 
  <div class="front"><center>Question no.17<br/><b>PROBLEM SOLVING</b></center></div>
</div>
 &nbsp;
 
<!--------------------------------->

<!--------------------------------->
 	<div class="flip3D">
  <div class="back">
 <font>18.)Which of the following has the least numerical value?


</font>
<div class="res">
<li><input type="radio"name="r"/>6+3 x 4	</li>
<li><input type="radio"name="r"/>3 x 6+4</li>
<li><input type="radio"name="r" value="c"/>4 x 6 +3</li>
<li><input type="radio"name="r" value="w" id="w" checked/></li>
 &nbsp;
</div>
</div> 
  <div class="front"><center>Question no.18<br/><b>PROBLEM SOLVING</b></center></div>
</div>
 &nbsp;
 
<!--------------------------------->
<!--------------------------------->
 	<div class="flip3D">
  <div class="back">
 <font>19.)The formula for covering Fahrenheit thermometer reading to centigrade reading is  C=5/9 ( F-32).  What is the equivalent of 95 degrees Fahrenheit?


</font>
<div class="res">
<li><input type="radio"name="s" value="c"/>35		</li>
<li><input type="radio"name="s"/>40	</li>
<li><input type="radio"name="s"/>50</li>
<li><input type="radio"name="s" value="w" id="w" checked/></li>
 &nbsp;
</div>
</div> 
  <div class="front"><center>Question no.19<br/><b>PROBLEM SOLVING</b></center></div>
</div>
 &nbsp;
 
<!--------------------------------->
<!--------------------------------->
 	<div class="flip3D">
  <div class="back">
 <font>20.)A farmer has seven hectares of land for rice production.  What should be the average yield in cavans per hectare of the land to produce a total of 525 cavans?


</font>
<div class="res">
<li><input type="radio"name="t" value="c"/>50	</li>
<li><input type="radio"name="t"/>75	</li>
<li><input type="radio"name="t"/>85	</li>
<li><input type="radio"name="t" value="w" id="w" checked/></li>
 &nbsp;
</div>
</div> 
  <div class="front"><center>Question no.20<br/><b>PROBLEM SOLVING</b></center></div>
</div>
 &nbsp;
 
<!--------------------------------->
<!--------------------------------->
 	<div class="flip3D">
  <div class="back">
 <font>21.)Mang Romy can climb a coconut tree at the rate of 10ft. per minute and return at 20 ft. per minute.  If it took him 3 minutes to climb and return. What is the height of the coconut?


</font>
<div class="res">
<li><input type="radio"name="u"/>10ft.</li>
<li><input type="radio"name="u"/>15ft.</li>
<li><input type="radio"name="u" value="c"/>20ft.</li>
<li><input type="radio"name="u" value="w" id="w" checked/></li>
 &nbsp;
</div>
</div> 
  <div class="front"><center>Question no.21<br/><b>PROBLEM SOLVING</b></center></div>
</div>
 &nbsp;
 
<!------------------------------>

<center><input type="submit" value="S U B M I T" name="send" id="myButton"/>&nbsp;&nbsp;&nbsp;<input type="reset" value="C L E A R" id="myButton"/></center>


	
    
	 </div>
		</form></div>
      
<marquee direction="up" behavior="alternate"><img src="images/star.gif"><marquee direction="down" width="40" height="1000"><img src="images/star.gif"></marquee></marquee>
    <marquee direction="down"><img src="images/star.gif"></marquee></marquee> <marquee direction="right" behavior="alternate"><img src="images/star.gif"><marquee direction="left" width="1000" height="40"><img src="images/star.gif"></marquee></marquee>
    <center><img src="images/star.gif"><img src="images/star.gif"><img src="images/star.gif"><img src="images/star.gif"><img src="images/star.gif"><img src="images/star.gif"></center>
<center><img src="images/star.gif"> CREATED BY: m@eus-2015<img src="images/star.gif"></center>
     <marquee direction="left" behavior="alternate"><img src="images/Clown.gif" width="98"><marquee direction="up" width="50"><img src="images/Clown.gif" width="50"><img src="images/Clown.gif" width="50"><img src="images/star.gif"></marquee><img src="images/Clown.gif"></marquee>
     </body>
     
   
