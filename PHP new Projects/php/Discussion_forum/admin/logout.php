<?php require("header.php");?>
<?php 
session_start();
session_destroy();
?>
<h1 style="color: #FFFBF0; font-weight: bold">log out</h1>
<p>
	  <span style="font-weight: bold; color: #2A0000">You have logged out.</span>  
	  <object classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" codebase="http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=5,0,0,0" width="103" height="24">
        <param name="movie" value="button2.swf" />
        <param name="quality" value="high" />
        <param name="bgcolor" value="#7F3FFF" />
        <embed src="button2.swf" quality="high" pluginspage="http://www.macromedia.com/shockwave/download/index.cgi?P1_Prod_Version=ShockwaveFlash" type="application/x-shockwave-flash" width="103" height="24" bgcolor="#7F3FFF"></embed>
      </object>
      <span style="font-weight: bold; color: #2A0000">to login again.</span></p>
<?php require("footer.php");?>