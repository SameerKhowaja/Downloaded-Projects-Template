<?php include('header.php'); 


$ID=$_GET['id'];


?>


<div>
    <ul class="breadcrumb">
        <li>
            <a href="#">Home</a>
        </li>
        <li>
            <a href="#">Edit Sundry</a>
        </li>
    </ul>
</div>

<div class="row">
    <div class="box col-md-12">
        <div class="box-inner">
            <div class="box-header well" data-original-title="">
                <h2><i class="glyphicon glyphicon-th-list"></i> Edit Sundry Details</h2>
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
						<a href="sundry.php"><button class="btn btn-primary"><i class="glyphicon glyphicon-arrow-left"></i> Back</button></a>
					</div>

<?php
  $query=mysql_query("select * from sundry where id='$ID'")or die(mysql_error());
$row=mysql_fetch_array($query);
  ?>					
					<form method="post" enctype="multipart/form-data" class="form-horizontal" style="margin-left:175px;">
					  <div class="form-group">
						<label for="inputEmail3" class="col-sm-3 control-label">Sundry Date</label>
						<div class="col-sm-3">
						  <input type="date" name="date" value="<?php echo $row['date']; ?>" class="form-control" id="inputEmail3" placeholder="SUNDRY DATE.....">
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputEmail3" class="col-sm-3 control-label">Sundry Bags</label>
						<div class="col-sm-4">
						  <input type="number" name="sundry_bags" value="<?php echo $row['Sundry_bags']; ?>" class="form-control" id="inputEmail3" placeholder="SUNDRY BAGS.....">
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputEmail3" class="col-sm-3 control-label">Recovery</label>
						<div class="col-sm-4">
						  <input type="number" name="recovery" value="<?php echo $row['recovery']; ?>" class="form-control" id="inputEmail3" placeholder="RECOVERY....." />
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">Short Weight</label>
						<div class="col-sm-4">
						  <input type="number" name="short_weight" value="<?php echo $row['short_weight']; ?>" class="form-control" id="inputPassword3" placeholder="SHORT WEIGHT.....">
						</div>
					  </div>
					  <div class="form-group">
						<label for="inputPassword3" class="col-sm-3 control-label">Final Weight</label>
						<div class="col-sm-4">
						  <input type="number" name="final_weight" value="<?php echo $row['final_weight']; ?>" class="form-control" id="inputPassword3" placeholder="FINAL WEIGHT.....">
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
						$sundry_bags=$_POST['sundry_bags'];
						$recovery=$_POST['recovery'];
						$short_weight=$_POST['short_weight'];
						$final_weight=$_POST['final_weight'];

$history_record=mysql_query("select * from user where user_id=$id_session");
$row=mysql_fetch_array($history_record);
$user=$row['firstname']." ".$row['lastname'];
mysql_query("INSERT INTO history (date,action,data) VALUES (NOW(),'Edit Sundry Details','$user')")or die(mysql_error());

{
mysql_query(" UPDATE sundry SET date='$date', sundry_bags='$sundry_bags', recovery='$recovery', short_weight='$short_weight', final_weight='$final_weight'
 WHERE id = '$id' ")or die(mysql_error());
echo "<script>alert('Successfully Updated Sundry Info!'); window.location='sundry.php'</script>";
}

}

?>
					
                <!-- End content here -->
            </div>
        </div>
    </div>
</div><!--/row-->


<?php include('footer.php'); ?>
