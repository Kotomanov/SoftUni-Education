function primePairs(params) {
    let firstPairInitialNumber = Number(params[0]);
    let secondPairInitialNumber = Number(params[1]);
    let firstDelta = Number(params[2]);
    let secondDelta = Number(params[3]);

    for (let f = firstPairInitialNumber; f <= firstPairInitialNumber + firstDelta; f++) {
        for (let s = secondPairInitialNumber; s <= secondPairInitialNumber + secondDelta; s++) {
            if (f % 2 != 0 && f % 3 != 0 && f % 5 != 0 && f % 7 != 0 && s % 2 != 0 && s % 3 != 0 && s % 5 != 0 && s % 7 != 0) {
                console.log(f.toString() + s.toString());
            }
        }
    }
}

primePairs(["51", "75", "4", "7"]);

primePairs(["10", "20", "5", "5"]);

primePairs(["10", "30", "9", "6"]);

