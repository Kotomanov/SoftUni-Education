function rectangleofNxNStars(params) {
    let number = Number(params[0]);
    let outcome = "";

    for (let row = 0; row < number; row++) {
        for (let col = 0; col < number; col++) {
            outcome += "*";
                    }
        console.log(outcome);
        outcome = "";
    }
}

rectangleofNxNStars(["2"]);

rectangleofNxNStars(["4"]);

rectangleofNxNStars(["6"]);