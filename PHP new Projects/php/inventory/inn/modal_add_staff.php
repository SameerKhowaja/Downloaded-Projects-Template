<button type="button" class="btn btn-primary" data-toggle="modal" data-target="#myModal1"><i class="glyphicon glyphicon-plus"></i> Add Staff</button>

<!-- Modal -->
<div class="modal fade" id="myModal1" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <!---<button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>-->
        <h4 class="modal-title" id="myModalLabel">Add Staff</h4>
      </div>
      <div class="modal-body">

					<form method="POST"  enctype="multipart/form-data" class="form-horizontal" style="margin-left:60px;" action="">
					  <div class="form-group">
						<label for="inputEmail3" class="col-sm-3 control-label">STAFF ID</label>
						<div class="col-sm-4">
						  <input type="text" name="staff_id" class="form-control" id="inputEmail3" placeholder="STAFF ID....." required />
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputEmail3" class="col-sm-3 control-label">NAME</label>
						<div class="col-sm-7">
						  <input type="text" name="name" class="form-control" id="inputEmail3" placeholder="Name....." required />
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">GENDER</label>
						<div class="col-sm-7">
						
						  <select name="gender" class="form-control">
						  <option value ="Male">Male</option>
						  <option value ="Female">Female</option>
						  </select>
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">EMAIL ADDRESS</label>
						<div class="col-sm-7">
						 <input type="email" name="email" class="form-control" id="inputPassword3" placeholder="EMAIL ADDRESS....." required />
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">HOME ADDRESS</label>
						<div class="col-sm-3">
						  <input type="text" name="home" class="form-control" id="inputPassword3" placeholder="HOME ADDRESS....." required />
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">PHONE NUMBER</label>
						<div class="col-sm-4">
						  <input type="number" name="phone" class="form-control" id="inputPassword3" placeholder="PHONE NUMBER....." required />
						</div>
					  </div>

					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">ACCOUNT NUMBER</label>
						<div class="col-sm-4">
						  <input type="text" name="account" class="form-control" id="inputPassword3" placeholder="ACCOUNT NUMBER....." required />
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">EMPLOYMENT DATE</label>
						<div class="col-sm-4">
						  <input type="date" name="date" class="form-control" id="inputPassword3" placeholder="EMPLOYMENT DATE....." required />
						</div>
					  </div><div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">GUARANTOR</label>
						<div class="col-sm-4">
						  <input type="text" name="guarantor" class="form-control" id="inputPassword3" placeholder="GUARANTOR....." required />
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
							
						$staff_id=$_POST['staff_id'];
						$name=$_POST['name'];
						$gender=$_POST['gender'];
						$email=$_POST['email'];
						$home=$_POST['home'];
						$phone=$_POST['phone'];
						$date=$_POST['date'];
						$guarantor=$_POST['guarantor'];
						$account = $_POST['account'];
						
						
						
$history_record=mysql_query("select * from user where user_id=$id_session");
$row=mysql_fetch_array($history_record);
$user=$row['firstname']." ".$row['lastname'];

mysql_query("INSERT INTO history(date,action,data) VALUES (NOW(),'Add staff','$user')") or die(mysql_error());

						
mysql_query("INSERT INTO staff(staff_id,name,gender,email,home,phone,account,date,guarantor) 
 VALUES ('$staff_id','$name','$gender','$email','$home','$phone','$account','$date','$guarantor')") or die(mysql_error());

						 						
						 echo "<script>alert(' successfully added!'); window.location='staff.php'</script>";
						 
						}
						?>
	  
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
      </div>
    </div>
  </div>
</div>