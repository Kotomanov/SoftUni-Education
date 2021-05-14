function minNumber(params) {
    let index = 0;
    let minNumber = Number.POSITIVE_INFINITY;
    while (params[index] !== "Stop") {
        let number = Number(params[index]);
        if (number < minNumber) {
            minNumber = number
        }
        index++;
    }

    console.log(minNumber);
}

minNumber(["100", "99", "80", "70", "Stop"]);



minNumber(["-10", "20", "-30", "Stop"]);


minNumber(["45", "-20", "7", "99", "Stop"]);


minNumber(["999", "Stop"]);

minNumber(["-1", "-2", "Stop"]);

