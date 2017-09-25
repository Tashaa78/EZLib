<?php

require $_SERVER['DOCUMENT_ROOT'] . "/Web_Server/classes/System.php";


$System = new \EZLib\System();

var_dump($System->validateLogin("ezlib", "Justin", "justinrocks123", "B86-B97D-E0D6-3572-3E24-CA7B-0476-DB35-C427-DC31"));