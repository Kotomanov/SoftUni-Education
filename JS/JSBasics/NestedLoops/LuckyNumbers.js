function luckyNumbers(params) {
    let number = Number(params[0]);
    let firstNumber = 0;
    let secondNumber = 0;
    let outcome = "";

    for (let i = 1; i <= 9; i++) {
        for (let j = 1; j <= 9; j++) {
            for (let k = 1; k <= 9; k++) {
                for (let l = 1; l <= 9; l++) {
                    firstNumber = i + j;
                    secondNumber = k + l;
                    if (firstNumber === secondNumber) {
                        if (number % firstNumber == 0) {
                            outcome += i.toString() + j.toString() + k.toString() + l.toString() + " ";
                        }

                    }

                }

            }

        }

    }

    console.log(outcome);

}

luckyNumbers(["3"]);

luckyNumbers(["7"]);

luckyNumbers(["24"]);