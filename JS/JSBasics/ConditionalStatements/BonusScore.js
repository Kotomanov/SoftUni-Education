function bonusScore(input) {
    let points = Number(input[0]);
    let bonusPoints = 0.0;
    if (points <= 100) {
        bonusPoints += 5;
    }
    else if (points > 1000) {
        bonusPoints += points * 0.10;
    }
    else {
        bonusPoints += points * 0.20;
    }

    if (points % 2 == 0) {
        bonusPoints += 1;
    }

    else if (points % 10 == 5) {
        bonusPoints += 2;
    }
    let totalPoints = points + bonusPoints;

    console.log(`${bonusPoints}`);
    console.log(`${totalPoints}`);

}

bonusScore(["2703"]);
bonusScore(["15875"]);
bonusScore(["175"]);