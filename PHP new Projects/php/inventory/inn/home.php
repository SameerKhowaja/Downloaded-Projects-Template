<?php require('header.php'); ?>
<div>
    <ul class="breadcrumb">
        <li>
            <a href="#">Home</a>
        </li>
    </ul>
</div>
<div class=" row">
    <div class="col-md-2 col-sm-2 col-xs-5" style="margin-left:25px;">
        <a data-toggle="tooltip" title="Total of Users" class="well top-block" href="user.php">
            <i class="glyphicon glyphicon-user blue"></i>
							<?php
							$result = mysql_query("SELECT * FROM user");
							$num_rows = mysql_num_rows($result);
							?>
            <div>Total Users</div>
            <div><?php echo $num_rows; ?></div>
        </a>
    </div>

    <div class="col-md-2 col-sm-2 col-xs-5" style="margin-left:25px;">
        <a data-toggle="tooltip" title="Total of Customer" class="well top-block" href="list_of_customer.php">
            <i class="glyphicon glyphicon-user"></i>
							<?php
							$result = mysql_query("SELECT * FROM customer");
							$num_rows1 = mysql_num_rows($result);
							?>
            <div>Total Customer</div>
            <div><?php echo $num_rows1; ?></div>
        </a>
    </div>

    <div class="col-md-2 col-sm-2 col-xs-5" style="margin-left:25px;">
        <a data-toggle="tooltip" title="Total of staffs" class="well top-block" href="list_of_staff.php">
            <i class="glyphicon glyphicon-user"></i>
							<?php
							$result = mysql_query("SELECT * FROM staff");
							$num_rows2 = mysql_num_rows($result);
							?>
            <div>Total Staffs</div>
            <div><?php echo $num_rows2; ?></div>
        </a>
    </div>

    <div class="col-md-2 col-sm-2 col-xs-5" style="margin-left:25px;">
        <a data-toggle="tooltip" title="Total of Buying" class="well top-block" href="list_of_buy.php">
            <i class="glyphicon glyphicon-th-list red"></i>
							<?php
							$result = mysql_query("SELECT * FROM buy");
							$num_rows3 = mysql_num_rows($result);
							?>
            <div>Total Buyings</div>
            <div><?php echo $num_rows3; ?></div>
        </a>
    </div>
	
    <div class="col-md-2 col-sm-2 col-xs-5" style="margin-left:25px;">
        <a data-toggle="tooltip" title="Analytics" class="well top-block" href="graph.php">
            <i class="glyphicon glyphicon-signal blue"></i>
							
            <div>Chart</div>
            <div><?php ?></div>
        </a>
    </div>
</div>
<?php require('footer.php'); ?>
