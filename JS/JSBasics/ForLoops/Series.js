function series(params) {
    let budget = Number(params[0]);

    for (let index = 2; index < params.length; index++) {
        if (index % 2 == 0) {
            if (params[index] == "Thrones") {
                budget -= 0.5 * (Number(params[index + 1]));
            } else if (params[index] == "Lucifer") {
                budget -= 0.6 * (Number(params[index + 1]));
            }
            else if (params[index] == "Protector") {
                budget -= 0.7 * (Number(params[index + 1]));
            }
            else if (params[index] == "TotalDrama") {
                budget -= 0.8 * (Number(params[index + 1]));
            }
            else if (params[index] == "Area") {
                budget -= 0.9 * (Number(params[index + 1]));
            }
            else {
                budget -= Number(params[index + 1]);
            }
        }
    }

    if (budget >= 0) {
        console.log(`You bought all the series and left with ${budget.toFixed(2)} lv.`);
    } else {
        console.log(`You need ${(budget * -1).toFixed(2)} lv. more to buy the series!`);
    }

}

series(["10", "3", "Thrones", "5", "Riverdale", "5", "Gotham", "2"]);


series(["25", "6", "Teen Wolf", "8", "Protector", "5", "TotalDrama", "5", "Area", "4", "Thrones", "5", "Lucifer", "9"]);
