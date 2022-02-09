$(function () {
    checkbackgroundcolor();
    $('.background a').on('click', function (e) {

        e.preventDefault();
        var color = $(this).data('color');
        //  alert(color);
        localStorage.color = color;
        setBackgroundColor(color);
    });
    function setBackgroundColor(color) {
        $('body').css('background-color', color);
    }
    function checkbackgroundcolor() {
        if (localStorage.color) {
            setBackgroundColor(localStorage.color);
        }

    }



});