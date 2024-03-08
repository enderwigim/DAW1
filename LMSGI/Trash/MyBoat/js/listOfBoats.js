class ListOfBoats {
    boatList = [];
    ammountOfSegments = [];
    maxSegments = 3;

    createBoats = function(ammount, mapHeight, mapWidth) {
        for(let i = 1; i <= ammount; i++) {
            let randomX = this.GetRandomNumber(mapHeight);
            let randomY = this.GetRandomNumber(mapWidth);
            let segment = this.GetRandomNumber(this.maxSegments);
            let direction = this.SetDirection(randomX, randomY, segment, mapHeight, mapWidth);

            this.ammountOfSegments.push(segment);
            let newBoat = new Boat(segment, randomX, randomY, direction)
            newBoat.AddPositionsWithDirec();
            this.boatList.push(newBoat);
        }
    };
    GetRandomNumber = function(max) {
        return Math.floor(Math.random() * max) + 1;
    };
    SetDirection = function(x, y, segment, mapHeight, mapWidth) {
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
