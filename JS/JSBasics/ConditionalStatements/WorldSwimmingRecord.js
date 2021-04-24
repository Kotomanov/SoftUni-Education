function worldSwimmingRecord(input) {
    let recordInseconds = Number(input[0]);
    let distance = Number(input[1]);
    let secondsPerMeter = Number(input[2]);
    let delayTime = Math.floor(distance / 15) * 12.5;
    let ivansTime = distance * secondsPerMeter + delayTime;
    let timeDelta = Math.abs(ivansTime - recordInseconds);

    if (ivansTime < recordInseconds) {
        console.log(`Yes, he succeeded! The new world record is ${ivansTime.toFixed(2)} seconds.`);
    } else {
        console.log(`No, he failed! He was ${timeDelta.toFixed(2)} seconds slower.`)
    }
}

worldSwimmingRecord(["10464", "1500", "20"])
worldSwimmingRecord(["55555.67", "3017", "5.03"])
worldSwimmingRecord(["1046", "100", "2"])