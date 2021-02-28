<?php
if($_SESSION['user_type'] == 'customer'){
?>
<div id="ddblueblockmenu">
	  <div class="menutitle">Customer Menu</div>
		  <ul>
			
			
			<li><a href="<?php echo WEB_ROOT; ?>view.php?mod=customer&view=makeComplain">Make Complaints</a></li>
			<li><a href="<?php echo WEB_ROOT; ?>view.php?mod=customer&view=compDetails">View Complaint Details</a></li>
			<li><a href="<?php echo $self; ?>?logOut">Logout</a></li>
		  </ul>
	  <div class="menutitle">&nbsp;</div>	  
</div>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<?php 
}else if($_SESSION['user_type'] == 'employee'){
?>
<div id="ddblueblockmenu">
	  <div class="menutitle">Staff Menu</div>
		  <ul>
			
			<li><a href="<?php echo WEB_ROOT; ?>view.php?mod=employee&view=viewComplain">View Assigned Complaints</a></li>
			<li><a href="<?php echo WEB_ROOT; ?>view.php?mod=employee&view=viewComplainClose">Close Complaints</a></li>
			<li><a href="<?php echo $self; ?>?logOut">Logout</a></li>
		  </ul>
	  <div class="menutitle">&nbsp;</div>	  
</div>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
	 
<?php 
}else if($_SESSION['user_type'] == 'admin'){
?>
<div id="ddblueblockmenu">
	  <div class="menutitle">Admin Menu</div>
		  <ul>
			
			<li><a href="<?php echo WEB_ROOT; ?>view.php?mod=admin&view=compDetails">Assign Complaints</a></li>
			<li><a href="<?php echo WEB_ROOT; ?>view.php?mod=admin&view=vDetails">View Complaints</a></li>
			<li><a href="<?php echo WEB_ROOT; ?>view.php?mod=admin&view=compCloseDetails">View Closed Complaints</a></li>
			<li><a href="<?php echo WEB_ROOT; ?>view.php?mod=admin&view=enggDetails">Staff Details</a></li>
			<li><a href="<?php echo WEB_ROOT; ?>view.php?mod=admin&view=custDetails">Customer Details</a></li>
			<li><a href="<?php echo WEB_ROOT; ?>view.php?mod=admin&view=reports">Reports</a></li>
			<li><a href="<?php echo $self; ?>?logOut">Logout</a></li>
		  </ul>
	  <div class="menutitle">&nbsp;</div>	  
</div>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<?php 
}
?>