<?php

function register_f(){
    
    $mysqli = new mysqli("127.0.0.1", "root", "", "memorygame");
    if ($mysqli -> connect_errno) {
        echo "connecterror" . $mysqli -> connect_error;
    exit();
    }
    
    $punev=$_POST['unev'];
    $tnev=$_POST['nev'];
    $passw=$_POST['jelszo'];
    
    $res=$mysqli->prepare("INSERT INTO users (unev,nev,jelszo) VALUES (?,?,?)");
    $res->bind_param("sss", $punev,$tnev,$passw);
    $result=$res->execute();
    
    if($result){
        return "OK";
    }else return "NemOK";
}
