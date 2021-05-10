function cleverLily(params) {
    let age = Number(params[0]);
    let washingmachinePrice = Number(params[1]);
    let toyPrice = Number(params[2]);
    let birthdayMoney = 0;
    let counter = 1;
    let toycount = 0;
    let hasManagedToGetWashingMachine;

    for (let i = 1; i <= age; i++) {
        if (i % 2 == 0) {
            birthdayMoney += counter * 10;
            counter++;
            birthdayMoney--;
        } else {
            toycount++;
        }
    }

    birthdayMoney += toyPrice * toycount;

    if (washingmachinePrice <= birthdayMoney) {
        hasManagedToGetWashingMachine = "Yes";
        birthdayMoney -= washingmachinePrice;

    } else {
        hasManagedToGetWashingMachine = "No";
        birthdayMoney = washingmachinePrice - birthdayMoney;
    }

    console.log(`${hasManagedToGetWashingMachine}! ${birthdayMoney.toFixed(2)}`);
}

cleverLily(["10", "170", "6"]);
cleverLily(["21", "1570.98", "3"]);