let everyLabel = document.getElementsByTagName("label");

for (let i = 0; i < everyLabel.length; i++) {
    let img = document.getElementById("img1");

    
    everyLabel[i].addEventListener("mouseover", function() {
        if (everyLabel[i].innerHTML == "World of Warcraft") {
            img.src = "img/wow.jpeg"
        }
        else if (everyLabel[i].innerHTML == "Guns Gore and Canoli") {
            img.src = "img/gunsgore.jpg"
        }
        else if (everyLabel[i].innerHTML == "Stardew Valley") {
            img.src = "img/stardew.jpg"
        } else {
            img.src = "img/castlecrashers.jpg"
        }
        img.style ="width: 200px; height:  200px;"
    })
}