function summerOutfit(params) {
    let temperature = Number(params[0]);
    let timeOfTheDay = params[1];
    let outfit;
    let shoes;

    if (timeOfTheDay == "Morning") {
        if (temperature >= 25) {
            outfit = "T-Shirt";
            shoes = "Sandals";
        } else if (temperature > 18) {
            outfit = "Shirt";
            shoes = "Moccasins";
        } else if (temperature >= 10) {
            outfit = "Sweatshirt";
            shoes = "Sneakers";
        }
    }
    else if (timeOfTheDay == "Afternoon") {
        if (temperature >= 25) {
            outfit = "Swim Suit";
            shoes = "Barefoot";
        } else if (temperature > 18) {
            outfit = "T-Shirt";
            shoes = "Sandals";
        } else if (temperature >= 10) {
            outfit = "Shirt";
            shoes = "Moccasins";
        }
    }
    else if (timeOfTheDay == "Evening") {
        outfit = "Shirt";
        shoes = "Moccasins";
    }

    console.log(`It's ${temperature} degrees, get your ${outfit} and ${shoes}.`);
}

summerOutfit(["16", "Morning"]);


summerOutfit(["22", "Afternoon"]);


summerOutfit(["28", "Evening"]);


summerOutfit(["40", "Morning"]);