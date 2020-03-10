<?php

     $servername = "localhost";
     $username = "root";
     $password = "usbw";
     $database = "marrow_donors"; 
     $port = 3307;
    
     $conn = new PDO("mysql:host=$servername;port=$port;dbname=$database", $username, $password); 
     $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
