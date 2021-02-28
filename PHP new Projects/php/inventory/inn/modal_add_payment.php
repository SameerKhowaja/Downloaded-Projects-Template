<button type="button" class="btn btn-primary" data-toggle="modal" data-target="#myModal1"><i class="glyphicon glyphicon-plus"></i> Add payment Data</button>

<!-- Modal -->
<div class="modal fade" id="myModal1" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
        <h4 class="modal-title" id="myModalLabel">Add Payment Data</h4>
      </div>
      <div class="modal-body">

					<form method="POST"  enctype="multipart/form-data" class="form-horizontal" style="margin-left:60px;" action="">
					  <div class="form-group">
						<label for="date" class="col-sm-3 control-label">DATE</label>
						<div class="col-sm-4">
						  <input type="date" name="date" class="form-control" id="inputEmail3" placeholder="DATE....."  required />
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">RECIPENT NAME</label>
						<div class="col-sm-7">
						  <input type="text" name="name" class="form-control" id="inputPassword3" placeholder="RECIPENT NAME....." required />
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">ACCOUNT NUMBER</label>
						<div class="col-sm-7">
						 <input type="int" name="account" class="form-control" id="inputPassword3" placeholder="ACCOUNT NUMBER....." required />
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">AMOUNT</label>
						<div class="col-sm-3">
						  <input type="text" name="amount" class="form-control" id="inputPassword3" placeholder="AMOUNT....." required />
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
							
						
						
						$name=$_POST['name'];
						$account=$_POST['account'];
						$amount=$_POST['amount'];
						$date=$_POST['date'];
						
						
						
						
$history_record=mysql_query("select * from user where user_id=$id_session");
$row=mysql_fetch_array($history_record);
$user=$row['firstname']." ".$row['lastname'];


mysql_query("INSERT INTO history(date,action,data) VALUES (NOW(),'added payment details for $name','$user')") or die(mysql_error());

						
mysql_query("INSERT INTO payment(date,name,account,amount) 
 VALUES ('$date','$name','$account','$amount')") or die(mysql_error());

						 						
						 echo "<script>alert(' successfully added!'); window.location='payment.php'</script>";
						 
						}
						?>
	  
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
      </div>
    </div>
  </div>
</div>