let map  = {
    height: 10,
    width: 10,
    enemyBoats: new ListOfBoats(),
    takenPositions: [],

    

    attackBoat: function(dx, dy) {
        this.enemyBoats.boatList.forEach(boat => {
            for (let i = 0; i < this.enemyBoats.boatList.length; i++) {
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


while (gameOn) {
    if (!gameSetted) {
        map.enemyBoats.createBoats(ammountOfBoats, map.height, map.width);
        gameSetted = true;
    }
    alert(map.enemyBoats.ReturnEveryBoatCoords());
    let attackX = prompt("x");
    let attackY = prompt("y");
    map.attackBoat(attackX, attackY);
    gameOn = false;
    
}



