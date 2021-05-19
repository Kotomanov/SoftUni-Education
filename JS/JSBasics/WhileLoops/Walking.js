function walking(params) {
    let index = 0;
    let stepsMade = 0;

    while (index < params.length) {
        if (params[index] === "Going home") {
            index++;
        }
        stepsMade += Number(params[index]);
        index++;
    }

    if (stepsMade >= 10000) {
        stepsMade -= 10000;
        console.log("Goal reached! Good job!");
        console.log(`${stepsMade} steps over the goal!`);
    } else {
        stepsMade = 10000 - stepsMade;;
        console.log(`${stepsMade} more steps to reach goal.`);
    }
}

walking(["1000", "1500", "2000", "6500"]);

walking(["125", "250", "4000", "30", "2678", "4682"]);


walking(["1500", "300", "2500", "3000", "Going home", "200"]);


walking(["1500", "3000", "250", "1548", "2000", "Going home", "2000"]);


