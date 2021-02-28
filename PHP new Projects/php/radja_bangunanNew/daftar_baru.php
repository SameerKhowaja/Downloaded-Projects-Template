<?php

/*
**date 		: 27/04/2015
**author 	: Herry Prasetyo Noor Wibowo
**time 		: 2:21pm 

*/
include_once "library/inc.connection.php";
include_once "library/inc.library.php";

//FUNCTION 
function randomcode($len="10"){
	global $pass;
	global $lchar;

$code= NULL;
for($i=0; $i<$len; $i++){
		$char=chr(rand(48,122));
		while (!ereg("[a-zA-Z0-9]", $char)) {
			if($char == $lchar) {continue;}
			$char =chr(rand(48,90));
		}
		$pass .=$char;
		$lchar=$char;
	}
	return $pass;
}

//JIKA PENYIMPANAN SUKSES
if (isset($_GET['Aksi']) and $_GET['Aksi']=="Sukses") {
	echo "<br><br><center><b>SELAMAT, PENDAFTARAN ANDA SUDAH KAMI TERIMA SILAHKAN UNTUK AKTIVASI DI EMAIL ANDA</b>";
}



//membuat validasi pada form
$error_tuh="";
if (isset($_POST['btnRegister'])) {
$pesanError = array();
    //MEMBERIKAN VARIABEL UNTUK SEMUA FORM
    $txtNamaLengkap			= $_POST['txtNamaLengkap'];
    $txtNamaLengkap			= str_replace("'", "&acute;", $txtNamaLengkap);

    $txtlastName			= $_POST['txtlastName'];
    $txtlastName			= str_replace("'", "&acute;", $txtlastName);

    $txtUsername			= $_POST['txtUsername'];
    $cmbGender				= $_POST['cmbGender'];
    $txtAlamat 				= $_POST['txtAlamat'];	
    $txtMobile				= $_POST['txtMobile'];
    $kec					= $_POST['kec'];
    $propinsi   			= $_POST['propinsi'];
    $kota	      			=$_POST	['kota'];
    $txtPhone				=$_POST['txtPhone'];
    $txtPassword 			= $_POST['txtPassword'];
    $txtKodepos				=$_POST['txtKodepos'];
    $txtEmail				=$_POST['txtEmail'];
    


   
//BACA VARIABEL form
    $txtNamaLengkap = htmlspecialchars(stripslashes(trim($_POST['txtNamaLengkap'])));
   if ($txtNamaLengkap == "") {
   	$error_tuh = "Nama harap disi ";
   }else {

   }
	

//VALIDASI USERNAME, Tidak boleh ada yang kembar
	$sqlCek= "SELECT * FROM pelanggan WHERE username ='$txtUsername' AND email='$txtEmail'";
	$sqlQuery = mysql_query($sqlCek,$koneksidb)or die("Gagal Query".mysql_error());
	$adaCek	=mysql_num_rows($sqlQuery);
	if ($adaCek >=1) {
		$pesanError[]= "Errrrrooooorr !!!,User <b>$txtUsername</b> Sudah Ada ganti dengan nama yang Lain";
	}


# JIKA ADA PESAN ERROR DARI VALIDASI
	if (count($pesanError)>=1 ){
		echo "<div class='mssgBox'>";
		echo "<img src='../images/attention.png'> <br><hr>";
			$noPesan=0;
			foreach ($pesanError as $indeks=>$pesan_tampil) { 
			$noPesan++;
				echo "&nbsp;&nbsp; $noPesan. $pesan_tampil<br>";	
			} 
		echo "</div> <br>"; 
	}
	else {
		$subjek ="Kode Aktivasi Radja bangunan";
$kodeAktivasi= randomcode();
$Kepada = $_POST[txtUsername];
$link=
"http://radjabangunan.net84.net/?open=Aktivasi&code=$kodeAktivasi";
$pesan="Halo $_POST[txtUsername],
Terima kasih telah bergabung dengan Radja Bangunan Online. Nikmati pengalaman berbelanja online bersama kami yang aman dan nyaman serta cepat.
Anda bisa menghubungi kami apabila ada pertanyaan. Kami siap membantu Anda.
Silahkan Klik tautan ini untuk mengaktifkan akun anda. 
$link


Salam Hangat, 

Radja Bangunan

";
$from="from : herry.prasetyo@radjabangunan.net84.net";
		#script untuk menyimpan data kedalam database
		
		$kodeBaru = buatkode("pelanggan","P");
		$tanggal	=date('Y-m-d');
        mail($txtEmail, $subjek,$pesan,$from);
		$mySql ="INSERT INTO pelanggan (kd_pelanggan,nm_pelanggan,nm_belakang,kelamin,email,no_telepon,mobile,alamat,id_prov,id_kabkot,id_kec,kode_pos,username,password,status,kode_aktivasi,tgl_daftar) 
			VALUES('$kodeBaru','$txtNamaLengkap','$txtlastName','$cmbGender','$txtEmail','$txtPhone','$txtMobile','$txtAlamat','$propinsi','$kota','$kec','$txtKodepos','$txtUsername',MD5('$txtPassword'),'N','$kodeAktivasi','$tanggal')";
		$myQry = mysql_query($mySql,$koneksidb) or die("gagal simpan".mysql_error());
		if ($myQry) {
			# code...
			echo "<meta http-equiv='refresh' content='0; url=?open=SuccessRegistration'>";
		}
		exit;
	}

}
#MEMBACA VARIABLE FORM
$dataNama			=isset($_POST['txtNamaLengkap']) ? $_POST['txtNamaLengkap'] :  '';
$dataLast			= isset($_POST['txtlastName']) ? $_POST['txtlastName'] : '' ;
$dataKelamin		=isset($_POST['cmbGender']) ?  $_POST['cmbGender'] :'' ;
$dataEmail			=isset($_POST['txtEmail']) ? $_POST['txtEmail'] :'';
$dataPhone 			=isset($_POST['txtPhone']) ? $_POST['txtPhone'] :'';
$dataKelamin		=isset($_POST['cmbGender']) ? $_POST['cmbGender'] : '';
$dataAlamat			=isset($_POST['Alamat']) ? $_POST['Alamat']:'';
$dataAlamat2		=isset($_POST['txtAlamat2']) ? $_POST['txtAlamat2'] :''; 
$dataProvinsi		=isset($_POST['cmbProvinsi']) ? $_POST['cmbProvinsi'] :'';
?>
<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="utf-8">
    <title>Online Shop</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="">
    <meta name="author" content="">

    <!-- Le styles  -->
    <link href="assets/css/bootstrap.css" rel="stylesheet"/>
    <link href="assets/css/bootstrap-responsive.css" rel="stylesheet"/>
	<link href="assets/css/docs.css" rel="stylesheet"/>
	 
    <link href="style.css" rel="stylesheet"/>
	<link href="assets/js/google-code-prettify/prettify.css" rel="stylesheet"/>
	
	<!-- Less styles  
	<link rel="stylesheet/less" type="text/css" href="less/bootsshop.less">
	<script src="less.js" type="text/javascript"></script>
	 -->
	
    <!-- Le HTML5 shim, for IE6-8 support of HTML5 elements -->
    <!--[if lt IE 9]>
      <script src="http://html5shim.googlecode.com/svn/trunk/html5.js"></script>
    <![endif]-->

    <!-- Le fav and touch icons -->
    <link rel="shortcut icon" href="assets/ico/favicon.ico">
    <link rel="apple-touch-icon-precomposed" sizes="144x144" href="assets/ico/apple-touch-icon-144-precomposed.png">
    <link rel="apple-touch-icon-precomposed" sizes="114x114" href="assets/ico/apple-touch-icon-114-precomposed.png">
    <link rel="apple-touch-icon-precomposed" sizes="72x72" href="assets/ico/apple-touch-icon-72-precomposed.png">
    <link rel="apple-touch-icon-precomposed" href="assets/ico/apple-touch-icon-57-precomposed.png">
	
	<script type="text/javascript" src="jquery.js"></script>
		<script type="text/javascript">
var htmlobjek;
$(document).ready(function(){
  //apabila terjadi event onchange terhadap object <select id=propinsi>
  $("#propinsi").change(function(){
    var propinsi = $("#propinsi").val();
    $.ajax({
        url: "ambilkota.php",
        data: "propinsi="+propinsi,
        cache: false,
        success: function(msg){
            //jika data sukses diambil dari server kita tampilkan
            //di <select id=kota>
            $("#kota").html(msg);
        }
    });
  });
  $("#kota").change(function(){
    var kota = $("#kota").val();
    $.ajax({
        url: "ambilkecamatan.php",
        data: "kota="+kota,
        cache: false,
        success: function(msg){
            $("#kec").html(msg);
        }
    });
  });
});

</script>

  </head>
<body>
	<div class="span9">
    <ul class="breadcrumb">
		<li><a href="index.php">Home</a> <span class="divider">/</span></li>
		<li class="active">Buat Akun Pelanggan Baru</li>
    </ul>
	<h3> Registrasi Akun Baru </h3>
	<hr class="soft"/>
	<div class="well">
	<div class="alert alert-info">
		
		<strong>Selamat Datang</strong>  <font face="comic sans">Di Radja Bangunan Online, layanan ecommerce dari Radja Bangunan. 
Kami siap melayani Anda untuk mendapatkan pengalaman menyenangkan berbelanja online bahan bangunan dan kategori lainnya.
Untuk mempermudah proses pemesanan, Anda harus melakukan registrasi pada form di bawah ini.</font></div>
	 <div class="alert alert-block alert-error fade in">
		
		<strong>  Penting untuk diingat.</strong> <font face="comic sans">Mohon untuk mengisikan data nama, alamat dan kontak yang bisa dihubungi selengkap mungkin untuk memudahkan kami dalam proses pengiriman barang.</font>
	 
	 </div>
	<form class="form-horizontal" name="form1" method="post" action="<?php $_SERVER['PHP_SELF']; ?>" target="_self" >
		<h3>Data Personal</h3>
		<div class="control-group">
		
			<label class="control-label" for="inputFname">Nama Depan <sup>*</sup></label>
			<div class="controls">
				<div style="color:red"><?php echo $error_tuh; ?></div>
			  <input type="text" id="txtNamaLengkap"  name="txtNamaLengkap"  value="<?php echo $dataNama; ?>"   placeholder="Nama Depan" class="form-control" required >
			
		 </div>
		 </div>
            
		 <div class="control-group">
            <label class="control-label" for="inputFnameLast">Nama Belakang<sup>*</sup></label>
             <div class="controls">
                 <input type="text" id="txtlastName" name="txtlastName" value="<?php echo $dataLast; ?>" placeholder="Nama Belakang" required>
             </div>
        </div>
            
		 	
        <div class="control-group">
            <label class="control-label" for="dob">Jenis Kelamin<sup>*</sup></label>
            <div class="controls">
                <select class="span2" id="jeniskelamin" name="cmbGender" required>
                    <option value="KOSONG">-Gender-</option>
                  <?php
                  $pilihan  = array("Laki-Laki","Perempuan");
                  	foreach ($pilihan as $nilai) {
                  		if ($nilai==$dataKelamin) {
                  			$cek ="selected";
                  	}else { $cek = "";}
                  	echo "<option value='$nilai' $cek>$nilai</option>";
                  }
                  ?>
                </select>
                <?php echo isset($pesanError['cmbGender']) ? $pesanError['cmbGender'] : '';?>
            </div>
        </div>
		
		<div class="control-group">
			<label class="control-label" for="adress">Alamat Lengkap<sup>*</sup></label>
			<div class="controls">
			  <input type="text" name="txtAlamat"   id="txtAlamat"  value="<?php echo $dataAlamat; ?>" placeholder="Adress"/ required> <span>Alamat Rumah, P.O. box, Alamat Perusahaan, c/o</span>
			</div>
		</div>
		<div class="control-group">
			<label class="control-label" for="city" >Provinsi<sup>*</sup></label>
			<div class="controls">
				<select type="text" id="propinsi" name="propinsi" required>
					<option value="BLANK">-Pilih Provinsi-</option>
					<?php
						//MENGAMBIL NAMA PROVINSI YANG DI DATABASE
						$propinsi =mysql_query("SELECT * FROM prov ORDER BY nama_prov");
						while ($dataProvinsi=mysql_fetch_array($propinsi)) {
							echo "<option value=\"$dataProvinsi[id_prov]\">$dataProvinsi[nama_prov]</option>\n";
						}
					?>
				</select>
			</div>
		</div>
		<div class="control-group">
			<label class="control-label" for="state" >Kota / Kabupaten<sup>*</sup></label>
			<div class="controls">
			  <select type="text" id="kota"  name="kota">
				<option value="BLANK">-Pilih Kota/Kabupaten-</option>
				<?php
				//mengambil nama-nama provinsi yang ada di database
				$kota=mysql_query("SELECT * FROM kabkot ORDER BY nama_kabkot ");
				while ($kab=mysql_fetch_array($kota)) {
					echo "<option value=\"$kota[id_kabkot]\">$kota[nama_kabkot]</option>\n";
				}
				?>
				</select>
			</div>
		</div>
		<div class="control-group">
			<label class="control-label" for="country">Kecamatan<sup>*</sup></label>
			<div class="controls">
			  <select type="text" id="kec" name="kec" >
				<option value="BLANK">-Pilih Kecamatan-</option>
				
			</select>
			</div>
		</div>
        <div class="control-group">
            <label class="control-label" for="postcode">Kode Pos<sup>*</sup></label>
            <div class="controls">
                <input type="text" name="txtKodepos" id="postcode"  placeholder="Zip / Postal Code" required>
            </div>
        </div>
	
		<div class="control-group">
			<label class="control-label" for="phone">Telepon Rumah <sup>*</sup></label>
			<div class="controls">
			  <input type="text"  name="txtPhone" id="phone" placeholder="phone" required> <span>You must register at least one phone number</span>
			</div>
		</div>
		
		<div class="control-group">
			<label class="control-label" for="mobile">Handphone</label>
			<div class="controls">
			  <input type="text"  name="txtMobile"  id="mobile" placeholder="Mobile Phone" required />
			</div>
		</div>

        <h3>Data Login</h3>
        <div class="control-group">
        	<label class="control-label" for="inputUsername">Username<sup>*</sup></label>
        	<div class="controls">
        		<input type="text" name="txtUsername"  id="inputUsername" placeholder="username" required>
        	</div>
        </div>
        <div class="control-group">
            <label class="control-label" for="inputEmail">Email <sup>*</sup></label>
            <div class="controls">
                <input type="text" name="txtEmail" id="inputEmail"  placeholder="Email" required>
            </div>
        </div>
        <div class="control-group">
            <label class="control-label" for="inputPassword">Password <sup>*</sup></label>
            <div class="controls">
                <input type="password" name="txtPassword"  id="inputPassword" placeholder="Password" required>
            </div>
        </div>
       <div >
            <label class="control-label" for="inputPassword">&nbsp; </label>
            <div class="controls">
                &nbsp;
            </div>
        </div>
         <div>
            <label class="control-label" for="inputPassword">&nbsp; </label>
            <div class="controls">
                &nbsp;
                           </div>
        </div>
         <div >
            <label class="control-label" for="inputPassword">&nbsp;</label>
            <div class="controls">
               
            </div>
        </div>
         <div >
            <label class="control-label" for="inputPassword">&nbsp;</label>
            <div class="controls">
                &nbsp;
            </div>
        </div>
        <p><sup>*</sup>Required field	</p>
	
	<div class="control-group">
			<div class="controls">
				<input type="hidden" name="email_create" value="1">
				<input type="hidden" name="is_new_customer" value="1">
				<input class="btn btn-large" type="submit" name="btnRegister" value="Register" />
			</div>
		</div>		
	</form>
</div>

</div>
</div>

</div>
  </body>
</html>