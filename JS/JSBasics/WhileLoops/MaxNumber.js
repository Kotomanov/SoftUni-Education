function maxNumber(params) {
    
    let maxNumber = Number.NEGATIVE_INFINITY;
    let index = 0;
    
    while (params[index] !== "Stop") {
        let number = Number(params[index]);
        if (number > maxNumber) {
            maxNumber = number;
        }
        index++;
    }

    console.log(maxNumber);

}

maxNumber(["100", "99", "80", "70", "Stop"]);


maxNumber(["-10", "20", "-30", "Stop"]);


maxNumber(["45", "-20", "7", "99", "Stop"]);


maxNumber(["999", "Stop"]);


maxNumber(["-1", "-2", "Stop"]);


