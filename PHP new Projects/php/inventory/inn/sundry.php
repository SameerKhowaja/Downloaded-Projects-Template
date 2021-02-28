<?php include('header.php'); ?>

<div>
    <ul class="breadcrumb">
        <li>
            <a href="#">Home</a>
        </li>
        <li>
            <a href="#">Sundry</a>
        </li>
    </ul>
</div>

<div class="row">
    <div class="box col-md-12">
        <div class="box-inner">
            <div class="box-header well" data-original-title="">
                <h2><i class="glyphicon glyphicon-info-sign"></i> Sundry</h2>

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
                
                <div class="control-group">
                </div>
				<div class="alert alert-info">
						<?php include ('modal_add_sundry.php'); ?>
					</div>
					<table class="table table-striped table-bordered bootstrap-datatable datatable responsive">
					<thead>
					<tr>
					    <th>Sundry Date</th>
						 <th>Sundry Bags</th>
						 <th>Recovery</th>
						 <th>Short Weight</th>
						 <th>Final Weight</th>
						<th>Actions</th>
					</tr>
					</thead>
					<tbody>
					<?php
							 $result= mysql_query("select * from sundry ") or die (mysql_error());
							 while ($row= mysql_fetch_array ($result) ){
							
							
									
							?>

					<tr class="del<?php echo $row['id'] ?>">
							<input type="hidden" name="item_id" value="<?php echo $row['id']; ?>">
						<td><?php echo date("M d, Y ",strtotime($row['date'])); ?></td>
						
						<td><?php echo $row['sundry_bags']; ?></td>
						<td><?php echo  $row['recovery'];   ?></td>
						<td> <?php echo $row['short_weight']; ?></td>
						<td> <?php echo $row['final_weight']; ?></td>
						<td class="center">
							<!--<a class="btn btn-success" href="#">
								<i class="glyphicon glyphicon-zoom-in icon-white"></i>
								View
							</a>-->
							<a class="btn btn-info" href="edit_sundry.php<?php echo '?id='.$row['id']; ?>">
								<i class="glyphicon glyphicon-edit icon-white"></i>
							</a>
							<a class="btn btn-danger" href="#delete<?php echo $row['id'];?>" data-toggle="modal" data-target="#delete<?php echo $row['id'];?>">
								<i class="glyphicon glyphicon-trash icon-white"></i>
							</a>
						<?php include( 'modal_delete_sundry.php'); ?>
						</td>
					</tr>
							 <?php } ?>
							
					</tbody>
					</table>
                   



				
                <!-- end content here -->
            </div>
        </div>
    </div>
</div><!--/row-->		
<script>		
$("#selectError").change(function() {
	var value = $(this).val();
	
	 window.location = 'sundry.php?cust_id='+value;
});
	

</script>		


<?php include('footer.php'); ?>
