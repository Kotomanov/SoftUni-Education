function volleyball(params) {
    let type = params[0];
    let holidaysCount = Number(params[1]);
    let weekendsToHomeTownCount = Number(params[2]);
    let result = 0;
    let weekendsPerYear = 48;
    let gamesOnHolidaysCount = holidaysCount * 2 / 3;

    result = (weekendsPerYear - weekendsToHomeTownCount) * 3 / 4 + gamesOnHolidaysCount + weekendsToHomeTownCount;

    if (type == "leap") {
        result *= 1.15;

    }
    console.log(Math.floor(result));
}
volleyball(["leap", "5", "2"]);


volleyball(["normal", "3", "2"]);


volleyball(["leap", "2", "3"]);


volleyball(["normal", "11", "6"]);


volleyball(["leap", "0", "1"]);


volleyball(["normal", "6", "13"]);
