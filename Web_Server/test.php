<?php

require $_SERVER['DOCUMENT_ROOT'] . "/Web_Server/classes/System.php";


$System = new \EZLib\System();

var_dump($System->isLicensed("5994393", "Justin"));