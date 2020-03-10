<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, shrink-to-fit=no, user-scalable=0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Document</title>
    <link href="https://fonts.googleapis.com/css?family=Spartan&display=swap" rel="stylesheet">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous">
    <style>
        .complete {
            position: absolute;
            font-family: 'Spartan', sans-serif;
            top: 10px;
            left: 10px;
            border: 5px solid rgb(150, 165, 25);
            background: rgb(150, 165, 25);
            width: 60%;
            height: auto;
            color: white;
            text-emphasis: bold;
            text-align: justify;
            float: inherit;
            word-spacing: 7px;
            font-size: 50px;
        }

        .butto {
            margin-left: 10px;
            margin-top: 130px;
            width: 60%;
            font-size: 50px;
            word-spacing: 7px;
            height: 20%;
            font-family: 'Spartan', sans-serif;
        }

        @media screen and (max-width: 400px) {
            .complete {
                position: absolute;
                font-family: 'Spartan', sans-serif;
                top: 10px;
                left: 10px;
                border: 5px solid rgb(150, 165, 25);
                background: rgb(150, 165, 25);
                width: 60%;
                height: auto;
                color: white;
                text-emphasis: bold;
                text-align: justify;
                float: inherit;
                word-spacing: 7px;
                font-size: 10px;
            }

            .butto {
                margin-left: 10px;
                margin-top: 40px;
                width: 60%;
                font-size: 10px;
                height: 20%;
                font-family: 'Spartan', sans-serif;
            }
        }
    </style>
</head>

<body>
    <?php
    include 'include.php';


    $name = $_POST['name'];

    $address = $_POST['address'];

    $email = $_POST['email'];

    if (!filter_var($email, FILTER_VALIDATE_EMAIL)) {
        echo "That is not a valid email - You'll be redirected shortly";
        echo "<script>setTimeout(\"location.href = 'http://localhost/Compatability_Tester/tester.php';\",10000);</script>";
        exit();
    }

    $phone = $_POST['phone'];
    if (!filter_var($phone, FILTER_SANITIZE_NUMBER_INT ) || (strlen($phone)> 11 || strlen($phone)< 10)){
        echo "No spaces allowed in the phone number";
        echo "That is not a valid phone - You'll be redirected shortly";
        echo "<script>setTimeout(\"location.href = 'http://localhost/Compatability_Tester/tester.php';\",10000);</script>";
        exit();
    }

    try {
        $conn = new PDO("mysql:host=$servername;port=$port;dbname=$database", $username, $password);
        $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

        $sql = "INSERT INTO cancer ( name, address, email, phone) VALUES ( '$name', '$address', '$email', '$phone')";

        $conn->exec($sql);
        echo "<p class=\"complete\">New record created successfully</p>";

        echo "<script>setTimeout(\"location.href = 'http://localhost/Compatability_Tester/test_form.html';\",10000);</script>";


        "<br>";
        "<br>";
    } catch (PDOException $e) {
        echo $sql . "<br>" . $e->getMessage(); 
    }

    ?>
    <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>
</body>

</html>