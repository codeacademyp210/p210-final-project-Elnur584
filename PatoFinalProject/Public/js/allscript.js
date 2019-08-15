"use strrict";
// Slider script

// ///////////////////// Toggle script
$("#toggle").click(function () {
  $(this).toggleClass("on");
  $("#menu").slideToggle();
});

// Second half rotate slider 
// makes sure the whole site is loaded
jQuery(window).load(function() {
    // will first fade out the loading animation
jQuery("#status").fadeOut(4000);
    // will fade out the whole DIV that covers the website.
jQuery("#preloader").delay(1000).fadeOut("slow");
})

  

  