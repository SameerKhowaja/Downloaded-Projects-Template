<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
<title>forget-password</title>
<style type="text/css">
fieldset {
	width:500px;
	border:5px dashed #CCCCCC;
	margin:0 auto;
	border-radius:5px;
}


legend {
	color: blue;
	font-size: 25px;
}

dl {
	float: right;
	width: 390px;
}

dt {
	width: 180px;
	color: brown;
	font-size: 19px;
}

dd {
	width:200px;
	float:left;
}

dd input {
	width: 200px;
	border: 2px dashed #DDD;
	font-size: 15px;
	text-indent: 5px;
	height: 28px;
}

.btn {
	color: #fff;
	background-color: dimgrey;
	height: 38px;
	border: 2px solid #CCC;
	border-radius: 10px;
	float: right;
}

.style1 {font-weight: bold}
.style3 {color: #2A0000}
.style4 {font-weight: bold}
.style5 {font-weight: bold}
.style6 {
	color: #2A0055;
	font-weight: bold;
}
</style>
</head>

<body background="ups/Mouse-Reading-a-Book-540x337.jpg">
<?php 

require_once './library/config.php';
require_once './library/functions.php';

$errorMessage = '&nbsp;';

if (isset($_POST['username'])) {
	$result = doChangePassword();
	
	if ($result != '') {
		$errorMessage = $result;
	}
	
}
	?>
<form id="form1" name="form1" method="post" action="">
  <table width="1000" align="center" cellpadding="0" background="ups/Page-BgGlare.png" height="200">
    <tr>
      <td colspan="3" background="ups/IMG_3375.JPG"><object classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" codebase="http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=7,0,19,0" width="1000" height="200">
        <param name="movie" value="ups/movbest.swf" />
        <param name="quality" value="high" />
        <embed src="ups/movbest.swf" quality="high" pluginspage="http://www.macromedia.com/go/getflashplayer" type="application/x-shockwave-flash" width="1000" height="200"></embed>
      </object></td>
    </tr>
    <tr>
      <td width="200"><img src="ups/IMG_3377.JPG" width="210" height="210" /></td>
      <td bordercolorlight="#FFFFFF"> <form method="post" name="frmLogin" id="frmLogin">
       <table width="600" height="210" border="0" align="center" cellpadding="5" cellspacing="1" bgcolor="#336699" class="entryTable">
        <tr id="entryTableHeader"> 
         <td align="center">:: Forget Password::</td>
        </tr>
        <tr> 
         <td class="contentArea" bgcolor="#CCCCCC"> 
		 <div class="errorMessage" align="center"><?php echo $errorMessage; ?></div>

		  <table width="100%" border="0" cellpadding="2" cellspacing="1">
           <tr align="center"> 
            <td colspan="3" bgcolor="">&nbsp;</td>
           </tr>
           <tr class="text"> 
            <td width="100" align="right"><span class="style6">User Name</span></td>
            <td width="9" align="center">:</td>
            <td width="463"><input name="username" type="text" class="box" id="txtUserName"  size="30" maxlength="40"></td>
           </tr>
           <tr>
             <td align="right"><span class="style6">E-mail</span></td>
             <td align="center">:</td>
             <td><input name="email" type="text" class="box" id="txtPassword" size="30" maxlength="40"></td>
           </tr>
           <tr> 
            <td width="100" align="right">&nbsp;</td>
            <td width="9" align="center">&nbsp;</td>
            <td><label></label></td>
           </tr>
           <tr>
             <td colspan="2">&nbsp;</td>
             <td>&nbsp;</td>
           </tr>
           <tr> 
            <td height="26" colspan="2">&nbsp;</td>
            <td><input name="btnLogin" type="submit" id="btnLogin" value=" Change Password " style="font-size:12px;color:#0066FF;"></td>
           </tr>
          </table></td>
        </tr>
       </table>
       <object classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" codebase="http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=5,0,0,0" width="100" height="20">
         <param name="movie" value="button4.swf" />
         <param name="quality" value="high" />
         <embed src="button4.swf" quality="high" pluginspage="http://www.macromedia.com/shockwave/download/index.cgi?P1_Prod_Version=ShockwaveFlash" type="application/x-shockwave-flash" width="100" height="20" ></embed>
       </object>
      </form>
	  </td>
      <td width="200"><img src="ups/boxing.JPG" width="210" height="210" /></td>
    </tr>
    <tr>
      <td colspan="3" align="center" bgcolor="#999999" background="ups/Page-BgGlare.png"><?php require_once('footer.php'); ?></td>
	  
    </tr>
  </table>
</form>
</body>
</html>
