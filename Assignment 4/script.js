
// Image Gallery
var fullImgBox = document.getElementById("fullImgBox");
var fullImg = document.getElementById("fullImg");

let currentIndex = 0;
const images = [
  "images/img1.png",
  "images/img2.png",
  "images/img3.png",
  "images/img4.png",
  "images/img6.png",
  "images/img5.png",
  "images/img7.png",
  "images/img8.png"
];

function openFullImg(pic) {
  fullImgBox.style.display = "flex";
  fullImg.src = pic;
  document.body.classList.add("disable-scroll");
  document.addEventListener("wheel", disableScroll, { passive: false }); 
}

function closeFullImg() {
  fullImgBox.style.display = "none";
  document.body.classList.remove("disable-scroll");
  document.removeEventListener("wheel", disableScroll); 
}

function showPreviousImage() {
    currentIndex = (currentIndex - 1 + images.length) % images.length;
    document.getElementById("fullImg").src = images[currentIndex];
  }
  
  function showNextImage() {
    currentIndex = (currentIndex + 1) % images.length;
    document.getElementById("fullImg").src = images[currentIndex];
  }

//   Disables user from scrolling when clicked on an image
function disableScroll(event) {
  event.preventDefault();
}

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

//   Increases the height of the water so it seems like water is being poured into cup
  window.addEventListener('scroll', function() {
    var water = document.getElementById('water');
    var scrollPercentage = (window.scrollY / (document.documentElement.scrollHeight - window.innerHeight)) * 100;
    var waterHeight = Math.min(scrollPercentage, 100) + '%';
    water.style.height = waterHeight;
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
