$(function () {
    var path = window.location.pathname;
    var path = path.substr(1,path.length);

    switch (path) {
        case "index.aspx":
            $("ul.nav-pills li:first-child").addClass("active");
        break;
        case "customer.aspx":
            $("ul.nav-pills li:nth-child(2)").addClass("active");
            break;
        case "order.aspx":
            $("ul.nav-pills li:nth-child(3)").addClass("active");
            break;
        case "orderitem.aspx":
            $("ul.nav-pills li:nth-child(4)").addClass("active");
            break;
        case "product.aspx":
            $("ul.nav-pills li:nth-child(5)").addClass("active");
            break;
        case "supplier.aspx":
            $("ul.nav-pills li:last-child").addClass("active");
            break;
    }
});