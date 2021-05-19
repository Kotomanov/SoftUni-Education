function coins(params) {
    let amount = Number(params[0]);
    amount *= 100;
    let counter = 0;
    while (amount.toFixed(0) > 0) {
        if (amount - 200 >= 0) {
            amount -= 200;
            counter++;
             
        }
        else if (amount - 100 >= 0) {
            amount -= 100;
            counter++;
             
        }
        else if (amount - 50 >= 0) {
            amount -= 50;
            counter++;
             
        }
        else if (amount - 20 >= 0) {
            amount -= 20;
            counter++;
             
        }
       else if (amount - 10 >= 0) {
            amount -= 10;
            counter++;
             
        }
        else if (amount - 5 >= 0) {
            amount -= 5;
            counter++;
             
        }
        else if (amount - 2 >= 0) {
            amount -= 2;
            counter++;
             
        }
        else if (amount - 1 >= 0) {
            amount -= 1;
            counter++;
             
        }
    }

    console.log(counter);

}

coins(["2.73"]);
coins(["0.56"]);
coins(["1.23"]);
coins(["2"]);