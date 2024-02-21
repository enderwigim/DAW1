let insertColumn = document.getElementById("insert-column");
let deleteRow = document.getElementById("delete-row");
let changeText = document.getElementById("change-text");

function CreateColumns(columnNum) {
    let tr = document.createElement("tr");
    let table = document.getElementById("myTable")
    for (let i = 1; i <= columnNum; i++) {
        let th = document.createElement("th");
        th.innerHTML = "Celda " + i;
        tr.appendChild(th);
    }
    table.appendChild(tr);
}

function DeleteRow(rowNumber) {
    let wasDeleted = false;
    let everyTR = document.getElementsByTagName("tr");
    if ( rowNumber > 0 && rowNumber <= everyTR.length) {
        everyTR[(rowNumber - 1)].remove();
        wasDeleted = true;
    }
    return wasDeleted;
}
// Esta función selecciona una celda utilizando el numero de fila y columna.
// Devuelve la celda, si existe, sino devuelve un booleano false.
function SelectCell(rowNumber, columnNum) {
    let everyTR = document.getElementsByTagName("tr");
    if (rowNumber <= everyTR.length) {
        let everyThInTR = everyTR[rowNumber - 1].children;
        if (columnNum <= everyThInTR.length) {
            let tHSelected = everyThInTR[columnNum - 1];
            return tHSelected;
        }
    }
    return false; 
    
    
}

insertColumn.addEventListener("click", function() {
    let columnNumbers = prompt("¿Cuantas columnas quieres?");
    if (columnNumbers <= 0) {
        alert("No puedes ingresar columnas negativas");
    } else {
        CreateColumns(columnNumbers);
    }
})

deleteRow.addEventListener("click", function() {

    let rowNumber = prompt("¿Que fila quieres borrar?");
    if (!DeleteRow(rowNumber)){
        alert("No pudo borrarse. La fila no puede ser negativa, y tiene que existir.");
    }
  })

changeText.addEventListener("click", function() {
    let input = document.getElementById("myInput");
    if (input.value != "") {
        let rowNumber = parseInt(prompt("¿Que fila quieres cambiar."));
        let columnNum = parseInt(prompt("¿Que columna?"));
        if (rowNumber <= 0 || columnNum <= 0) {
            alert("No existe eso.");
        } else if (isNaN(columnNum) || isNaN(rowNumber)){
            alert("No existen esas columnas.");
        }
        else {
            
            let cellSelected = SelectCell(rowNumber, columnNum);
            if (cellSelected != false) {
                cellSelected.innerHTML = input.value; 
            } else {
                alert("Esa celda no existe.");
            }
        }
    }
    else {
        alert("There's no text in the input.");
    }
})


