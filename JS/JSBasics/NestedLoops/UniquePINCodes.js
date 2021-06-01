function uniquePINCodes(params) {
    let firstNumberLimit = Number(params[0]);
    let secondNumberLimit = Number(params[1]);
    let thirdNumberLimit = Number(params[2]);
    let outcome = "";

    for (let i = 2; i <= firstNumberLimit; i++) {
        for (let j = 1; j <= secondNumberLimit; j++) {
            for (let k = 2; k <= thirdNumberLimit; k++) {
                if (i % 2 == 0 && k % 2 == 0 && (j == 2 || j == 3 || j == 5 || j == 7)) {
                    outcome+= i + " " + j + " " + k + " ";
                    console.log(outcome);
                    outcome = "";
                }

            }

        }

    }

    
}

uniquePINCodes(["3", "5", "5"]);

uniquePINCodes(["8", "2", "8"]);