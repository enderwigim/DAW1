let countButton = document.getElementById("countButton")
let addH1Button = document.getElementById("AddH1Button");
let changeHrefButton = document.getElementById("ChangeHrefButton");


addH1Button.addEventListener("click", function() {
    let h1Text = prompt("What's the text that you want to insert?");
    if (h1Text !== "") {
        let newH1 = document.createElement("h1");
        newH1.innerHTML = h1Text;
        document.body.appendChild(newH1);
    } else {
        alert("The text can't be added. It is empty.");
    }
})

changeHrefButton.addEventListener("click", function() {
    let everyA = document.getElementsByTagName("a");
    let firstHref = everyA[0].href;
    everyA[0].href = everyA[1].href;
    everyA[1].href = firstHref;

})

countButton.addEventListener("click", function(){
    let everyA = document.getElementsByTagName("a");
    let everyBtn = document.getElementsByTagName("button");
    let everyH1 = document.getElementsByTagName("h1");

    let paraph = document.getElementById("counter");
    if (everyH1.length === 0) {
        paraph.innerHTML = "Hay " + everyA.length + " enlaces, " + everyBtn.length + " botones y no hay titulos";
    } else {
        paraph.innerHTML = "Hay " + everyA.length + " enlaces, " + everyBtn.length + " botones y " 
        + everyH1.length + " titulos";
    }

})