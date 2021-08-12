function easterEggs(params) {
    let eggsCount = Number(params[0]);
    let redEggsCount = 0;
    let orangeEggsCount = 0;
    let blueEggsCount = 0;
    let greenEggsCount = 0;
    let maxCount = -1;
    let maxColor = "";

    for (let e = 1; e <= eggsCount; e++) {
        if (params[e] === "red") {
            redEggsCount++;
            if (maxCount < redEggsCount) {
                maxCount = redEggsCount;
                maxColor = "red";
            }
        } else if (params[e] === "orange") {
            orangeEggsCount++;
            if (maxCount < orangeEggsCount) {
                maxCount = orangeEggsCount;
                maxColor = "orange";
            }
        } else if (params[e] === "blue") {
            blueEggsCount++;
            if (maxCount < blueEggsCount) {
                maxCount = blueEggsCount;
                maxColor = "blue";
            }
        } else if (params[e] === "green") {
            greenEggsCount++;
            if (maxCount < greenEggsCount) {
                maxCount = greenEggsCount;
                maxColor = "green";
            }
        }
    }

    console.log(`Red eggs: ${redEggsCount}`);
    console.log(`Orange eggs: ${orangeEggsCount}`);
    console.log(`Blue eggs: ${blueEggsCount}`);
    console.log(`Green eggs: ${greenEggsCount}`);
    console.log(`Max eggs: ${maxCount} -> ${maxColor}`);
}

easterEggs(["7", "orange", "blue", "green", "green", "blue", "red", "green"]);


easterEggs(["4", "blue", "red", "blue", "orange"]);