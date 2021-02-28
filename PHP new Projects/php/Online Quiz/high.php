

<link rel="stylesheet"type="text/css" media="all" href="mystyle.css">


  


<a href="index.php" id="myButton">TAKE EXAM</a>
<a href="index.php" id="myButton">HOME</a>
<?php

include ('config.php');
//connection
?>

<form>


<?php

	
	
	$res=mysql_query("SELECT * FROM person where Deleted=1 ORDER BY SCORE DESC LIMIT 2");
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

</div>
</div> 
  <div class="front"><div class="tt"><center><img src="<?php echo $row['Imagepath']; ?>" width="220" height="150"><br/><?php  echo "EXAMINEER".$row['ID'];  ?><br/><b><?php echo $row['Firstname']."      ".$row['Lastname'];  ?></b><br/><strong><?php echo $row['Remarks'] ?></strong></center></div></div>
</div>
    
    
   
    
    

<?php
	/*<a href="edit.php?id=<?php echo $row['id']; ?>"> is used to pass parameter to edit.php to specify the record to be updated */
	}
?>







</form>