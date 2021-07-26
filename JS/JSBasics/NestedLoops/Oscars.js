function oscars(params) {
    let actorsName = params[0];
    let academyPoints = Number(params[1]);
    let number = Number(params[2]);


    for (let i = 3; i < number + 3; i++) {
        if (i % 2 !== 0) { // name
            for (let l = 0; l < params[i].length; l++) {
                let sandBox = params[i][l];
                academyPoints += sandBox.charCodeAt(0);//not ok

            }

            if (academyPoints >= 1250.5) { // in the forloopitself??
                console.log(`Congratulations, ${actorsName} got a nominee for leading role with ${academyPoints.toFixed(2)}!`);
                return;
            }

        } else { // grade

        }


    }



    if (academyPoints < 1250.5) {
        let pointsNeeded = 1250.5 - academyPoints;
        console.log(`Sorry, ${actorsName} you need ${pointsNeeded.toFixed(2)} more!`);
    }
}

oscars(["Sandra Bullock", "340", "5", "Robert De Niro", "50", "Julia Roberts", "40.5", "Daniel Day-Lewis", "39.4", "Nicolas Cage", "29.9", "Stoyanka Mutafova", "33"]);

oscars(["Zahari Baharov", "205", "4", "Johnny Depp", "45", "Will Smith", "29", "Jet Lee", "10", "Matthew Mcconaughey", "39"]);
