$(document).ready(function () {
    // executes when HTML-Document is loaded and DOM is ready

    // breakpoint and up  
    $(".navbar-mega .dropdown-toggle").hover(function () {
        $(this).parent().toggleClass("show");
        $(this).parent().find(".dropdown-menu").toggleClass("show");
    });

    // hide the menu when the mouse leaves the dropdown
    $(".navbar-mega .dropdown-menu").mouseleave(function () {
        $(this).removeClass("show");
    });



    // document ready  
});