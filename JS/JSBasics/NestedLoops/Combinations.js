function combinations(params) {
    let number = Number(params[0]);
    let counter = 0;
    for (let i = 0; i <= number; i++) {
        for (let j = 0; j <= number; j++) {
            for (let k = 0; k <= number; k++) {
                if (i + j + k === number) {
                    counter++;
                }
            }
        }

    }
    console.log(counter);
}
combinations(["25"]);

combinations(["20"]);