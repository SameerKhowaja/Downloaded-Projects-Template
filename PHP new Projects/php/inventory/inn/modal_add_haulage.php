<button type="button" class="btn btn-primary" data-toggle="modal" data-target="#myModal1"><i class="glyphicon glyphicon-plus"></i> Add Haulage Data</button>

<!-- Modal -->
<div class="modal fade" id="myModal1" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
        <h4 class="modal-title" id="myModalLabel">Add Haulage Data</h4>
      </div>
      <div class="modal-body">

					<form method="POST"  enctype="multipart/form-data" class="form-horizontal" style="margin-left:60px;" action="">
					  <div class="form-group">
						<label for="lorry_number" class="col-sm-3 control-label">LORRY NUMBER</label>
						<div class="col-sm-4">
						  <input type="text" name="lorry" class="form-control" id="inputEmail3" placeholder="LORRY NUMBER....."  required />
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">DRIVER NAME</label>
						<div class="col-sm-7">
						  <input type="text" name="driver" class="form-control" id="inputPassword3" placeholder="DRIVER NAME....." required />
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">TOTAL BAGS LOADED</label>
						<div class="col-sm-7">
						 <input type="text" name="loaded" class="form-control" id="inputPassword3" placeholder="BAGS LOADED....." required />
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">DESTINATION</label>
						<div class="col-sm-3">
						  <input type="text" name="destination" class="form-control" id="inputPassword3" placeholder="DESTINATION....." required />
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">ESCORT</label>
						
						<div class="col-sm-4">
						  <input type="text" name="escort" class="form-control" id="inputPassword3" placeholder="ESCORT....." required />
						</div>
					  </div>

					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">DATE LOADED</label>
						<div class="col-sm-4">
						  <input type="date" name="date" class="form-control" id="inputPassword3" placeholder="DATE LOADED....." required />
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
						
						if (isset($_POST['submit'])){
							
						$lorry=$_POST['lorry'];
						
						$driver=$_POST['driver'];
						$loaded=$_POST['loaded'];
						$destination=$_POST['destination'];
						$escort=$_POST['escort'];
						$date=$_POST['date'];
						
						
						
$history_record=mysql_query("select * from user where user_id=$id_session");
$row=mysql_fetch_array($history_record);
$user=$row['firstname']." ".$row['lastname'];
$customer = $customer['firstname'].' '.$customer['lastname'];

mysql_query("INSERT INTO history(date,action,data) VALUES (NOW(),'added buy details for $customer','$user')") or die(mysql_error());

						
mysql_query("INSERT INTO haulage(lorry,driver,loaded,destination,escort,date) 
 VALUES ('$lorry','$driver','$loaded','$destination','$escort','$date')") or die(mysql_error());

						 						
						 echo "<script>alert(' successfully added!'); window.location='haulage.php'</script>";
						 
						}
						?>
	  
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
      </div>
    </div>
  </div>
</div>