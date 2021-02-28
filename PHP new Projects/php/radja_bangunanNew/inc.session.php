<?php 
if(empty($_SESSION['SES_USERNAME'])){
	echo "<center>";
	echo "<br><br><b>Maaf Akses Anda Ditolak!</b><br>
			Anda Belum melakukan login, untuk mengakses halaman ini anda 
			diharuskan untuk melakukan login terlebih dahulu. Apabila belum memiliki 
			Account, silahkan daftar disini <br><b>Silahkan Untuk registrasi dahulu..!!</b>";
    echo "<meta http-equiv='refresh' content='2; url=?open=DataBaru'>";
	echo "</center>";	
exit;	
}
?>