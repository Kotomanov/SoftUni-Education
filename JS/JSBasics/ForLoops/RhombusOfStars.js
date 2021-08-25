function rhombusOfStars(params) {
    let number = Number(params[0]);
    let outcome = "";

    for (let row = 0; row < number; row++) {
        for (let col = 0; col <= row; col++) {
            outcome += "*"
        }
        console.log(outcome);
        outcome = ""
    }

}

rhombusOfStars(["1"]);

rhombusOfStars(["2"]);

rhombusOfStars(["3"]);

rhombusOfStars(["4"]);