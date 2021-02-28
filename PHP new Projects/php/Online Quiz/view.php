<link rel="stylesheet"type="text/css" media="all" href="mystyle.css">


  


<a href="index.php" id="myButton">TAKE EXAM</a>
<a href="index.php" id="myButton">HOME</a>
<?php

include ('config.php');
session_start();
if(!isset($_SESSION['ID'])){
header('location:login.php');


}
//connection
?>
          <a href="logout.php" id="myButton"> Log-out</a>
<form>


<?php

	
	
	$res=mysql_query("SELECT * FROM person where Deleted=1");
	//query to select records from the table
	while ($row=mysql_fetch_array($res)){
	//$res is an array therefore you should fetch the array
?>
	
     	<div class="flip3D">
  <div class="back">
 <font>


</font>
<div class="res">
<br/>
<br/>
<li><b>EXAMINEER NO:</b>   EX<?php echo $row['ID']; ?></li><br/>
<li><b>COMPLETE NAME:</b>  <?php echo $row['Firstname']." ".$row['Lastname']." ".$row['Middlename'] ?></li><br/>
<li><b>ADDRESS:</b>        <?php echo $row['Address']; ?> </li><br/>
<li><b>GENDER:</b>        <?php echo $row['Gender']; ?></li><br/>
<li><b>AGE:</b>           <?php echo $row['Age'] ?></li><br/>
<li><b>SCORE:</b>         <?php echo $row['Score'] ?></li> <br/>
<li><b>REMARKS:</b>       <?php echo $row['Remarks'] ?></li>
 &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<a href="edit.php?id=<?php echo $row['ID']; ?>"><img src="images/edit.png" title="EDIT YOUR RECORDS" width="20" height="30" /></a>
 &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<a href="Delete.php?id=<?php echo $row['ID']; ?>"><img src="images/delete.png" width="20" height="30" title="DELETE YOUR RECORDS"/></a>
 &nbsp;
</div>
</div> 
  <div class="front"><div class="tt"><center><img src="<?php echo $row['Imagepath']; ?>" width="220" height="150"><br/><?php  echo "EXAMINEER".$row['ID'];  ?><br/><b><?php echo $row['Firstname']."      ".$row['Lastname'];  ?></b><br/><strong><?php echo $row['Remarks'] ?></strong></center></div></div>
</div>
    
    
   
    
    

<?php
	/*<a href="edit.php?id=<?php echo $row['id']; ?>"> is used to pass parameter to edit.php to specify the record to be updated */
	}
?>







</form>