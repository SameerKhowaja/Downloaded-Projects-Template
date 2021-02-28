<button type="button" class="btn btn-primary" data-toggle="modal" data-target="#myModal1"><i class="glyphicon glyphicon-plus"></i> Add Customer</button>

<!-- Modal -->
<div class="modal fade" id="myModal1" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <!-- <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button> -->
        <h4 class="modal-title" id="myModalLabel">Add Customer</h4>
      </div>
      <div class="modal-body">

					<form method="post" enctype="multipart/form-data" class="form-horizontal" style="margin-left:60px;">
					  <div class="form-group">
						<label for="inputEmail3" class="col-sm-3 control-label">Customer ID</label>
						<div class="col-sm-7">
						  <input type="number" name="customer_id" class="form-control" id="inputEmail3" placeholder="Customer ID....." required />
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputEmail3" class="col-sm-3 control-label">Firstname</label>
						<div class="col-sm-7">
						  <input type="text" name="firstname" class="form-control" id="inputEmail3" placeholder="Firstname....." required />
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputEmail3" class="col-sm-3 control-label">Middlename</label>
						<div class="col-sm-7">
						  <input type="text" name="middlename" class="form-control" id="inputEmail3" placeholder="MI / Middlename....." />
						</div>
						<span style="color:red;">optional</span>
					  </div>
					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">Lastname</label>
						<div class="col-sm-7">
						  <input type="text" name="lastname" class="form-control" id="inputPassword3" placeholder="Lastname....." required />
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">Gender</label>
						<div class="col-sm-7">
						  <select class="form-control" name="gender">
						  <option value="Male">Male</option>
						  <option value="Female">Female</option>
						  </select>
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">Phone Number</label>
						<div class="col-sm-7">
						  <input type="number" name="phone" class="form-control" id="inputPassword3" placeholder="Phone....." required />
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">Home Address</label>
						<div class="col-sm-7">
						  <input type="text" name="home" class="form-control" id="inputPassword3" placeholder="Home....." required />
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">Account Number</label>
						<div class="col-sm-7">
						  <input type="number" name="account" class="form-control" id="inputPassword3" placeholder="Account....." required />
						</div>
					  </div>
					  
					  
					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label"></label>
						<div class="col-sm-7">
						  <button type="submit" name="submit" class="btn btn-primary"><i class="glyphicon glyphicon-save"></i> Submit</button>
						</div>
					  </div>
					</form>
					
						<?php 
						include('include/database.php');
						if (isset($_POST['submit'])){
							
						$customer_id=$_POST['customer_id'];
						$firstname=$_POST['firstname'];
						$middlename=$_POST['middlename'];
						$lastname=$_POST['lastname'];
						$gender=$_POST['gender'];
						$home=$_POST['home'];
						$phone=$_POST['phone'];
						$account=$_POST['account'];
						
						
$history_record=mysql_query("select * from user where user_id=$id_session");
$row=mysql_fetch_array($history_record);
$user=$row['firstname']." ".$row['lastname'];
mysql_query("INSERT INTO history (date,action,data) VALUES (NOW(),'Add Customer','$user')")or die(mysql_error());
						
						{
						mysql_query ("INSERT INTO customer (customer_id,firstname,middlename,lastname,gender,home,phone,account)
						 VALUES ('$customer_id','$firstname','$middlename','$lastname','$gender','$home','$phone','$account')")or die(mysql_error());
						}
						echo "<script>alert('Customer successfully added!'); window.location='customer.php'</script>";
						 
						}
						?>
	  
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
      </div>
    </div>
  </div>
</div>