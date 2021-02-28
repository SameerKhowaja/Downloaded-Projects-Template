<html>
<head>
<link href="css/style.css" rel="stylesheet" type="text/css">
<script src="http://ajax.googleapis.com/ajax/libs/jquery/1.11.0/jquery.min.js"></script>
<script type="text/javascript">
$(document).ready(function(){
	$('#feedback').load('check.php').show();
		$('#username').keyup(function(){
			$.post('check.php', { username:form1.username.value },
			function(result){
				$('#feedback').html(result).show();
		});
	});
});
</script>
</head>
<body>
<form method="get" action="check.php"  id="index">	<table>
		<tr><td>Username:</td></tr>
    	<tr><td><input type="text" name="username" id="username"></td></tr>
        <tr><td><h1 id="feedback"></h1></td></tr>
    </table>
<br><input name="Submit" type="submit" value="Submit">
</form>
</body>
</html>