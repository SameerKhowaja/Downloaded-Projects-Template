<?php
 
if ( isset( $_REQUEST ) && !empty( $_REQUEST ) ) {
 if (
 isset( $_REQUEST['mail'], $_REQUEST['mailto'], $_REQUEST['Mailto'] ) &&
  !empty( $_REQUEST['phoneNumber'] ) &&
  !empty( $_REQUEST['carrier'] )
 ) {
  $message = wordwrap( $_REQUEST['smsMessage'], 70 );
  $to = $_REQUEST['phoneNumber'] . '@' . $_REQUEST['carrier'];
  $result = @mail( $to, '', $mailto );
  print 'Message was sent to ' . $to;
 } else {
  print 'Not all information was submitted.';
 }
}
?>
<?php
$cl_sms_serv="coraleon free sms services"
<html>
 <head>
   <meta charset="utf-8" />
   <style>
    body {
     margin: 0;
     padding: 3em 0;
     color: #fff;
     background: #0080d2;
     font-family: Georgia, Times New Roman, serif;
    }
 
    #container {
     width: 600px;
     background: #fff;
     color: #555;
     border: 3px solid #ccc;
     -webkit-border-radius: 10px;
     -moz-border-radius: 10px;
     -ms-border-radius: 10px;
     border-radius: 10px;
     border-top: 3px solid #ddd;
     padding: 1em 2em;
     margin: 0 auto;
     -webkit-box-shadow: 3px 7px 5px #000;
     -moz-box-shadow: 3px 7px 5px #000;
     -ms-box-shadow: 3px 7px 5px #000;
     box-shadow: 3px 7px 5px #000;
    }
 
    ul {
     list-style: none;
     padding: 0;
    }
 
    ul > li {
     padding: 0.12em 1em
    }
 
    label {
     display: block;
     float: left;
     width: 130px;
    }
 
    input, textarea {
     font-family: Georgia, Serif;
    }
   </style>
  </head>
  <body>
   <div id="container">
    <h1>Sending email</h1>
    <form action="" method="post">
     <ul>
      <li>
       <label for="emailto">email</label>
       <input type="email" name="mail" id="email" placeholder="@email" /></li>
      <li>
      <label for="carrier">Carrier</label>
       <input type="mailto" name="carrier" id="mailto" />
      </li>
      <li>
       <label for="Message">Message</label>
       <textarea name="Message" id="Message" cols="45" rows="15"></textarea>
      </li>
     <li><input type="submit" name="Mailto" id="Mailto" value="Mailto" /></li>
    </ul>
   </form>
  </div>
 </body>
</html>