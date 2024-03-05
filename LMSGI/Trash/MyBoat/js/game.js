let map  = {
    height: 10,
    width: 10,


    attackBoat: function(dx, dy) {
        enemyBoats.boatList.forEach(boat => {
            for (let i = 0; i < enemyBoats.boatList.length; i++) {
                if (dx == boat.xPosition[i] && dy == boat.yPosition[i]) {
                    alert("attacked");
                }
            }
        });
    }
}



let gameOn = true;
let gameSetted = false;
let ammountOfBoats = 5;

let enemyBoats = new ListOfBoats();
while (gameOn) {
    if (!gameSetted) {
        enemyBoats.createBoats(ammountOfBoats, map.height, map.width);
        gameSetted = true;
    }
    alert(enemyBoats.ReturnEveryBoatCoords());
    let attackX = prompt("x");
    let attackY = prompt("y");
    map.attackBoat(attackX, attackY);
    gameOn = false;
    
}



