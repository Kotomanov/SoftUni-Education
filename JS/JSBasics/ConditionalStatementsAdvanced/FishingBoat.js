function fishingBoat(params) {
    let budget = Number(params[0]);
    let season = params[1];
    let peopleCount = Number(params[2]);
    let boatRent = 0;

    if (season == "Spring") {
        boatRent = 3000;
    } else if (season == "Summer" || season == "Autumn") {
        boatRent = 4200;
    }
    else if (season == "Winter") {
        boatRent = 2600;
    }

    if (peopleCount <= 6) {
        boatRent *= 0.9;
    } else if (peopleCount >= 12) {
        boatRent *= 0.75;
    }
    else {
        boatRent *= 0.85;
    }

    if (peopleCount % 2 == 0 && season != "Autumn") {
        boatRent *= 0.95;
    }

    if (boatRent <= budget) {
        budget-=boatRent;
        console.log(`Yes! You have ${budget.toFixed(2)} leva left.`);
    } else {
        
        boatRent -= budget;
        console.log(`Not enough money! You need ${boatRent.toFixed(2)} leva.`);
    }


}

fishingBoat(["3000", "Summer", "11"]);


fishingBoat(["3600", "Autumn", "6"]);

fishingBoat(["2000", "Winter", "13"]);

