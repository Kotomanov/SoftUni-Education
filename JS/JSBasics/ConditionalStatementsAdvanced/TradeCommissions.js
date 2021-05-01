function tradeCommissions(params) {
    let city = params[0];
    let amount = Number(params[1]);
    let comission = -1;

    if (amount > 10000) {

        if (city == "Sofia") {
            comission = amount * 0.12;
        }
        else if (city == "Plovdiv") {
            comission = amount * 0.145;
        }

        else if (city == "Varna") {
            comission = amount * 0.13;
        }

    } else if (amount > 1000) {

        if (city == "Sofia") {
            comission = amount * 0.08;
        }
        else if (city == "Plovdiv") {
            comission = amount * 0.12;
        }

        else if (city == "Varna") {
            comission = amount * 0.1;
        }

    }
    else if (amount > 500) {

        if (city == "Sofia") {
            comission = amount * 0.07;
        }
        else if (city == "Plovdiv") {
            comission = amount * 0.08;
        }

        else if (city == "Varna") {
            comission = amount * 0.075;
        }

    }
    else if (amount >= 0) {

        if (city == "Sofia") {
            comission = amount * 0.05;
        }
        else if (city == "Plovdiv") {
            comission = amount * 0.055;
        }

        else if (city == "Varna") {
            comission = amount * 0.045;
        }

    }


    if (comission == -1) {
        console.log("error");
    } else {
        console.log(comission.toFixed(2));

    }
}

tradeCommissions(["Sofia", "1500"]);


tradeCommissions(["Plovdiv", "499.99"]);


tradeCommissions(["Varna", "3874.50"]);


tradeCommissions(["Kaspichan", "-50"]);
