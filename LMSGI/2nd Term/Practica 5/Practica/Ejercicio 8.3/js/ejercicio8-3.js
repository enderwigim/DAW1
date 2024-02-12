// Obtengo los elementos.
let start_counter = document.getElementById("start_counter");
let stop_counter = document.getElementById("stop_counter");


// Creo una función que utilice un contador, que sume uno y que modifique el texto del text_area.
let counter = 0;
function addToCounter() {
    let text_area = document.getElementById("counter");
    counter++;
    
    counter = 0;
    
    text_area.innerHTML = counter;
}

// Declaro mi variable para que funcione dentro del global-scope.
let addToCounterEverySec;

start_counter.addEventListener("click", function() {
    // Aquí, no solo activo mi intervalo, asino que seteo esa función a mi variable addToCounterEverySec.
    addToCounterEverySec = setInterval(addToCounter, 20)
})

stop_counter.addEventListener("click", function() {
    //Utilizo clearInterval para que frene a la función iniciada previamente. Guardada previamente en mi variable.
    clearInterval(addToCounterEverySec);
})