function sumSeconds(input) {
    let firstTime = Number(input[0]);
    let secondTime = Number(input[1]);
    let thirdTime = Number(input[2]);
    let sumOfSeconds = firstTime + secondTime + thirdTime;
    let minutes = Math.floor(sumOfSeconds / 60);
    let seconds = sumOfSeconds % 60;

    if (seconds < 10) {
        console.log(`${minutes}:0${seconds}`)
    }
    else {
        console.log(`${minutes}:${seconds}`)
    }
}

sumSeconds(["35", "45", "44"])
sumSeconds(["14", "12", "10"])
sumSeconds(["50", "50", "49"])
sumSeconds(["3", "1", "4"])
