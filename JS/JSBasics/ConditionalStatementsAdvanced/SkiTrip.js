function skiTrip(params) {
    let daysCount = Number(params[0]);
    let roomType = params[1];
    let rateType = params[2];
    daysCount--;

    let totalAmount = 0;


    if (roomType == "room for one person") {
        totalAmount = daysCount * 18;
    } else if (roomType == "apartment") {
        totalAmount = daysCount * 25;
        if (daysCount > 15) {
            totalAmount*=0.5;
        } else if (daysCount >= 10) {
            totalAmount*=0.65;
        }

        else if (daysCount < 10) {
            totalAmount*=0.7;
        }
    }
    else if (roomType == "president apartment") {
        totalAmount = daysCount * 35;
        if (daysCount > 15) {
            totalAmount*=0.8;
        } else if (daysCount >= 10) {
            totalAmount*=0.85;
        }

        else if (daysCount < 10) {
            totalAmount*=0.9;
        }
    }

    if (rateType == "positive") {
        totalAmount *= 1.25;
    } else if (rateType == "negative") {
        totalAmount *= 0.9;
    }

    console.log(totalAmount.toFixed(2));
}

skiTrip(["14", "apartment", "positive"]);


skiTrip(["30", "president apartment", "negative"]);


skiTrip(["140", "apartment", "positive"]);


skiTrip(["12", "room for one person", "positive"]);


skiTrip(["2", "apartment", "positive"]);
