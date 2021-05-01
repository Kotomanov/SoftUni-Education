function fruitShop(params) {
    let fruit = params[0];
    let dayOfWeek = params[1];
    let qty = Number(params[2]);
    let fruitPrice = -1;


    if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday") {
        if (fruit == "banana") {
            fruitPrice = 2.70;
        } else if (fruit == "apple") {
            fruitPrice = 1.25;
        }

        else if (fruit == "orange") {
            fruitPrice = 0.90;
        }

        else if (fruit == "grapefruit") {
            fruitPrice = 1.60;
        }

        else if (fruit == "kiwi") {
            fruitPrice = 3;
        }

        else if (fruit == "pineapple") {
            fruitPrice = 5.60;
        }

        else if (fruit == "grapes") {
            fruitPrice = 4.20;
        }

    } else if (dayOfWeek == "Monday"
        || dayOfWeek == "Tuesday"
        || dayOfWeek == "Wednesday"
        || dayOfWeek == "Thursday"
        || dayOfWeek == "Friday") {
        if (fruit == "banana") {
            fruitPrice = 2.50;
        } else if (fruit == "apple") {
            fruitPrice = 1.20;
        }

        else if (fruit == "orange") {
            fruitPrice = 0.85;
        }

        else if (fruit == "grapefruit") {
            fruitPrice = 1.45;
        }

        else if (fruit == "kiwi") {
            fruitPrice = 2.70;
        }

        else if (fruit == "pineapple") {
            fruitPrice = 5.50;
        }

        else if (fruit == "grapes") {
            fruitPrice = 3.85;
        }
    }


    if (fruitPrice != -1) {
        let totalAmount = qty * fruitPrice;

        console.log(totalAmount.toFixed(2));
    }

    else {
        console.log("error");
    }

}

fruitShop(["apple", "Tuesday", "2"])

fruitShop(["orange", "Sunday", "3"])

fruitShop(["kiwi", "Monday", "2.5"])

fruitShop(["grapes", "Saturday", "0.5"])

fruitShop(["tomato", "Monday", "0.5"])
