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

    //AJAX post for the Add to cart
    //bind a submit event to our form
    $('stuff form').on('submit', function (event) {
        event.preventDefault();
        //Do the AJAX post 
        $.post('/Cart/Add/', $(this).serialize(), function (data) {
            $('.MiniCart').html(data);
        });
    });
});

