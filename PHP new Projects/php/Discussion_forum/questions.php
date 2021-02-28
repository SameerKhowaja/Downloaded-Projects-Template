<?php session_start();
	require("header.php");
	require("checkUser.php");
	
	$id=$_GET["id"];
?>

<p><a href="question.php?stid=<?php echo $id ?>">
  <object classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" codebase="http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=5,0,0,0" width="100" height="23">
    <param name="movie" value="button8.swf" />
    <param name="quality" value="high" />
    <param name="bgcolor" value="#A0A0A4" />
    <embed src="button8.swf" quality="high" pluginspage="http://www.macromedia.com/shockwave/download/index.cgi?P1_Prod_Version=ShockwaveFlash" type="application/x-shockwave-flash" width="100" height="23" bgcolor="#A0A0A4"></embed>
  </object>
  <img src="res/images/askq.jpg" width="260"  class='imagedel'/></a></p>
<hr />
<?php 
	
	$str="SELECT * FROM question, user WHERE question.user_id=user.user_id and subtopic_id=$id";
	$result=ExecuteQuery($str);
	
	$no_rows = mysql_num_rows($result);
	
	if ($no_rows > 0)
	{
		while($row = mysql_fetch_array($result))
		{
			$rowsc=ExecuteQuery("SELECT count(*) as counter from answer where question_id=$row[question_id]");
			$rowc = mysql_fetch_array($rowsc);
			$count = $rowc['counter'];
			
			echo "<h4>";
			echo "<span class='box2'>";
			echo "<span class='head'><a href='questionview.php?qid=$row[question_id]' >$row[heading]</a> </span>";
			
			echo "</span>";
			echo "</h4>";
			
			echo "$row[question_detail] <span class='view2'>Views : $row[views], Replies :$count</span>";
			echo "<br/><br/>";
			
			echo "Asked by<br/>$row[fullname]";
		
			echo "<br/><div class='line'></div>";
			//echo  "<a href='answer.php?qid=$row[question_id]' class='reply'>REPLY</a>";
			
		}
	
		
	}
	
			

	else
	{
		echo "No questions at the moment";
	}
	
 

?>
<?php require("footer.php")?>