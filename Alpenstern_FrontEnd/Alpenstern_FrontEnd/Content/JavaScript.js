// #region login
function showPassword() {

    var key_attr = $('#key').attr('type');

    if (key_attr != 'text') {

        $('.checkbox').addClass('show');
        $('#key').attr('type', 'text');

    } else {

        $('.checkbox').removeClass('show');
        $('#key').attr('type', 'password');

    }

}

// #endregion

// #region Game
$(document).ready(function () {

    $('#bonus1').click(function () {
        $('#bonustabelle1').css('background-color', 'green')
    });

    $('#bonus2').click(function () {
        $('#bonustabelle2').css('background-color', 'green')
    });

    $('#bonus3').click(function () {
        $('#bonustabelle3').css('background-color', 'green')
    });

    $('#megabonus').click(function () {
        $('#megabonustabelle').css('background-color', 'green')
    });
});


// #endregion
