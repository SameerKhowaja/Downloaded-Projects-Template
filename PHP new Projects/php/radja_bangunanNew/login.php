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
<body>
<div class="row">

<div id="sidebar" class="span3"> &nbsp;</div>
		<div class="span3">

			<div class="well well-small">

			<?php
		 if (!isset($_SESSION['SES_PELANGGAN'])) {
		 	//JIKA BELUM LOGIN MAKA FORM LOGIN DITAMPILKAN

		?>
			<form class="form-horizontal loginFrm" action="?open=LoginValidasi"  method="POST">
				<div class="control-group">
				<h5>LOGIN / REGISTER</h5>
						<label><b>Username</b></label>
							<input type="text" name="txtUsername" class="span2" id="inputEmail" placeholder="Username" required>
						  </div>
						  <div class="control-group">
						  <label><b>password</b></label>
							<input type="password" name ="txtPassword"class="span2" id="inputPassword" placeholder="Password" required>
						  </div>
						  <div class="control-group">
							<label>
							<a href='?open=DataBaru'>Member Baru</a>
							</label>
							<button type="submit" class="btn pull-right" name="btnLogin" >Sign in</button>
                          </div>
 </form>
        <?php
}
else {

	//JIKA SUDAH LOGIN, MAKA MENU PELANGGAN DITAMPILKAN
 ?>

 	<h5>TRANSAKSI</h5>

                <div class="control-group">

						<label><b> <img src="images/ikon.png" width="9" height="9"> <a href="?open=KeranjangBelanja" target="_self">Keranjang Belanja</a></b></label>
						  </div>
                <div class="control-group">
							<lable><b><img src="images/ikon.png" width="9" height="9"><a href="?open=TransaksiList" target="_self"> <b>Order History</b></a></b></lable>
						  </div>
                <div class="control-group">
                		<label><b><img src="images/ikon.png" width="9" height="9">Testimoni</b></label>
                </div>

                <div class="control-group">
						<label><b><a href='login_out.php' target="_self">LogOut</a></b></label>
							&nbsp;&nbsp;
						  </div>
              <?php } ?>

    </div>

    </div>

    </div>

</body>
