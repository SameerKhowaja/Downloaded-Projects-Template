<?php include('header.php'); 


$ID=$_GET['id'];


?>


<div>
    <ul class="breadcrumb">
        <li>
            <a href="#">Home</a>
        </li>
        <li>
            <a href="#">Edit Buying</a>
        </li>
    </ul>
</div>

<div class="row">
    <div class="box col-md-12">
        <div class="box-inner">
            <div class="box-header well" data-original-title="">
                <h2><i class="glyphicon glyphicon-th-list"></i> Edit Buying Details</h2>

                <div class="box-icon">
                <!---    <a href="#" class="btn btn-setting btn-round btn-default"><i
                            class="glyphicon glyphicon-cog"></i></a> -->
                    <a href="#" class="btn btn-minimize btn-round btn-default"><i
                            class="glyphicon glyphicon-chevron-up"></i></a>
                    <a href="#" class="btn btn-close btn-round btn-default"><i
                            class="glyphicon glyphicon-remove"></i></a>
                </div>
            </div>
            <div class="box-content">
                <!-- Start content here -->
				
					<div class="alert alert-info">
						<a href="buy.php"><button class="btn btn-primary"><i class="glyphicon glyphicon-arrow-left"></i> Back</button></a>
					</div>

<?php
  $query=mysql_query("select * from buy where buy_id='$ID'")or die(mysql_error());
$row=mysql_fetch_array($query);
  ?>					
					<form method="post" enctype="multipart/form-data" class="form-horizontal" style="margin-left:175px;">
					  <div class="form-group">
						<label for="inputEmail3" class="col-sm-3 control-label">Customer ID</label>
						<div class="col-sm-3">
						  <input type="number" name="customer_id" value="<?php echo $row['customer_id']; ?>" class="form-control" id="inputEmail3" placeholder="Customer ID.....">
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputEmail3" class="col-sm-3 control-label">Gross Weight</label>
						<div class="col-sm-4">
						  <input type="number" name="gross_weight" value="<?php echo $row['gross_weight']; ?>" class="form-control" id="inputEmail3" placeholder="Gross Weight.....">
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputEmail3" class="col-sm-3 control-label">Total bag</label>
						<div class="col-sm-4">
						  <input type="number" name="total_bag" value="<?php echo $row['total_bag']; ?>" class="form-control" id="inputEmail3" placeholder="MI / Total Bag....." />
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">TD</label>
						<div class="col-sm-4">
						  <input type="number" name="td"  value="<?php echo $row['td']; ?>" class="form-control" id="inputPassword3" placeholder="TD.....">
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">Discount</label>
						<div class="col-sm-4">
						  <input type="number" name="discount" value="<?php echo $row['discount']; ?>" class="form-control" id="inputPassword3" placeholder="Discount.....">
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">Shaft</label>
						<div class="col-sm-4">
						  <input type="number" name="shaft" value="<?php echo $row['shaft']; ?>" class="form-control" id="inputPassword3" placeholder="Shaft.....">
						</div>
						</div>
					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">Dust</label>
						<div class="col-sm-4">
						  <input type="number" name="dust" value="<?php echo $row['dust']; ?>" class="form-control" id="inputPassword3" placeholder="Dust.....">
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label"></label>
						<div class="col-sm-7">
						  <button type="submit" name="update" class="btn btn-primary"><i class="glyphicon glyphicon-check"></i> Update</button>
						</div>
					  </div>
					</form>
							
<?php
$id =$_GET['id'];
if (isset($_POST['update'])) {

						$customer_id=$_POST['customer_id'];
						$gross_weight=$_POST['gross_weight'];
						$total_bag=$_POST['total_bag'];
						$td=$_POST['td'];
						$discount=$_POST['discount'];
						$shaft=$_POST['shaft'];
						$dust=$_POST['dust'];

$history_record=mysql_query("select * from user where user_id=$id_session");
$row=mysql_fetch_array($history_record);
$user=$row['firstname']." ".$row['lastname'];
mysql_query("INSERT INTO history (date,action,data) VALUES (NOW(),'Edit Buy Details','$user')")or die(mysql_error());

{
mysql_query(" UPDATE buy SET customer_id='$customer_id', gross_weight='$gross_weight', total_bag='$total_bag', td='$td', discount='$discount', 
shaft='$shaft', dust='$dust' WHERE buy_id = '$id' ")or die(mysql_error());
echo "<script>alert('Successfully Updated Buying Info!'); window.location='buy.php'</script>";
}

}

?>
					
                <!-- End content here -->
            </div>
        </div>
    </div>
</div><!--/row-->


<?php include('footer.php'); ?>
