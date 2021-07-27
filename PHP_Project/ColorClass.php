<?php
//include 'SQLconfig.php';
class ColorClass{
		public $ColorArray = array();
		public $DateArray = array();
	
	function printArrays(){
			echo "<tr>";
			echo "<td>"."Color Name"."</td>";
			echo "<td>"."Color Date"."</td>";
			
			for($i=0; $i< sizeof($this ->DateArray); $i++){
				echo "<tr>";
				echo "<td>".$this-> ColorArray[$i]."</td>";
				echo "<td>".$this-> DateArray[$i]."</td>";
				echo "</tr>";
			}
	}
	
	
	function add_to_sql(){
		include 'SQLconfig.php';
		$selectedColor = $conn->real_escape_string($_POST["color_list"]);
		$sql = "INSERT INTO `color` (`color_name`) VALUES ('$selectedColor');";
		$result = $conn->query($sql) or die($conn->error);
		Header("Location: index.php");
	}
	
	function sql_to_array($sql){
		include 'SQLconfig.php';
		$this -> ColorArray = array();
		$this -> DateArray = array();
		//$sql = "SELECT `color_name` FROM `color`;";
		$result = mysqli_query($conn, $sql);
		$resultcheck = mysqli_num_rows($result);
		if($resultcheck > 0){
			while($row = mysqli_fetch_assoc($result)){
				array_push($this -> ColorArray, $row['color_name']);
				array_push($this -> DateArray, $row['color_date']);
			}
		}
	}
	

	
	
	function most_popular(){
		$highest = 0;
		$highestname = "";
		$dict = $this-> counting_colors();
		foreach ($dict as $name => $value){
			if($value > $highest){
				$highest = $value;
				$highestname = $name;
			}
		}
		echo "Most Popular color is: ".$highestname."<br>";
	}
		
	function picked_colors(){
		$dict = $this->counting_colors();
		echo "The chosen colors are:";
		foreach ($dict as $name  => $value ){
			if($value > 0){
				echo $name.",";	
			}
		}
		echo "<br>";
	}	
		
	public function counting_colors(){
		$dict = array(
			"Red" => 0,
			"Blue" => 0,
			"Green" => 0,
			"Yellow" => 0,
			"White" => 0,
			"Black" => 0,
			"Pink" => 0,
		);
		foreach ($this -> ColorArray as $name){
			if($name == "Red")
				$dict[$name] +=1;
			if($name == "Blue")
				$dict[$name] +=1;
			if($name == "Green")
				$dict[$name] +=1;
			if($name == "Yellow")
				$dict[$name] +=1;
			if($name == "White")
				$dict[$name] +=1;
			if($name == "Black")
				$dict[$name] +=1;
			if($name == "Pink")
				$dict[$name] +=1;
		}
		return $dict;
	}
	
	function print_table(){
		
	}
}
?>