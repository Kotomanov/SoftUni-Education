function accountBalance(params) {
    let index = 0;
    let balance = 0;

    while (params[index] != "NoMoreMoney") {

        let amount = Number(params[index]);
        if (amount < 0) {
            console.log("Invalid operation!");
            break;
        }
        console.log(`Increase: ${amount.toFixed(2)}`)
        balance += amount;
        index++;
    }

    console.log(`Total: ${balance.toFixed(2)}`);

}

accountBalance(["5.51", "69.42", "100", "NoMoreMoney"]);


accountBalance(["120", "45.55", "-150"]);

