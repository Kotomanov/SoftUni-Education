function vacation(params) {
    let excursionMoney = Number(params[0]);
    let availableMoney = Number(params[1]);
    let index = 2;
    let command;
    let spendCounter = 0;
    let daysCounter = 0;
    let isNotDone = true;

    while (isNotDone) {
        if (index % 2 == 0) {
            command = params[index];
        } else {
            if (command == "spend") {
                spendCounter++;
                daysCounter++;
                if (spendCounter == 5) {
                    console.log("You can't save the money.")
                    console.log(`${spendCounter}`);
                    isNotDone = false;
                    break;
                }
                availableMoney -= Number(params[index]);
                if (availableMoney < 0) {
                    availableMoney = 0;
                }
            } else if (command == "save") {
                spendCounter = 0;
                daysCounter++;
                availableMoney += Number(params[index]);
                if (availableMoney >= excursionMoney) {
                    console.log(`You saved the money for ${daysCounter} days.`);
                    isNotDone = false;
                    break;
                }
            }

        }

        index++;
    }
}

vacation(["2000", "1000", "spend", "1200", "save", "2000"]);


vacation(["110", "60", "spend", "10", "spend", "10", "spend", "10", "spend", "10", "spend", "10"]);


vacation(["250", "150", "spend", "50", "spend", "50", "save", "100", "save", "100"]);


vacation(["110", "60","spend", "10", "spend", "10", "spend", "10", "spend", "10", "spend", "10"]);