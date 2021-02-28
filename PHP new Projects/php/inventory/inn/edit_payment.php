<?php include('header.php'); 


$ID=$_GET['id'];


?>


<div>
    <ul class="breadcrumb">
        <li>
            <a href="#">Home</a>
        </li>
        <li>
            <a href="#">Edit Payment</a>
        </li>
    </ul>
</div>

<div class="row">
    <div class="box col-md-12">
        <div class="box-inner">
            <div class="box-header well" data-original-title="">
                <h2><i class="glyphicon glyphicon-th-list"></i> Edit Payment Details</h2>

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
						<a href="payment.php"><button class="btn btn-primary"><i class="glyphicon glyphicon-arrow-left"></i> Back</button></a>
					</div>

<?php
  $query=mysql_query("select * from payment where id='$ID'")or die(mysql_error());
$row=mysql_fetch_array($query);
  ?>					
					<form method="post" enctype="multipart/form-data" class="form-horizontal" style="margin-left:175px;">
					  <div class="form-group">
						<label for="inputEmail3" class="col-sm-3 control-label">Date</label>
						<div class="col-sm-3">
						  <input type="date" name="date" value="<?php echo $row['date']; ?>" class="form-control" id="inputEmail3" placeholder="Date.....">
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputEmail3" class="col-sm-3 control-label">Recipient Name</label>
						<div class="col-sm-4">
						  <input type="text" name="name" value="<?php echo $row['name']; ?>" class="form-control" id="inputEmail3" placeholder="Recipient Name.....">
						</div>
					  </div>
				
					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">Account Number</label>
						<div class="col-sm-4">
						  <input type="text" name="account"  value="<?php echo $row['account']; ?>" class="form-control" id="inputPassword3" placeholder="Account Number.....">
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">Amount</label>
						<div class="col-sm-4">
						  <input type="text" name="amount" value="<?php echo $row['amount']; ?>" class="form-control" id="inputPassword3" placeholder="Amount.....">
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

						$date=$_POST['date'];
						$name=$_POST['name'];
						$account=$_POST['account'];
						$amount=$_POST['amount'];
						

$history_record=mysql_query("select * from user where user_id=$id_session");
$row=mysql_fetch_array($history_record);
$user=$row['firstname']." ".$row['lastname'];
mysql_query("INSERT INTO history (date,action,data) VALUES (NOW(),'Edit Payment Details','$user')")or die(mysql_error());

{
mysql_query(" UPDATE payment SET date='$date', name='$name', account='$account', amount='$amount'
WHERE id = '$id' ")or die(mysql_error());
echo "<script>alert('Successfully Updated Payment Info!'); window.location='payment.php'</script>";
}

}

?>
					
                <!-- End content here -->
            </div>
        </div>
    </div>
</div><!--/row-->


<?php include('footer.php'); ?>
