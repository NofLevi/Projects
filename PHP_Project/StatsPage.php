<?php include "phpIndex.php";?>
<html>
	<body>
		<form method="post">
			<a href="index.php">Add Colors Page</a></br></br>
			<input type="submit" value="Default Table" name="defaulttable">
			<input type="submit" value="Daily Table" name="dailytable"> 
			<input type="submit" value="Weekly Table" name="weeklytable">
			</br>
			<label>From:</label>
			<input type="text" name="from" id="from">
			<label>Until:</label>
			<input type="text" name="until" id="until">
			<label>[Year-Month-Day][yyyy-mm-dd]</label></br>
			<label>*From and Until fields have to be with information</label>
			<input type="submit" value="Between Table" name="betweentable">
			 
		</form>
		
		<?php 
		switch($index){
			case 0:
				$colors -> sql_to_array("SELECT * FROM `color`;");
				$colors -> most_popular();
				$colors -> picked_colors();
				$_SESSION["index"] = $index;
				break;
			case 1:
				$colors -> sql_to_array("SELECT * FROM `color` WHERE color_date = CURDATE();");
				$colors -> most_popular();
				$colors -> picked_colors();
				$_SESSION["index"] = $index;
				break;
			case 2:
				$colors -> sql_to_array("SELECT * FROM color WHERE color_date> DATE_SUB(NOW(), INTERVAL 7 DAY);");
				$colors -> most_popular();
				$colors -> picked_colors();
				$_SESSION["index"] = $index;
				break;
			default:
				$x = $_SESSION["from"];
				$y = $_SESSION["until"];
				$colors -> sql_to_array("select * from color where color_date between ".$x." AND ".$y.";");
				$colors -> most_popular();
				$colors -> picked_colors();
				$_SESSION["index"] = $index;
				break;
		}
		?> 
		
		<table align="left" border="1" cellpadding="3" cellspacing="0">
		<?php
			$colors -> printArrays();
		?>
		</table>

	</body>
</html>