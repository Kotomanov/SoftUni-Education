function areaOfFigures(input) {
    let shapeType = input[0];
    let sideA = input[1];
    let area = 0;
    if (shapeType === "square") {
        area = sideA * sideA;
    }
    else if (shapeType === "rectangle") {
        let sideB = input[2];
        area = sideA * sideB;
    }
    else if (shapeType === "circle") {
        area = Math.PI * sideA * sideA;
    }
    else if (shapeType === "triangle") {
        let sideB = input[2];
        area = (sideA * sideB)/2;
    }
    console.log(area.toFixed(3));
}
areaOfFigures(["triangle", "4.5", "20"])
areaOfFigures(["rectangle", "7", "2.5"])
areaOfFigures(["square", "5"])
areaOfFigures(["circle", "6"])


