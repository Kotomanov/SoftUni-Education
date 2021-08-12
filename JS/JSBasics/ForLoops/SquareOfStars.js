function squareOfStars(params) {
    let number = Number(params[0]);
    let outcome = "";

    for (let row = 0; row < number; row++) {
        for (let col = 0; col < number; col++) {
            outcome += "* ";
                    }
        console.log(outcome);
        outcome = "";
    }
}

squareOfStars(["2"]);

squareOfStars(["4"]);

squareOfStars(["6"]);