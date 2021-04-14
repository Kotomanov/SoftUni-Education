function birthdayParty(input) {
    let hallRent = Number(input[0]);
    let cakePrice = hallRent * 0.20;
    let drinksPrice = cakePrice * 0.55;
    let animatorRate = hallRent / 3 ;
    let totalAmount = hallRent + cakePrice + drinksPrice + animatorRate;
    console.log(`${totalAmount}`);
}
birthdayParty(["3720"])