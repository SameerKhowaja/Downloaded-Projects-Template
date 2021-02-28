<?php include('header.php'); 


$ID=$_GET['id'];


?>


<div>
    <ul class="breadcrumb">
        <li>
            <a href="#">Home</a>
        </li>
        <li>
            <a href="#">Edit Haulage</a>
        </li>
    </ul>
</div>

<div class="row">
    <div class="box col-md-12">
        <div class="box-inner">
            <div class="box-header well" data-original-title="">
                <h2><i class="glyphicon glyphicon-th-list"></i> Edit Haulage Details</h2>

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
						<a href="haulage.php"><button class="btn btn-primary"><i class="glyphicon glyphicon-arrow-left"></i> Back</button></a>
					</div>

<?php
  $query=mysql_query("select * from haulage where id='$ID'")or die(mysql_error());
$row=mysql_fetch_array($query);
  ?>					
					<form method="post" enctype="multipart/form-data" class="form-horizontal" style="margin-left:175px;">
					  <div class="form-group">
						<label for="inputEmail3" class="col-sm-3 control-label">Lorry Number</label>
						<div class="col-sm-3">
						  <input type="number" name="lorry" value="<?php echo $row['lorry']; ?>" class="form-control" id="inputEmail3" placeholder="Lorry Number.....">
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputEmail3" class="col-sm-3 control-label">Driver Name</label>
						<div class="col-sm-4">
						  <input type="text" name="driver" value="<?php echo $row['driver']; ?>" class="form-control" id="inputEmail3" placeholder="Driver Name.....">
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputEmail3" class="col-sm-3 control-label">Total Bags Loaded</label>
						<div class="col-sm-4">
						  <input type="text" name="loaded" value="<?php echo $row['loaded']; ?>" class="form-control" id="inputEmail3" placeholder="Total Bags Loaded....." />
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">Destination</label>
						<div class="col-sm-4">
						  <input type="text" name="destination"  value="<?php echo $row['destination']; ?>" class="form-control" id="inputPassword3" placeholder="Destination.....">
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">Escort</label>
						<div class="col-sm-4">
						  <input type="text" name="escort" value="<?php echo $row['escort']; ?>" class="form-control" id="inputPassword3" placeholder="Escort.....">
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">Date Loaded</label>
						<div class="col-sm-4">
						  <input type="date" name="date" value="<?php echo $row['date']; ?>" class="form-control" id="inputPassword3" placeholder="Date Loaded.....">
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

						$lorry=$_POST['lorry'];
						$driver=$_POST['driver'];
						$loaded=$_POST['loaded'];
						$destination=$_POST['destination'];
						$escort=$_POST['escort'];
						$date=$_POST['date'];
						;

$history_record=mysql_query("select * from user where user_id=$id_session");
$row=mysql_fetch_array($history_record);
$user=$row['firstname']." ".$row['lastname'];
mysql_query("INSERT INTO history (date,action,data) VALUES (NOW(),'Edit Haulage Details','$user')")or die(mysql_error());

{
mysql_query(" UPDATE haulage SET lorry='$lorry', driver='$driver', loaded='$loaded', destination='$destination', escort='$escort', 
date='$date' WHERE id = '$id' ")or die(mysql_error());
echo "<script>alert('Successfully Updated Haulage Info!'); window.location='haulage.php'</script>";
}

}

?>
					
                <!-- End content here -->
            </div>
        </div>
    </div>
</div><!--/row-->


<?php include('footer.php'); ?>
