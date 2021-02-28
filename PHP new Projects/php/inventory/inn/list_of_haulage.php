<?php include('header.php'); ?>


<div>
    <ul class="breadcrumb">
        <li>
            <a href="#">Home</a>
        </li>
        <li>
            <a href="#">List of Haulage</a>
        </li>
    </ul>
</div>

<div class="row">
    <div class="box col-md-12">
        <div class="box-inner">
            <div class="box-header well" data-original-title="">
                <h2><i class="glyphicon glyphicon-th-list"></i> List of Haulage</h2>

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
						<th>Lorry Number</th>
						<th>Driver Name</th>
						<th>Total Bags Loaded</th>
						<th>Destination</th>
						<th>Escort Name</th>
						<th>Date Loaded</th>
						
					</tr>
					</thead>
					<tbody>
						 
                            <?php  $user_query=mysql_query("select * from haulage 
							
							
							ORDER BY id DESC")or die(mysql_error());
							while($row=mysql_fetch_array($user_query)){
							$lorry=$row['lorry'];
							$driver=$row['driver'];
							$loaded=$row['loaded'];
							$destination=$row['destination'];
							$escort = $row['escort'];
							$date = $row['date'];
							
							?>
					<tr>
						<td><?php echo $lorry; ?></td>
						<td><?php echo $driver; ?></td>
						<td><?php echo $loaded; ?></td>
						<td><?php echo $destination; ?> </td>
						<td><?php echo $escort; ?></td>
						<td><?php echo $date; ?></td>
						
						
						
						
					
					
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
