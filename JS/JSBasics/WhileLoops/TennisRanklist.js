function tennisRanklist(params) {
    let gamesCount = Number(params[0]);
    let playerPoints = Number(params[1]);
    let pointsSum = 0;
    let winsCount = 0;

    for (let i = 2; i < gamesCount + 2; i++) {
        if (params[i] === "W") {
            playerPoints += 2000;
            pointsSum += 2000;
            winsCount++;
        }
        else if (params[i] === "SF") {
            playerPoints += 720;
            pointsSum += 720;
        }

        else if (params[i] === "F") {
            playerPoints += 1200;
            pointsSum += 1200;
        }

    }

    console.log(`Final points: ${playerPoints}`);
    console.log(`Average points: ${Math.floor(pointsSum / gamesCount)}`);
    console.log(`${((winsCount / gamesCount) * 100).toFixed(2)}%`);

}

tennisRanklist(["5", "1400", "F", "SF", "W", "W", "SF"]);


tennisRanklist(["4", "750", "SF", "W", "SF", "W"]);
