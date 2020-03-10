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
        label {
            display: block;
            text-align: center;

        }

        .submitbutton {
            display: flex;
            align-items: center;
            justify-content: center;
            text-align: center;
            margin-left: 65px;
            margin-top: 10px;
            font-family: 'Spartan', sans-serif;



        }

        .response {
            position: relative;
            font-family: 'Spartan', sans-serif;
            top: 30px;
            left: 25px;
            border: 5px solid rgb(150, 165, 25);
            background: rgb(150, 165, 25);
            width: 30%;
            height: auto;
            color: white;
            text-emphasis: bold;
            text-align: justify;
            float: inherit;
        }

        #buttons {
            height: 48em;
            display: flex;
            align-items: center;
            justify-content: center;
            margin-left: 500px;


        }

        .phone {
            visibility: hidden;
        }

        .goodwill {
            position: relative;
            font-family: 'Spartan', sans-serif;
            top: 200px;
            left: -118px;
            border: 5px solid rgb(150, 165, 25);
            background: rgb(150, 165, 25);
            width: 30%;
            height: auto;
            color: white;
            text-emphasis: bold;
            text-align: justify;
            float: inherit;
        }

        body {
            background-image: url("omaewa.jpg");
            background-position: center center;
            background-repeat: no-repeat;
            background-attachment: fixed;
            background-size: cover;
            background-color: #464646;
            font-size: 0.9vw;

        }

        .move {
            position: absolute;
            margin-top: -150px;
            margin-left: 220px
        }

        @media screen and (max-width: 400px) {
            .submitbutton {
                margin-left: 8px;
                margin-top: 8px;
            }

            #buttons {
                margin-left: 30%;
                position: absolute;
            }

            .goodwill {
                position: relative;
                font-family: 'Spartan', sans-serif;
                top: 60px;
                left: -45px;
                border: 5px solid rgb(150, 165, 25);
                background: rgb(150, 165, 25);
                width: 30%;
                height: auto;
                color: white;
                text-emphasis: bold;
                text-align: justify;
                float: inherit;
            }

            .move {
                position: absolute;
                margin-top: -50px;
                margin-left: 70px
            }

            .phone {
                position: absolute;
                visibility: visible;
                height: 50px;
                width: 40px;
                right: -50px;
            }

            .response {
                position: absolute;
                font-family: 'Spartan', sans-serif;
                top: 50px;
                left: 25px;
                border: 5px solid rgb(150, 165, 25);
                background: rgb(150, 165, 25);
                width: 30%;
                height: auto;
                color: white;
                text-emphasis: bold;
                text-align: justify;
                float: inherit;
            }


        }
    </style>
</head>

<body>
    <?php
    // include 'include.php';
    $age = $_POST['age'];
    $gender = $_POST['gender'];
    $ethnicity = $_POST['ethnicity'];
    $weight = $_POST['weight'];
    $BMI = $_POST['BMI'];
    $rarity = 0;


    if ($BMI)

        if ($age == "16ole" || $weight == "50ole" || $BMI == "40omo" || $age == "30omon") {
            echo "<p class=\"response\">You're not able to donate at this time for the following reason(s)</p>";
            if ($age == "16ole") {
                echo "<p class=\"response\">You're too young only people older than 16 and younger than 30 are allowed to join the register</p> ";
            }
            if ($weight == "50ole") {
                echo "<p class=\"response\">You do not weigh enough to donate, all people who wish to donate must be 50kg or more</p> ";
            }
            if ($BMI == "40omo") {
                echo "<p class=\"response\">Your BMI is not within a healthy enough range. Consider some life style changes before attempting to donate in the future</p>";
            }
            if ($age == "30omon") {
                echo "<p class=\"response\">You are too old to donate</p>";
            }

            echo "<script>setTimeout(\"location.href = 'http://localhost/Compatability_Tester/test_form.html';\",15000);</script>";

            exit();
        }



    if ($age == "16-30") {
        $rarity = $rarity + 5;
    }

    if ($age == "30omo") {
        $rarity = $rarity - 5;
        echo "<p class=\"response\">Since you joined the register before you turned 30 you are still eligible to donate up to the age of 60, though less likely to do so due to factors of aging and lifestyle.</p>";
    }

    if ($gender == "male") {
        $rarity = $rarity + 10;
    }

    if ($gender == "female") {
        $rarity = $rarity + 5;
    }

    if ($ethnicity != "white") {
        $rarity = $rarity + 10;
    }
    if ($ethnicity == "white") {
        $rarity = $rarity + 5;
    }




    switch (strval($rarity)) {
        case "5":
            echo "<p class=\"response\">Overall, you're most unlikely to donate due to a being older female and white.</>";
            break;
        case "10":
            echo "<p class=\"response\">Overall, you're second least likely to donate due to being older, male and white/older, female and BAME.</>";
            break;
        case "15":
            echo "<p class=\"response\">Overall, you have the third highest chance of donating due to being young, female and white/older, male and BAME.</>";
            break;
        case "20":
            echo "<p class=\"response\">Overall you have the second highest chance of donating due to being young, male and white/young, female and BAME.</>";
            break;
        case "25":
            echo "<p class=\"response\">Overall, you have the highest chance of being a donor due to being young, male and BAME.</>";
            break;
        default:
            echo "<p class=\"response\"> Something went wrong</p>";
    }

    ?>
    <div class="move">
        <p class="goodwill">If you've found out your eligible to donate, regardless of the likelyhood, why not leave your info below and we'll forward it to Anthony Nolan. Save a life today.</p>
        <div id=buttons>
            <form action="information.php" method="POST">

                <label for="name">Name:</label>
                <input type="text" name="name" required>
                <label for="name">Email:</label>
                <input type="text" name="email" required>
                <label for="name">Address:</label>
                <input type="text" name="address" required>
                <label for="name">Phone:</label>
                <input type="text" name="phone" required>

                <input class="submitbutton" type="submit" value="Submit">


            </form>


            <img class="phone" src="phone.png" alt="Anthony Nolan Phone">
        </div>
    </div>

    <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>
</body>

</html>