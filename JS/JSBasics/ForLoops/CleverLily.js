function cleverLily(params) {
    let age = Number(params[0]);
    let washingmachinePrice = Number(params[1]);
    let toyPrice = Number(params[2]);
    let birthdayMoney = 0;
    let counter = 1;

    let hasManagedToGetWashingMachine;

    for (let i = 1; i <= age; i++) {
        if (i % 2 == 0) {
            birthdayMoney += counter * 10;
            counter++;
            birthdayMoney--;
        } else {
            birthdayMoney += toyPrice
        }
    }

    let delta = birthdayMoney - washingmachinePrice;

    if (delta >= 0) {
        hasManagedToGetWashingMachine = "Yes";

    } else {
        hasManagedToGetWashingMachine = "No";
        delta*=-1;
    }

    console.log(`${hasManagedToGetWashingMachine}! ${delta.toFixed(2)}`);
}

cleverLily(["10", "170", "6"]);
cleverLily(["21", "1570.98", "3"]);