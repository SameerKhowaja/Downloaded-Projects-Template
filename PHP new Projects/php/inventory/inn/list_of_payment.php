<?php include('header.php'); ?>


<div>
    <ul class="breadcrumb">
        <li>
            <a href="#">Home</a>
        </li>
        <li>
            <a href="#">List of Payment</a>
        </li>
    </ul>
</div>

<div class="row">
    <div class="box col-md-12">
        <div class="box-inner">
            <div class="box-header well" data-original-title="">
                <h2><i class="glyphicon glyphicon-th-list"></i> List of Payment</h2>

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
						<th>Date</th>
						<th>Recipent Name</th>
						<th>Account Number</th>
						<th>Amount</th>
						
					</tr>
					</thead>
					<tbody>
						 
                            <?php  $user_query=mysql_query("select * from payment 
							
							
							ORDER BY id DESC")or die(mysql_error());
							while($row=mysql_fetch_array($user_query)){
							$date=$row['date'];
							$name=$row['name'];
							$account=$row['account'];
							$amount=$row['amount'];
							
							?>
					<tr>
						<td><?php echo date("M d, Y ",strtotime($row['date'])); ?></td>
						<td><?php echo $name; ?></td>
						<td><?php echo $account; ?></td>
						<td><?php echo $amount; ?> </td>
						
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
