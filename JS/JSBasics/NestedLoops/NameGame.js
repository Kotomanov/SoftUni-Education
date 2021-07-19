function nameGame(params) {
    let index = 0;
    let name = "";
    let playerPoints = 0;
    let bestPlayerPoints = 0;
    let playerName = "";
    let bestPlayerName = "";
    let counter = 0;

    while (params[index] !== "Stop") {
        if (isNaN(params[index])) {
            name = params[index];
            for (let i = 0; i < name.length; i++) {
                index++;
                if (name[i].charCodeAt(0) == Number(params[index])) {
                    playerPoints += 10;
                }
                else {
                    playerPoints += 2;
                }
                playerName = name;

            }

            if (bestPlayerPoints <= playerPoints) {

                if (counter <= 2) {
                    bestPlayerPoints = playerPoints;
                    bestPlayerName = playerName;
                    playerPoints = 0;
                    
                }
                counter++;

            }
            index++;
        }
    }

    console.log(`The winner is ${bestPlayerName} with ${bestPlayerPoints} points!`);
}

nameGame(["Ivan", "73", "20", "98", "110", "Ivo", "80", "65", "87", "Stop"]);


nameGame(["Pesho", "124", "34", "111", "97", "99", "Gosho", "98", "124", "88", "76", "18", "Stop"]);
