function highJump(params) {
    let targetedHeigth = Number(params[0]); // record
    let startingHeigth = targetedHeigth - 30; //starts 30 cm under the record
    let jumpsCount = 0;
    let failsCount = 0;
    let successHeigth = 0;
    let failHeigth = 0;
    let failHeigthCm = 0;
    let isSuccessful = false; 

    for (let i = 1; i <= params.length; i++) {
        if (Number(params[i]) <= startingHeigth) { // fails as under the minimum
            failHeigth = Number(params[i]);
            //При три неуспешни скока на една и съща височина
            failsCount++;
            if (failsCount >= 3) {
                i = params.length + 1; //??
                //break; //??? because of jumpsCount..
            }
            //3 times fail at the same heigth 
        }
        else { // he manages to jump above the target height
            startingHeigth += 5;//increase by 5 cm
            failsCount = 0; //??
            successHeigth = Number(params[i]);
            if (startingHeigth<= successHeigth) { //has jumped successfully
                
            }
        }

        jumpsCount++;
    }

    if (isSuccessful) { // success 
        console.log(`Tihomir succeeded, he jumped over ${targetedHeigth} cm after ${jumpsCount} jumps.`);
    } else { // fails
        console.log(`Tihomir failed at ${failHeigth}cm after ${jumpsCount} jumps.`);
    }
}

highJump(["231", "205", "212", "213", "228", "229", "230", "235"]);

highJump(["250", "225", "224", "225", "228", "231", "235", "234", "235"]);

