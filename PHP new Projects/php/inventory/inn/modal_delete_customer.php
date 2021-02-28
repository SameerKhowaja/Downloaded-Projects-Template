
<div class="modal fade" id="delete<?php  echo $id;?>" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
       
        <h4 class="modal-title" id="myModalLabel">Delete Customer</h4>
      </div>
      <div class="modal-body">
			<div class="alert alert-danger">
				Are you sure you want to delete customer <span class="label-primary label label-default"><?php echo $row['firstname']." ".$row['lastname']; ?></span> ?
			</div>
			<div class="modal-footer">
			<button class="btn btn-inverse" data-dismiss="modal" aria-hidden="true"><i class="glyphicon glyphicon-remove icon-white"></i> No</button>
			<a href="delete_customer_query.php<?php echo '?id='.$id; ?>" class="btn btn-primary"><i class="glyphicon glyphicon-ok icon-white"></i> Yes</a>
			</div>
      </div>
    </div>
  </div>
</div>