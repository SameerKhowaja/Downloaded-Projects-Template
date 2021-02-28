<?php include('header.php'); ?>


<div>
    <ul class="breadcrumb">
        <li>
            <a href="#">Home</a>
        </li>
        <li>
            <a href="#">List of Sundry</a>
        </li>
    </ul>
</div>

<div class="row">
    <div class="box col-md-12">
        <div class="box-inner">
            <div class="box-header well" data-original-title="">
                <h2><i class="glyphicon glyphicon-th-list"></i> List of Sundry</h2>

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
						<th>Sundry Date</th>
						 <th>Sundry Bags</th>
						 <th>Recovery</th>
						 <th>Short Weight</th>
						 <th>Final Weight</th>
						
					</tr>
					</thead>
					<tbody>
						 
                            <?php  $user_query=mysql_query("select * from sundry 
							
							
							ORDER BY id DESC")or die(mysql_error());
							while($row=mysql_fetch_array($user_query)){
							$date=$row['date'];
							$sundry_bags=$row['sundry_bags'];
							$recovery=$row['recovery'];
							$short_weight=$row['short_weight'];
							$final_weight = $row['final_weight'];
							?>
					<tr>
						<td><?php echo date("M d, Y ",strtotime($row['date'])); ?></td>
						<td><?php echo $sundry_bags; ?></td>
						<td><?php echo $recovery; ?></td>
						<td><?php echo $short_weight; ?> </td>
						<td><?php echo $final_weight; ?></td>
						
						
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
