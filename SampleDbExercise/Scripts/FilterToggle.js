$(function () {
    $("p.lead").addClass("btn btn-default");
    $("p.lead").html("Nascondi Filtri");
    $("div.filterContainer").show();
    $("p.lead").click(function () {
        var link = $(this);
        $("div.filterContainer").toggle("fast", function () {
            if ($(this).is(':visible'))
                link.text("Nascondi Filtri");
            else
                link.text("Mostra Filtri");
        });
    });
});