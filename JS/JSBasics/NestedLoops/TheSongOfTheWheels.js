function theSongOfTheWheels(params) {
    let number = Number(params[0]);
    let isNumberFound = false;
    let counter = 0;
    let password = "";
    let outcome = "";

    for (let a = 1; a <= 9; a++) {
        for (let b = 1; b <= 9; b++) {
            for (let c = 1; c <= 9; c++) {
                for (let d = 1; d <= 9; d++) {
                    if (a < b && c > d) {
                        if (a * b + c * d == number) {
                            outcome += a.toString() + b.toString() + c.toString() + d.toString() + " ";
                            counter++;
                            if (counter == 4) {
                                password = a.toString() + b.toString() + c.toString() + d.toString();
                                isNumberFound = true;
                            }
                        }
                    }
                }
            }
        }
    }

    console.log(outcome);

    if (isNumberFound == false) {
        console.log("No!");
    }
    else {
        console.log(`Password: ${password}`);
    }
}

theSongOfTheWheels(["11"]);

theSongOfTheWheels(["55"]);

theSongOfTheWheels(["139"]);

theSongOfTheWheels(["110"]);