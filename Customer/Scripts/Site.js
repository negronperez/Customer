$(document).ready(function () {
    $('.valid_form').validate({
        rules: {
        },
        messages: {
        }
    });

    $('.validate').each(function () {
        $(this).attr('required', 'required');
    });
});