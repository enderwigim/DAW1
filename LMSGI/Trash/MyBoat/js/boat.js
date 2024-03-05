class Boat {
    segment;
    xPosition;
    yPosition;
    direction;

    constructor(segments, dx, dy, direction) {
        this.segments = segments;
        this.xPosition = [dx];
        this.yPosition = [dy];
        this.direction = direction;
    }

    AddPositionsWithDirec = function() {
        if (this.direction == "RIGHT") {
            for(let i = 1; i <= this.segments; i++) {
                this.xPosition[i] = this.xPosition[i - 1] + 1;
                this.yPosition[i] = this.yPosition[i - 1];
            }
        } 
        else if (this.direction == "LEFT") {
            for(let i = 1; i <= this.segments; i++) {
                this.xPosition[i] = this.xPosition[i - 1] - 1;
                this.yPosition[i] = this.yPosition[i - 1];
            }
        }
        else if (this.direction == "UP") {
            for(let i = 1; i <= this.segments; i++) {
                this.xPosition[i] = this.xPosition[i - 1];
                this.yPosition[i] = this.yPosition[i - 1] + 1;
            }
        }
        else if (this.direction == "DOWN") {
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


