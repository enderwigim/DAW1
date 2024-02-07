let ul = document.getElementById("list");
let add_element_btn = document.getElementById("add_element");
let delete_last_btn = document.getElementById("delete_last_element");

add_element_btn.addEventListener("click", function() {
    let new_text = prompt("Añade un nuevo elemento.");
    let li = document.createElement("li");
    let li_text = document.createTextNode(new_text);
    li.appendChild(li_text);
    ul.appendChild(li);
})

delete_last_btn.addEventListener("click", function() {
    let ul_every_element = ul.getElementsByTagName("li");
    ul_every_element[ul_every_element.length - 1].remove();

})

