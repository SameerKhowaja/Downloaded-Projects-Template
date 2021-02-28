<?php include('header.php'); 


$ID=$_GET['id'];


?>


<div>
    <ul class="breadcrumb">
        <li>
            <a href="#">Home</a>
        </li>
        <li>
            <a href="#">Edit Customer</a>
        </li>
    </ul>
</div>

<div class="row">
    <div class="box col-md-12">
        <div class="box-inner">
            <div class="box-header well" data-original-title="">
                <h2><i class="glyphicon glyphicon-th-list"></i> Edit Customer Details</h2>

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
						<a href="customer.php"><button class="btn btn-primary"><i class="glyphicon glyphicon-arrow-left"></i> Back</button></a>
					</div>

<?php
  $query=mysql_query("select * from customer where id='$ID'")or die(mysql_error());
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
						<label for="inputEmail3" class="col-sm-3 control-label">Firstname</label>
						<div class="col-sm-4">
						  <input type="text" name="firstname" value="<?php echo $row['firstname']; ?>" class="form-control" id="inputEmail3" placeholder="Firstname.....">
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputEmail3" class="col-sm-3 control-label">Middlename</label>
						<div class="col-sm-4">
						  <input type="text" name="middlename" value="<?php echo $row['middlename']; ?>" class="form-control" id="inputEmail3" placeholder="MI / Middlename....." />
						</div>
						<span style="color:red;">optional</span>
					  </div>
					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">Lastname</label>
						<div class="col-sm-4">
						  <input type="text" name="lastname"  value="<?php echo $row['lastname']; ?>" class="form-control" id="inputPassword3" placeholder="Lastname.....">
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">Gender</label>
						<div class="col-sm-4">
						  <input type="text" name="gender" value="<?php echo $row['gender']; ?>" class="form-control" id="inputPassword3" placeholder="Gender.....">
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">Home</label>
						<div class="col-sm-4">
						  <input type="text" name="home" value="<?php echo $row['home']; ?>" class="form-control" id="inputPassword3" placeholder="Home.....">
						</div>
						</div>
					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">Phone Number</label>
						<div class="col-sm-4">
						
						  <input type="number" name="phone" value="<?php echo $row['phone']; ?>" class="form-control" id="inputPassword3" placeholder="Phone.....">
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">Account Number</label>
						<div class="col-sm-4">
						  <input type="number" name="account" value="<?php echo $row['account']; ?>" class="form-control" id="inputPassword3" placeholder="Account.....">
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
						$firstname=$_POST['firstname'];
						$middlename=$_POST['middlename'];
						$lastname=$_POST['lastname'];
						$gender=$_POST['gender'];
						$phone=$_POST['phone'];
						$home=$_POST['home'];
						$account=$_POST['account'];

$history_record=mysql_query("select * from user where user_id=$id_session");
$row=mysql_fetch_array($history_record);
$user=$row['firstname']." ".$row['lastname'];
mysql_query("INSERT INTO history (date,action,data) VALUES (NOW(),'Edit Customer Details','$user')")or die(mysql_error());

{
mysql_query(" UPDATE customer SET customer_id='$customer_id', firstname='$firstname', middlename='$middlename', lastname='$lastname', gender='$gender', 
 phone='$phone',home='$home', account='$account', WHERE id = '$id' ")or die(mysql_error());
echo "<script>alert('Successfully Updated Customer Info!'); window.location='customer.php'</script>";
}

}

?>
					
                <!-- End content here -->
            </div>
        </div>
    </div>
</div><!--/row-->


<?php include('footer.php'); ?>
