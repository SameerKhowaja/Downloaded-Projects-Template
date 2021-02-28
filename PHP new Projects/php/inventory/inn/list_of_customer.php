<?php include('header.php'); ?>


<div>
    <ul class="breadcrumb">
        <li>
            <a href="#">Home</a>
        </li>
        <li>
            <a href="#">List of Customer</a>
        </li>
    </ul>
</div>

<div class="row">
    <div class="box col-md-12">
        <div class="box-inner">
            <div class="box-header well" data-original-title="">
                <h2><i class="glyphicon glyphicon-th-list"></i> List of Customer</h2>

                <div class="box-icon">
                 <!--   <a href="#" class="btn btn-setting btn-round btn-default"><i
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
					    <th>Customer ID</th>
						<th>Name</th>
						<th>Gender</th>
						<th>Home Address</th>
						<th>Phone Number</th>
						<th>Account Number</th>
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
					
							<?php include('modal_delete_customer.php'); ?>
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


<?php include('footer.php'); ?>
