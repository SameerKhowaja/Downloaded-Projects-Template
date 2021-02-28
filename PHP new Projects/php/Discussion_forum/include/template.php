<?php
if (!defined('WEB_ROOT')) {
	exit;
}
$self = WEB_ROOT . 'index.php';
$uType = $_SESSION['user_type'];
if($uType == 'admin' || $uType == 'employee' ){
//	$img = WEB_ROOT . 'images/company_info.jpg';
$img = WEB_ROOT . 'images/baner1.png';
}else {
	$img = WEB_ROOT . 'images/baner1.png';
}
?>
<html>
<head>
<title><?php echo $pageTitle; ?></title>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1">
<link href="<?php echo WEB_ROOT;?>include/admin.css" rel="stylesheet" type="text/css">
<link href="<?php echo WEB_ROOT;?>include/menu.css" rel="stylesheet" type="text/css">
<link href="<?php echo WEB_ROOT;?>include/main.css" rel="stylesheet" type="text/css">
<script language="JavaScript" type="text/javascript" src="<?php echo WEB_ROOT;?>library/common.js"></script>
<script language="JavaScript" type="text/javascript" src="<?php echo WEB_ROOT;?>library/complains.js"></script>
</head>
<body>
<br/><br/>
<table width="1000" height="500" border="0" align="center" cellpadding="0" cellspacing="1" class="graybox" height="500">
  <tr>
    <td colspan="2"><img src="<?php echo $img; ?>" width="1000" height="120"></td>
  </tr>
  <tr>
    <td width="40%" valign="top" class="navArea"><p>&nbsp;</p>
 	<?php include("menu.php"); ?>    
	</td>
    <td width="900" valign="top" class="contentArea"><table width="100%" border="0" cellspacing="0" cellpadding="20">

        <tr>
          <td>
<?php
require_once $content;	 
?>
          </td>
        </tr>
      </table></td>
  </tr>
</table>
<p>&nbsp;</p>
<p><b>Copyright &copy; 2016: AKURE AMOS </b></p>
</body>
</html>
