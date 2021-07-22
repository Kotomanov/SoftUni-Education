function movieTickets(params) {
    let firstNumber = Number(params[0]);
    let secondNumber = Number(params[1]);
    let thirdNumber = Number(params[2]);

    for (let i = firstNumber; i < secondNumber; i++) { // maybe FirstNumber+1..
        for (let j = 1; j < thirdNumber; j++) {
            for (let k = 1; k < thirdNumber / 2; k++) {
                if (i % 2 !== 0 && (i + j + k) % 2 !== 0) {
                    console.log(`${String.fromCharCode(i)}-${j}${k}${i}`);
                }

            }

        }

    }

}

//movieTickets(["86", "88", "4"]);

//movieTickets(["71", "74", "6"]);

//movieTickets(["69", "72", "4 "]);

movieTickets(["76", "78", "7"]);

//movieTickets(["65", "91", "5"]);

//movieTickets(["89", "90", "9"]);

//movieTickets(["73", "91", "7"]);
