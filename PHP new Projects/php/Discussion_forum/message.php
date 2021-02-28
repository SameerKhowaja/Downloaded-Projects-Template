<?php 
session_start();
require("header.php");
require("checkUser.php");

$sql="SELECT * from user where user_id=$_GET[id]";

$rows=ExecuteQuery($sql);
$row = mysql_fetch_array($rows);
?>
<?php $username = urlencode("place username here");
 $password = urlencode("place password here");
 $api_id = urlencode("place api_id here");
 $to = urlencode("mobile number");
 $message = urlencode("Test Message");

 echo file_get_contents("https://api.clickatell.com/http/sendmsg"
 . "?user=$username&password=$password&api_id=$api_id&to=$to&text=$message"); ?>
<script type="text/javascript">
function check(f)
{
	if(f.tt.value=="")	
	{
		document.getElementById("a").innerHTML="Please,Enter the message";
		//alert("Please,Enter The Question");
		f.tt.focus();
		return false;
		}
		else
		return true;
	}

</script>

<form action="messageH.php" method="POST" enctype="multipart/form-data" onsubmit="return check(this)">
	<input type="hidden" name="uto" value="<?php echo $_GET['id'] ?>" />
<table>
<tr><td>To</td><td>:</td><td><?php echo $row['fullname']; ?></td></tr>
<tr><td></td><td></td><td><textarea rows="3" cols="30" name="tt" ></textarea><span id='a' style="color: red;"></span></td></tr>
<tr><td></td><td></td><td><input type="submit" value="SEND" >
  <label></label>
</td>
</tr>
</table>
<label></label>
</form>
<br/>


<?php require("footer.php")?>