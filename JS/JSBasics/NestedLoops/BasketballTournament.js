function basketballTournament(params) {
    let index = 0;
    let winCount = 0;
    let lossCount = 0;
    let totalGamesCount = 0;
    let counter = 1;

    while (params[index] !== "End of tournaments") {
        if (isNaN(params[index])) {
            gameName = params[index];
            index++;
            let gamesCount = Number(params[index]);

            for (let g = 0; g <= gamesCount * 2; g++) {
                if (g % 2 !== 0) {
                    gameDeltaPoints = Number(params[index + g] - Number(params[index + 1 + g]));
                    if (gameDeltaPoints > 0) {
                        console.log(`Game ${counter} of tournament ${gameName}: win with ${gameDeltaPoints} points.`);
                        winCount++;
                    } else {
                        lossCount++;
                        console.log(`Game ${counter} of tournament ${gameName}: lost with ${gameDeltaPoints * -1} points.`)
                    }
                    counter++;
                    totalGamesCount++;
                }
            }
            counter = 1
        }
        index++;
    }

    console.log(`${((winCount / totalGamesCount) * 100).toFixed(2)}% matches win`);
    console.log(`${((lossCount / totalGamesCount) * 100).toFixed(2)}% matches lost`);

}

basketballTournament(["Dunkers", "2", "75", "65", "56", "73", "Fire Girls", "3", "67", "34", "83", "98", "66", "45", "End of tournaments"]);


basketballTournament(["Ballers", "3", "87", "63", "56", "65", "75", "64", "Sharks", "4", "64", "76", "65", "86", "68", "99", "45", "78", "End of tournaments"]);

