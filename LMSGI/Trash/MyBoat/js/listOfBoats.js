class ListOfBoats {
    boatList = [];
    // ammountOfSegments = [];
    maxSegments = 3;

    createBoats = function(mapHeight, mapWidth, randomX, randomY) {
        
        // let randomX = GetRandomNumber(mapHeight);
        // let randomY = GetRandomNumber(mapWidth);
        let segment = GetRandomNumber(this.maxSegments);
        let direction = this.SetDirection(randomX, randomY, segment, mapHeight, mapWidth);

        // this.ammountOfSegments.push(segment);
        let newBoat = new Boat(segment, randomX, randomY, direction)
        newBoat.AddPositionsWithDirec();
        this.boatList.push(newBoat);
        return newBoat;
        
    }
    
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
        let posibility = GetRandomNumber(4);
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
    ReturnEveryBoatCoordsInString = function() {
        let boats = "";
        for(let i = 0; i < this.boatList.length; i++) {
            boats += "El bote " + i + "Tiene las siguientes coords: "
            boats += this.boatList[i].GetCoordsBySegmentText() + "\n";
        }
        return boats;
    }
    ReturnEveryTakenPosition = function() {
        let takenPositions = []
        for (let i = 0; i < this.boatList.length; i++) {
            takenPositions.push(this.boatList[i].GetBoatCoords())
        }
        return takenPositions;
    }


}
