
let button = document.getElementById("cambioImagen");
let image = document.getElementsByTagName("img")[0]

button.addEventListener("click", function() {
    if (image.alt === "toothless1"){
        image.src = "https://i.redd.it/mkjz83nnhmj71.jpg";
        image.alt = "toothless2";
    } else {
        image.src = "https://i.kym-cdn.com/entries/icons/facebook/000/047/760/dt.jpg"
        image.alt = "toothless1"
    }
});

function changeImg() 
{  
  window.setTimeout(function() {
    image.src = "t2.gif";
  }, 3500);   
} 
     