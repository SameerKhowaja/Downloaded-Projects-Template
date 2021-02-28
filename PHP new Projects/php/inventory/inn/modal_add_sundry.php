<button type="button" class="btn btn-primary" data-toggle="modal" data-target="#myModal1"><i class="glyphicon glyphicon-plus"></i> Add Sundry Data</button>

<!-- Modal -->
<div class="modal fade" id="myModal1" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
        <h4 class="modal-title" id="myModalLabel">Add Sundry Data</h4>
      </div>
      <div class="modal-body">

					<form method="POST"  enctype="multipart/form-data" class="form-horizontal" style="margin-left:60px;" action="">
					  <div class="form-group">
						<label for="customer_id" class="col-sm-3 control-label">SUNDRY DATE</label>
						<div class="col-sm-4">
						  <input type="date" name="date" class="form-control" id="inputEmail3" placeholder="SUNDRY DATE....." value="<?php echo $customerID;?>" required />
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputEmail3" class="col-sm-3 control-label">Sundry Bags</label>
						<div class="col-sm-4">
						  <input type="number" name="sundry_bags"  class="form-control" id="inputEmail3" placeholder="SUNDRY BAGS.....">
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">RECOVERY</label>
						<div class="col-sm-7">
						  <input type="text" name="recovery" class="form-control" id="inputPassword3" placeholder="RECOVERY....." required />
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">SHORT WEIGHT</label>
						<div class="col-sm-7">
						 <input type="text" name="short_weight" class="form-control" id="inputPassword3" placeholder="SHORT WEIGHT....." required />
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">FINAL WEIGHT</label>
						<div class="col-sm-3">
						  <input type="text" name="final weight" class="form-control" id="inputPassword3" placeholder="FINAL WEIGHT....." required />
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
							
						$date=$_POST['date'];
						
						$sundry_bags=$_POST['sundry_bags'];
						$recovery=$_POST['recovery'];
						$short_weight=$_POST['short_weight'];
						$final_weight=$_POST['final_weight'];
						
						
						
						
$history_record=mysql_query("select * from user where user_id=$id_session");
$row=mysql_fetch_array($history_record);
$user=$row['firstname']." ".$row['lastname'];


mysql_query("INSERT INTO history(date,action,data) VALUES (NOW(),'added sundry details on $date','$user')") or die(mysql_error());

						
mysql_query("INSERT INTO sundry(date,sundry_bags,recovery,short_weight,final_weight)  
 VALUES('$date','$sundry_bags','$recovery','$short_weight','$final_weight')") or die(mysql_error());

						 						
						 echo "<script>alert(' successfully added!'); window.location='sundry.php'</script>";
						 
						}
						?>
	  
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
      </div>
    </div>
  </div>
</div>