function traveling(params) {
    let destination;
    let excursionPrice = 0;
    let moneySaved = 0;
    for (let i = 0; i < params.length; i++) {

        if (params[i] === "End") {
            break;
        }

        if (isNaN(params[i])) {

            destination = params[i];
            i++;
            excursionPrice = Number(params[i]);
            i++;

            while (!isNaN(params[i])) {
                moneySaved += Number(params[i]);
                if (moneySaved >= excursionPrice) {
                    console.log(`Going to ${destination}!`);
                    break;
                }
            }

        }

    }
}

traveling(["Greece", "1000", "200", "200", "300", "100", "150", "240", "Spain", "1200", "300", "500", "193", "423", "End"]);


traveling(["France", "2000", "300", "300", "200", "400", "190", "258", "360", "Portugal", "1450", "400", "400", "200", "300", "300", "Egypt", "1900", "1000", "280", "300", "500", "End"]);

