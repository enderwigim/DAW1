
let button = document.getElementById('mybutton');
button.addEventListener("click", function() {
    document.getElementById('demo').innerHTML = document.getElementById('intro').innerHTML;
    let link = document.getElementsByTagName('a');
    link[0].href = "https://www.google.com";
    document.getElementById('intro').style.textAlign = "justify";
})

