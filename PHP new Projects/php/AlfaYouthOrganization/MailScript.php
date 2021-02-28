 <?php
$form = "noreply@siteezy.com";
$email = "email@yourdomain.com";
$subject = $_POST['subject'];
$message= $_POST['Message'];
mail($email,$subject,$message, "Form".$form);

print "Your Message was Successifuly Sent.Thank you for contacting us";
?>