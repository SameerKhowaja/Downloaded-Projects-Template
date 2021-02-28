<?php
include('dbcon.php');
$path = "uploads/";

	$valid_formats = array("jpg", "png", "gif", "bmp");
	if(isset($_POST) and $_SERVER['REQUEST_METHOD'] == "POST")
		{
			$name = $_FILES['photoimg']['name'];
			$size = $_FILES['photoimg']['size'];
			
			if(strlen($name))
				{
					list($txt, $ext) = explode(".", $name);
					if(in_array($ext,$valid_formats))
					{
					if($size<(1024*1024))
						{
							$image = time().substr(str_replace(" ", "_", $txt), 5).".".$ext;
							$tmp = $_FILES['photoimg']['tmp_name'];
							if(move_uploaded_file($tmp, $path.$image))
								{
mysql_query("insert into  tblfiles (files)values('".$image."')");

									
		echo "<img src='uploads/".$image."'  class='preview'>";
								}
							else
								echo "failed";
						}
						else
						echo '<script>alert("Image file size must not exceed 1MB!"); </script>';					
						}
						else
						echo '<script>alert("Invalid file format!"); </script>';	
				}
				
			else
				echo '<script>alert("Please select image to upload"); </script>';
				
			exit;
		}
?>