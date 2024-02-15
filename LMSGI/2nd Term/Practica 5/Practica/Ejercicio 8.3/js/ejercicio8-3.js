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
let isGameStarted = false;

start_game.addEventListener("click", function() {
    if (!isGameStarted){
        document.body.style.backgroundImage = "url(img/castle.jpg)";
    start_counter.remove();

    let oldLabel = document.getElementById("random-number");
    if (oldLabel) {
        oldLabel.remove()
    }
    createGameElements();
    addToCounterEverySec = setInterval(addToCounterFrom1To10, 20);
    start_game.innerHTML = "Guess My Number!";
    isGameStarted = true;

    } else {
        clearInterval(addToCounterEverySec);
        let guessedNumber = document.getElementById("counter");
        let random_number = document.getElementById("random-number");
        if (guessedNumber == random_number) {
            random_number.innerHTML = "You won!!";
        } else {
            random_number.innerHTML = "You lost :("
        }
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
    // Delete start and stop buttons.
    start_counter.remove();
    stop_counter.remove();

    // Change Div Style
    div_container.style = "border: 5px solid; margin: auto; width: 50%; padding: 10px; display: flex; flex-direction: column; align-items: center;"


    // Create new label.
    let label = document.createElement("label")
    label.style = "color: white; font-size: 200px;"
    label.innerHTML = generateRandomNumber();
    label.id = "random-number";
    

    div_container.appendChild(label);

}





