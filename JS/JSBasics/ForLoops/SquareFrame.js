function squareFrame(params) {
    let number = Number(params[0]);
    let outcome = "";

    for (let row = 0; row < number; row++) {
        for (let col = 0; col < number; col++) {
            if (row == 0 || row == number - 1) {
                if (col == 0 || col == number - 1) {
                    outcome += "+ "
                } else {
                    outcome += "- "
                }

            } else {
                if (col == 0 || col == number - 1) {
                    outcome += "| "
                } else {
                    outcome += "- "
                }
            }
        }
        console.log(outcome);
        outcome = "";
    }
}

squareFrame(["3"]);

squareFrame(["5"]);

squareFrame(["9"]);