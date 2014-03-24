$(function () {
    sizeWindow();
});

function sizeWindow() {
    window.resizeTo(800, 600);
    $('#lblPatients').addClass('hide');
};

function showLabel() {
    $('#lblPatients').removeClass('hide');
}
