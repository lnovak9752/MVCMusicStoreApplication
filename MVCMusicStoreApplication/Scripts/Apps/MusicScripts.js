
$(function () { $("#album-list img").mouseover(function () { $(this).animate({ height: "+=25", width: " += 25" }).animate({ height: "-= 25", width: " -=25" }); }); });

function searchFailed() {
    $("#searchresults").html("Sorry, there was a problem with the search.");
}

$(function () {
    $(".RemoveLink").click(function () {
        var id = $(this).attr("data-id");

        $.post("/ShoppingCart/RemoveFromCart", { "id": id }, function (data) {
            $("#update-message").text(data.Message);
            $("#cart-total").text(data.CartTotal);
            $("#item-count-" + data.DeleteId).text(data.ItemCount);

            if (data.ItemCount < 1) {
                $("#record-" + data.DeleteId).fadeOut();
            }
        });
    });
});