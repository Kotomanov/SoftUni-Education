function challengeTheWedding(params) {
    let menCount = Number(params[0]);
    let womenCount = Number(params[1]);
    let tableCount = Number(params[2]);
    let outcome = "";

    for (let m = 1; m <= menCount; m++) {
        for (let w = 1; w <= womenCount; w++) {
            if (tableCount <= 0) {
                break;
            }
            outcome += `(${m} <-> ${w})` + " ";
            tableCount--;
        }

    }
    console.log(outcome);

}

challengeTheWedding(["2", "2", "6"]);

challengeTheWedding(["2", "2", "3"]);

challengeTheWedding(["5", "8", "40"]);