let map  = {
    height: 10,
    width: 10,

    



}


let enemyBoats = {
    maxSegments: 3,
    enemyBoats: [],
    ammountOfSegments: [],

    createBoats: function() {
        for(let i = 1; i <= 5; i++) {
            let randomX = this.GetRandomNumber(height);
            let randomY = this.GetRandomNumber(weight);
            this.enemyBoats.push(new Boat(randomX, randomY));
        }
    },

    GetRandomNumber: function(max) {
        return Math.floor(Math.random() * max) + 1;
    },

    destroyBoat: function(index) {
        this.enemyBoats.splice(index, 1)
    },

    attackBoat: function(attackX, attackY) {
        for(let i = 0; i < this.enemyBoats.length; i++) {
            if (attackX == this.enemyBoats[i].GetX() && attackY == this.enemyBoats[i].GetY()) {
                return i;
            } 
            
        }
        return -1;
    },

    CountBoats: function() {
        return this.enemyBoats.length;
    },

}

function ListOfBoats(mapHeight, mapWidth) {
    this.boatList = [];
    this.ammountOfSegments = [];
    this.maxSegments = 3;

    this.createBoats = function(ammount) {
        for(let i = 1; i <= ammount; i++) {
            let randomX = this.GetRandomNumber(mapHeight);
            let randomY = this.GetRandomNumber(mapWidth);
            let segment = this.GetRandomNumber(this.maxSegments);
            let direction = this.SetDirection(randomX, randomY, segment, mapWidth, mapHeight);
            this.enemyBoats.push(new Boat(segment, randomX, randomY, direction));
        }
    };
    this.GetRandomNumber = function(max) {
        return Math.floor(Math.random() * max) + 1;
    };
    this.SetDirection = function(x, y, segment, mapWidth, mapHeight) {
        let direction;
        if (x - segment <= 0) {
            direction = "RIGHT";
        } else if (x - segment >= mapWidth) {
            direction = "LEFT";
        } else if (y - segment <= 0) {
            direction = "UP";
        } else if (y - segment >= mapHeight) {
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
    }

}
function Boat(segments, dx, dy, direction) {
    this.segments = segments;
    this.xPosition = [dx];
    this.yPosition = [dy];
    this.direction = direction;
    

    this.AddPositionsWithDirec = function() {
        if (direction = "RIGHT") {
            for(let i = 1; i < this.segments; i++) {
                this.xPosition[i] = this.xPosition[i - 1] + 1;
                this.yPosition[i] = this.yPosition[i - 1];
            }
        } 
        else if (direction = "LEFT") {
            for(let i = 1; i < this.segments; i++) {
                this.xPosition[i] = this.xPosition[i - 1] - 1;
                this.yPosition[i] = this.yPosition[i - 1];
            }
        }
        else if (direction = "UP") {
            for(let i = 1; i < this.segments; i++) {
                this.xPosition[i] = this.xPosition[i - 1];
                this.yPosition[i] = this.yPosition[i - 1] + 1;
            }
        }
        else if (direction = "DOWN") {
            for(let i = 1; i < this.segments; i++) {
                this.xPosition[i] = this.xPosition[i - 1];
                this.yPosition[i] = this.yPosition[i - 1] - 1;
            }
        }
    }

}

let gameOn = true;
let gameSetted = false;
let ammountOfBoats = 5;

while (gameOn) {
    if (!gameSetted) {
        map.createBoats()
        gameSetted = true;
    }
    alert(map.Check());
    let attackX = prompt("En que posición de x esta?");
    let attackY = prompt("En que posición de y esta?");
    let boatAttacked = map.attackBoat(attackX, attackY);
    if (boatAttacked == -1) {
        alert("Ups, you missed.")
    } else {
        map.destroyBoat(boatAttacked);
    }

    if (map.CountBoats() == 0) {
        gameOn = false;
        alert("Ganaste");
    } else {
        alert("Todavia te quedan: " + map.CountBoats() + "barcos.")
    }
}
