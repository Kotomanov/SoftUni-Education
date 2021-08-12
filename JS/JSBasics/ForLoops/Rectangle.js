function rectangle() {
    let outcome = "";
    for (let row = 0; row < 10; row++) {
        for (let col = 0; col < 10; col++) {
            outcome+="*";
        }

        console.log(outcome);
        outcome = "";
    }
}

rectangle()