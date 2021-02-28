<!DOCTYPE html>
<html>
<head>
<!---Written By Sanwebe Modified By Sudhanshu Pandey Resulthosting.in--->
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Advanced Ajax Php Contact Form</title>
<link href='http://fonts.googleapis.com/css?family=Rokkitt' rel='stylesheet' type='text/css'>
<script src="http://ajax.googleapis.com/ajax/libs/jquery/2.0.0/jquery.min.js"></script>
<script type="text/javascript">
$(document).ready(function() {
    $("#submit_btn").click(function() { 
       
	    var proceed = true;
        //simple validation at client's end
        //loop through each field and we simply change border color to red for invalid fields		
		$("#contact_form input[required=true], #contact_form textarea[required=true]").each(function(){
			$(this).css('border-color',''); 
			if(!$.trim($(this).val())){ //if this field is empty 
				$(this).css('border-color','red'); //change border color to red   
				proceed = false; //set do not proceed flag
			}
			//check invalid email
			var email_reg = /^([\w-\.]+@([\w-]+\.)+[\w-]{2,4})?$/; 
			if($(this).attr("type")=="email" && !email_reg.test($.trim($(this).val()))){
				$(this).css('border-color','red'); //change border color to red   
				proceed = false; //set do not proceed flag				
			}	
		});
       
        if(proceed) //everything looks good! proceed...
        {
           //data to be sent to server         
            var m_data = new FormData();    
            m_data.append( 'name', $('input[name=name]').val());
            m_data.append( 'email', $('input[name=email]').val());
            m_data.append( 'code', $('input[name=code]').val());
            m_data.append( 'mob', $('input[name=mob]').val());
            m_data.append( 'subject', $('select[name=subject]').val());
			m_data.append( 'msg', $('textarea[name=message]').val());
			m_data.append( 'file_attach', $('input[name=file_attach]')[0].files[0]);
			 
            //instead of $.post() we are using $.ajax()
            //that's because $.ajax() has more options and flexibly.
  			$.ajax({
              url: 'contact_me.php',
              data: m_data,
              processData: false,
              contentType: false,
              type: 'POST',
              dataType:'json',
              success: function(response){
                 //load json data from server and output message     
 				if(response.type == 'error'){ //load json data from server and output message     
					output = '<div class="error">'+response.text+'</div>';
				}else{
				    output = '<div class="success">'+response.text+'</div>';
				}
				$("#contact_form #contact_results").hide().html(output).slideDown();
              }
            });
			

        }
    });
    
    //reset previously set border colors and hide all message on .keyup()
    $("#contact_form  input[required=true], #contact_form textarea[required=true]").keyup(function() { 
        $(this).css('border-color',''); 
        $("#result").slideUp();
    });
});
</script>
<link href="style.css" rel="stylesheet" type="text/css" />
</head>
<!---Written By Sanwebe Modified By Sudhanshu Pandey Resulthosting.in--->
<body>
<div class="form-style" id="contact_form">
<h1 align="center">Result Hosting International :: Contact Form</h1>
    <div class="form-style-heading"><p align="center"><strong><a href="http://resulthosting.in/live-comment-system/"><img src="https://fifa16demo2015.files.wordpress.com/2015/06/download-button.png" width="150" height="52"></a></strong></p></div>
    <div id="contact_results"></div>
    <div id="contact_body">
        <label><span>Name <span class="required">*</span></span>
            <input type="text" name="name" placeholder="your full name.." id="name" class="input-field" required/>
        </label>
        <label><span>Email <span class="required">*</span></span>
            <input type="email" name="email" placeholder="your email.."  class="input-field" required/>
        </label>
        <label><span>Phone <span class="required">*</span></span>
            <input type="text" name="code" maxlength="4" placeholder="+91"  required="true" class="tel-number-field"/>&mdash;<input type="text" name="mob" maxlength="15" placeholder="7547665753"  class="tel-number-field long" required/>
        </label>
        <label><span>Attachment</span>
            <input type="file" name="file_attach" class="input-field" />
        </label>
<!---Written By Sanwebe Modified By Sudhanshu Pandey Resulthosting.in--->
            <label for="subject"><span>Regarding</span>
            <select name="subject" class="select-field">
            <option value="General Question">General Question</option>
            <option value="Advertise">Advertisement</option>
            <option value="Partnership">Partnership Oppertunity</option>
            </select>
        </label>
        <label for="field5"><span>Message <span class="required">*</span></span>
            <textarea name="message" id="message" class="textarea-field" required></textarea>
        </label>
        <label>
            <span>&nbsp;</span><input type="submit" id="submit_btn" value="Submit" />
        </label>
    </div>
</div>
<!---Written By Sanwebe Modified By Sudhanshu Pandey Resulthosting.in--->
</body>
</html>
