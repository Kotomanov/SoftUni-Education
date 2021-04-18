function fruitMarket(input) {
    let strawberryPrice = Number(input[0]);
    let bananasQuantity = Number(input[1]);
    let orangeQuantity = Number(input[2]);
    let raspberryQuantity = Number(input[3]);
    let strawberryQuantity = Number(input[4]);

    let raspberryPrice = strawberryPrice / 2;
    let orangePrice = raspberryPrice * 0.6;
    let bananaPrice = raspberryPrice * 0.20;

    let strawberryAmount = strawberryPrice * strawberryQuantity;
    let bananaAmount = bananaPrice * bananasQuantity;
    let orangeAmount = orangePrice * orangeQuantity;
    let raspberryAmount = raspberryPrice * raspberryQuantity; 

    let totalAmount = strawberryAmount + bananaAmount + orangeAmount + raspberryAmount;
    console.log(totalAmount);

}
fruitMarket(["63.5", "3.57", "6.35", "8.15", "2.5"])
