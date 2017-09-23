<?php

namespace EZLib
{
    class System
    {
        private $errorReporting = false;

        // Database
        public function database()
        {
            define("DB_HOST", "localhost");
            define("DB_USER", "root");
            define("DB_PASS", "");
            define("DB_NAME", "ezlib");

            $connection = new \mysqli(DB_HOST, DB_USER, DB_PASS, DB_NAME);
            if ($connection->connect_errno) {
                exit("Failed to connect: " . $connection->connect_error);
            }
            $this->varChecks();
            return $connection;
        }

        // Other
        public function varChecks()
        {
            if ($this->errorReporting === TRUE) {
                ini_set('display_errors', 1);
                ini_set('display_startup_errors', 1);
                error_reporting(E_ALL);
            } else {
                error_reporting(0);
            }
        }
        public function prepare($parameter)
        {
            return mysqli_real_escape_string($this->database(), $parameter);
        }

        // Validation
        public function userExist($username)
        {
            $sql = "SELECT * FROM `users` WHERE `username`='$username'";

            if (mysqli_num_rows($this->database()->query($sql)) == 1) {
                return true;
            } else {
                return false;
            }
        }
        public function validateProgramId($programId)
        {
            $sql = "SELECT * FROM `program_ids` WHERE `program_token`='$programId'";

            if (mysqli_num_rows($this->database()->query($sql)) == 1) {
                $array = mysqli_fetch_array($this->database()->query($sql));

                return json_encode(array(
                    "status" => "success",
                    "programName" => "{$array['program_name']}",
                ));
            } else {
                return json_encode(array(
                    "status" => "error",
                    "reason" => "Program ID does not exist",
                ));
            }
        }
        public function isLicensed($programId, $username)
        {
            $sql = "SELECT * FROM `program_licenses` WHERE `program_id`='$programId' AND `license_holder`='$username'";
            $programExist = json_decode($this->validateProgramId("{$programId}"), true);

            if ($programExist['status'] == "success") {
                if (mysqli_num_rows($this->database()->query($sql)) == 1) {
                    $array = mysqli_fetch_array($this->database()->query($sql));
                    $today = date("M d Y");
                    $todayDate = new \DateTime("{$today}");
                    $expiryDate = new \DateTime("{$array['license_expires']}");

                    if ($array['license_active'] == 1 || "1") {
                        if ($todayDate >= $expiryDate) {
                            return json_encode(array(
                                "status" => "error",
                                "reason" => "License expired",
                            ));
                        } else {
                            return json_encode(array(
                                "status" => "success",
                                "license" => "{$array['program_license']}",
                            ));
                        }
                    } else {
                        return json_encode(array(
                            "status" => "error",
                            "reason" => "License is banned",
                        ));
                    }
                } else {
                    return json_encode(array(
                        "status" => "error",
                        "reason" => "User does not have a license",
                    ));
                }
            } else {
                return json_encode(array(
                    "status" => "error",
                    "reason" => "Program ID does not exist",
                ));
            }
        }

        // User
        public function validateLogin($username, $password, $hardware_id)
        {
            $sql = "SELECT * FROM `users` WHERE `username`='$username'";

            if ($this->userExist($username)) {
                $array = mysqli_fetch_array($this->database()->query($sql));

                if (password_verify("{$password}", "{$array['password']}")) {
                    if ($array['hardware_id'] == $hardware_id) {
                        return json_encode(array(
                            "status" => "success",
                            "username" => "{$username}",
                        ));
                    } else {
                        return json_encode(array(
                            "status" => "error",
                            "username" => "Hardware ID does not match",
                        ));
                    }
                } else {
                    return json_encode(array(
                        "status" => "error",
                        "reason" => "Password is incorrect",
                    ));
                }
            } else {
                return json_encode(array(
                    "status" => "error",
                    "reason" => "User does not exist",
                ));
            }
        }
        public function registerClient($username, $password, $ip_address, $hardware_id)
        {
            if (!$this->userExist($username)) {
                $check_sql = "SELECT * FROM `users` WHERE `ip_address`='$ip_address'";

                if (mysqli_num_rows($this->database()->query($check_sql)) == 1) {
                    return json_encode(array(
                        "status" => "error",
                        "reason" => "IP address found",
                    ));
                } else {
                    $encrypted_password = password_hash("{$password}", PASSWORD_DEFAULT);
                    $sql = "INSERT INTO `users` (username, password, ip_address, hardware_id) VALUES ('$username', '$encrypted_password', '$ip_address', '$hardware_id')";
                    $this->database()->query($sql);

                    return json_encode(array(
                        "status" => "success",
                        "username" => "{$username}",
                    ));
                }
            } else {
                return json_encode(array(
                    "status" => "error",
                    "reason" => "User already exists",
                ));
            }
        }
    }
}