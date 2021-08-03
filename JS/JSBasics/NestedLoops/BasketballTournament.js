function basketballTournament(params) {
    let index = 0;
    let winCount = 0;
    let lossCount = 0;
    let totalGamesCount = 0;

    while (params[index] !== "End of tournaments") {
        if (isNaN(params[index])) { // team name 
            for (let i = index + 1 ; i < Number(params[index + 1 * 2]); i++) { // 3 * 2 lines one our team, one the other 
                if (i%2==0) {
                    
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

