let insertColumn = document.getElementById("insert-column");
let deleteRow = document.getElementById("delete-row");

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
    let everyTR = document.getElementsByTagName("tr");
    everyTR[(rowNumber - 1)].remove();
}

function SelectCell(rowNumber, columnNum) {
    let everyTR = document.getElementsByTagName("tr");
    let everyThInTR = everyTR[rowNumber - 1].children;
    let tHSelected = everyThInTR[columnNum - 1];

    tHSelected.remove();
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
    if (rowNumber <= 0) {
        alert("No hay filas negativas.");
    } else {
        DeleteRow(rowNumber);
    }
})

deleteRow.addEventListener("click", function() {
    let rowNumber = prompt("¿Que fila quieres borrar?");
    let columnNum = prompt("¿Que columna?")
    if (rowNumber <= 0 && columnNum <= 0 && typeof(rowNumber) != ) {
        alert("No existe eso.");
    } else {
        SelectCell(rowNumber, columnNum);
    }
})