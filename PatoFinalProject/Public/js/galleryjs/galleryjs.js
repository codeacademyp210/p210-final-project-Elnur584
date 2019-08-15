"use strict";
let buttons = document.querySelectorAll(".tab-button");
let tabs = document.querySelectorAll(".alldata");
buttons[0].style.borderRadius = "10px";
buttons[0].style.backgroundColor = "black";
buttons[0].style.color = "white";


for (let i = 0; i < buttons.length; i++) {
    buttons[i].addEventListener("click", function () {
        let elementId = this.getAttribute("data-tab-target");
        for (let j = 0; j < tabs.length; j++) {
            tabs[j].classList.add("d-none");
           buttons[i].style.backgroundColor = "black";
           buttons[i].style.color = "white";
           buttons[i].style.borderRadius = "10px";
           buttons[i].style.transition = "0.5s ease";
           for(let j=0; j<buttons.length; j++){
               if(i!=j){
                buttons[j].style.background = "none"
                buttons[j].style.color = "black"
                

               }
           }
        }
        document.querySelector("#" + elementId).classList.remove("d-none");
       
    });
}