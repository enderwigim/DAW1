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
let isCountActivated = false;
start_counter.addEventListener("click", function() {
    // Aquí, no solo activo mi intervalo, asino que seteo esa función a mi variable addToCounterEverySec.
    if (!isCountActivated) {
        addToCounterEverySec = setInterval(addToCounter, 1000)
        isCountActivated = true;
    }
})

stop_counter.addEventListener("click", function() {
    //Utilizo clearInterval para que frene a la función iniciada previamente. Guardada previamente en mi variable.
    clearInterval(addToCounterEverySec);
    isCountActivated = false;
})







// Inciar juego. Obtengo otros elementos, el botón de juego, el container y el contador.
let start_game = document.getElementById("start_game");
let div_container = document.getElementsByClassName("container")[0];
let guessCounter = document.getElementById("counter");

// Declaro una variable para ver si el juego se encuentra iniciado.
let isGameStarted = false;

// Ejecuto el juego a través del siguiente botón.
start_game.addEventListener("click", function() {
    // guessCounter.hidden = "hidden";

    // Si el juego no se encuentra iniciado. Seteamos todo para que funcione.
    if (!isGameStarted){
        createGameElements();
        
        
        clearInterval(addToCounterEverySec);
        addToCounterEverySec = setInterval(addToCounterFrom1To10, 100);
        start_game.innerHTML = "Guess My Number!";
        isGameStarted = true;

    } else {
        clearInterval(addToCounterEverySec);
        let random_number = document.getElementById("random-number");
        // guessCounter.removeAttribute("hidden")
        if (guessCounter.innerHTML == random_number.innerHTML) {
            random_number.innerHTML = "You won!!";
        } else {
            random_number.innerHTML = "You lost :("
        }
        random_number.style.fontSize = "80px"
        isGameStarted = false;
        start_game.innerHTML = "Play Again";

    }   

    
})




function addToCounterFrom1To10() {
    let text_area = document.getElementById("counter");
    counter++;
    if (counter > 10) {
        counter = 1;
    }
    text_area.innerHTML = counter;
}


function generateRandomNumber() {
    let random_number = Math.floor((Math.random() * 10) + 1);
    return random_number;
}

function createGameElements() {
    // Seteamos el background a esta imagen, y eliminamos los botones de la pagina previa.
    document.body.style.backgroundImage = "url(img/castle.jpg)";
    start_counter.remove();
    stop_counter.remove();

    // Cambiamos el style del div.
    div_container.style = "border: 5px solid; margin: auto; width: 50%; padding: 10px; display: flex; flex-direction: column; align-items: center;"

    // Si hay un label viejo, igual al que crearemos, lo eliminamos.
    let oldLabel = document.getElementById("random-number");
    if (oldLabel) {
        oldLabel.remove()
    }

    // Creamos un nuevo label, el cual será nuestro numero a obtener. 
    let label = document.createElement("label")
    label.style = "color: white; font-size: 200px;"
    label.innerHTML = generateRandomNumber();
    label.id = "random-number";
    
    // Lo agregamos al div.
    div_container.appendChild(label);

}





