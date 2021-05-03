function newHouse(params) {
    let flowerType = params[0];
    let flowersCount = Number(params[1]);
    let budget = Number(params[2]);
    let moneyAmount = 0;

    if (flowerType = "Roses") {
        moneyAmount = flowersCount * 5;
    } else if (flowerType = "Dahlias") {
        moneyAmount = flowersCount * 3.80;
    } else if (flowerType = "Tulips") {
        moneyAmount = flowersCount * 2.80;
    } else if (flowerType = "Narcissus") {
        moneyAmount = flowersCount * 3;
    } else if (flowerType = "Gladiolus") {
        moneyAmount = flowersCount * 2.50;
    }




    console.log(`Hey, you have a great garden with ${flowersCount} ${flowerType} and ${budget.toFixed(2)} leva left.`);

    console.log(`Not enough money, you need ${budget.toFixed(2)} leva more.`);

}

newHouse(["Roses", "55", "250"]);


newHouse(["Tulips", "88", "260"]);


newHouse(["Narcissus", "119", "360"]);


newHouse(["Gladiolus", "880", "1260"]);