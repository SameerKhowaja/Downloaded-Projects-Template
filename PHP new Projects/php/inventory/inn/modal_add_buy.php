<?php  include('include/database.php');
							$query = "select * from customer where id = $customerID LIMIT 1";
							$customer = mysql_fetch_array(mysql_query($query));
							
						?>
<button type="button" class="btn btn-primary" data-toggle="modal" data-target="#myModal1"><i class="glyphicon glyphicon-plus"></i> Add Buying Data</button>

<!-- Modal -->
<div class="modal fade" id="myModal1" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
        <h4 class="modal-title" id="myModalLabel">Add Buying Data</h4>
      </div>
      <div class="modal-body">

					<form method="POST"  enctype="multipart/form-data" class="form-horizontal" style="margin-left:60px;" action="">
					  <div class="form-group">
						<label for="customer_id" class="col-sm-3 control-label">Customer ID</label>
						<div class="col-sm-4">
						  <input type="text" name="customer_id" class="form-control" id="inputEmail3" placeholder="CUSTOMER ID....." value="<?php echo $customer['customer_id'];?>" required />
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputEmail3" class="col-sm-3 control-label">Customer Name</label>
						<div class="col-sm-7">
						
						  <input type="text" name="name" class="form-control" id="inputEmail3" value="<?php echo $customer['firstname'] .' '. $customer['lastname'];?>" placeholder="Name....." required />
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">GROSS WEIGHT</label>
						<div class="col-sm-7">
						  <input type="text" name="gross_weight" class="form-control" id="inputPassword3" placeholder="GROSS WEIGHT....." required />
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">TOTAL BAG</label>
						<div class="col-sm-7">
						 <input type="number" name="total_bag" class="form-control" id="inputPassword3" placeholder="TOTAL BAG....." required />
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">TD</label>
						<div class="col-sm-3">
						  <input type="text" name="td" class="form-control" id="inputPassword3" placeholder="TD....." required />
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">DISCOUNT</label>
						
						<div class="col-sm-4">
						  <input type="text" name="discount" class="form-control" id="inputPassword3" placeholder="DISCOUNT....." required />
						</div>
					  </div>

					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">SHAFT</label>
						<div class="col-sm-4">
						  <input type="text" name="shaft" class="form-control" id="inputPassword3" placeholder="SHAFT....." required />
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">DUST</label>
						<div class="col-sm-4">
						  <input type="text" name="dust" class="form-control" id="inputPassword3" placeholder="DUST....." required />
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">DATE</label>
						<div class="col-sm-4">
						  <input type="date" name="date" class="form-control" id="inputPassword3" placeholder="DATE....." required />
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
							
						$customer_id=$_POST['customer_id'];
						
						$gross_weight=$_POST['gross_weight'];
						$total_bag=$_POST['total_bag'];
						$td=$_POST['td'];
						$discount=$_POST['discount'];
						$shaft=$_POST['shaft'];
						$dust=$_POST['dust'];
						$date=$_POST['date'];
						
						
						
$history_record=mysql_query("select * from user where user_id=$id_session");
$row=mysql_fetch_array($history_record);
$user=$row['firstname']." ".$row['lastname'];
$customer = $customer['firstname'].' '.$customer['lastname'];

mysql_query("INSERT INTO history(date,action,data) VALUES (NOW(),'added buy details for $customer','$user')") or die(mysql_error());

						
mysql_query("INSERT INTO buy(customer_id,gross_weight,total_bag,td,discount,shaft,dust) 
 VALUES ('$customer_id','$gross_weight','$total_bag','$td','$discount','$shaft','$dust','$date')") or die(mysql_error());

						 						
						 echo "<script>alert(' successfully added!'); window.location='buy.php'</script>";
						 
						}
						?>
	  
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
      </div>
    </div>
  </div>
</div>