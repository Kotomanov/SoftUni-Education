function minNumber(params) {
    let numbersCount = Number(params[0]);
    let minNumber = Number.MAX_VALUE;

    for (let i = 1; i <= numbersCount; i++) {
        let number = Number(params[i]);
        if (number < minNumber) {
            minNumber = number;
        }
    }

    console.log(minNumber);
}

minNumber(["2", "100", "99"]);


minNumber(["3", "-10", "20", "-30"]);


minNumber(["4", "45", "-20", "7", "99"]);


minNumber(["2", "-1", "-2"]);

minNumber(["1", "999"]);
