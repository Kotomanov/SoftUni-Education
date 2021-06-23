function happyCatParking(params) {
    let daysCount = Number(params[0]);
    let hoursPerDay = Number(params[1]);
    let finalAmount = 0;
    let dailyAmount = 0;

    for (let day = 1; day <= daysCount; day++) {
        for (let hour = 1; hour <= hoursPerDay; hour++) {
            if (day % 2 == 0 && hour % 2 != 0) {
                dailyAmount += 2.50;
            }
            else if (day % 2 != 0 && hour % 2 == 0) {
                dailyAmount += 1.25;
            }
            else {
                dailyAmount++;
            }

        }
        console.log(`Day: ${day} – ${dailyAmount.toFixed(2)} leva`);
        finalAmount += dailyAmount;
        dailyAmount = 0;
    }

    console.log(`Total: ${finalAmount.toFixed(2)} leva`);
}

happyCatParking(["2", "5"]);

happyCatParking(["5", "2"]);