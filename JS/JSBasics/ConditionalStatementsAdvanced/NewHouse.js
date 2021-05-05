function newHouse(params) {
    let flowerType = params[0];
    let flowersCount = Number(params[1]);
    let budget = Number(params[2]);
    let moneyAmount = 0;

    if (flowerType == "Roses") {
        moneyAmount = flowersCount * 5;
        if (flowersCount > 80) {
            moneyAmount *= 0.9;
        }
    } else if (flowerType == "Dahlias") {
        moneyAmount = flowersCount * 3.80;
        if (flowersCount > 90) {
            moneyAmount *= 0.85;
        }
    } else if (flowerType == "Tulips") {
        moneyAmount = flowersCount * 2.80;
        if (flowersCount > 80) {
            moneyAmount *= 0.85;
        }
    } else if (flowerType == "Narcissus") {
        moneyAmount = flowersCount * 3;
        if (flowersCount < 120) {
            moneyAmount *= 1.15;
        }
    } else if (flowerType == "Gladiolus") {
        moneyAmount = flowersCount * 2.50;
        if (flowersCount < 80) {
            moneyAmount *= 1.2;
        }
    }


    if (moneyAmount <= budget) {
        budget -= moneyAmount;
        console.log(`Hey, you have a great garden with ${flowersCount} ${flowerType} and ${budget.toFixed(2)} leva left.`);
    } else {
        moneyAmount -= budget;
        console.log(`Not enough money, you need ${moneyAmount.toFixed(2)} leva more.`);
    }

}

newHouse(["Roses", "55", "250"]);


newHouse(["Tulips", "88", "260"]);


newHouse(["Narcissus", "119", "360"]);


newHouse(["Gladiolus", "880", "1260"]);