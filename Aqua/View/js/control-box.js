$().ready(function () {
    $("body").on("click", ".control-box #close", function (e) {
        windowsApp.close();
    });

    $("body").on("click", ".control-box #max-normalize", function (e) {
        windowsApp.toggleWindow();
    });

    $("body").on("click", ".control-box #minimize", function (e) {
        windowsApp.minimize();
    });
});