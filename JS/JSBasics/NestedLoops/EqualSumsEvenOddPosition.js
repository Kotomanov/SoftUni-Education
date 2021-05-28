function equalSumsEvenOddPosition(params) {
    let firstNumber = Number(params[0]);
    let secondNumber = Number(params[1]);
    let number = "";
    let evenNumbersSum = 0;
    let oddNumbersSum = 0;
    let outcome ="";

    for (let index = firstNumber; index <= secondNumber; index++) {
        number = "" + index;
        for (let i = 0; i < number.length; i++) {
            let digit = Number(number[i]);
            if (i % 2 == 0) {
                evenNumbersSum += digit;
            } else {
                oddNumbersSum += digit;
            }
        }

        if (evenNumbersSum == oddNumbersSum) {
            outcome+=index+" ";
        }
        evenNumbersSum = 0;
        oddNumbersSum = 0;
    }

    console.log(outcome);
}

equalSumsEvenOddPosition(["100000", "100050"]);


equalSumsEvenOddPosition(["123456", "124000"]);


equalSumsEvenOddPosition(["299900","300000"]);


equalSumsEvenOddPosition(["100115","100120"]);
