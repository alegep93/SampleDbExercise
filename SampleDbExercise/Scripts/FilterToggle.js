$(function () {
    $("div.filterContainer").show();
    $("p.lead").html("Mostra Filtri");
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