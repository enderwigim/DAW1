let ul = document.getElementById("list");
let add_element_btn = document.getElementById("add_element");
let delete_last_btn = document.getElementById("delete_last_element");

/* Como la función de crear objetos en la lista se ha vuelto extensa, y cada vez encuentro cosas para
agregar, creo que es optimo utilizar una función a parte de la creada en el listener.
Aún asi, dejaré comentado mi viejo listener aqui.

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
*/

// Crearemos nuestros nuevos elementos de manera dinamica con esta función.
function addNewLiElement(new_text) {
    // Creamos el li y el input, al cual asignamos el tipo de checkbox.
    let li = document.createElement("li");
    let checkbox = document.createElement("input");
    checkbox.type = "checkbox";

    // Crearemos un label, el cual contendrá la información que queremos agregar a la lista.
    let to_do_label = document.createElement('label');
    to_do_label.innerHTML = new_text;
    to_do_label.className = "to_do_label";
    // Tambien crearemos un label para la basura.
    let trash_label = document.createElement('label');
    trash_label.innerHTML = "🗑️";
    trash_label.className = "trash_label";


    // appendChild para cada apartado, en orden de visualización. Primero checkbox, luego texto y finalmente, label.
    
    li.appendChild(checkbox);
    li.appendChild(to_do_label);
    li.appendChild(trash_label);

    // Luego agarramos ese li y lo sumamos a ul.
    ul.appendChild(li);
}

// Esta función recibira un LI, el cual será el padre del input, y de los dos labels.
// De aquí se cambiará el estilo del textDecoration y se activará el checkbox o desactivara en conjunto.
function changeLineThrough(li_parent) {
    // Si el label donde se encuentra el texto añadido, no se encuentra tachado, lo tacharemos y activaremos el checkbox.
    if (li_parent.children[1].style.textDecoration != 'line-through'){
        li_parent.children[0].checked = true;
        li_parent.children[1].style.textDecoration = 'line-through';
        

    // En caso de que ya se encuentre tachado, le quitaremos eso y desactivaremos el checkbox.
    } else {
        li_parent.children[1].style.textDecoration = 'none';
        li_parent.children[0].checked = false;
    }
}

add_element_btn.addEventListener("click", function() {
    // Le pediremos al usuario que ingrese un texto nuevo.
    let new_text = prompt("Añade un nuevo elemento.");
    // Si el texto nuevo, no se encuentra vacio, lo añadiremos.
    // No queremos añadir elementos vacios a la lista.
    if (new_text !== '') {
        addNewLiElement(new_text);
    } else {
        alert("El elemento agregado, estaba vacio. Completa el espacio.")
    }
    
})

// Este botón solo borrará el ultimo archivo de la lista.
delete_last_btn.addEventListener("click", function() {
    let ul_every_element = ul.getElementsByTagName("li");
    ul_every_element[ul_every_element.length - 1].remove();

})

/* Dado a que queremos ver que ocurre cuando el usuario haga click en cualquiera de los distintos apartados de cada
<li>, le cederemos el evento al padre, y a partir del evento de click que se desate, actuaremos en consecuencia.
*/
ul.addEventListener("click", function(e) {
    /*Una vez algún sector del ul sea clickeado, se activará esta función, que utiliza e como paramentro.
    e es utilizado en JavaScript como el evento.
    Utilizaremos e.target, para actuar sobre el objeto que ha desatado el evento.*/
    
    // Revisaremos que sea un INPUT
    if(e.target.nodeName == "INPUT") {
        // Llamaremos a esta función, que tachará el texto del to_do_label y encenderá el checkbox.
        changeLineThrough(e.target.parentElement);
    }
    // Revisaremos si se hizo click sobre un LABEL y si <label> recibe la clase de "to_do_label".
    else if (e.target.nodeName == "LABEL" && e.target.className == "to_do_label") {
        // Con esto, tacharemos el texto y encenderemos el checkbox. Si esta ya tachado, podremos reactivarlo.
        changeLineThrough(e.target.parentElement);
    }
    else if (e.target.nodeName == "LABEL" && e.target.className == "trash_label") {
        // Si se da click a .trash_label, seleccionaremos al padre y lo borraremos.
        e.target.parentElement.remove();
    }
})