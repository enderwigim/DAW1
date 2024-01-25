// Array Objetos
// let personas = [
//     { nombre: "Maria", edad: 25},
//     { nombre: "Carlos", edad: 20}
// ]; 

// for (let clave in personas) {
//     alert(personas[clave].nombre);
// }

//Crear una funcion que devuelva el ultimo elemento de un vector.
function last_element(array) {
    return array[array.length-1];
}
function first_element(array) {
    return array[array.length];
}
function sum_array(array) {
    let sum = 0;
    for (let i = 0; i < array.length; i++) {
        sum += array[i];
    };
    return sum;
};

let result = sum_array([1, 2, 3]);
document.write(result)