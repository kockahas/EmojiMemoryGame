<?php

function resultwrite_f(){
    
    $punev=$_POST['unev'];
    $mysqli = new mysqli("127.0.0.1", "root", "", "memorygame");
    if ($mysqli -> connect_errno) {
        echo "connecterror" . $mysqli -> connect_error;
        exit();
    }
    
    $sql = "SELECT id FROM users WHERE unev='$punev'";
    $result = $mysqli->query($sql);
    if ($result->num_rows > 0) {
        while($row = $result->fetch_assoc()) {
        $játekosid=$row["id"];
        }
        } else {
            return "NemOKok";
        }
        $mysqli->close();
        
        $plepesek=(int)$_POST['lepesek'];
        $pido=$_POST['ido'];
        $ptipus=(int)$_POST['tipus'];
        
        $mysqli2 = new mysqli("127.0.0.1", "root", "", "memorygame");
        $res2=$mysqli2->prepare("INSERT INTO eredmeny4 (jatekos_id,lepesek,ido,tipus) VALUES (?,?,?,?)");
        $res2->bind_param("iisi",$játekosid,$plepesek,$pido,$ptipus);
        if($res2->execute()){
        return "OK";
    }else{
        return "NemOK";
    }
}


