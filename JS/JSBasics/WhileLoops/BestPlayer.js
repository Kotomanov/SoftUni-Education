function bestPlayer(params) {
    let index = 0;
    let playerName = params[index];
        let goalsCount = Number(params[index+1]);
    let bestPlayerName = "";
    let bestPlayerScore = -1; 
    let outcome = "";
    

    while (playerName !== "END") {
        
        if (goalsCount > bestPlayerScore) {
            bestPlayerScore =  goalsCount;
            bestPlayerName = playerName;
        }

        if (bestPlayerScore>=10) {
            break;//?
        }

        index++;
    }
    console.log(`${bestPlayerName} is the best player!`);
    outcome +=`He has scored ${bestPlayerScore} goals `;
    if (bestPlayerScore>=3) {
        outcome +="and made a hat-trick !!!";
        //console.log(`He has scored ${bestPlayerScore} goals and made a hat-trick !!!`);
    } 
    console.log(outcome);
}

bestPlayer(["Neymar", "2", "Ronaldo", "1", "Messi", "3", "END"]);

bestPlayer(["Neymar", "2", "Ronaldo", "1", "Messi", "10"]);

bestPlayer(["Silva", "5", "Harry", "Kane", "10"]);