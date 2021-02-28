<script language="javascript" src="kalender.js"></script>
<script type="text/javascript">
	document.write (hari+","+tanggal+" "+bulan+" "+tahun)
</script>
<?php 
if (isset($_SESSION['SES_PELANGGAN'])=="") {
	echo "<b><font color='red'>Welcome";
	echo "|Guest</font></b>";
}
else {
	echo "<b>[Login Sebagai";
	echo "  |Selamat Datang: ".$_SESSION['SES_USERNAME']."]";
	echo "  [<a href=login_out.php>Logout</a>]</b>";
}
?>