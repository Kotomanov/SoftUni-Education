function highJump(params) {
    let targetedHeigth = Number(params[0]);
    let startingHeigth = targetedHeigth - 30;
    let jumpsCount = 0;
    let failsCount = 0;
    let successHeigth = 0; 
    let failHeigth = 0; 

    for (let i = 1; i <= array.length; i++) {
        if (Number(params[i]) < startingHeigth) { // fails
            failHeigth = Number(params[i]);
            failsCount++;
            if (failsCount >= 3) {
                break;//i = array.length;
            }

        }
        else {
            startingHeigth += 5;//increase by 5 cm
            successHeigth = Number(params[i]);
        }

        jumpsCount++;
    }

    if (condition) { // success 
        console.log(`Tihomir succeeded, he jumped over ${successHeigth} cm after ${jumpsCount} jumps.`);
    } else { // fails
        console.log(`Tihomir failed at ${failHeigth}cm after ${jumpsCount} jumps.`);
    }
}

highJump(["231", "205", "212", "213", "228", "229", "230", "235"]);

highJump(["250", "225", "224", "225", "228", "231", "235", "234", "235"]);

