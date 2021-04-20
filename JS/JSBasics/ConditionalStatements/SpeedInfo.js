function speedInfo(input) {
    let speed = Number(input[0]);
    let result;
    if (speed <= 10) {
        result = "slow";
    } else if (speed <= 50) {
        result = "average";
    }
    else if (speed <= 150) {
        result = "fast";
    }
    else if (speed <= 1000) {
        result = "ultra fast";
    }
    else if (speed > 1000){
        result = "extremely fast";
    }

    console.log(result)
}
speedInfo(["49.5"])
speedInfo(["3500"])
speedInfo(["8"])
speedInfo(["160"])
speedInfo(["126"])