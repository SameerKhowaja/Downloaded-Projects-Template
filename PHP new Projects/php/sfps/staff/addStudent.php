
  <div class="row-fluid">
                        <!-- block -->
 <div class="block">
 <div class="navbar navbar-inner block-header">
<div class="muted pull-left"><i class="icon-plus-sign icon-large"> Register New Student</i></div>
</div>
<div class="block-content collapse in">
                                <div class="span12">
								
								 <!--------------------form------------------->
								<form method="post">
					<div class="control-group">
                                <p> <div class="controls">
                                   <p>
                                     <input class="input focused" name="name" id="focusedInput" type="text" placeholder = "full name E.g. John Mwiti" required> 
                                   </p>
                                 </div>
                                  </div>
								  </p>
								  <div class="control-group">
                                <p> <div class="controls">
                                   <p>
                                     <input class="input focused" name="username" id="focusedInput" type="text" placeholder = "Registration number" required> 
                                   </p>
                                 </div>
                                  </div>
								  </p>
								  <div class="control-group">
                                <p> <div class="controls">
                                   <p>
                                     <input class="input focused" name="form" id="focusedInput" type="text" placeholder = "Form E.g. 4N" required> 
                                   </p>
                                 </div>
                                  </div>
								  </p>
								  <div class="control-group">
                                <p> <div class="controls">
                                   <p>
                                     <input class="input focused" name="contacts" id="focusedInput" type="text" placeholder = "mobile number E.g. 072534344" required> 
                                   </p>
                                 </div>
                                  </div>
								  </p>
								<div class="control-group">
                                <p> <div class="controls">
                                   <p>
                                     <input class="input focused" name="post_address" id="focusedInput" type="text" placeholder = "postal address E.g. 45 meru" required> 
                                   </p>
                                 </div>
                                  </div>
								  </p>		
										
										<div class="control-group">
                                <p> <div class="controls">
                                   <p>
                                     <input class="input focused" name="Postal_code" id="focusedInput" type="text" placeholder = "postal code E.g. 60602" required> 
                                   </p>
                                 </div>
                                  </div>
								  </p>
									<div class="control-group">
                                <p> <div class="controls">
                                   <p>
                                     <input class="input focused" name="Date_of_birth" id="focusedInput" type="text" placeholder = "date of birth E.g. 1992" required> 
                                   </p>
                                 </div>
                                  </div>
								  </p>
								  <div class="control-group">
                                <p> <div class="controls">
                                   <p>
                                     <input class="input focused" name="place_of_birth" id="focusedInput" type="text" placeholder = "place of birth E.g. kisumu" required> 
                                   </p>
                                 </div>
                                  </div>
								  </p>
								  <div class="control-group">
                                <p> <div class="controls">
                                   <p>
                                     <input class="input focused" name="contact_name" id="focusedInput" type="text" placeholder = "parent/Guardian E.g. Beny Alan" required> 
                                   </p>
                                 </div>
                                  </div>
								  </p>
								  <div class="control-group">
                                <p> <div class="controls">
                                   <p>
                                     <input class="input focused" name="password" id="focusedInput" type="password" placeholder = "password " required> 
                                   </p>
                                 </div>
                                  </div>
								  </p>
                                    </div>
										
                                
                                        
										<div class="control-group">
                                          <div class="controls">
 <button name="save" class="btn btn-info" id="save" data-placement="right" title="Click to Save"><i class="icon-plus-sign icon-large"> Save</i></button>
												<script type="text/javascript">
	                                            $(document).ready(function(){
	                                            $('#save').tooltip('show');
	                                            $('#save').tooltip('hide');
	                                            });
	                                            </script>
                                          </div>
                                        </div>
                                </form>
								
								</div>
                            </div>
                        </div>
                        <!-- /block -->
                  				 
<?php
if (isset($_POST['save'])){
$name = $_POST['name'];
$username = $_POST['username'];
$form = $_POST['form'];
$contacts= $_POST['contacts'];
$post_address = $_POST['post_address'];
$Postal_code = $_POST['Postal_code'];
$Date_of_birth= $_POST['Date_of_birth'];
$place_of_birth= $_POST['place_of_birth'];
$contact_name = $_POST['contact_name'];
$password = $_POST['password'];


$query = @mysql_query("select * from student where  username = '$username'  ")or die(mysql_error());
$count = mysql_num_rows($query);

if ($count > 0){ ?>
<script>
alert('Registration Number Already Allocated');
</script>
<?php
}else{
mysql_query("insert into student (username,Name,Form,password,contacts,post_address,Postal_code,Date_of_Birth,Place_of_Birth,thumbnail,contact_name) 
values('$username','$name','$form','$password','$contacts','$post_address','$Postal_code','$Date_of_birth','$place_of_birth','','$contact_name')")or die(mysql_error());

mysql_query("insert into activity_log (date,username,action) values(NOW(),'$staff_fullname','Added Student $username')")or die(mysql_error());
?>
<script>
window.location = "add_student.php";
$.jGrowl("Student Successfully added", { header: 'Student add' });
</script>
<?php
}
}
?>