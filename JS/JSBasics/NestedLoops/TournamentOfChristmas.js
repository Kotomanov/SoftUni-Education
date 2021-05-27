function TournamentOfChristmas(params) {
    let wonGamesCount = 0;
    let lostGamesCount = 0;
    let moneyWon = 0;
    let totalMoneyWon = 0;
    let totalWinCount = 0;
    let totalLossCount = 0;
    let outcome = "";

    for (let i = 1; i < params.length; i++) {

        while (params[i] !== "Finish") {

            if (params[i] === "win") {
                wonGamesCount++;
                totalWinCount++;
                moneyWon += 20;
            } else if (params[i] === "lose") {
                lostGamesCount++;
                totalLossCount++;
            }

            i++;
        }

        if (wonGamesCount > lostGamesCount) {
            moneyWon *= 1.1;
        }
        totalMoneyWon += moneyWon;
        moneyWon = 0;
        wonGamesCount = 0;
        lostGamesCount = 0;
    }

    if (totalWinCount > totalLossCount) {
        totalMoneyWon *= 1.2;
        outcome = "won";

    } else {
        outcome = "lost";
    }

    console.log(`You ${outcome} the tournament! Total raised money: ${totalMoneyWon.toFixed(2)}`);
}

TournamentOfChristmas(["2", "volleyball", "win", "football", "lose", "basketball", "win", "Finish", "golf", "win", "tennis", "win", "badminton", "win", "Finish"]);

TournamentOfChristmas(["3", "darts", "lose", "handball", "lose", "judo", "win", "Finish", "snooker", "lose", "swimming", "lose", "squash", "lose", "table tennis", "win", "Finish", "volleyball", "win", "basketball", "win", "Finish"]);