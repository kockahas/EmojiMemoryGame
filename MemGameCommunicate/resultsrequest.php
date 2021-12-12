<?php

function resrequest_f(){
    
    $sendstr="";
    $gtype=(int)$_POST["GT"];

    $mysqli = new mysqli("127.0.0.1", "root", "", "memorygame");
    if ($mysqli -> connect_errno) {
        echo "connecterror" . $mysqli -> connect_error;
    exit();
    }
    $sql = "SELECT  `unev`,`lepesek`,`ido` FROM `users`,`eredmeny4` WHERE eredmeny4.tipus='$gtype' AND eredmeny4.jatekos_id=users.id ORDER BY eredmeny4.lepesek DESC LIMIT 10";
    $result = $mysqli->query($sql);

    if ($result->num_rows > 0) {
          while($row = $result->fetch_assoc()) {
            $sendstr.=$row["unev"]."ß".$row["lepesek"]."ß".$row["ido"]."|";
        }
        return $sendstr;
    }
    return "NemOK";
}

