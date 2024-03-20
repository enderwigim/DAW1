class Boat {
    segment;
    /*
    xPosition;
    yPosition;
    */
    coordinates = []
    direction;

    constructor(segments, dx, dy, direction) {
        this.segments = segments;
        this.coordinates = [{
            x: dx,
            y: dy
        }]
        /*
        this.xPosition = [dx];
        this.yPosition = [dy];
        */
        this.direction = direction;
    }

    AddPositionsWithDirec = function() {
        if (this.direction == "RIGHT") {
            for(let i = 1; i <= this.segments; i++) {
                this.coordinates.push({
                    x: this.coordinates[i - 1]["x"] + 1,
                    y: this.coordinates[i - 1]["y"],
                })
                
                /*
                this.xPosition[i] = this.xPosition[i - 1] + 1;
                this.yPosition[i] = this.yPosition[i - 1];
                */
            }
        } 
        else if (this.direction == "LEFT") {
            for(let i = 1; i <= this.segments; i++) {
                this.coordinates.push({
                    x: this.coordinates[i - 1]["x"] - 1,
                    y: this.coordinates[i - 1]["y"]
                })
                
                /*
                this.xPosition[i] = this.xPosition[i - 1] - 1;
                this.yPosition[i] = this.yPosition[i - 1];
                */
            }
        }
        else if (this.direction == "UP") {
            for(let i = 1; i <= this.segments; i++) {
                this.coordinates.push({
                    x: this.coordinates[i - 1]["x"],
                    y: this.coordinates[i - 1]["y"] + 1
                })
                
                /*
                this.xPosition[i] = this.xPosition[i - 1];
                this.yPosition[i] = this.yPosition[i - 1] + 1;
                */
            }
        }
        else if (this.direction == "DOWN") {
            for(let i = 1; i <= this.segments; i++) {
                this.coordinates.push({
                    x: this.coordinates[i - 1]["x"],
                    y: this.coordinates[i - 1]["y"] - 1
                })
                
                /*
                this.xPosition[i] = this.xPosition[i - 1];
                this.yPosition[i] = this.yPosition[i - 1] - 1;
                */
            }
        }
    }
    GetCoordsBySegmentText = function() {
        let textWithCoords = ""
        for (let i = 0; i < this.coordinates.length; i++) {
            textWithCoords += "(" + this.coordinates[i]["x"]+ "," + this.coordinates[i]["y"] + ") / ";
        }
        textWithCoords += this.direction
        return textWithCoords;
    }
    GetBoatCoords = function() {
        return this.coordinates;
    }

}


