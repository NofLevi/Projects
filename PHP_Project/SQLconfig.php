<?php
    // Create connection to the SQL DB.
    $servername = "localhost";
    $dbusername = "root";
    $dbpassword = "";
    $dbname     = "colorsdb";
    
    //Create connection
    $conn = new mysqli($servername, $dbusername, $dbpassword, $dbname);

    //Check connection
    if ($conn->connect_error) {
        die("Connection failed: " . $conn->connect_error);
    }
?>