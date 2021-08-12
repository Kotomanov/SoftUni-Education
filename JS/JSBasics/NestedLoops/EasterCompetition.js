function easterCompetition(params) {
    let sweetBreadCount = Number(params[0]);
    let chefPoints = 0;
    let maxPoints = 0;
    let chefName = "";

    for (let i = 1; i < params.length; i++) {
        if (isNaN(params[i])) {
            if (params[i] == "Stop") {
                console.log(`${chefName} has ${chefPoints} points.`);
                if (chefPoints > maxPoints) {
                    maxPoints = chefPoints;
                    console.log(`${chefName} is the new number 1!`);
                }
                chefPoints = 0;
            } else { //name
                chefName = params[i];
            }

            // where to make 0 ???
        }

    }
}

easterCompetition(["3", "Chef Manchev", "10", "10", "10", "10", "Stop", "Natalie", "8", "2", "9", "Stop", "George", "9", "2", "4", "2", "Stop"]);


easterCompetition(["2", "Chef Angelov", "9", "9", "9", "Stop", "Chef Rowe", "10", "10", "10", "10", "Stop"]);
