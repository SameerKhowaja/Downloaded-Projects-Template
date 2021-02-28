<?php include('includes/header.php'); ?>
<?php include('includes/session.php'); ?>
<?php include('includes/navbar_books.php'); ?>
<?php $id = $_GET['id'];?>
<div class="container">
		<div class="margin-top">
			<div class="row">	
                            <div class="span12">
                                <div class="alert alert-info"><i class="icon-pencil"></i>&nbsp;Edit Books</div>
			<p><a class="btn btn-info" href="books.php"><i class="icon-arrow-left icon-large"></i>&nbsp;Back</a></p>
	<div class="addstudent">
	<div class="details">Please Enter Details Below</div>	
        <?php

$edit = mysql_query("SELECT * FROM books WHERE accession_no = '$id'") or die(mysql_error());
$book = mysql_fetch_array($edit); 
$title = $book['title'];
$author = $book['author'];
$publisher_name = $book['publisher_name'];
$status = $book['status'];
$isbn = $book['isbn_no'];
$call_no = $book['call_number'];
$section = $book['section'];
$place_publication = $book['place_publication'];
$copyright = $book['copyright_year'];
$subClass = $book['subclass_2'];
$Class = $book['subclass_1'];
?>
        <input type="hidden" name="id" id="id" class="id" value="<?php echo $id; ?>" />
<ul>
<li><label>accession number</label><span><strong><?php echo $id; ?></strong></span></li>
<li><label>Title</label><input type="text" id="title" value="<?php echo $title; ?>" /></li>
<li><label>Author</label><input type="text" id="author"  value="<?php echo $author; ?>"/></li>
<li><label>publisher Name</label><input type="text" id="publisher" value="<?php echo $publisher_name; ?>" /></li>
<li><label>copyright Year</label><input type="text" id="copyright" value="<?php echo $copyright; ?>" /></li>
<li><label>status</label>
	<select id="status">
	<optioN value = "R" <?php  if($status == 'R'){ echo "selected";}  ?>>Replacement</option> 
	<optioN value = "L" <?php  if($status == 'L'){ echo "selected";}  ?>>Lost</option> 
	<optioN value = "E" <?php  if($status == 'E'){ echo "selected";}  ?>>Existing</option> 
	</select></li>
<li><label>Section</label>
	<select id="section">
	<optioN value = "filipinina" <?php  if($section == 'filipinina'){ echo "selected";}  ?>>Filipinina</option> 
	<optioN value = "circulation" <?php  if($section == 'circulation'){ echo "selected";}  ?>>Circulation</option> 
	<optioN value = "feasibility" <?php  if($section == 'feasibility'){ echo "selected";}  ?>>Feasibility</option> 
	<optioN value = "magazine" <?php  if($section == 'magazine'){ echo "selected";}  ?>>Magazine</option> 
	<optioN value = "references" <?php  if($section == 'references'){ echo "selected";}  ?>>References</option> 
	</select></li>
<li><label>ISBN Number</label><input type="text" id="isbn" value="<?php echo $isbn; ?>" /></li>
<li><label>Class number</label><input type="text" id="call_no" value="<?php echo $call_no; ?>" /></li>

<li><label>Subject</label><input type="text" id="Class" value="<?php echo $Class; ?>" /></li>
<li><label>Sub-subject</label><textarea id="subClass" cols="50" rows="5" ><?php echo $subClass; ?></textarea></li>
<li><label>Place of Publication</label><textarea id="placePublication" cols="50" rows="5" ><?php echo $place_publication; ?></textarea></li>
</ul>
<button class="button" id="update"><span>Update</span></button>
<span><a href="books.php"><< back</a></span>
        </div>		
                            </div>
                        </div>
                </div>
                    
</div>