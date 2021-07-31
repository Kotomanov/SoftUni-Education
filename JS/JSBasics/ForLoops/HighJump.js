function highJump(params) {
    let targetedHeigth = Number(params[0]);
    let startingHeigth = targetedHeigth - 30;
    let jumpsCount = 0;
    let failsCount = 0;

    for (let i = 1; i <= params.length; i++) {
        jumpsCount++;
        if (Number(params[i]) <= startingHeigth) {
            failsCount++;
            if (failsCount == 3) {
                console.log(`Tihomir failed at ${Number(params[i])}cm after ${jumpsCount} jumps.`);
                break;
            }
        }
        else {
            if (Number(params[i]) > targetedHeigth) {
                console.log(`Tihomir succeeded, he jumped over ${targetedHeigth}cm after ${jumpsCount} jumps.`);
                break;
            }
            startingHeigth += 5;
            failsCount = 0;
        }
    }
}

highJump(["231", "205", "212", "213", "228", "229", "230", "235"]);

highJump(["250", "225", "224", "225", "228", "231", "235", "234", "235"]);

