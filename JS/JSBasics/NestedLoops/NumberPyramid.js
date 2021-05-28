function numberPyramid(params) {
    let number = Number(params[0]);
    let outcome = "";
    let counter = 1;

    for (let i = 1; i <= number; i++) {
        outcome = "";
        for (let j = 1; j <= i; j++) {
            if (counter <= number) {
                outcome += i + " ";
                counter++;
            }
        }
        console.log(outcome);
    }
}

numberPyramid(["3"]);

numberPyramid(["7"]);

numberPyramid(["15"]);

numberPyramid(["12"]);