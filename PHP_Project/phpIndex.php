<?php
	session_start();
	include 'ColorClass.php';
	$colors = new ColorClass();
	$index = 0;
	if($_SESSION){
		$index = $_SESSION["index"];
	}
	
	if(isset($_POST["submit"])){
		$colors -> add_to_sql();
	}
	
	if(isset($_POST["defaulttable"])){
		$index = 0;
		header("Refresh:0");
	}
	
	if(isset($_POST["dailytable"])){
		$index = 1;
		header("Refresh:0");
	}
	
	if(isset($_POST["weeklytable"])){
		$index = 2;
		header("Refresh:0");
	}
	
	if(isset($_POST["betweentable"])){
		$index = 3;
		$x = "'".$_POST["from"]."'";
		$_SESSION["from"] = $x;
		$x = "'".$_POST["until"]."'";
		$_SESSION["until"] = $x;
		header("Refresh:0");
	}
	
	if(isset($_POST["specifcolor"])){
		$index = 4;
		header("Refresh:0");
	}
?>