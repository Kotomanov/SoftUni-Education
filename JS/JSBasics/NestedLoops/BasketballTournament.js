function basketballTournament(params) {
    let index = 0;
    let winCount = 0;
    let lossCount = 0;
    let totalGamesCount = 0;

    while (params[index] !== "End of tournaments") {
        if (isNaN(params[index])) { // team name 
            for (let i = index + 1; i < Number(params[index + 1 * 2]); i++) { // 3 * 2 lines one our team, one the other 
                if (i % 2 == 0) {

                }

            }
        }


        index++;

    }
    let counter = 1;
    let gameDeltaPoints = 0;
    let gameName = "";

    for (let i = 0; i < params.length; i++) {
        if (isNaN(params[i])) {
            if (params[i] == "End of tournaments") {
                break;
            } else {
                i += 2;
                for (let j = i; j < Number(params[i]) * 2; j++) {


                }

            }
        }

    }

    while (params[index] !== "End of tournaments") {
        if (isNan(params[index])) { // name of a game
            gameName = params[index];
            index++; //to get to the count of games
            let gamesCount = Number(params[index]); // how many games follow
            for (let g = index; g < index + gamesCount * 2; g++) {
                if (counter % 2 !== 0) { // our team 
                    gameDeltaPoints = Number(params[index] - Number(params[index + 1])); // get the game outcome 
                    if (gameDeltaPoints > 0) { //we win
                        console.log(`Game ${counter} of tournament ${gameName}: win with ${gameDeltaPoints} points.`);
                        winCount++;
                    } else { // we loose
                        lossCount++;
                    }
                    totalGamesCount++;

                }

            }

        }
        index++;
    }

    console.log(`${((winCount / totalGamesCount) * 100).toFixed(2)}% matches win`);
    console.log(`${((lossCount / totalGamesCount) * 100).toFixed(2)}% matches lost`);

}

basketballTournament(["Dunkers", "2", "75", "65", "56", "73", "Fire Girls", "3", "67", "34", "83", "98", "66", "45", "End of tournaments"]);


basketballTournament(["Ballers", "3", "87", "63", "56", "65", "75", "64", "Sharks", "4", "64", "76", "65", "86", "68", "99", "45", "78", "End of tournaments"]);

