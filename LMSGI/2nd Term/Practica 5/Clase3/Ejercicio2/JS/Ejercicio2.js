function crear() {
    let nodotitle = document.createElement("title");
    let textAlign = document.createTextNode("Mi pagina dinamica");
    nodotitle.appendChild(textAlign);
    document.head.appendChild(nodotitle);

    // Create an H1
    let h1node = document.createElement("h1");
    let h1text = document.createTextNode("Sergio False");
    h1node.appendChild(h1text);
    document.body.appendChild(h1node);

    // Create a p
    let parraph = document.createElement("p");
    let ptext = document.createTextNode("Sergio ultra true");
    parraph.setAttribute("style", "font-style: italic");
    parraph.appendChild(ptext);
    document.body.appendChild(parraph);
}