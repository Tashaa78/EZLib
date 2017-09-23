<?php

require $_SERVER['DOCUMENT_ROOT'] . "/classes/System.php";

use \rbxWorkshop\System as System;

$System = new System();

if (isset($_GET['action'])) {
    $action = $System->prepare($_GET['action']);

    if ($action == "authenticate") {
        if (isset($_GET['username']) || isset($_GET['password']) || isset($_GET['hardware_id'])) {
            $username = $System->prepare($_GET['username']);
            $password = $System->prepare($_GET['password']);
            $hardware_id = $System->prepare($_GET['hardware_id']);

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
        if (isset($_GET['username']) || isset($_GET['password']) || isset($_GET['ip_address']) || isset($_GET['hardware_id'])) {
            $username = $System->prepare($_GET['username']);
            $password = $System->prepare($_GET['password']);
            $ip_address = $System->prepare($_GET['ip_address']);
            $hardware_id = $System->prepare($_GET['hardware_id']);

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
        if (isset($_GET['programId'])) {
            $programId = $System->prepare($_GET['programId']);

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
        if (isset($_GET['programId']) || isset($_GET['username'])) {
            $programId = $System->prepare($_GET['programId']);
            $username = $System->prepare($_GET['username']);

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
        if (isset($_GET['dllHash'])) {
            $dllHash = $System->prepare($_GET['dllHash']);
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
        if (isset($_GET['username']) || isset($_GET['programId']))
        {
            $username = $System->prepare($_GET['username']);
            $programId = $System->prepare($_GET['programId']);

            $validProgramId = json_decode($System->validateProgramId("{$programId}"), true);

            if ($validProgramId['status'] == "success") {

                $userLicense = json_decode($System->isLicensed("{$programId}", "{$username}"), true);

                if ($userLicense['status'] == "success") {
                    if (isset($_GET['format'])) {
                        $format = $System->prepare($_GET['format']);

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