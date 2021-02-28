<?php include('header.php'); ?>


<div>
    <ul class="breadcrumb">
        <li>
            <a href="#">Home</a>
        </li>
        <li>
            <a href="#">List of staff</a>
        </li>
    </ul>
</div>

<div class="row">
    <div class="box col-md-12">
        <div class="box-inner">
            <div class="box-header well" data-original-title="">
                <h2><i class="glyphicon glyphicon-th-list"></i> List of staff</h2>

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
			        </br>
					<table class="table table-striped table-bordered bootstrap-datatable datatable responsive">
					<thead>
					<tr>
						<th>Staff ID</th>
						<th>Name</th>
						<th>Gender</th>
						<th>Email Address</th>
						<th>Home Address</th>
						<th>Phone Number</th>
						<th>Account Number</th>
						<th>Employment Date</th>
						<th>Guarantor</th>
					</tr>
					</thead>
					<tbody>
							<?php
							$result= mysql_query("select * from staff order by id DESC ") or die (mysql_error());
							while ($row= mysql_fetch_array ($result) ){
							$id=$row['id'];
							?>
					<tr>
						
						<td><?php echo $row['staff_id']; ?></td>
						<td><?php echo $row['name']; ?></td>
						<td><?php echo $row['gender']; ?></td>
						<td><?php echo $row['email']; ?></td>
						<td><?php echo $row['home']; ?></td>
						<td><?php echo  $row['phone']; ?></td>
						<td><?php echo $row['account'];?></td>
						<td><?php echo $row['date']; ?></td>
						<td><?php echo  $row['guarantor']; ?></td>
					<!---	<td class="center">
							<a class="btn btn-success" href="#">
								<i class="glyphicon glyphicon-zoom-in icon-white"></i>
								View
							</a>
							<a class="btn btn-info" href="edit_item.php<?php // echo '?item_id='.$id; ?>">
								<i class="glyphicon glyphicon-edit icon-white"></i>
							</a>
							<a class="btn btn-danger" href="#delete<?php // echo $id;?>" data-toggle="modal" data-target="#delete<?php // echo $id;?>">
								<i class="glyphicon glyphicon-trash icon-white"></i>
							</a>
							<?php // include('modal_delete_item.php'); ?>
						</td>-->
					</tr>
							<?php } ?>
					</tbody>
					</table>
				
                <!-- end content here -->
            </div>
        </div>
    </div>
</div><!--/row-->


<?php include('footer.php'); ?>
