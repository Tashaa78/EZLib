<?php

require $_SERVER['DOCUMENT_ROOT'] . "/Web_Server/classes/System.php";

$System = new \EZLib\System;

if (isset($_GET['action'])) {
    $action = $_GET['action'];
    if ($action == "authenticate") {
        if (isset($_GET['username']) || isset($_GET['password']) || isset($_GET['hardware_id'])) {
            $username = $_GET['username'];
            $password = $_GET['password'];
            $hardware_id = $_GET['hardware_id'];

            header("content-type: application/json");
            echo $System->validateLogin("ezlib", "{$username}", "{$password}", "{$hardware_id}");
        } else {
            header("content-type: application/json");
            echo json_encode(array(
                "status" => "error",
                "reason" => "Parameter missing",
            ));
        }
    } elseif ($action == "register") {
        if (isset($_GET['username']) || isset($_GET['password']) || isset($_GET['ip_address']) || isset($_GET['hardware_id'])) {
            $username = $_GET['username'];
            $password = $_GET['password'];
            $ip_address = $_GET['ip_address'];
            $hardware_id = $_GET['hardware_id'];

            header("content-type: application/json");
            echo $System->registerUser("ezlib", "{$username}", "{$password}", "{$ip_address}", "{$hardware_id}");
        } else {
            header("content-type: application/json");
            echo json_encode(array(
                "status" => "error",
                "reason" => "Parameter missing",
            ));
        }
    } elseif ($action == "authenticateProgram") {
        if (isset($_GET['programId'])) {
            $programId = $_GET['programId'];

            header("content-type: application/json");
            echo $System->programIdExist("ezlib", "{$programId}");
        } else {
            header("content-type: application/json");
            echo json_encode(array(
                "status" => "error",
                "reason" => "Parameter missing",
            ));
        }
    } elseif ($action == "isLicensed") {
        if (isset($_GET['programId']) || isset($_GET['username'])) {
            $programId = $_GET['programId'];
            $username = $_GET['username'];

            header("content-type: application/json");
            echo $System->isLicensed("{$programId}", "{$username}");
        } else {
            header("content-type: application/json");
            echo json_encode(array(
                "status" => "error",
                "reason" => "Parameter missing",
            ));
        }
    } elseif ($action == "randomCaptcha") {
        $captcha = bin2hex(random_bytes(5));
        echo substr("{$captcha}", 0, 6);
    }
} else {
    header("content-type: application/json");
    echo json_encode(array(
        "status" => "error",
        "reason" => "Parameter missing",
    ));
}