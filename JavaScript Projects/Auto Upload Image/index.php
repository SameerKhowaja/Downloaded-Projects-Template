<?php
include('dbcon.php');
?>
<html>
<head>
<title>Image Upload with Auto Submit</title>
</head>
<script type="text/javascript" src="js/jquery.min.js"></script>
<script type="text/javascript" src="js/jquery.form.js"></script>
<script type="text/javascript" >
 $(document).ready(function() { 
		
            $('#photoimg').live('change', function()			{ 
			           $("#preview").html('');
			    $("#preview").html('Uploading.....');
			$("#imageform").ajaxForm({
						target: '#preview'
		}).submit();
		
			});
        }); 
</script>

<style>
#upload_form{
width:300px;
margin:auto;
border:1px solid #ccc;
text-align:center;
padding:20px;
}
.preview
{
width:250px;
height:200px;
border:solid 1px #000;
padding:5px;
}
#preview
{
color:#aaa;
}
input{
border:1px solid #aaa;
padding:5px;
}
</style>
<body>
<div id="upload_form">

<h3>Image Upload Auto Submit</h3>
<form id="imageform" method="post" enctype="multipart/form-data" action='upload.php'>
<input type="file" name="photoimg" id="photoimg" />
</form>
<div id='preview'>
</div>
</div>
</body>
</html>