<?php 
	session_start();
	require("header.php");
	require("checkUser.php");
?>
<script type="text/javascript">
	document.getElementById("ahome").className="active";
</script>
[<a href="../changepassword.php">Change password</a>]

<?php require("footer.php");?>