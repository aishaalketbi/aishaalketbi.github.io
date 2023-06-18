
let layer_1 = document.querySelector(".layer-1");
let layer_2 = document.querySelector(".layer-2");
let layer_3 = document.querySelector(".layer-3");
let layer_4 = document.querySelector(".layer-4");
let layer_5 = document.querySelector(".layer-5");

window.onscroll = function(){
    let Y = window.scrollY;

    layer_1.style.transform = "translateY("+ Y/1.5 +"px)";
    layer_2.style.transform = "translateY("+ Y/2 +"px)";
    layer_3.style.transform = "translateY("+ Y/1.5 +"px)";
    layer_4.style.transform = "translateY("+ Y/2 +"px)";
    layer_5.style.transform = "translateY("+ Y/3 +"px)";
}

const inputs = document.querySelectorAll(".input");

function focusFunc(){
    let parent = this.parentNode;
    parent.classList.add("focus");
}

function blurFunc(){
    let parent = this.parentNode;
    if(this.value == ""){
        parent.classList.remove("focus");
    }
    
}

inputs.forEach(input => {
    input.addEventListener("focus", focusFunc);
    input.addEventListener("blur", blurFunc);
})

// Allows navigation to stick onto the top of the screen 
window.addEventListener('scroll', function() {
    var nav = document.querySelector('nav');
    var scrollPosition = window.scrollY;
  
    if (scrollPosition > 0) {
      nav.classList.add('stick');
    } else {
      nav.classList.remove('stick');
    }
  });

  //   Allows elements to fade into screen
  window.addEventListener('scroll', reveal);

  function reveal(){
      var reveals = document.querySelectorAll('.reveal');
  
      for(var i = 0; i < reveals.length; i++){
          var windowheight = window.innerHeight;
          var revealtop = reveals[i].getBoundingClientRect().top;
          var revealpoint = 150;
  
          if(revealtop < windowheight - revealpoint){
              reveals[i].classList.add('active');
          }
          else{
              reveals[i].classList.remove('active'); 
          }
          }
      }