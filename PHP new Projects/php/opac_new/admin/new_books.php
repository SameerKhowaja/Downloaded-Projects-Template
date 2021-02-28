<?php include('includes/header.php'); ?>
<?php include('includes/session.php'); ?>
<?php include('includes/navbar_books.php'); ?>
    <div class="container">
		<div class="margin-top">
			<div class="row">	
			<div class="span12">	
			   <div class="alert alert-info">
                                    <button type="button" class="close" data-dismiss="alert">&times;</button>
                                    <strong><i class="icon-user icon-large"></i>&nbsp;Books Table</strong>
                                </div>
						<!--  -->
								    <ul class="nav nav-pills">
										<li><a href="books.php">All</a></li>
										<li  class="active"><a href="new_books.php">New Books</a></li>
										<li><a href="lost.php">Lost Books</a></li>
										<li><a href="sub_rep.php">Subject for Replacement</a></li>
									</ul>
						<!--  -->
						<center class="title">
						<h1>New Books</h1>
						</center>
                           <table cellpadding="0" cellspacing="0" border="0" class="table table-bordered table-condensed" id="example">
	<thead>
		<tr>
			<th>Title</th>
			<th>Author</th>
			<th>Publisher Name</th>
			<th>Status</th>
			<th>ISBN</th>
			<th>Class Number</th>
			<th>Actions</th>
		</tr>
	</thead>
	<tbody>
	
<?php $sql = mysql_query("SELECT * FROM books ORDER by accession_no ASC")or die(mysql_query());
		WHILE($book=mysql_fetch_array($sql)){ 
		$id = $book['accession_no'];
		?>
		
		<tr class="gradeX del<?php echo $id; ?>" id="<?php echo $id; ?>" >
			<td><?php echo $book['title']; ?></td>
			<td><?php echo $book['author']; ?></td>
			<td><?php echo $book['publisher_name']; ?></td>
			<td><?php echo $book['status']; ?></td>
			<td><?php echo $book['isbn_no']; ?></td>
			<td><?php echo $book['call_number']; ?></td>
                        <td><a href="edit_book.php?id=<?php echo $id; ?>" class="btn btn-success"><i class="fa fa-pencil"></i>Edit</a></td>
                        <td><a rel="tooltip"  title="Delete" id="<?php echo $id; ?>" href="#delete_book<?php echo $id; ?>" data-toggle="modal"    class="btn btn-danger"><i class="icon-trash icon-large"></i></a></td>
                            <?php include('delete_book_modal.php'); ?>
                </tr>
<?php } ?>
	</tbody>
</table>
							
			
			</div>		
			</div>
		</div>
    </div>
<?php include('footer.php') ?>