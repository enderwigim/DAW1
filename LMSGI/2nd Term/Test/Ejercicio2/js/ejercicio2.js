let startButton = document.getElementById("startButton");
let deleteButton = document.getElementById("deleteParaph");

function GetRandomNumber() {
    let random_number = Math.floor((Math.random() * 30) + 1);
    return random_number;
}

function CreateParaphs(ammountOfP) {
    for (let i = 1; i <= ammountOfP; i++) {
        let newParaph = document.createElement("p");
        newParaph.innerHTML = "Hola este es el párrafo " + i;
        document.body.appendChild(newParaph);
    }
}

function ClearParaphs(everyParaph) {
    let i = 0;
    while (everyParaph.length > i) {
        everyParaph[i].remove();
    }
}

// Esta función borra un parrafo y llama a la función AddaptEveryParaph para reordenar y que el usuario no se maree.
function DeleteParaph(everyParaph, paraphNum) {
    everyParaph[paraphNum - 1].remove();
    AddaptEveryParaph(everyParaph);
}

// Readapta todos los parrafos. Asignandole el numero de parrafo segun su ubicación.
function AddaptEveryParaph(everyParaph) {
    for (let i = 1; i <= everyParaph.length; i++) {
        everyParaph[i - 1].innerHTML = "Hola este es el párrafo " + i;
    }
}

startButton.addEventListener("click", function() {
    let randomNumber = GetRandomNumber();
    let everyParaph = document.getElementsByTagName("p");
    alert(randomNumber);
    if (everyParaph.length > 0) {
        ClearParaphs(everyParaph);
    }
    CreateParaphs(randomNumber);
})

deleteButton.addEventListener("click", function() {
    let everyParaph = document.getElementsByTagName("p");
    if (everyParaph.length > 0) {
        let paraphToDelete = prompt("What paraph do you want delete?")
        if (paraphToDelete > 0 || paraphToDelete < everyParaph.length) {
            DeleteParaph(everyParaph, paraphToDelete);
        } else {
            alert("That paraph doesn't exist.")
        }
    } else {
        alert("There isn't any paraph yet.")
    }
})