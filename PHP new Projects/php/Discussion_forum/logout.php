<?php require("header.php");?>
<?php 
session_start();

ExecuteNonQuery ("UPDATE User SET isuser=false WHERE user_id='$_SESSION[uid]'");

session_destroy();
?>
<h1 style="color: #2A0000; font-weight: bold">Signed out</h1>
<p>
	<span style="color: #2A0000; font-weight: bold">You have signed out.</span>
	<object classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" codebase="http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=5,0,0,0" width="107" height="18">
      <param name="BGCOLOR" value="#551FAA" />
      <param name="movie" value="button1.swf" />
      <param name="quality" value="high" />
      <embed src="button1.swf" width="107" height="18" quality="high" pluginspage="http://www.macromedia.com/shockwave/download/index.cgi?P1_Prod_Version=ShockwaveFlash" type="application/x-shockwave-flash" bgcolor="#551FAA" ></embed>
    </object>
	<a href="index.php" style="color: #FFFBF0; font-weight: bold"></a><span style="font-weight: bold; color: #2A0000">to login again.</span></p>
<?php require("footer.php");?>