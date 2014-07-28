$(document).ready(function () {
    $('.button').on('click', function () {
        var id = $(this).data('id');
        var add = $(this);
        $.post('/Cart/Add/' + id, function (data) {
            add.html(data);
        });
    });
    $('.thumbnail').on("click", function () {
        var src = $(this).attr('src');
        $('.photo').attr('src', src);
    });
});

