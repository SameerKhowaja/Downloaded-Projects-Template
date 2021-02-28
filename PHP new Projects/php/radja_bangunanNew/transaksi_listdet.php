<?php
#session_start();
include_once "inc.session.php";
include_once "library/inc.connection.php";
include_once "library/inc.library.php";

// Baca Kode Pelanggan yang Login
$KodePelanggan  = $_SESSION['SES_PELANGGAN'];
$NamaPelanggan  = $_SESSION['SES_USERNAME'];

// data Kode di URL harus ada
if(isset($_GET['Kode'])) {
  // Membaca Kode (No Pemesanan)
  $Kode = $_GET['Kode'];

  // Sql membaca data Pemesanan utama sesuai Kode yang dipilih
  $mySql  = "SELECT pemesanan.*, pelanggan.nm_pelanggan, kabkot.nama_kabkot, kec.nama_kec, prov.*
        FROM pemesanan
        LEFT JOIN pelanggan ON pemesanan.kd_pelanggan= pelanggan.kd_pelanggan
        LEFT JOIN prov ON pemesanan.id_prov=prov.id_prov
        LEFT JOIN kabkot ON pemesanan.id_kabkot=kabkot.id_kabkot
        LEFT JOIN kec ON pemesanan.id_kec=kec.id_kec
        WHERE pemesanan.kd_pelanggan='$KodePelanggan' AND  pemesanan.nm_pelanggan='$NamaPelanggan' AND pemesanan.no_pemesanan ='$Kode'";
  $myQry = mysql_query($mySql, $koneksidb) or die ("Gagal query");
  $myData= mysql_fetch_array($myQry);
}

?>
<!DOCTYPE html>
<html>
<head>
    <title>Cetak Lengkap transaksi Pemesanan</title>
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <meta name="description" content="">
  <meta name="author" content="">

  <!--less style -->
  <link rel="stylesheet" type="text/css" href="assets/css/bootstrap.css">
  <link rel="stylesheet" type="text/css" href="assets/css/bootstrap-responsive.css">
  <link rel="stylesheet" type="text/css" href="assets/css/docs.css">


    <link href="style.css" rel="stylesheet"/>
  <link href="assets/js/google-code-prettify/prettify.css" rel="stylesheet"/>
  <link rel="stylesheet" type="text/css" href="style/style_cetak.css">
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
</head>
<body>
 <div class="alert  alert-success span8">
        <button type="button" class="close" data-dismiss="alert">×</button>
        <strong>HISTORY BELANJA</strong>
Silakan lanjutkan transaksi pembelian barang  dengan metode pembayaran yang sudah Anda pilih
     </div>
<div>
  <img src="images/history.gif">
</div>
<div class="row-fluid">
  <div class="span9">
<table class="table table-striped table-bodered">
  <thead>
    <tr>
      <th colspan="3" align="center"><strong>Transaksi Detail</strong></th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td width="30%"><strong>No</strong></td>
      <td width="3%"><strong>:</strong></td>
      <td width="67%"><?php echo $myData['no_pemesanan']; ?></td>
    </tr>
    <tr>
      <td><strong>Tgl.Pemesanan</strong></td>
      <td><strong>:</strong></td>
      <td><?php echo IndonesiaTgl($myData['tgl_pemesanan']); ?></td>
    </tr>
    <tr>
      <td><strong>Kode Pelanggan</strong></td>
      <td><strong>:</strong></td>
      <td><?php echo $myData['kd_pelanggan']; ?></td>
    </tr>
    <tr>
      <td><b>Nama Pelanggan</b></td>
      <td><strong>:</strong></td>
      <td><?php echo $myData['nm_pelanggan']; ?></td>
    </tr>
    <tr>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
    <tr>
      <td><strong>Nama Penerima</strong></td>
      <td><strong>:</strong></td>
      <td><?php echo $myData['nm_pelanggan']; ?></td>
    </tr>
    <tr>
      <td><strong>Alamat</strong></td>
            <td><strong>:</strong></td>
            <td><?php echo $myData['alamat_lengkap'];?></td>
    </tr>
    <tr>
      <td><strong>Provinsi</strong></td>
      <td><strong>:</strong></td>
      <td><?php echo $myData['nama_prov']; ?></td>
    </tr>
    <tr>
      <td><strong>Kota/Kabupaten</strong></td>
      <td><strong>:</strong></td>
      <td><?php echo $myData['nama_kabkot']; ?></td>
    </tr>
        <tr>
            <td><strong>Kecamatan</strong></td>
            <td><strong>:</strong></td>
            <td><?php echo $myData['nama_kec']; ?></td>
        </tr>
        <tr>
            <td><strong>KodePos</strong></td>
            <td><strong>:</strong></td>
            <td><?php echo $myData['kode_pos']; ?></td>
        </tr>
        <tr>
            <td><strong>Unik Transfer</strong></td>
            <td><strong>:</strong></td>
            <td><?php echo substr($myData['no_telepon'],-2); ?></td>
        </tr>

        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>

        <tr>
            <td><strong>Status Bayar </strong></td>
            <td><strong>:</strong></td>
            <td><strong><font color="red"><?php echo $myData['status_bayar']; ?></font><sup>*</sup></strong></td>
        </tr>

        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
  </tbody>
</table>
<table class="table table-bordered" >
  <thead>
    <tr>
      <th width="23" align="center" bgcolor="#CCCCCC"><strong>No</strong></th>
      <th width="76" bgcolor="#CCCCCC"><strong>Kode</strong></th>
      <th width="324" bgcolor="#CCCCCC"><strong>Nama barang</strong></th>
      <th width="132" align="right" bgcolor="#CCCCCC"><strong>Harga (Rp)</strong></th>
      <th width="60" align="right" bgcolor="#CCCCCC"><strong>Jumlah</strong></th>
      <th width="122" align="right" bgcolor="#CCCCCC"><strong>Total (Rp)</strong></th>
    </tr>
         <?php
      // Deklarasi variabel
      $subTotal = 0;
      $totalBarang = 0;
      $totalBiayaKirim = 0;
      $totalHarga = 0;
      $totalBayar =0;
      $unik_transfer =0;

      // SQL Menampilkan data Barang yang dipesan
    $tampilSql = "SELECT barang.nm_barang, pemesanan_item.*
                FROM pemesanan, pemesanan_item
                LEFT JOIN barang ON pemesanan_item.kd_barang=barang.kd_barang
                WHERE pemesanan.no_pemesanan=pemesanan_item.no_pemesanan
                AND pemesanan.no_pemesanan='$Kode'
                ORDER BY pemesanan_item.kd_barang";
    $tampilQry = mysql_query($tampilSql, $koneksidb) or die ("Gagal SQL".mysql_error());
    $no = 0;
    while ($tampilData = mysql_fetch_array($tampilQry)) {
      $no++;
      // Menghitung subtotal harga (harga  * jumlah)
      $subTotal     = $tampilData['harga'] * $tampilData['jumlah'];

      // Menjumlah total semua harga
      $totalHarga   = $totalHarga + $subTotal;

      // Menjumlah item barang
      $totalBarang  = $totalBarang + $tampilData['jumlah'];
  ?>
  </thead>
  <tbody>
    <tr>
      <td><?php echo $no; ?></td>
      <td><strong><?php echo $tampilData['kd_barang']; ?></strong></td>
      <td><strong><?php echo $tampilData['nm_barang']; ?></strong></td>
      <td><strong>Rp. <?php echo format_angka($tampilData['harga']); ?></strong></td>
      <td><?php echo $tampilData['jumlah']; ?></td>
      <td><b>Rp. <?php echo format_angka($subTotal); ?></b></td>

    </tr>
        <?php }
//MEGNHITUNG LAGI
       
    // Total biaya Kirim = Biaya kirim x Total barang
    $totalBiayaKirim = $myData['biaya_kirim'] * $totalBarang;
    
    $totalBayar = $totalHarga + $totalBiayaKirim;  
    
    $digitHp  = substr($myData['no_telepon'],-2); // ambil 3 digit terakhir no HP
    $unik_transfer = $totalBayar + $digitHp;
        ?>
      <tr>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td align="right">&nbsp;</td>
  </tr>
  <tr>
    <td colspan="5" align="right"><strong>Total Belanja (Rp) : </strong></td>
    <td align="right">Rp. <?php echo format_angka($totalHarga); ?></td>
  </tr>
 <tr>
    <td colspan="5" align="right"><strong>Total Biaya Kirim  (Rp) : </strong></td>
    <td colspan="5" align="right">Rp. <?php echo format_angka($totalBiayaKirim); ?></td>
  </tr>
   <tr>
    <td colspan="5" align="right"><strong>GRAND TOTAL  (Rp) : </strong></td>
    <td align="right">Rp.<?php echo format_angka($totalBayar); ?></td>
  </tr>
  <tr>
    <td colspan="6" align="right" >Nominal yang harus <b>DiTRANSFER</b> adalah <font color="red"><b>Rp. <?php echo format_angka($unik_transfer); ?></b> </font></td>
  </tr>
  </tbody>
</table>
<table class="table table-bordered" border="1">
    <thead>
        <tr>
          <td colspan="3" bgcolor="#CCCCCC"><strong>No Rekening <font color="red" align="center"><b>Radja</b></font> <font color="green"><b>Bangunan<b></font></strong></td>
        </tr>
    </thead>
    <tbody>
      <tr>
            <td colspan="2" width="20%"><img src="images/BCA.gif"></td>
            <td><p><strong>  
            A/C          : 342 333 6699<br />
            A/N          : PT. RADJA BANGUNAN<br />
            CABANG       : MATRAMAN, JAKARTA</strong></p></td>
      </tr>
      <tr>
           <td colspan="2" width="20%"><img src="images/mandiri2.png"></td>
           <td><p><strong>  
            A/C          : 166 0000 4902 43<br />
            A/N          : PT. RADJA BANGUNAN<br />
            CABANG       : PONDOK KELAPA, JAKARTA</strong></p></td>
      </tr>
    </tbody>
</table>
</div>
</div>
</body>
</html>