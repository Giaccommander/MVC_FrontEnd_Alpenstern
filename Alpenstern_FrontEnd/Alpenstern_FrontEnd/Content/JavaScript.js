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



// #endregion

// #region Gallery

//$(document).ready(function () {
//    $("[class^='thumbnail-']").click(function () {
//        $("[class^='thumbnail-']").slideToggle("fast");
//        $(this).next("[class^='large-']").slideToggle();
//    });

//    $(".close").click(function () {
//        $("[class^='large-']:visible").toggle();
//        $("[class^='thumbnail-']").fadeToggle("fast");
//    });

//});

//new WOW().init();


// #endregion