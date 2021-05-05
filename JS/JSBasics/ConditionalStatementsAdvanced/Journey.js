function journey(params) {
    let budget = Number(params[0]);
    let season = params[1];
    let location;
    let shelterType;


    if (season == "summer") {
        if (budget <= 100) {
            location = "Bulgaria"
            budget *= 0.30;
            shelterType = "Camp"
        } else if (budget <= 1000) {
            location = "Balkans"
            budget *= 0.40;
            shelterType = "Camp"
        }

        else if (budget > 1000) {
            location = "Europe"
            budget *= 0.90;
            shelterType = "Hotel"
        }
        
    } else if (season == "winter") {
        if (budget <= 100) {
            location = "Bulgaria"
            budget *= 0.70;
        } else if (budget <= 1000) {
            location = "Balkans"
            budget *= 0.80;
        }

        else if (budget > 1000) {
            location = "Europe"
            budget *= 0.90;
            
        }
        shelterType = "Hotel"
    }

    
    console.log(`Somewhere in ${location}`);
    console.log(`${shelterType} - ${budget.toFixed(2)}`);


}

journey(["50", "summer"]);

journey(["75", "winter"]);

journey(["312", "summer"]);

journey(["678.53", "winter"]);

journey(["1500", "summer"]);
