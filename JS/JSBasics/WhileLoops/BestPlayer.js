function bestPlayer(params) {
    let index = 0;
    let goalsCount = -1;
    let bestPlayerName = "";
    let bestPlayerScore = -1;
    let outcome = "";

    while (params[index] !== "END") {

        if (index % 2 == 0) {
            goalsCount = Number(params[index + 1]);
            if (goalsCount > bestPlayerScore) {
                bestPlayerScore = goalsCount;
                bestPlayerName = params[index];
            }
        }

        if (bestPlayerScore >= 10) {
            break;
        }
        index++;
    }
    console.log(`${bestPlayerName} is the best player!`);
    outcome += `He has scored ${bestPlayerScore} goals.`;
    if (bestPlayerScore >= 3) {
        outcome = `He has scored ${bestPlayerScore} goals and made a hat-trick !!!`;
    }

    console.log(outcome);
}

bestPlayer(["Neymar", "2", "Ronaldo", "1", "Messi", "3", "END"]);

bestPlayer(["Neymar", "2", "Ronaldo", "1", "Messi", "10"]);

bestPlayer(["Silva", "5", "Kane", "10"]); //?

bestPlayer(["Neymar", "1", "Ronaldo", "2", "Messi", "2", "END"]);

bestPlayer(["Neymar", "2", "Ronaldo", "11"]);
