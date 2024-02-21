
let map  = {
    height: 10,
    weight: 10,
    enemyBoats: [],

    createBoats: function() {
        for(let i = 1; i <= 5; i++) {
            let randomX = this.GetRandomNumber(this.height);
            let randomY = this.GetRandomNumber(this.weight);
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

    Check: function() {
        let everyPosition = "";
        for (let i = 0; i < this.CountBoats(); i++) {
            everyPosition += this.enemyBoats[i].GetX() + " " + this.enemyBoats[i].GetY() +  "\n";
        }
        return everyPosition;
    }





}
function Boat(dx, dy) {
    this.x = dx;
    this.y = dy,

    this.GetX = function() {
        return this.x;
    };

    this.GetY = function(){
        return this.y;
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
