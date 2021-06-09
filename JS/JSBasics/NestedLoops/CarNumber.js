function carNumber(params) {
    let firstNumber = Number(params[0]);
    let secondNumber = Number(params[1]);
    let outcome = "";

    for (let f = firstNumber; f <= secondNumber; f++) {
        for (let s = firstNumber; s <= secondNumber; s++) {
            for (let t = firstNumber; t <= secondNumber; t++) {
                for (let v = firstNumber; v <= secondNumber; v++) {
                    if (f > v) {
                        if (f % 2 == 0 && v % 2 != 0 || f % 2 != 0 && v % 2 == 0) {
                            if ((s + t) % 2 == 0) {
                                outcome += f.toString() + s.toString() + t.toString() + v.toString() + " ";
                            }
                        }
                    }

                }

            }

        }

    }
    console.log(outcome);
}

carNumber(["2", "3"]);

carNumber(["3", "5"]);

carNumber(["5", "8"]);