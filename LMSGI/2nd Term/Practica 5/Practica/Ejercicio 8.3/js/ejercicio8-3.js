// Obtengo los elementos.
let start_counter = document.getElementById("start_counter");
let stop_counter = document.getElementById("stop_counter");


// Creo una función que utilice un contador, que sume uno y que modifique el texto del text_area.
let counter = 0;
function addToCounter() {
    let text_area = document.getElementById("counter");
    counter++;
    text_area.innerHTML = counter;
}

// Declaro mi variable para que funcione dentro del global-scope.
let addToCounterEverySec;

start_counter.addEventListener("click", function() {
    // Aquí, no solo activo mi intervalo, asino que seteo esa función a mi variable addToCounterEverySec.
    addToCounterEverySec = setInterval(addToCounter, 100)
})

stop_counter.addEventListener("click", function() {
    //Utilizo clearInterval para que frene a la función iniciada previamente. Guardada previamente en mi variable.
    clearInterval(addToCounterEverySec);
})



// Probar videojuego
let start_game = document.getElementById("start_game");
let div_container = document.getElementsByClassName("container")[0];


function generateRandomNumber() {
    let random_number = Math.floor((Math.random() * 10) + 1);
    return random_number;
}

function createRandomLabel() {
    let label = document.createElement("label")
    label.style = "color: white; font-size 20rem;"
    label.innerHTML = generateRandomNumber();
    label.id = "random-number";
    return label
}
function centerContainerAndAddLabel() {
    div_container.style = "border: 5px solid; margin: auto; width: 50%; padding: 10px; display: flex; flex-direction: column; align-items: center;"
    let new_label = createRandomLabel();
    div_container.appendChild(new_label);

    
}

start_game.addEventListener("click", function() {
    document.body.style.backgroundImage = "url(img/castle.jpg)";
    start_counter.remove();

    let oldLabel = document.getElementById("random-number");
    if (oldLabel) {
        oldLabel.remove()
    }
    centerContainerAndAddLabel();
    

})

