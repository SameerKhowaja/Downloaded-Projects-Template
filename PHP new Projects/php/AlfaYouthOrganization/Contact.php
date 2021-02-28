<?php
//set email variables
$email_to = 'Youremail@address.com';
$email_subject ='Form submission';

//set required fields
$required_fields = array ('fullname','email','comment');

//set error message
$error_messages = array(
'fullname' => 'please enter a name to proceed',
'email' =>'Please enter a valid Email address to continue.',
'comment' => 'Please enter your message to continue.');

//set form status
$form_complete = False;

//configure validation array
$validation = array();

//check for sbmittal
if (!empty($_POST))
{
	///sanitise Post array
	foreach ($_POST as $key => $value) $_POST[$key] = remove_email_injection(trim($value));
	//loop into requird fields and make sure they match our needs
	foreach ($required_fields as $field)
	{
		//the field has been submitted?
		if (!array_key_exists($field,$_POST)) array_push($validation,$field);
		
		//check there is informationin the field?
		if($_POST[$field] == '') array_push($validation, $field);
		
		//validate the email address supplied
		if($field == 'email') if (!validation_email_address($_POST[$field]))array_push($validation,$field);
	}
	//basic validation result
	if(count($validation)==0)
	{
		//prepare our content string
		$email_content = 'New Website Commment:'."\n\n";
		
		//simple email content
		foreach ($_POST as $key => $value)
		{
			if($key != 'submit') $email_content = $key . ':' .$value . "\n";
		}
		//if validation passed ok then send the email
		mail($email_to,$email_subject,$email_content);
		
		//update form switch
		$form_complete = TRUE;
	}
}
function validate_email_address($email = FALSE)
{
	return (preg_match('/^[^@\s]+@([-a-z0-9]+\,)+[a-z](2,]$/1',$email))?TRUE : FALSE;
}
function remove_email_injection($field = FALSE)
{
	return (str_ireplace(array("\r","\n","%0a","%0d","Content-Type:","bcc:","to:","cc:"),'',$field));
?>
<html>
<head>
<title>AYO|Contact us</title>
<link rel="stylesheet" type="text/css" href="css/style.css"/>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<style type="text/css">
body,td,th {
	color: #000;
}
</style>
<script type="text/javascript">
var fullnameError = '<?php echo $error_messages['fullname'];?>';
var emailError = '<?php echo  $error_messages['email'];?>';
var commentError = '<?php echo $error_messages['comment'];?>';
</script>
</head>

<header class="mainlogo">
<img src="images/header.png" class="logo" />
</header>
<header class="mainheader">
<nav align="center">
<ul>
<li> <a href="index.php"> Home</a></li>
<li><a href="Vision2020.php">Vision2020 </a></li>
<li id="phones"><a href="MicroFinance.php"> Micro-Finance</a></li>
<li><a href="Forums.php"> Forums</a></li>
<li><a href="Partnership.php"> Partnership</a></li>
<li id= "about"><a href="About Us.php"> About us</a></li>
<li id= "about"><a href="Contact Us.php"> Contact Us</a></li>
<li id= "about"><a href="Downloads.php"> Downloads</a></li>
<li><a href="UserRegistration.php">Register </a></li>
<li id= "about"><a href="Login.php">Login </a></li>
</ul>
</nav>
</header>
</div>
<div><form class="search">
<input type="text" placeholder="Search..."/>
</form></div>
<div class="body">
<body>
&nbsp;
<br>
<div class="content">
  <div class="title"><h3 align="center">Contacts</h3></div>
  <div class="formWrap">
  <div id="form">
  <?php if ($form_complete===FALSE):?>
  <form action="Contact Us.php" method="post" id="comments_form " > 
  <div class="row">
    <div class="lable">Your Name:</div><!--end of lable-->
    <div class="input">
  <input type="text" id="fullname" class="detail" name="fullname" value="<?php echo isset($_POST['fullname'])? $_POST['fullname'] : '';?>"/>  
  <?php if (in_array('fullname',$validation)):?><span class="error"><?php echo $error_messages['fullname'];?></span><?php endif;?>
  </div><!--end of class input-->
  <div class="context"> e.g. Kithinji Godfrey or Japhet Mwela  </div><!--end of context-->
   </div><!--end of row-->
  
    <div class="row">
    <div class="lable">Your Email Address: </div><!--end of lable-->
    <div class="input"></div><!--end of class input-->
    <div class="input">
    <input type="text" id="email" class="detail" name="email" value="<?php echo isset($_POST['email']) $_POST['email'] :''; ?>"/>
    <?php if (in_array('emial',$validation)):?><span class="error"><?php echo $error_messages['email'];?></span><?php endif;?>
    </div>
    <div class="context"> We will not share your Email  with anyone or spam you with messages either  </div><!--end of context-->
   </div><!--end of row-->
  
    <div class="row">
    <div class="lable">Your Message: </div><!--end of lable-->
    <div class="input">
  <textarea   class="mess" name="comment"> <?php echo isset($_POST['comment']) :'';?>
  </textarea>  
  <?php if (in_array('comment',$validation)):?><span class="error"><?php echo $error_messages['comment'];?></span><?php endif;?>
  </div><!--end of class input-->
    </div><!--end of row-->
    <div class="submit">
      <input type="submit" id="submit" value="Send Message" />
         </div>
         </form>
         <?php else: ?>
      <p>Thank you for Message!</p>
      <?php endif; ?>
  </div><!--end of form-->
  
  </div><!--end of form wrap--> 
</div><!--end of content-->
<div class="sidebarright">
<div class="title"><h3 align="center">Links</h3></div>
</div><br>
<div class="sidebarright1">
<div class="title"><h3 align="center">Links</h3></div>
</div> <br>
<div class="sidebarright2">
<div class="title"><h3 align="center">Links</h3></div>
</div><br>


</div>

<div class="footer">

<div class="contact">
<p><h3>Contacts</h3></p>
<p><h4>Mobile:020-8146838</h4></p>
<p><h4>Email:<a href="#"> alfayouthg@yahoo.com </a> </p></h4>
</div>

<div class="copyright">
<h2> &copy;Alfa Youth Organization 2015</h2><br>
<h2>Designed by | <a href="#">GBS Digitech Ltd</a></h2>
</div>
<div class="social">
<h2>Follow Us :</h2> <br>
<a href="#"><img src="images/facebook.png" height="57" /></a>
<a href="#"><img src="images/twitter.png" height="57" /></a>
<a href="#"><img src="images/linkedin.png" height="57" /></a>
<a href="#"><img src="images/youtube.png" height="57" /></a>
<a href="#"><img src="images/gmail.png" height="57" /></a>
</div>
</div>

</body>
</html>