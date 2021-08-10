function easterDecoration(params) {
    let customersCount = Number(params[0]);
    let itemsCount = 0;
    let customerTotalAmount = 0;
    let totalSum = 0;

    for (let i = 1; i <= params.length; i++) {

        if (params[i] == "basket") {
            customerTotalAmount += 1.50;
            itemsCount++;
        } else if (params[i] == "wreath") {
            customerTotalAmount += 3.80;
            itemsCount++;
        }
        else if (params[i] == "chocolate bunny") {
            customerTotalAmount += 7;;
            itemsCount++;
        }

        if (params[i] == "Finish") {

            if (itemsCount % 2 == 0) {
                //totalSum *= 0.80
                customerTotalAmount *= 0.80;
            }
            totalSum += customerTotalAmount;
            console.log(`You purchased ${itemsCount} items for ${customerTotalAmount.toFixed(2)} leva.`);
            customerTotalAmount = 0;
            itemsCount = 0;
        }
    }
    console.log(`Average bill per client is: ${(totalSum / customersCount).toFixed(2)} leva.`)

}

easterDecoration(["1", "basket", "wreath", "chocolate bunny", "wreath", "basket", "chocolate bunny", "Finish"]);

easterDecoration(["2", "basket", "wreath", "chocolate bunny", "Finish", "wreath", "chocolate bunny", "Finish"])

