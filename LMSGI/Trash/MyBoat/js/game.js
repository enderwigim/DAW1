// This is the map, it will be the controller of the game.
let map  = {
    height: 10,
    width: 10,
    enemyBoats: new ListOfBoats(),
    /*takenPositions: [{
        x: -1,
        y: -1
    }],
    */
    // This will create all the enemies
    CreateEnemyBoats: function(ammount) {
        for(let i = 1; i <= ammount; i++) {
            let randomX = GetRandomNumber(this.height);
            let randomY = GetRandomNumber(this.width);
            if (!this.IsPositionOcuppied(this.height, this.width, this.enemyBoats.ReturnEveryTakenPosition())){
                let newBoat = this.enemyBoats.createBoats(this.height, this.width, randomX, randomY)
                this.takenPositions.push(newBoat.GetBoatCoords())
            } else {
                i--;
            }
        }
        
    },

    IsPositionOcuppied: function(newX, newY, takenPositions) {
        for(let i = 0; i < takenPositions.length; i++) {
            if (newX == takenPositions[i]["x"] && newY == takenPositions[i]["y"]){
                return true;
            }
        }
        return false;
    },


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
GetRandomNumber = function(max) {
    return Math.floor(Math.random() * max) + 1;
};


let gameOn = true;
let gameSetted = false;
let ammountOfBoats = 5;


while (gameOn) {
    if (!gameSetted) {
        map.CreateEnemyBoats(ammountOfBoats, map.height, map.width);
        gameSetted = true;
    }
    alert(map.enemyBoats.ReturnEveryBoatCoordsInString());
    /*
    let attackX = prompt("x");
    let attackY = prompt("y");
    map.attackBoat(attackX, attackY);
    */
    gameOn = false;
    
}



