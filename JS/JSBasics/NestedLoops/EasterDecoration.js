function easterDecoration(params) {
    let customersCount = Number(params[0]);
    //let basketCount = 0;
    // let chocolateBunniesCount = 0;
    //let wreathCount = 0;
    let itemsCount = 0;
    let customerTotalAmount = 0;
    let totalSum = 0;

    for (let i = 1; i <= params.length; i++) {

        if (params[i] == "basket") {
            //basketCount++;
            customerTotalAmount += 1.50;
            itemsCount++;
        } else if (params[i] == "wreath") {
            //wreathCount++;
            customerTotalAmount += 3.80;
            itemsCount++;
        }
        else if (params[i] == "chocolate bunny") {
            //chocolateBunniesCount++;
            customerTotalAmount += 7;;
            itemsCount++;
        }

        //customerTotalAmount = basketCount * 1.50 + chocolateBunniesCount * 7 + wreathCount * 3.90;
        totalSum += customerTotalAmount;
        if (itemsCount % 2 == 0) {
            totalSum *= 0.80;
        }
        if (params[i] == "Finish") {

            console.log(`You purchased ${itemsCount} items for ${customerTotalAmount} leva.`);
            customerTotalAmount = 0;
            itemsCount = 0;
        }


    }

    console.log(`Average bill per client is: ${(totalSum / customersCount).toFixed(2)} leva.`)

}

easterDecoration(["1", "basket", "wreath", "chocolate bunny", "wreath", "basket", "chocolate bunny", "Finish"]);

easterDecoration(["2", "basket", "wreath", "chocolate bunny", "Finish", "wreath", "chocolate bunny", "Finish"])

