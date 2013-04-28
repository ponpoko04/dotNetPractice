$(function (e) {
//    alert(e.type);
    // Add Rowボタンクリック
    $("#BtnAddRow").unbind("click").bind("click", (function (e) {
        alert("click!!");
        //$(this).myPlugin().addRow(e);
        //$.fn.myPlugin.addRow(e);
        return;
    }));
});

function BtnShow_Click() {
    $("#BtnShow").get(0).click();
}
//$.fn.myPlugin = function () {
//    // plugin sample
//    addRow: function (e) {
//        e.preventDefault();
//        alert("plugin!!");
//        return this;
//    }
//};
