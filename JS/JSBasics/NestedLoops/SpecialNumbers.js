function specialNumbers(params) {
    let specialNumber = Number(params[0]);
    let number = "";
    let counter = 0;
    let result = "";
    for (let n = 1111; n <= 9999; n++) {
        number = n.toString();
        for (let letter = 0; letter < number.length; letter++) {
            if (specialNumber % Number(number[letter]) == 0) {
                counter++;
                if (counter == 4) {
                    result += number + " ";
                }
            }
        }
        counter = 0;
    }

    console.log(result);
}

specialNumbers(["3"]);

specialNumbers(["11"]);

specialNumbers(["16"]);