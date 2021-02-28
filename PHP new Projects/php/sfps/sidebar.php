		
		
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
									<div class="ellipsis-text"> <b style ="color:#000; font-size:16px; line-height:25px;"><?php echo $r_row['content']; ?></b><br>
									</div></div>
							
								<?php } ?>
					</div>
					
			
					<br>
						

									<?php include ("slide.php"); ?>	

							
					
							
							
				</div>