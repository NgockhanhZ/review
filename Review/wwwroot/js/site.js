$(document).ready(function () {
    // Ẩn/hiện mô tả khi nhấn nút
    $(".toggle-description").click(function () {
        $(this).siblings(".description").slideToggle();
    });

    // Hiệu ứng khi di chuột vào card
    $(".card").hover(
        function () {
            $(this).addClass("shadow-lg").css("cursor", "pointer");
        },
        function () {
            $(this).removeClass("shadow-lg");
        }
    );
});
