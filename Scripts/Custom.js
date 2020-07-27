$(document).ready(function () {
    InitControls();
});


function InitControls() {
    //افزودن استایل دیفالت به همه کنترل ها
    $("input[type=text],textarea,select,input[type=password]").each(function () {
        $(this).attr("class", $(this).attr("class") + " form-control");
    });

    //افزودن استایل دیفالت به همه دکمه ها
    $("input[type=submit],input[type=Button]").each(function () {
        $(this).attr("class", "btn btn-xs " + $(this).attr("class"));
    });

    //فعال شدن آیکون ها حین فکوس با موس
    $('.icon-xs,.icon-sm,.icon-md,.icon-lg,.icon-xl').hover(function () {
        $(this).stop().fadeTo("fast", 1);
    }, function () {
        $(this).stop().fadeTo("fast", 0.85);
    });

    //نمایش منو درصورت داشتن آیتم در دیوایس
    if ($(".navbar-collapse>ul").length == 0) {
        $(".navbar-toggle").remove();
    }

    //نمایش جداول دارای آیتم در دیوایس
    $("div.table-responsive").each(function () {
        if ($(this).find("div>table").length == 0) {
            $(this).remove();
        }
    });
}
