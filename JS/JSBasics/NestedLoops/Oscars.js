function oscars(params) {
    let actorsName = params[0];
    let academyPoints = Number(params[1]);
    let number = Number(params[2]);


    for (let i = 3; i < params.length; i++) {
        if (i % 2 !== 0) {
            academyPoints += (Number(params[i + 1]) * params[i].length) / 2;
            if (academyPoints > 1250.5) { 
                console.log(`Congratulations, ${actorsName} got a nominee for leading role with ${academyPoints.toFixed(1)}!`);
                return;
            }
        }
    }

    if (academyPoints <= 1250.5) {
        let pointsNeeded = 1250.5 - academyPoints;
        console.log(`Sorry, ${actorsName} you need ${pointsNeeded.toFixed(1)} more!`);
    }
}

oscars(["Sandra Bullock", "340", "5", "Robert De Niro", "50", "Julia Roberts", "40.5", "Daniel Day-Lewis", "39.4", "Nicolas Cage", "29.9", "Stoyanka Mutafova", "33"]);

oscars(["Zahari Baharov", "205", "4", "Johnny Depp", "45", "Will Smith", "29", "Jet Lee", "10", "Matthew Mcconaughey", "39"]);
