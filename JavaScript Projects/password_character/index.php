<html>
<head>
<style>
input[type=checkbox]
{
  -ms-transform: scale(1.2); 
  -moz-transform: scale(1.2); 
  -webkit-transform: scale(1.2); 
  -o-transform: scale(1.2); 
  padding: 5px;
}

</style>
<script type="text/javascript">
function change_char(){
	
	var pass = document.getElementById("pw");
	var checkbox = document.getElementById("cb");
	
	if(pass.type == "password"){
		pass.type = "text";
		checkbox.checked = true;
	}else{
		pass.type = "password";
		checkbox.checked = false;
	}
}
</script>
<title>Show Password Character</title>
</head>
<body>
Password:</br>
<input type="password" name="password" id="pw"> </br>
<input type="checkbox" name="checkbox" id="cb" onClick="change_char();"> Show Characters
</body>
</html>