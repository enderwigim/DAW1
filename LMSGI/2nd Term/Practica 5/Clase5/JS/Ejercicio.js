let input_text = document.getElementById("colorFondo");
let button = document.getElementById("cambiarColor");

// <button id="cambiarColor">Cambiar</button>
let p = document.createElement("p");
p.id= "left_p";
let p_text = document.createTextNode("Te quedan:" + input_text.maxLength);
p.appendChild(p_text);

document.body.appendChild(p);



/* button.addEventListener("click", function() {
    
    document.body.style.backgroundColor = input_text.value;
})
*/

input_text.addEventListener("keyup", function() {
    let p = document.getElementById("left_p");
    p.innerHTML = "Te quedan " + (input_text.maxLength - input_text.value.length)
})
