<?php

function login_f(){
    
    $mysqli = new mysqli("127.0.0.1", "root", "", "memorygame");
    if ($mysqli -> connect_errno) {
        echo "connecterror" . $mysqli -> connect_error;
    exit();
    }
    $punev=$_POST['unev'];
    $passw=$_POST['jelszo'];
    $res=$mysqli->prepare("SELECT id FROM users WHERE unev=? AND jelszo=?");
    $res->bind_param("ss",$punev,$passw);
    $res->execute();
    $result=$res->get_result();
    if ($result->num_rows>0 ) {
        return 'OK';    
    }else
        return "NemOK";
 }

