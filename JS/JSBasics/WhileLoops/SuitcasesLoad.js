function suitcasesLoad(params) {
    let capacity = Number(params[0]);
    let index = 1;
    let outcome = "";
    let counter = 0;
    while (params[index] !== "End") {
        capacity -= Number(params[index]);
        index++;
        if (capacity < 0) {
            break;
        }
        counter++;
    }

    if (capacity >= 0) {
        outcome = "Congratulations! All suitcases are loaded!";
    }
    else {
        outcome = "No more space!";
    }
    console.log(outcome);
    console.log(`Statistic: ${counter} suitcases loaded.`);
}

suitcasesLoad(["550", "100", "252", "72", "End"]);

suitcasesLoad(["700.5", "180", "340.6", "126", "220"]);

suitcasesLoad(["1200.2", "260", "380.5", "125.6", "305", "End"]);



