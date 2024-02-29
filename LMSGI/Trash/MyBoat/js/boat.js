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


class ListOfBoats {
    boatList = [];
    ammountOfSegments = [];
    maxSegments = 3;

    createBoats = function(ammount) {
        for(let i = 1; i <= ammount; i++) {
            let randomX = this.GetRandomNumber(mapHeight);
            let randomY = this.GetRandomNumber(mapWidth);
            let segment = this.GetRandomNumber(this.maxSegments);
            let direction = this.SetDirection(randomX, randomY, segment);

            this.ammountOfSegments.push(segment);
            let newBoat = new Boat(segment, randomX, randomY, direction)
            newBoat.AddPositionsWithDirec();
            this.boatList.push(newBoat);
        }
    };
    GetRandomNumber = function(max) {
        return Math.floor(Math.random() * max) + 1;
    };
    SetDirection = function(x, y, segment) {
        let direction;
        if (x - segment <= 0) {
            direction = "RIGHT";
        } else if (y - segment <= 0) {
            direction = "UP";
        } else if (x + segment >= mapWidth) {
            direction = "LEFT";
        } else if (y + segment >= mapHeight) {
            direction = "DOWN";
        } else {
            direction = this.SetRandomDirection();
        }
        return direction;
    };
    SetRandomDirection = function() {
        let posibility = this.GetRandomNumber(4);
        switch (posibility) {
            case 1:
                return "RIGHT"
                
            case 2:
                return "LEFT"
            case 3:
                return "UP"
            case 4:
                return "DOWN"
            default:
                return "RIGHT"
        }
    };
    ReturnEveryBoatCoords = function() {
        let boats = "";
        for(let i = 0; i < this.boatList.length; i++) {
            boats += "El bote " + i + "Tiene las siguientes coords: "
            boats += this.boatList[i].GetCoordsBySegmentText() + "\n";
        }
        return boats;
    }
}

/*
function ListOfBoats(mapHeight, mapWidth) {
    this.boatList = [];
    this.ammountOfSegments = [];
    this.maxSegments = 3;

    this.createBoats = function(ammount) {
        for(let i = 1; i <= ammount; i++) {
            let randomX = this.GetRandomNumber(mapHeight);
            let randomY = this.GetRandomNumber(mapWidth);
            let segment = this.GetRandomNumber(this.maxSegments);
            let direction = this.SetDirection(randomX, randomY, segment);

            this.ammountOfSegments.push(segment);
            let newBoat = new Boat(segment, randomX, randomY, direction)
            newBoat.AddPositionsWithDirec();
            this.boatList.push(newBoat);
        }
    };
    this.GetRandomNumber = function(max) {
        return Math.floor(Math.random() * max) + 1;
    };
    this.SetDirection = function(x, y, segment) {
        let direction;
        if (x - segment <= 0) {
            direction = "RIGHT";
        } else if (y - segment <= 0) {
            direction = "UP";
        } else if (x + segment >= mapWidth) {
            direction = "LEFT";
        } else if (y + segment >= mapHeight) {
            direction = "DOWN";
        } else {
            direction = this.SetRandomDirection();
        }
        return direction;
    };
    this.SetRandomDirection = function() {
        let posibility = this.GetRandomNumber(4);
        switch (posibility) {
            case 1:
                return "RIGHT"
                
            case 2:
                return "LEFT"
            case 3:
                return "UP"
            case 4:
                return "DOWN"
            default:
                return "RIGHT"
        }
    };

    this.ReturnEveryBoatCoords = function() {
        let boats = "";
        for(let i = 0; i < this.boatList.length; i++) {
            boats += "El bote " + i + "Tiene las siguientes coords: "
            boats += this.boatList[i].GetCoordsBySegmentText() + "\n";
        }
        return boats;
    }
}
*/
class Boat {
    segment;
    xPosition;
    yPosition;
    direction;

    Boat(segments, dx, dy, direction) {
        this.segments = segments;
        this.xPosition = [dx];
        this.yPosition = [dy];
        this.direction = direction;
    }

    AddPositionsWithDirec = function() {
        if (direction == "RIGHT") {
            for(let i = 1; i <= this.segments; i++) {
                this.xPosition[i] = this.xPosition[i - 1] + 1;
                this.yPosition[i] = this.yPosition[i - 1];
            }
        } 
        else if (direction == "LEFT") {
            for(let i = 1; i <= this.segments; i++) {
                this.xPosition[i] = this.xPosition[i - 1] - 1;
                this.yPosition[i] = this.yPosition[i - 1];
            }
        }
        else if (direction == "UP") {
            for(let i = 1; i <= this.segments; i++) {
                this.xPosition[i] = this.xPosition[i - 1];
                this.yPosition[i] = this.yPosition[i - 1] + 1;
            }
        }
        else if (direction == "DOWN") {
            for(let i = 1; i <= this.segments; i++) {
                this.xPosition[i] = this.xPosition[i - 1];
                this.yPosition[i] = this.yPosition[i - 1] - 1;
            }
        }
    }
    GetCoordsBySegmentText = function() {
        let textWithCoords = ""
        for (let i = 0; i < this.xPosition.length; i++) {
            textWithCoords += "(" + this.xPosition[i] + "," + this.yPosition[i] + ") / ";
        }
        textWithCoords += this.direction
        return textWithCoords;
    }

}

/*
function Boat(segments, dx, dy, direction) {
    this.segments = segments;
    this.xPosition = [dx];
    this.yPosition = [dy];
    this.direction = direction;
    

    this.AddPositionsWithDirec = function() {
        if (direction == "RIGHT") {
            for(let i = 1; i <= this.segments; i++) {
                this.xPosition[i] = this.xPosition[i - 1] + 1;
                this.yPosition[i] = this.yPosition[i - 1];
            }
        } 
        else if (direction == "LEFT") {
            for(let i = 1; i <= this.segments; i++) {
                this.xPosition[i] = this.xPosition[i - 1] - 1;
                this.yPosition[i] = this.yPosition[i - 1];
            }
        }
        else if (direction == "UP") {
            for(let i = 1; i <= this.segments; i++) {
                this.xPosition[i] = this.xPosition[i - 1];
                this.yPosition[i] = this.yPosition[i - 1] + 1;
            }
        }
        else if (direction == "DOWN") {
            for(let i = 1; i <= this.segments; i++) {
                this.xPosition[i] = this.xPosition[i - 1];
                this.yPosition[i] = this.yPosition[i - 1] - 1;
            }
        }
    }

    this.GetCoordsBySegmentText = function() {
        let textWithCoords = ""
        for (let i = 0; i < this.xPosition.length; i++) {
            textWithCoords += "(" + this.xPosition[i] + "," + this.yPosition[i] + ") / ";
        }
        textWithCoords += this.direction
        return textWithCoords;
    }
    
    

    

}
*/

let gameOn = true;
let gameSetted = false;
let ammountOfBoats = 5;

let enemyBoats = new ListOfBoats(map.height, map.width);
while (gameOn) {
    if (!gameSetted) {
        enemyBoats.createBoats(ammountOfBoats);
        gameSetted = true;
    }
    alert(enemyBoats.ReturnEveryBoatCoords());
    let attackX = prompt("x");
    let attackY = prompt("y");
    map.attackBoat(attackX, attackY);
    gameOn = false;
    
}
