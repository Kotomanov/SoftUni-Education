function petShop(input) {
    let dogsCount = Number(input[0]);
    let otherAnimalsCount = Number(input[1]);
    let dogsFoodAmout = 2.50 * dogsCount
    let otherAnimalsFoodAmount = 4 * otherAnimalsCount;
    let totalAmount = dogsFoodAmout + otherAnimalsFoodAmount;
    console.log(`${totalAmount} lv.`);
}
function petShop()