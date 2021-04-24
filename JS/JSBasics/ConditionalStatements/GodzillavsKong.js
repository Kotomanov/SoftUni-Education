function godzillavsKong(input) {
    let movieBudget = Number(input[0]);
    let statistsCount = Number(input[1]);
    let clothesPrice = Number(input[2]);

    let dekorsAmount = movieBudget / 10;
    let clothesTotalAmount = statistsCount * clothesPrice;

    if (statistsCount > 150) {
        clothesTotalAmount *= 0.9;
    }

    let totalMovieAmount = dekorsAmount + clothesTotalAmount;
    let moneyleft = Math.abs(movieBudget - totalMovieAmount);

    if (movieBudget >= totalMovieAmount) {
        console.log("Action!")
        console.log(`Wingard starts filming with ${moneyleft.toFixed(2)} leva left.`);
    } else {
        console.log("Not enough money!")
        console.log(`Wingard needs ${moneyleft.toFixed(2)} leva more.`)
    }

}
godzillavsKong(["20000", "120", "55.5"])
godzillavsKong(["15437.62", "186", "57.99"])
godzillavsKong(["9587.88", "222", "55.68"])
godzillavsKong(["20", "12", "5"])