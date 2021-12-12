<?php

error_reporting(0);

include 'login.php';
include 'register.php';
include 'resultwrite.php';
include 'resultsrequest.php';

if (isset($_POST['COM'])) {
     switch ($_POST['COM']) {
         case 'login': echo login_f(); break;
         case 'register':  echo register_f(); break;
         case 'RW' : echo resultwrite_f();break ;
         case 'RQ' : echo resrequest_f();break;
         default: break;
     }
}

