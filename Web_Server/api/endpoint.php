<?php

require $_SERVER['DOCUMENT_ROOT'] . "/Web_Server/classes/System.php";

$System = new \EZLib\System;
$System->varChecks();

if (strpos($_SERVER['HTTP_USER_AGENT'], "EZLib") !== false) {
    if (isset($_GET['action']) || isset($_GET['authCode'])) {
        $action = $_GET['action'];
        $authCode = $_GET['authCode'];
        if ($authCode == $System->authCode) {
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
                if (isset($_GET['username']) || isset($_GET['programId'])) {
                    $username = $_GET['username'];
                    $programId = $_GET['programId'];

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
            } elseif ($action == "logException") {
                $programId = $_GET['programId'];
                $exceptionName = $_GET['exceptionName'];
                $exceptionMessage = $_GET['exceptionMessage'];

                header("content-type: application/json");
                echo $System->logException("{$programId}", "{$exceptionName}", "{$exceptionMessage}");
            } elseif ($action == "licenseUser") {
                $username = $_GET['username'];
                $programId = $_GET['programId'];
                $license_key = $_GET['licenseKey'];

                header("content-type: application/json");
                echo $System->licenseUser("{$username}", "{$programId}", "{$license_key}");
            } elseif ($action == "licenseInformation") {
                if (isset($_GET['programId']) || isset($_GET['username']) || isset($_GET['information'])) {
                    $programId = $_GET['programId'];
                    $username  = $_GET['username'];
                    $information = $_GET['information'];

                    if ($information == "licenseKey") {
                        $licenseInformation = json_decode($System->licenseInformation("{$programId}", "{$username}", "licenseKey"), true);
                        echo $licenseInformation['license_key'];
                    } elseif ($information == "licenseExpiration") {
                        $licenseInformation = json_decode($System->licenseInformation("{$programId}", "{$username}", "licenseExpiration"), true);
                        echo $licenseInformation['license_expiration'];
                    }
                } else {
                    header("content-type: application/json");
                    echo json_encode(array(
                        "status" => "error",
                        "reason" => "Parameter missing",
                    ));
                }
            }
        } else {
            header("content-type: application/json");
            echo json_encode(array(
                "status" => "error",
                "reason" => "Authentication code is incorrect",
            ));
        }
    } else {
        header("content-type: application/json");
        echo json_encode(array(
            "status" => "error",
            "reason" => "Parameter missing",
        ));
    }
} else {
    header("content-type: application/json");
    echo json_encode(array(
        "status" => "error",
        "reason" => "Unknown traffic",
    ));
}