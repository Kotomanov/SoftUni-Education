function triangleOfDollars(params) {
    let number = Number(params[0]);
    let outcome = "";

    for (let row = 1; row <= number; row++) {
        for (let col = 1; col <= row; col++) {
            outcome += "$ "
        }
        console.log(outcome);
        outcome = "";
    }
}

triangleOfDollars(["9"]);

triangleOfDollars(["3"]);

triangleOfDollars(["8"]);