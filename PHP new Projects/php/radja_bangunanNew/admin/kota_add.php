<?php
include_once "../library/inc.connection.php";
include_once "../library/inc.library.php";

#MEMBACA TOMBOL simpan klik
if (isset($_POST['btnSimpan'])) {
	#baca variabel 
	$txtNama =$_POST['txtNama'];
	$txtNama	=str_replace("'", "&acute;", $txtNama);

	#VALIDASI UNTUK FORM JIKA FORM KOSONG

	$pesanError= array();
	if (trim($txtNama)=="") {
		$pesanError[]= "Data <b>Nama Kota </b> Tidak Boleh KOSONG";
	}

	//VALIDASI nama kota, tidak boleh ada nama kota yang sama
	$cekSql ="SELECT kd_kota,nm_kota FROM kota WHERE nm_kota='$txtNama'";
	$cekQry = mysql_query($cekSql, $koneksidb) or die("Error Query:".mysql_error());
	if (mysql_num_rows($cekQry)>=1) {
		$pesanError[]= "Maaf, Kota <b>$txtNama</b> Sudah Dimasukkan ganti dengan nama lain";
	}

	#JIKA ADA PESAN ERROR DARI VALIDASI FORM 
	if (count($pesanError)>=1) {
		echo "<div class='mssgBox'>";
		echo "<img src ='../images/attention.png'><br><hr>";
		$noPesan= 0;
		foreach ($pesanError as $indeks => $pesan_tampil) {
			$noPesan++;
				echo "&nbsp;&nbsp; $noPesan. $pesan_tampil<br>";
		}
		echo "</div><br />";
	}
	else{
		#SIMPAN DATA KE DALAM DATABASE jika tidak menemukan error 
		$kodeBaru= buatKode("kota","K");
		$mySql= "INSERT INTO kabkot (,nm_kota)VALUES ('$kodeBaru','$txtNama')";
		$myQry= mysql_query($mySql, $koneksidb)or die("Gagal Simpan".mysql_error());
		if ($myQry) {
			echo "<meta http-equiv='refresh' content='0; url=?open=Kota-Data'>";
		}
	}
}
$dataKode		= buatKode("kota","K");
$dataNama		= isset($_POST['txtNama']) ? $_POST['txtNama']: '';
?>
<form action="<?php $_SERVER['PHP_SELF']; ?>" method="POST" name="frmadd">
<table class="table-list" width="100%" style="margin-top:0px;">
	<tr>
		<th colspan="3">TAMBAH DATA KOTA</th>
	</tr>
	<tr>
		<td width="18%"><strong>Id Provinsi</strong></td>
		<td width="1%"><strong>:</strong></td>
		<td width="81%"><input name="textfield" id="textfield" value="<?php echo $dataKode; ?>" size="10" maxlength="10" readonly="readonly"></td>
	</tr>
	<tr>
		<td><strong>Nama Kota</strong></td>
		<td><strong>:</strong></td>
		<td><input name="txtNama" value="<?php echo $dataNama; ?>" size="80" maxlength="100"></td>
	</tr>
	<tr>
		<td>&nbsp;</td>
		<td>&nbsp;</td>
		<td><input name="btnSimpan" type="submit" value="SIMPAN" style="cursor:pointer;"></td>
	</tr>
</table>
	
</form>