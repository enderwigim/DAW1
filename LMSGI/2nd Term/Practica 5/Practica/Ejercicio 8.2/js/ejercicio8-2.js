let ul = document.getElementById("list");
let add_element_btn = document.getElementById("add_element");
let delete_last_btn = document.getElementById("delete_last_element");


add_element_btn.addEventListener("click", function() {
    // Le pediremos al usuario que ingrese un texto nuevo.
    let new_text = prompt("Añade un nuevo elemento.");
    // Si el texto nuevo, no se encuentra vacio, lo añadiremos.
    // No queremos añadir elementos vacios a la lista.
    if (new_text !== '') {
        let li = document.createElement("li");

        let checkbox = document.createElement("input");
        checkbox.type = "checkbox";
        
        let li_text = document.createTextNode(new_text);
        li.appendChild(checkbox);
        li.appendChild(li_text);
        ul.appendChild(li);
    } else {
        alert("El elemento agregado, estaba vacio. Completa el espacio.")
    }
    
})

delete_last_btn.addEventListener("click", function() {
    let ul_every_element = ul.getElementsByTagName("li");
    ul_every_element[ul_every_element.length - 1].remove();

})

// With this, we'll create an eventListenert for the father, the UL.
ul.addEventListener("click", function(e) {
    // Once ul was clicked, we'll triger a function that recieves e as a parameter.
    // e is used in JS as an event.
    // After that, we will use target to select the item clicked, and we will check if it was an input.
    if(e.target.nodeName == "INPUT") {
        // We will select the parent, the LI, which has a text added and we will set a new style to it.
        let li = e.target.parentElement;
        
        if (li.style.textDecoration != 'line-through'){
            li.style.textDecoration = 'line-through';

        } else {
            li.style.textDecoration = 'none';
        }
        
    }
})