// alert("Hola Mundo");


// edad = confirm("Eres mayor de edad?");
// if (edad) {
    //     alert("DISFRUTA xD")
    // } else {
        //     alert("Te falta leche todavia.")
        // }
        
// let edad;
// let nombre;
// edad = prompt("Introduce tu edad");
// nombre = prompt("Introduce tu nombre");

// if(edad >= 18 && nombre == 'Santiago') {
//     alert("Eres mayor de edad y eres " + nombre)
// }
// else if (edad >= 18 || nombre == 'Santiago') {
//     if (edad >= 18) {
//         alert("Eres mayor de edad")
//     } else {
//         alert("Eres Santiago")
//     }
// }
// else {
//     alert("Todavía no eres mayor de edad")
// };

//while
// let x=1;

// while(x<= 100) {
//     document.write(x);
//     document.write('<br>');
//     x++;
// }

//for
// for(let f=1;f<=100;f++) {
//     document.write(f + ' ');
// }

//do while
// let valor;
// do {
//     valor = prompt("Introduce un valor en 0 y 999 (con 0 terminas)")
//     document.write('El numero ' + valor + ": ")
//     if (valor < 10) {
//         document.write('Tiene un digito');
//     }
//     else if (valor < 100) {
//         document.write('Tiene dos digitos');
//     }
//     else {
//         document.write('Tiene tres digitos');
//     }
//     document.write('<br>')
// } while(valor == 0);

//Ejemplo1
// let number = 1;
// while (number <= 100) {
//     if (number % 2 == 0) {
//         document.write(number + "<br>");
//     }
//     number++;
// }

//Ej2
// let sum = 0;
// for(let i=1; i <= 10; i++) {
//     sum += i;
// }
// document.write(sum);

//Ej3

const random_number = Math.floor(Math.random()*10)+1;
let founded = false;

for(let i = 1; i <= 3 && !founded; i++) {
    let num = parseInt(prompt("Enter a number"));
    if (num === random_number) {
        founded = true;
        alert("Well done! You win!")
    }
    else if (3 - i != 0){
        alert("You still have " + (3 - i) + " tries");
    }

}
if (!founded) {
    alert("Computer wins!");
}