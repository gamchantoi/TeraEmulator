var MessageNumber = 1;
var KeepaliveInterval = 1000 * 60 * 15;

var GAME_ID = 1;
var SLS_URL = "http://127.0.0.1/list.en";
var CURRENT_LANGUAGE = "en";
var CUSTOMER_SUPPORT_URL = "";
var GAME_EXE = "Client/TL.exe";
var ACCOUNT_NAME = "#ACCOUNT_NAME#";
var ACCOUNT_EMAIL = "#ACCOUNT_EMAIL#";

var LAUNCHER_EXIT_MSGS = {};

LAUNCHER_EXIT_MSGS["0111"] = "SLS download error";
LAUNCHER_EXIT_MSGS["ffff"] = "Fatal game client exception";
LAUNCHER_EXIT_MSGS["0112"] = "Game string error";
LAUNCHER_EXIT_MSGS["0113"] = "Game execution failure";
LAUNCHER_EXIT_MSGS["0111_0001"] = "General failure";
LAUNCHER_EXIT_MSGS["0112_01f4"] = "General service error";
LAUNCHER_EXIT_MSGS["0111_0002"] = "XML parse error";
LAUNCHER_EXIT_MSGS["0008"] = "General network failure";
LAUNCHER_EXIT_MSGS["0111_0003"] = "Malformed XML / fields missing";
LAUNCHER_EXIT_MSGS["0104_8000"] = "Game time exhausted";
LAUNCHER_EXIT_MSGS["0112_0194"] = "Account not found / session expired";
LAUNCHER_EXIT_MSGS["0101"] = "Ticket verification error";
LAUNCHER_EXIT_MSGS["0102"] = "Billing system failure";
LAUNCHER_EXIT_MSGS["0103"] = "Account is already logged in";
LAUNCHER_EXIT_MSGS["0104"] = "Game time exhausted";
LAUNCHER_EXIT_MSGS["0105"] = "System failure";
LAUNCHER_EXIT_MSGS["0101_019c"] = "Game is currently in maintenance";
LAUNCHER_EXIT_MSGS["0108"] = "Account banned";
LAUNCHER_EXIT_MSGS["0111_01f4"] = "General service error";
LAUNCHER_EXIT_MSGS["0104_0000"] = "Game time exhausted";
LAUNCHER_EXIT_MSGS["0101_01f4"] = "General authentication service error";
LAUNCHER_EXIT_MSGS["0112_0000"] = "JSON parse error";
LAUNCHER_EXIT_MSGS["0112_0001"] = "Malformed JSON / missing fields";
LAUNCHER_EXIT_MSGS["0111_0194"] = "Server list for requested language does not exist";
LAUNCHER_EXIT_MSGS["0101_0191"] = "Account is banned or suspended";
LAUNCHER_EXIT_MSGS["0101_0194"] = "Ticket not found or expired";
LAUNCHER_EXIT_MSGS["0101_0195"] = "Insufficient privileges";
LAUNCHER_EXIT_MSGS["000a"] = "Insufficient memory";
LAUNCHER_EXIT_MSGS["000b"] = "DirectX initialization failure";
LAUNCHER_EXIT_MSGS["000c"] = "Unsupported graphics card";
LAUNCHER_EXIT_MSGS["000f"] = "User input too long";

function testInterface() {
    alert("Message Received by AMS Hosted IFrame!");
}

function serverPing() {
    $.ajax({
        url: "/launcher/keepalive",
        success: function (data) {
            setTimeout(serverPing, KeepaliveInterval);
        },
        error: function (jqXHR, textStatus, errorThrown) {
            setTimeout(serverPing, KeepaliveInterval);
        }
    });
}

var LockPlayButton = false;
function gameLaunch() {
    launchGameExe();
}

function launchGameExe() {
    parent.copyCub.launchGame(GAME_EXE);
    MessageNumber++;
}

function gameSendMessage() {
    parent.copyCub.sendMessage("Some data: " + MessageNumber);
    MessageNumber++;
}

function getSLSURL() {
    return SLS_URL;
}

function getAuthTicket() {
    var out = "";

    $.ajax({
        async: false,
        url: "/launcher/auth_ticket",
        success: function (data) {
            out = data;
        },
        error: function (jqXHR, textStatus, errorThrown) {
            out = jqHXR.responseText;
        }
    });

    return out
}

function endPopup(endType1, endType2) {
    var str_e1 = new Number(endType1).toString(16);
    var str_e2 = new Number(endType2).toString(16);

    str_e1 = rPadString(str_e1, 4, "0");
    str_e2 = rPadString(str_e2, 4, "0");

    var msg = getErrorMsgFromTypes(str_e1, str_e2);
    if (msg != null) {
        var title = "Error: " + str_e1 + ":" + str_e2;
        parent.displayError(title, msg);
    }
}

function getErrorMsgFromTypes(str_e1, str_e2) {
    return LAUNCHER_EXIT_MSGS[str_e1 + "_" + str_e2] || LAUNCHER_EXIT_MSGS[str_e1] || null;
}

function rPadString(str, len, chr) {
    var pad = [];
    while (pad.length + str.length < len) {
        pad[pad.length] = chr;
    }
    return pad.join('') + str;
}

function csPopup() {
    parent.navigateDefaultBrowser(CUSTOMER_SUPPORT_URL);
}

function handleNewWindowLinkClick(event) {
    var link = $(this);
    var tgt = link.attr("target");

    if (tgt == "blank" || tgt == "_blank") {
        parent.navigateDefaultBrowser(link.attr("href"));
        event.preventDefault();
    }
}

function getAccountServerInfo() {
    return "{\"access_level\":1,\"result-message\":\"OK\",\"game_account_name\":\"TERA\",\"ticket\":\"#SESSION_TICKET#\",\"last_connected_server_id\":0,\"account_bits\":\"0x00980003\",\"user_permission\":0,\"master_account_name\":\"#ACCOUNT_NAME#\",\"result-code\":200,\"chars_per_server\":{}}";
}

function getGameString() {
    return getAccountServerInfo();
}

function getLastConnectedServerId() {
    var out = $.parseJSON(getAccountServerInfo());
    delete out.user_permission;
    delete out.chars_per_server;
    return JSON.stringify(out);

}

function getListOfCharacterCount() {
    var out = $.parseJSON(getAccountServerInfo());
    delete out.user_permission;
    delete out.last_connected_server_id;
    return JSON.stringify(out);
}

parent.enableLaunchButton = function (visible) {
    parent.wcLaunchButton.className = "ready";
    parent.wcLaunchButton.onclick = function () { parent.launch(); };
}

parent.LoginSuccess();