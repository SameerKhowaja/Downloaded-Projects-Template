<!DOTYPE html>
<html lang="en">
<head>
	<meta charset="utf-8">
	<title>SFMS</title>
	<link rel="stylesheet" type="text/css" href="css/style.css">
	<link rel="stylesheet" type="text/css" href="css/bootstrap.css">
	<link rel="stylesheet" type="text/css" href="css/bootstrap-responsive.css">
	<link rel="stylesheet" href="css/font-awesome.min.css">
	
	
<link rel='stylesheet' id='style-css'  href='diapo.css' type='text/css' media='all'> 
<script type='text/javascript' src='scripts/jquery.min.js'></script>
<!--[if !IE]><!--><script type='text/javascript' src='scripts/jquery.mobile-1.0rc2.customized.min.js'></script><!--<![endif]-->
<script type='text/javascript' src='scripts/jquery.easing.1.3.js'></script> 
<script type='text/javascript' src='scripts/jquery.hoverIntent.minified.js'></script> 
<script type='text/javascript' src='scripts/diapo.js'></script> 

<script>
$(function(){
	$('.pix_diapo').diapo();
});

</script>

	
	<?php include ("dbconn.php");?>
	<?php $get_id = $_GET['id']; ?>
</head>


<body>
	
	<?php include ('menu.php'); ?>
			<div class="rightcont">    <br>
		
		
			
		  <div style="margin-top:-0px;" class="searchform3">
				<?php
			$query=mysql_query("SELECT * FROM accounts where id = '$get_id'") or die (mysql_error());
			while ($r_row=mysql_fetch_array($query)){
			$r_id=$r_row['id'];
			?>
				
				<div class="topviewtab"><?php echo $r_row['Bank_Name'];?></div>
				<div class='blue'><?php echo $r_row['Account_Number'];?></div>
				

				
				<center>
							
					
		</div>
			
				<?php } ?>
			
			</div>
			</div>
				<script SRC="js/jquery.tools.min.js"></script>
<script type="text/javascript" language="javascript" src="administrator/media/js/jquery.dataTables.js"></script>
<link rel='stylesheet' id='style-css'  href='scripts/diapo.css' type='text/css' media='all' /> 
<script type='text/javascript' src='scripts/jquery.hoverIntent.minified.js'></script> 
<script type='text/javascript' src='scripts/diapo.js'></script> 
		
		
		<div id="sidebar" >
			<div class="serts">
							<form method="post" action="search.php"><br>
							<div style="font:bold 15px 'arial';">Search Here: </div>
								<input class="serts" style="padding:10px;" type="search" name="search" placeholder="Search .......">
							</form>
					</div>
					<div class="text-right" style="margin-top: -23px;">
					
					
					
					<font style=" color:darkblue; font:bold 24px 'cambria';">BANK ACCOUNTS</font><hr style="margin:8px; border-bottom:1px solid #ccc;">
							
								<?php
								$r_query = mysql_query("select * from accounts where Branch = 'Meru' ")or die(mysql_error());
								while($r_row=mysql_fetch_array($r_query)){
								$r_id = $r_row['id'];
								?>
									<div style="margin:8px;">	
									<i class="icon-book icon-large"></i> <a style ="color:#000; font-size:16px; line-height:25px;" href="accounts.php?id=<?php echo $r_id; ?>"><?php echo $r_row['Bank_Name']; ?></a><br>
									</div>
							
								<?php } ?>
								<div class="line-block"></div>
								<font style=" color:darkblue; font:bold 24px 'cambria';">MOBILE MONEY</font><hr style="margin:8px; border-bottom:1px solid #ccc;">
								<?php
								$r_query = mysql_query("select * from accounts where Branch = 'Safaricom'")or die(mysql_error());
								while($r_row=mysql_fetch_array($r_query)){
								$r_id = $r_row['id'];
								?>
									<div style="margin:8px;">
									<div class="ellipsis-text"> <i class="icon-book icon-large"></i> <a style ="color:#000; font-size:16px; line-height:25px;" href="accounts.php?id=<?php echo $r_id; ?>"><?php echo $r_row['Bank_Name']; ?></a><br>
									</div></div>
							
								<?php } ?>
					</div>
					<br><br>
						<div class="text-right"  style="margin-top: -23px;">
					
						<font style=" color:darkblue; font:bold 24px 'cambria';">NOTICE</font><hr style="margin:8px; border-bottom:1px solid #ccc;">
<?php
								$r_query = mysql_query("select * from announcement where title = 'notice'")or die(mysql_error());
								while($r_row=mysql_fetch_array($r_query)){
								$r_id = $r_row['announcement_id'];
								?>
									<div style="margin:8px;">
									<div class="ellipsis-text"> <B style ="color:#000; font-size:16px; line-height:25px;"><?php echo $r_row['content']; ?></B><br>
									</div></div>
							
								<?php } ?>
					</div>
												
		
			
							
					</div>
					
	
				
										

			</div>

		</div><!-- end content --->
		
	</div><!-- end container --->

</body>

<?php include('scripts.php'); ?>
</html>