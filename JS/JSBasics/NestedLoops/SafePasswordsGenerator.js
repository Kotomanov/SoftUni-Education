function safePasswordsGenerator(params) {
    let firstNumber = Number(params[0]);
    let secondNumber = Number(params[1]);
    let maxCount = Number(params[2]);
    let outcome = "";
    let firstSign = 35;
    let secondSign = 64;

    for (let a = 1; a <= firstNumber; a++) {
        for (let b = 1; b <= secondNumber; b++) {
            outcome += String.fromCharCode(firstSign) + String.fromCharCode(secondSign) + a + b + String.fromCharCode(secondSign) + String.fromCharCode(firstSign) + "|";
            maxCount--;
            if (maxCount == 0) {
                console.log(outcome)
                return;
            }
            firstSign++;
            if (firstSign == 56) {
                firstSign = 35;
            }
            secondSign++;
            if (secondSign == 97) {
                secondSign = 64;
            }
        }
    }
    console.log(outcome)
}

safePasswordsGenerator(["2", "3", "10"]);
safePasswordsGenerator(["20", "50", "10"]);