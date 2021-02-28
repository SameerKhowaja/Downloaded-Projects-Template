<?php include('header.php'); ?>

<?php
if(isset($_GET['cust_id']) && !empty($_GET['cust_id'])){
	$customerID = $_GET['cust_id'];
}
else{
echo "<script> window.location='buy.php?cust_id=9'</script>";
}
?>
<div>
    <ul class="breadcrumb">
        <li>
            <a href="#">Home</a>
        </li>
        <li>
            <a href="#">Buying</a>
        </li>
    </ul>
</div>

<div class="row">
    <div class="box col-md-12">
        <div class="box-inner">
            <div class="box-header well" data-original-title="">
                <h2><i class="glyphicon glyphicon-info-sign"></i> Buying</h2>

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
                    <label class="control-label" for="selectError">Customer Name</label>
                    <div class="controls">
                        <select name="id" id="selectError" data-rel="chosen" required>
				<?php
				$result =  mysql_query("select * from customer")or die(mysql_error()); 
				
				while ($row=mysql_fetch_array($result)){ ?>
                            <option value="<?php echo $row['id']; ?>" <?php if($row['id'] == $customerID) {echo 'selected';} ?>><?php echo $row['firstname']." ".$row['lastname']; ?></option>
				<?php } ?>
                        </select>
                    </div>
                </div>
				<br />
				<br />
				<br />
                <div class="control-group">
                </div>
				<div class="alert alert-info">
						<?php include ('modal_add_buy.php'); ?>
					</div>
					<table class="table table-striped table-bordered bootstrap-datatable datatable responsive">
					<thead>
					<tr>
						<th>Customer ID</th>
						<th>Gross Weight(kg)</th>
						<th>Total bag</th>
						<th>TD</th>
						<th>Discount(%)</th>
						<th>Shaft(%)</th>
						<th>Dust(%)</th>
						<th>Actions</th>
					</tr>
					</thead>
					<tbody>
						 <?php
							 $result= mysql_query("select * from buy 
							LEFT JOIN customer ON buy.customer_id = customer.id  WHERE buy.customer_id = $customerID") or die (mysql_error());
							 while ($row= mysql_fetch_array ($result) ){		
							?>
					<tr class="del<?php echo $id ?>">
							<input type="hidden" name="item_id" value="<?php echo $id; ?>">
						<td><?php echo $row['customer_id']; ?></td>
						<td><?php echo $row['gross_weight']; ?></td>
						<td><?php echo $row['total_bag']; ?></td>
						<td><?php echo  $row['td'];   ?></td>
						<td> <?php echo $row['discount']; ?></td>
						<td> <?php echo $row['shaft']; ?></td>
						<td> <?php echo $row['dust']; ?></td>
						<td class="center">
							<!--<a class="btn btn-success" href="#">
								<i class="glyphicon glyphicon-zoom-in icon-white"></i>
								View
							</a>-->
							<a class="btn btn-info" href="edit_buy.php<?php echo '?id='.$row['buy_id']; ?>">
								<i class="glyphicon glyphicon-edit icon-white"></i>
							</a>
							<a class="btn btn-danger" href="#delete<?php echo $row['buy_id'];?>" data-toggle="modal" data-target="#delete<?php echo $row['buy_id'];?>">
								<i class="glyphicon glyphicon-trash icon-white"></i>
							</a>
							<?php include( 'modal_delete_buy.php'); ?>
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
	
	 window.location = 'buy.php?cust_id='+value;
});
	

</script>		


<?php include('footer.php'); ?>
