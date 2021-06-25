function theSongOfTheWheels(params) {
    let number = Number(params[0]);
    let isNumberFound = false;
    let counter = 0;
    let password = ""; 

    for (let a = 1; a <= 9; a++) {
        for (let b = 1; b <= 9; b++) {
            for (let c = 1; c <= 9; c++) {
                for (let d = 1; d <= 9; d++) {
                    if (a < b && c > d) {
                        if (a * b + c * d == number) {
                                                       console.log(`Password: ${а}${b}${c}${d} `);
                                                       counter++;
                            if (counter == 4) {
                                password = abcd;
                                isNumberFound = true;
                                return;
                            }

                        }
                    }

                }

            }

        }

    }

    if (isNumberFound == false) {
        console.log("No!");
    }
}

theSongOfTheWheels(["11"]);

theSongOfTheWheels(["139"]);

theSongOfTheWheels(["110"]);