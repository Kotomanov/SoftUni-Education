function smallShop(params) {
    let item = params[0];
    let city = params[1];
    let qty = Number(params[2]);
    let totalAmount = 0;

    if (city == "Varna") {
        switch (item) {
            case "coffee": totalAmount = qty * 0.45; break;
            case "water": totalAmount = qty * 0.70; break;
            case "beer": totalAmount = qty * 1.10; break;
            case "sweets": totalAmount = qty * 1.35; break;
            case "peanuts": totalAmount = qty * 1.55; break;

            default:
                break;
        }
    }

    else if (city == "Plovdiv") {
        switch (item) {
            case "coffee": totalAmount = qty * 0.40; break;
            case "water": totalAmount = qty * 0.70; break;
            case "beer": totalAmount = qty * 1.15; break;
            case "sweets": totalAmount = qty * 1.30; break;
            case "peanuts": totalAmount = qty * 1.50; break;

            default:
                break;
        }
    }

    else if (city == "Sofia") {
        switch (item) {
            case "coffee": totalAmount = qty * 0.50; break;
            case "water": totalAmount = qty * 0.80; break;
            case "beer": totalAmount = qty * 1.20; break;
            case "sweets": totalAmount = qty * 1.45; break;
            case "peanuts": totalAmount = qty * 1.60; break;

            default:
                break;
        }
    }
    console.log(totalAmount);
}

smallShop(["coffee", "Varna", "2"])
smallShop(["peanuts", "Plovdiv", "1"])
smallShop(["beer", "Sofia", "6"])
smallShop(["water", "Plovdiv", "3"])
smallShop(["sweets", "Sofia", "2.23"])

