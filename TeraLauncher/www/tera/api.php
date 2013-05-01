<?php

header('Content-Type: text/html; charset=utf-8');

/*
 * author - karyzir
 * предоставляет интерфейс для работы из базой данных
 */

include_once("bd.php");

// получаем название функции для обработки
$action = $_GET['action'];

if (isset($action) && $action != "")
{
    if($action == 'login')
    {
        LoginAction();
        exit;
    }

    if($action == 'register')
    {
        RegisterAction();
        exit;
    }

    if($action == 'servers')
    {
        ServersAction();
        exit;
    }


    ErrorAction("Запрашиваный вами API::".$action." не существует!");
}
else
{
    ErrorAction("URL-запрос имеет не правильны формат!");
}

function ErrorAction($val)
{
    $result = '{"success":"false","error":"'. $val .'"}';
    echo $result;
    exit;
}


function LoginAction()
{
    if (isset($_GET['login'])) {
        $login = $_GET['login'];
        if ($login == '') {
            unset($login);
            ErrorAction("Введите логин!");
        }
    }
    if (isset($_GET['password'])) {
        $password=$_GET['password'];
        if ($password =='') {
            unset($password);
            ErrorAction("Введите пароль!");
        }
    }

    $login = stripslashes($login);
    $login = htmlspecialchars($login);

    $password = stripslashes($password);
    $password = htmlspecialchars($password);

    $login = trim($login);
    $password = trim($password);
    $password = md5($password);

    $user = mysql_query("SELECT * FROM users WHERE login='$login' AND password='$password'");
	$u = mysql_fetch_array($user);
    if (empty($u['id'])){
        ErrorAction("Введённый вами логин или пароль неверный!");
    }
    else
    {
        if ($u["money"] == "")
        {
            $u["money"] = 0;
        }

        $result = '{"success": "true",
                    "login":"'. $login.'",
					"password":"'.$password.'",
                    "id": "'.$u['id'].'",
                    "first_name":"'.$u['name_user'] .'",
                    "last_name": "'.$u['lastname'] .'",
                    "email":"'.$u["email"].'",
                    "money": "'.$u["money"].'"}';

        echo $result;
    }
}

function GetValue($value)
{
    $value = $_GET[$value];
    $value = stripslashes($value);
    $value = htmlspecialchars($value);
    $value = trim($value);
    return $value;
}

function RegisterAction()
{
    $login = GetValue('login');
    $email = GetValue('email');
    $password= GetValue('password');
    $password = md5($password);
    $first_name = GetValue('first_name');
    $lats_name = GetValue('last_name');

    $query = mysql_query("SELECT * FROM users WHERE login='$login'");
    $uniq  = mysql_fetch_array($query);
    if (isset($uniq['id']))
    {
        ErrorAction("Ошибка. Логин: ".$login." - не доступен!");
    }

    $query = mysql_query("SELECT * FROM users WHERE email='$email'");
    $uniq  = mysql_fetch_array($query);
    if (isset($uniq['id']))
    {
        ErrorAction("Ошибка. Email: " . $email . " -  уже используется!");
    }

    $sql = "insert into users
            (login, password, email, name_user, lastname)
            values
            ('".$login."', '".$password."', '".$email."', '".$first_name."', '".$lats_name."')";

    $result = mysql_query($sql) or die("Invalid query: " . mysql_error());
    LoginAction();
}


function ServersAction()
{
    $sql = "SELECT `id`,`title`,`small_text`,`img` FROM `servers` WHERE `l_visible`='1'";
    $result = mysql_query($sql);

    //echo "<pre>";

    if (!$result)
    {
        ErrorAction("Нет даных");
    }

    if (mysql_num_rows($result) == 0)
    {
        ErrorAction("No Servers Available");
    }

    $response = '{"success": "true","count": "' .mysql_num_rows($result). '"';

    $i = 0;
    while ($row = mysql_fetch_assoc($result)) {

        $response .= ',
        "'. $i .'":
        {
            "id":"'.$row["id"].'",
            "title":"'.$row["title"].'",
            "small_text":"'.$row["small_text"].'",
            "img":"'.$row["img"].'"
        }';
        $i++;
    }
    $response .= '}';
    mysql_free_result($result);
    echo $response;
}



