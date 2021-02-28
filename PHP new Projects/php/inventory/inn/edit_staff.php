<?php include('header.php'); 


$ID=$_GET['id'];


?>


<div>
    <ul class="breadcrumb">
        <li>
            <a href="#">Home</a>
        </li>
        <li>
            <a href="#">Edit staff</a>
        </li>
    </ul>
</div>

<div class="row">
    <div class="box col-md-12">
        <div class="box-inner">
            <div class="box-header well" data-original-title="">
                <h2><i class="glyphicon glyphicon-th-list"></i> Edit staff Details</h2>

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
						<a href="staff.php"><button class="btn btn-primary"><i class="glyphicon glyphicon-arrow-left"></i> Back</button></a>
					</div>

<?php
  $query=mysql_query("select * from staff where id='$ID'")or die(mysql_error());
$row=mysql_fetch_array($query);
  ?>					
					<form method="post" enctype="multipart/form-data" class="form-horizontal" style="margin-left:175px;">
					  <div class="form-group">
						<label for="inputEmail3" class="col-sm-3 control-label">STAFF ID</label>
						<div class="col-sm-3">
						  <input type="number" name="staff_id" value="<?php echo $row['staff_id']; ?>" class="form-control" id="inputEmail3" placeholder="staff ID.....">
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputEmail3" class="col-sm-3 control-label">NAME</label>
						<div class="col-sm-4">
						  <input type="text" name="name" value="<?php echo $row['name']; ?>" class="form-control" id="inputEmail3" placeholder="Name.....">
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">EMAIL</label>
						<div class="col-sm-4">
						  <input type="text" name="email" value="<?php echo $row['email']; ?>" class="form-control" id="inputPassword3" placeholder="email.....">
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">HOME</label>
						<div class="col-sm-4">
						<input type="text" name="home" value="<?php echo $row['home']; ?>" class="form-control"id="inputEmail3" placeholder="Home.....">
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">PHONE</label>
						<div class="col-sm-2">
						  <input type="text" name="phone" value="<?php echo $row['phone']; ?>" class="form-control" id="inputPassword3" placeholder="phone.....">
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">ACCOUNT</label>
						<div class="col-sm-2">
						  <input type="text" name="account" value="<?php echo $row['account']; ?>" class="form-control" id="inputPassword3" placeholder="ACCOUNT.....">
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">DATE</label>
						<div class="col-sm-2">
						  
							<input type="text"name="date" value="<?php echo $row['date']; ?>">
						
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">Guarantor</label>
						<div class="col-sm-2">
						  <input type="text" name="guarantor" value="<?php echo $row['guarantor']; ?>" class="form-control" id="inputPassword3" placeholder="ACCOUNT.....">
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
						$staff_id=$_POST['staff_id'];
						$name=$_POST['name'];
						$gender=$_POST['gender'];
						$email=$_POST['email'];
						$home=$_POST['home'];
						$phone=$_POST['phone'];
						$date=$_POST['date'];
						$guarantor=$_POST['guarantor'];

$history_record=mysql_query("select * from user where user_id=$id_session");
$row=mysql_fetch_array($history_record);
$user=$row['firstname']." ".$row['lastname'];
mysql_query("INSERT INTO history (date,action,data) VALUES (NOW(),'Edit staff Details','$user')")or die(mysql_error());

{
mysql_query(" UPDATE staff SET staff_id='$staff_id', name='$name', gender='$gender', email='$email', 
home='$home', phone='$phone', date='$date',guarantor='$guarantor' WHERE id = '$id' ")or die(mysql_error());
echo "<script>alert('Successfully Updated staff Info!'); window.location='staff.php'</script>";
}

}

?>
					
                <!-- End content here -->
            </div>
        </div>
    </div>
</div><!--/row-->


<?php include('footer.php'); ?>
