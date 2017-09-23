<?php

require $_SERVER['DOCUMENT_ROOT'] . "/Web_Server/classes/System.php";

use \rbxWorkshop\System as System;

$System = new System();

if (isset($_POST['action'])) {
    $action = $System->prepare($_POST['action']);

    if ($action == "authenticate") {
        if (isset($_POST['username']) || isset($_POST['password']) || isset($_POST['hardware_id'])) {
            $username = $System->prepare($_POST['username']);
            $password = $System->prepare($_POST['password']);
            $hardware_id = $System->prepare($_POST['hardware_id']);

            header("content-type: application/json");
            echo $System->validateLogin("{$username}", "{$password}", "{$hardware_id}");
        } else {
            header("content-type: application/json");
            echo json_encode(array(
                "status" => "error",
                "reason" => "Parameter missing",
            ));
        }
    } elseif ($action == "register") {
        if (isset($_POST['username']) || isset($_POST['password']) || isset($_POST['ip_address']) || isset($_POST['hardware_id'])) {
            $username = $System->prepare($_POST['username']);
            $password = $System->prepare($_POST['password']);
            $ip_address = $System->prepare($_POST['ip_address']);
            $hardware_id = $System->prepare($_POST['hardware_id']);

            header("content-type: application/json");
            echo $System->registerClient("{$username}", "{$password}", "{$ip_address}", "{$hardware_id}");
        } else {
            header("content-type: application/json");
            echo json_encode(array(
                "status" => "error",
                "reason" => "Parameter missing",
            ));
        }
    } elseif ($action == "authenticateProgram") {
        if (isset($_POST['programId'])) {
            $programId = $System->prepare($_POST['programId']);

            header("content-type: application/json");
            echo $System->validateProgramId("{$programId}");
        } else {
            header("content-type: application/json");
            echo json_encode(array(
                "status" => "error",
                "reason" => "Parameter missing",
            ));
        }
    } elseif ($action == "isLicensed") {
        if (isset($_POST['programId']) || isset($_POST['username'])) {
            $programId = $System->prepare($_POST['programId']);
            $username = $System->prepare($_POST['username']);

            header("content-type: application/json");
            echo $System->isLicensed("{$programId}", "{$username}");
        } else {
            header("content-type: application/json");
            echo json_encode(array(
                "status" => "error",
                "reason" => "Parameter missing",
            ));
        }
    } elseif ($action == "checksum") {
        if (isset($_POST['dllHash'])) {
            $dllHash = $System->prepare($_POST['dllHash']);
            $validDLLHash = ""; // on official build

            if ($dllHash == $validDLLHash) {
                header("content-type: application/json");
                echo json_encode(array(
                    "status" => "success",
                    "hash" => "{$validDLLHash}",
                ));
            } else {
                header("content-type: application/json");
                echo json_encode(array(
                    "status" => "error",
                    "reason" => "Hashes do not match",
                ));
            }
        } else {
            header("content-type: application/json");
            echo json_encode(array(
                "status" => "error",
                "reason" => "Parameter missing",
            ));
        }
    } elseif ($action == "getLicense") {
        if (isset($_POST['username']) || isset($_POST['programId']))
        {
            $username = $System->prepare($_POST['username']);
            $programId = $System->prepare($_POST['programId']);

            $validProgramId = json_decode($System->validateProgramId("{$programId}"), true);

            if ($validProgramId['status'] == "success") {

                $userLicense = json_decode($System->isLicensed("{$programId}", "{$username}"), true);

                if ($userLicense['status'] == "success") {
                    if (isset($_POST['format'])) {
                        $format = $System->prepare($_POST['format']);

                        if ($format == "plaintext") {
                            echo $userLicense['license'];
                        } else {
                            header("content-type: application/json");
                            echo json_encode($userLicense);
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
                        "reason" => "User does not have a license",
                    ));
                }
            } else {
                header("content-type: application/json");
                echo json_encode(array(
                    "status" => "error",
                    "reason" => "Program ID does not exist",
                ));
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
        "reason" => "Parameter missing",
    ));
}