let changeButton = document.getElementById("changeButton");
let stopButton = document.getElementById("stopButton");

let myInterval;

function changeImageAndBody() {
    let img = document.getElementById("myImg");
    if (img.alt == "castleCrashers" && document.body.style.backgroundColor == "black") {
        img.src = "img/toothless_meme.jpg";
        img.alt = "toothless";
        document.body.style.backgroundColor = "green"
    } else {
        img.src = "img/castle.jpg";
        img.alt = "castleCrashers";
        document.body.style.backgroundColor = "black"
    }
}


changeButton.addEventListener("click", function() {
    // Con esto nos aseguramos que no pase por el clear en caso de que este indefinida nuestra variable.
    if (myInterval !== undefined) {
        clearInterval(myInterval);
    }
    myInterval = setInterval(changeImageAndBody, 3000);
})

stopButton.addEventListener("click", function() {
    clearInterval(myInterval);
})
