function numbersDivisibleBy9(params) {
    let firstNumber = Number(params[0]);
    let secondNumber = Number(params[1]);
    let sum = 0;
    for (let i = firstNumber; i <= secondNumber; i++) {
        if (i % 9 == 0) {
            sum += i;
        }

    }
    console.log(`The sum: ${sum}`);
    for (let i = firstNumber; i <= secondNumber; i++) {
        if (i % 9 == 0) {
            console.log(i);
            sum += i;
        }

    }
}

numbersDivisibleBy9(["100", "200"]);