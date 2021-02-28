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
                 <!---   <a href="#" class="btn btn-setting btn-round btn-default"><i
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
						<th>Customer Name</th>
						<th>Gross Weight(kg)</th>
						<th>Total Bag</th>
						<th>TD</th>
						<th>Discount(%)</th>
						<th>Shaft(%)</th>
						<th>Dust(%)</th>
						
					</tr>
					</thead>
					<tbody>
						 
                            <?php  $user_query=mysql_query("select * from buy 
							LEFT JOIN customer ON buy.customer_id = customer.id
							
							ORDER BY id DESC")or die(mysql_error());
							while($row=mysql_fetch_array($user_query)){
							$customer_id=$row['customer_id'];
							$total_bag=$row['total_bag'];
							$gross_weight=$row['gross_weight'];
							$td=$row['td'];
							$name=$row['firstname']." ".$row['lastname'];
							$discount = $row['discount'];
							$shaft = $row['shaft'];
							$dust = $row['dust'];
							?>
					<tr>
						<td><?php echo $customer_id; ?></td>
						<td><?php echo $name; ?></td>
						<td><?php echo $gross_weight; ?></td>
						<td><?php echo $total_bag; ?> </td>
						<td><?php echo $td; ?></td>
						<td><?php echo $discount; ?></td>
						<td><?php echo $shaft; ?></td>
						<td><?php echo $dust; ?></td>
					
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
