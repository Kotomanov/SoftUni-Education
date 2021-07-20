function FootballTournament(params) {
    let teamName = params[0];
    let gamesPlayed = Number(params[1]);
    let winCount = 0;
    let equalCount = 0;
    let looseCount = 0;
    let winrate = 0;
    let gamePoints = 0;

    if (gamesPlayed == 0) {
        console.log(`${teamName} hasn't played any games during this season.`);
        return;
    }

    for (let i = 2; i < gamesPlayed + 2; i++) {

        if (params[i] == "W") {
            winCount++;
            gamePoints += 3;
        } else if (params[i] == "D") {
            equalCount++;
            gamePoints++;
        } else if (params[i] == "L") {
            looseCount++;
        }

    }

    winrate = (winCount / gamesPlayed) * 100;
    console.log(`${teamName} has won ${gamePoints} points during this season.`);
    console.log("Total stats:");
    console.log(`## W: ${winCount}`);
    console.log(`## D: ${equalCount}`);
    console.log(`## L: ${looseCount}`);
    console.log(`Win rate: ${winrate.toFixed(2)}%`);

}

FootballTournament(["Liverpool", "10", "W", "D", "D", "W", "L", "W", "D", "D", "W", "W"]);

FootballTournament(["Barcelona", "7", "W", "D", "L", "L", "W", "W", "D"]);

FootballTournament(["Chelsea", "0"]);
