"use strict";
var nav = document.getElementById("myNav");

function openNav() {
    nav.style.width = "100%";
}

function closeNav() {
    nav.style.width = "0";
}

var toggle = document.getElementById("toggle-icon");
window.onscroll = function() {fixedtogglebtn()};
var media = window.matchMedia("(max-width:768px)")
function fixedtogglebtn(){
    
    if(document.body.scrollTop > 150 || document.documentElement.scrollTop > 150){
     toggle.style.color ="rgb(161, 161, 87)"
     toggle.style.top = "10px"
     toggle.style.opacity = "0.8"
    
    }
    else{
        toggle.style.color ="white"
        toggle.style.top = "90px"
        toggle.style.transition = "1s"
    }
   
}
