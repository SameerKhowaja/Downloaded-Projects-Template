<?php include('header.php'); ?>
<div>
    <ul class="breadcrumb">
        <li>
            <a href="#">Home</a>
        </li>
        <li>
            <a href="#">Customer</a>
        </li>
    </ul>
</div>

<div class="row">
    <div class="box col-md-12">
        <div class="box-inner">
            <div class="box-header well" data-original-title="">
                <h2><i class="glyphicon glyphicon-user"></i> Customer Table</h2>

                <div class="box-icon">
                    
                    <a href="#" class="btn btn-minimize btn-round btn-default"><i
                            class="glyphicon glyphicon-chevron-up"></i></a>
                    <a href="#" class="btn btn-close btn-round btn-default"><i
                            class="glyphicon glyphicon-remove"></i></a>
                </div>
            </div>
            <div class="box-content">
                
				
					<div class="alert alert-info">
						<?php include ('modal_add_customer.php') ?>
					</div>
					<table class="table table-striped table-bordered bootstrap-datatable datatable responsive">
					<thead>
					<tr>
						<th>Customer ID</th>
						<th>Name</th>
						<th>Gender</th>
						<th>Home Address</th>
						<th>Phone Number</th>
						<th>Account Number</th>
						<th>Actions</th>
					</tr>
					</thead>
					<tbody>
							<?php
							$result= mysql_query("select * from customer order by id DESC ") or die (mysql_error());
							while ($row= mysql_fetch_array ($result) ){
							$id=$row['id'];
							?>
					<tr>
						<td><?php echo $row['customer_id']; ?></td>
						<td><?php echo $row['firstname']." ".$row['middlename']." ".$row['lastname']; ?></td>
						<td><?php echo $row['gender']; ?></td>
						<td><?php echo $row['home']; ?></td>
						<td><span class="label-primary label label-default"><?php echo $row['phone']; ?></span></td>
						<td><?php echo $row['account']; ?></td>
						<td class="center">
							
							<a class="btn btn-info" href="edit_customer.php<?php echo '?id='.$id; ?>">
								<i class="glyphicon glyphicon-edit icon-white"></i>
							</a>
							<?php if($user_access == 'admin') { ?>
							<a class="btn btn-danger" href="#delete<?php echo $id;?>" data-toggle="modal" data-target="#delete<?php echo $id;?>">
								<i class="glyphicon glyphicon-trash icon-white"></i>
							</a>
							<?php include('modal_delete_customer.php'); }?>
						</td>
					</tr>
							<?php } ?>
					</tbody>
					</table>
				
                
            </div>
        </div>
    </div>
</div>

    <div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel"
         aria-hidden="true">

        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">×</button>
                    <h3>Settings</h3>
                </div>
                <div class="modal-body">
                    <p>Here settings can be configured...</p>
                </div>
                <div class="modal-footer">
                    <a href="#" class="btn btn-default" data-dismiss="modal">Close</a>
                    <a href="#" class="btn btn-primary" data-dismiss="modal">Save changes</a>
                </div>
            </div>
        </div>
    </div>

<?php include('footer.php'); ?>
