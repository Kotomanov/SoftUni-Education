function toyShop(input) {
    let excursionPrice = Number(input[0]);
    let puzzleCount = Number(input[1]);
    let dollsCount = Number(input[2]);
    let bearsCount = Number(input[3]);
    let minionsCount = Number(input[4]);
    let trucksCount = Number(input[5]);

    let truckAmount = trucksCount * 2;
    let bearsAmount = bearsCount * 4.10;
    let minionsAmount = minionsCount * 8.20;
    let dollsAmount = dollsCount * 3;
    let puzzleAmount = puzzleCount * 2.60;

    let toysCount = puzzleCount + dollsCount + bearsCount + minionsCount + trucksCount;
    let totalAmount = truckAmount + bearsAmount + minionsAmount + dollsAmount + puzzleAmount;
    
console.log();
    if (toysCount >= 50) {
        totalAmount *= 0.75;
    }

    totalAmount *= 0.9;
    
    let amountLeft =  Math.abs(excursionPrice - totalAmount );
    
    if (totalAmount >= excursionPrice) {
        console.log(`Yes! ${amountLeft.toFixed(2)} lv left.`);
    }
    else {
        console.log(`Not enough money! ${amountLeft.toFixed(2)} lv needed.`);
    }
}
toyShop(["320", "8", "2", "5", "5", "1"])
toyShop(["40.8", "20", "25", "30", "50", "10"])