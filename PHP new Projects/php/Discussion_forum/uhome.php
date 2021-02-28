<?php 
	session_start();
	require("header.php");
	require("checkUser.php");
?>
<script type="text/javascript">
	document.getElementById("auhome").className="active";
</script>
<style type="text/css">
<!--
.style1 {color: #2A0000}
.style2 {color: #2A0000; }
.style3 {font-weight: bold}
.style4 {font-weight: bold}
-->
</style>
<h4 class="style2"><a href="que.php"></a>
  <object classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" codebase="http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=5,0,0,0" width="100" height="20">
    <param name="movie" value="button6.swf" />
    <param name="quality" value="high" />
    <param name="bgcolor" value="#808080" />
    <embed src="button6.swf" quality="high" pluginspage="http://www.macromedia.com/shockwave/download/index.cgi?P1_Prod_Version=ShockwaveFlash" type="application/x-shockwave-flash" width="100" height="20" bgcolor="#808080"></embed>
  </object>
  &nbsp;&nbsp;<strong>&nbsp;&nbsp;&nbsp;
    <a href="ans.php"></a></strong>
  <object classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" codebase="http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=5,0,0,0" width="100" height="20">
    <param name="movie" value="button5.swf" />
    <param name="quality" value="high" />
    <param name="bgcolor" value="#808080" />
    <embed src="button5.swf" quality="high" pluginspage="http://www.macromedia.com/shockwave/download/index.cgi?P1_Prod_Version=ShockwaveFlash" type="application/x-shockwave-flash" width="100" height="20" bgcolor="#808080"></embed>
  </object>
  <object classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" codebase="http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=5,0,0,0" width="100" height="20">
    <param name="movie" value="button7.swf" />
    <param name="quality" value="high" />
    <param name="bgcolor" value="#A0A0A4" />
    <embed src="button7.swf" quality="high" pluginspage="http://www.macromedia.com/shockwave/download/index.cgi?P1_Prod_Version=ShockwaveFlash" type="application/x-shockwave-flash" width="100" height="20" bgcolor="#A0A0A4"></embed>
  </object>
</h4>
<?php

	$sql="select * from question,user where question.user_id=user.user_id ORDER BY  datetime desc limit 0,5";
	
	$result=ExecuteQuery($sql);
	

	while($row = mysql_fetch_array($result))
	{
		   
			
			echo "<span class='box2'>";
			echo "<span class='head'><a href='questionview.php?qid=$row[question_id]' >$row[heading]</a></span>";
			
			echo "<table>";
			echo "<tr><td valign='top' width='100px'>
				<img src='$row[uimg]' alt='' class='uimg'/>
				<br/>
			$row[fullname]
			<td valign='top'>
			$row[question_detail]<br/><br/>
			$row[datetime]<br/><br/>
			</td></tr>";
			
			
			echo "</table></span><div class='h10'></div>";
		}
	
?>

<?php require("footer.php");?>