var GRID_STATE = 'searched';

$(function () {
    var allcookies = document.cookie;
    var result = new Array();
    if (allcookies) {
        var cookies = allcookies.split(';');

        for (var i = 0; i < cookies.length; i++) {
            var cookie = cookies[i].split('=');

            // クッキーの名前をキーとして 配列に追加する
            result[cookie[0]] = decodeURIComponent(cookie[1]);
        }
        if (result.searched === "true") { $("#BtnShow").get(0).click(); }
    }

    $("#BtnShow").unbind("click").bind("click", (function () {
        document.cookie = GRID_STATE + '=true';
    }));
});
