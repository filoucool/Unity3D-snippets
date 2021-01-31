<?php
        $hostname = 'localhot';
        $username = 'yourusername';
        $password = 'yourpassword';
        $database = 'yourdatabase';
        $secretKey = "mySecretKey"; 

        try {
            $dbh = new PDO('mysql:host='. $hostname .';dbname='. $database, $username, $password);
        } catch(PDOException $e) {
            echo '<h1>error</h1><pre>', $e->getMessage() ,'</pre>';
        }
?>