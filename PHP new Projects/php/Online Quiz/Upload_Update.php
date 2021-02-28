	<link rel="stylesheet"type="text/css" media="all" href="mystyle.css">
    <body>
<?php

function counter(){// static everytime na tatawagin ung function madadagdagan ung value ng counts
static $counts = 0;
$counts++;
global $re;
$re=$counts;
}
	

include ('config.php');//connection


$id=$_GET['id'];//GET the parameter passed by view.php


$res=mysql_query("SELECT * FROM person WHERE ID='$id'");//select the specific record to be edit


$row=mysql_fetch_array($res);//$res is an array fetch is required;


if (isset($_POST['send'])){//update changes

$n1=$_POST['a'];
$n2=$_POST['b'];
$n3=$_POST['c'];
$n4=$_POST['d'];
$n5=$_POST['e'];
$n6=$_POST['f'];
$n7=$_POST['g'];
$n8=$_POST['h'];
$n9=$_POST['i'];
$n10=$_POST['j'];
$n11=$_POST['k'];
$n12=$_POST['l'];
$n13=$_POST['m'];
$n14=$_POST['n'];
$n15=$_POST['o'];
$n16=$_POST['p'];
$n17=$_POST['q'];
$n18=$_POST['r'];
$n19=$_POST['s'];
$n20=$_POST['t'];
$n21=$_POST['u'];	
					if((($n1=="w")&&($n2=="w")&&($n3=="w")&&($n4=="w")&&($n5=="w")&&($n6=="w")&&($n7=="w")
				&&($n8=="w")&&($n9=="w")&&($n10=="w")&&($n11=="w")&&($n12=="w")&&($n13=="w")&&($n14=="w")
				&&($n15=="w")&&($n16=="w")&&($n17=="w")&&($n18=="w")&&($n19=="w")&&($n20=="w")&&($n21=="w")/*)||
				
				(($n1=="w")||($n2=="w")||($n3=="w")||($n4=="w")||($n5=="w")||($n6=="w")&&($n7=="w")
				||($n8=="w")||($n9=="w")||($n10=="w")||($n11=="w")||($n12=="w")||($n13=="w")||($n14=="w")
				&&($n15=="w")||($n16=="w")||($n17=="w")||($n18=="w")||($n19=="w")||($n20=="w")||($n21=="w")*/)){
					
					
					echo'<script> alert("Please make sure that you answered the questions"); history.back();</script>';
					}
					
								else{
					//generating results#########################################################
				
					if($n1=="w"){echo"1. No Answer <br/>";}
					else if($n1=="c"){
					counter();
					echo"1. correct <br/>";
					}else{echo"1. wrong <br/>";}
					
					
					if($n2=="w"){echo"2. No Answer <br/>";}
					else if($n2=="c"){
					counter();
					echo"2. correct <br/>";
					}else{echo"2. wrong <br/>";}
					
					if($n3=="w"){echo"3. No Answer <br/>";}
					else if($n3=="c"){
					counter();
					echo"3. correct <br/>";
					}else{echo"3. wrong <br/>";}
					
					if($n4=="w"){echo"4. No Answer <br/>";}
					else if($n4=="c"){
					counter();
					echo"4. correct <br/>";
					}else{echo"4. wrong <br/>";}
					
					if($n5=="w"){echo"5. No Answer <br/>";}
					else if($n5=="c"){
					counter();
					echo"5. correct <br/>";
					}else{echo"5. wrong <br/>";}
					
					if($n6=="w"){echo"6. No Answer <br/>";}
					else if($n6=="c"){
					counter();
					echo"6. correct <br/>";
					}else{echo"6. wrong <br/>";}
					
					if($n7=="w"){echo"7. No Answer <br/>";}
					else if($n7=="c"){
					counter();
					echo"7. correct <br/>";
					}else{echo"7. wrong <br/>";}
					
					if($n8=="w"){echo"8. No Answer <br/>";}
					else if($n8=="c"){
					counter();
					echo"8. correct <br/>";
					}else{echo"8. wrong <br/>";}
					
					
					if($n9=="w"){echo"9. No Answer <br/>";}
					else if($n9=="c"){
					counter();
					echo"9. correct <br/>";
					}else{echo"9. wrong <br/>";}
					
					if($n10=="w"){echo"10. No Answer <br/>";}
					else if($n10=="c"){
					counter();
					echo"10. correct <br/>";
					}else{echo"10. wrong <br/>";}
					
					if($n11=="w"){echo"11. No Answer <br/>";}
					else if($n11=="c"){
					counter();
					echo"11. correct <br/>";
					}else{echo"11. wrong <br/>";}
					
					if($n12=="w"){echo"12. No Answer <br/>";}
					else if($n12=="c"){
					counter();
					echo"12. correct <br/>";
					}else{echo"12. wrong <br/>";}
					
					if($n13=="w"){echo"13. No Answer <br/>";}
					else if($n13=="c"){
					counter();
					echo"13. correct <br/>";
					}else{echo"13. wrong <br/>";}
					
					if($n14=="w"){echo"14. No Answer <br/>";}
					else if($n14=="c"){
					counter();
					echo"14. correct <br/>";
					}else{echo"14. wrong <br/>";}
					
					if($n15=="w"){echo"15. No Answer <br/>";}
					else if($n15=="c"){
					counter();
					echo"15. correct <br/>";
					}else{echo"15. wrong <br/>";}
					
					if($n16=="w"){echo"16. No Answer <br/>";}
					else if($n16=="c"){
					counter();
					echo"16. correct <br/>";
					}else{echo"16. wrong <br/>";}
					
					if($n17=="w"){echo"17. No Answer <br/>";}
					else if($n17=="c"){
					counter();
					echo"17. correct <br/>";
					}else{echo"17. wrong <br/>";}
					
					if($n18=="w"){echo"18. No Answer <br/>";}
					else if($n18=="c"){
					counter();
					echo"18. correct <br/>";
					}else{echo"18. wrong <br/>";}
					
					if($n19=="w"){echo"19. No Answer <br/>";}
					else if($n19=="c"){
					counter();
					echo"19. correct <br/>";
					}else{echo"19. wrong <br/>";}
					
					if($n20=="w"){echo"20. No Answer <br/>";}
					else if($n20=="c"){
					counter();
					echo"20. correct <br/>";
					}else{echo"20. wrong <br/>";}
					
					if($n21=="w"){echo"21. No Answer <br/>";}
					else if($n21=="c"){
					counter();
					echo"21. correct <br/>";
					}else{echo"21. wrong <br/>";}


					
				
			
				
			
		############################################ PAG MALI LAHAT NG SAGOT #########################################				
				if((($n1!="c")&&($n2!="c")&&($n3!="c")&&($n4!="c")&&($n5!="c")&&($n6!="c")&&($n7!="c")
				&&($n8!="c")&&($n9!="c")&&($n10!="c")&&($n11!="c")&&($n12!="c")&&($n13!="c")&&($n14!="c")
				&&($n15!="c")&&($n16!="c")&&($n17!="c")&&($n18!="c")&&($n19!="c")&&($n20!="c")&&($n21!="c"))){
					$re=0;
				}
		###############################################################################################################
		
		 $av=-4*($re/21)+5;
if($av>=3.0){
      $remarks="FAILED";
}
else{
      $remarks="PASSED";
}
				

$fname=ucfirst($_POST['fname']);
$lname=ucfirst($_POST['lname']);
$mname=ucfirst($_POST['mname']);
$address=ucfirst($_POST['address']);
$gender=ucfirst($_POST['gender']);
$age=$_POST['age'];
$description=$remarks;
$scores=$re;
		##################################  PICTURE     ##########################################################
$filetmp=$_FILES['imagesee']['tmp_name'];
$filename=$_FILES['imagesee']['name'];
$filetype=$_FILES['imagesee']['type'];
$filepath="uploaded_pic/".$filename;			
	
		 if($gender=="----"){
			echo'<script> alert("Please make sure that you selected your gender")</script>';
			echo"<h1>Error occured!</h1><img src='images/gold.gif'>";}
		 else{
			if(($filename=="")||($filetmp=="")||($filetype=="")||($filepath=="")){
				$ins=mysql_query("Update PERSON set Firstname='$fname', Lastname='$lname', Middlename='$mname', Address='$address', Gender='$gender', Age='$age', Score='$scores', Remarks='$remarks',Imagename='default.png', Imagepath='uploaded_pic/default.png', Imagetype='PNG' where ID='$id' ");}
			else{
				move_uploaded_file($filetmp,$filepath);
				$ins=mysql_query("Update PERSON set Firstname='$fname', Lastname='$lname', Middlename='$mname', Address='$address', Gender='$gender', Age='$age', Score='$scores', Remarks='$remarks',Imagename='$filename', Imagepath='$filepath', Imagetype='$filetype' where ID='$id'");}
					if($ins) {
echo'<hr/><br/>TOTAL SCORE EARNED:   '.$re;
echo'<hr/><br/> GRADE:   '.$av;
echo'<hr/><br/> REMARKS:   '.$remarks;
							echo "<script language='javascript' type='text/javascript'>alert('Successfully Updated!')</script>";
							echo "<script language='javascript' type='text/javascript'>window.open('view.php','_self')</script>";
							  }
			  }


}//sa else
return false;
}
		 
		 

?>
   </body>