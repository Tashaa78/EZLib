<?php

namespace EZLib
{
    class System
    {
        private $errorReporting = false;
        public $authCode = "mtgEcuTSDUOW3vDDEbY6"; // Keep this a secret

        // Database
        public function database() // Connects to the database
        {
            try {
                $connection = new \PDO("mysql:host=127.0.0.1;dbname=ezlib", "root", "");
                $connection->setAttribute(\PDO::ATTR_ERRMODE, \PDO::ERRMODE_EXCEPTION);
                return $connection;
            } catch (\PDOException $exception) {
                die("An error has occurred. Error: " . $exception->getMessage());
            }

        }

        // Quick Checks
        public function varChecks() // Quick checks for errors etc.
        {
            if ($this->errorReporting === TRUE) {
                ini_set('display_errors', 1);
                ini_set('display_startup_errors', 1);
                error_reporting(E_ALL);
            } else {
                error_reporting(0);
            }
        }
        public function usernameExist($username) // Checks if username exists
        {
            $query = $this->database()->prepare("SELECT * FROM `users` WHERE `username`=? LIMIT 1");
            $query->bindParam(1, $username);
            $query->execute();

            if ($query->fetch(\PDO::FETCH_ASSOC) > 0) {
                return true;
            } else {
                return false;
            }
        }
        public function ipAddressExist($ip_address) // Checks if IP Address exists
        {
            $query = $this->database()->prepare("SELECT * FROM `users` WHERE `ip_address`=? LIMIT 1");
            $query->bindParam(1, $ip_address);
            $query->execute();

            if ($query->fetch(\PDO::FETCH_ASSOC) > 0) {
                return true;
            } else {
                return false;
            }
        }
        public function programIdExist($service, $program_id) // Checks if program ID exists
        {
            if ($service == "website") {
                $query = $this->database()->prepare("SELECT * FROM `program_ids` WHERE `program_id`=? LIMIT 1");
                $query->bindParam(1, $program_id);
                $query->execute();

                if ($query->fetch(\PDO::FETCH_ASSOC) > 0) {
                    return true;
                } else {
                    return false;
                }
            } elseif ($service == "ezlib") {
                $query = $this->database()->prepare("SELECT * FROM `program_ids` WHERE `program_id`=? LIMIT 1");
                $query->bindParam(1, $program_id);
                $query->execute();
                $array = $query->fetch(\PDO::FETCH_ASSOC);

                if ($array > 0) {
                    return $array["program_name"];
                } else {
                    return "error";
                }
            } else {
                return json_encode(array(
                    "status" => "error",
                    "reason" => "Unknown service parameter",
                ));
            }
        }
        public function isLicensed($program_id, $username) // Checks if user has a license with the provided program ID
        {
            if ($this->programIdExist("website", "{$program_id}")) {
                $query = $this->database()->prepare("SELECT * FROM `program_licenses` WHERE `program_id`=? AND `license_holder`=?");
                $query->bindParam(1, $program_id);
                $query->bindParam(2, $username);
                $query->execute();
                $array = $query->fetch(\PDO::FETCH_ASSOC);

                if ($array > 0) {
                    $today = date("M d Y");
                    $todayDate = new \DateTime("{$today}");
                    $expiryDate = new \DateTime("{$array['license_expiry']}");

                    if ($array['license_active'] == "1" || 1) {
                        if ($todayDate <= $expiryDate) {
                            return json_encode(array(
                                "status" => "success",
                                "username" => "{$username}",
                                "license" => "{$array['program_license']}",
                                "expiry_date" => "{$array['license_expiry']}",
                            ));
                        } else {
                            return json_encode(array(
                                "status" => "error",
                                "reason" => "License Key is expired",
                            ));
                        }
                    } else {
                        return json_encode(array(
                            "status" => "error",
                            "reason" => "License Key is not active/banned",
                        ));
                    }
                } else {
                    return json_encode(array(
                        "status" => "error",
                        "reason" => "User does not have a license key",
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
        public function validateLogin($service, $username, $password, $hardware_id) // Checks if user has authenticated correctly
        {
            if ($service == "website") {
                // Adding when website is being worked on
            } elseif ($service == "ezlib") {
                if ($this->usernameExist("{$username}")) {
                    $query = $this->database()->prepare("SELECT * FROM `users` WHERE `username`=? AND `hardware_id`=? LIMIT 1");
                    $query->bindParam(1, $username);
                    $query->bindParam(2, $hardware_id);
                    $query->execute();
                    $array = $query->fetch(\PDO::FETCH_ASSOC);

                    if (password_verify("{$password}", "{$array['password']}")) {
                        if ($hardware_id == $array['hardware_id']) {
                            return json_encode(array(
                                "status" => "success",
                                "username" => "{$username}",
                                "hardware_id" => "{$hardware_id}",
                                "ip_address" => "{$_SERVER['REMOTE_ADDR']}",
                            ));
                        } else {
                            return json_encode(array(
                                "status" => "error",
                                "reason" => "Hardware ID does not match",
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
            } else {
                return json_encode(array(
                    "status" => "error",
                    "reason" => "Unknown service parameter"
                ));
            }
        }
        public function registerUser($service, $username, $password, $ip_address, $hardware_id) // Registers the user
        {
            if ($service == "website") {
                // Adding when website is being worked on
            } elseif ($service == "ezlib") {
                if (!$this->usernameExist("{$username}")) {
                    if (!$this->ipAddressExist("{$ip_address}")) {
                        $encrypted_password = password_hash("{$password}", PASSWORD_DEFAULT, ['cost' => 12]);

                        $query = $this->database()->prepare("INSERT INTO `users` (username, password, ip_address, hardware_id) VALUES (?, ?, ?, ?)");
                        $query->bindParam(1, $username);
                        $query->bindParam(2, $encrypted_password);
                        $query->bindParam(3, $ip_address);
                        $query->bindParam(4, $hardware_id);
                        $query->execute();

                        return json_encode(array(
                            "status" => "success",
                            "username" => "{$username}",
                        ));
                    } else {
                        return json_encode(array(
                            "status" => "error",
                            "reason" => "User has already registered once",
                        ));
                    }
                } else {
                    return json_encode(array(
                        "status" => "error",
                        "reason" => "Username is taken",
                    ));
                }
            }
        }
    }
}