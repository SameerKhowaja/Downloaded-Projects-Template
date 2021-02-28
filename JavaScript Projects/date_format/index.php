
<!doctype html>
<html lang="en">
<head>
	<meta charset="utf-8">
	<title>Format date</title>
	<script src="jquery-1.10.2.js"></script>
	<script src="jquery-ui.js"></script>
	<style>
		*
		{
			padding: 0;
			margin: 0;	
		}
		body {
			font-family: "sans-serif";
			font-size: 16px;
			background-color: #eee;
			}
		#container
		{
			width: 600px;
			height: 200px;
			margin-left: auto;
			margin-right: auto;
			background-color: #fff;
			border-radius: 3px;
		}
		.head
		{
			margin-top: 100px;
			width: inherit;
			background-color: #428bca;
			text-align: center;
			font-size: 20px;
			padding: 5px 0px;
			border-radius: 3px;
		}
		.font
		{
			font-size: 16px;
		}
		table
		{
			margin-top: 30px;
			margin-left: auto;
			margin-right: auto;
		}
	</style>
	<script>
	$(function() {
		$( "#datepicker" ).datepicker();
		$( "#format" ).change(function() {
			$( "#datepicker" ).datepicker( "option", "dateFormat", $( this ).val() );
		});
	});
	</script>
	<link rel="stylesheet" href="//code.jquery.com/ui/1.11.4/themes/smoothness/jquery-ui.css">

</head>
<body>
<div id="container">
<div class="head">
Format Date with Date Picker
</div>
<table>
	<thead>
		<tr>
			<th>Date</th>
			<th>Format Options</th>
		</tr>
	</thead>
	<tbody>
		<tr>
			<td><input type="text" id="datepicker" size="30"></td>
			<td><select id="format">
		<option value="mm/dd/yy">Default - mm/dd/yy</option>
		<option value="yy-mm-dd">ISO 8601 - yy-mm-dd</option>
		<option value="d M, y">Short - d M, y</option>
		<option value="d MM, y">Medium - d MM, y</option>
		<option value="DD, d MM, yy">Full - DD, d MM, yy</option>
		<option value="&apos;day&apos; d &apos;of&apos; MM &apos;in the year&apos; yy">With text - 'day' d 'of' MM 'in the year' yy</option>
	</select></td>
		</tr>
	</tbody>
</table>
</div>

</body>
</html>
