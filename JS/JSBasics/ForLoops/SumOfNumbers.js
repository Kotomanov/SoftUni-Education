function sumOfNumbers(params) {
    let input = params[0];
    let sum = 0;
    for (let i = 0; i < input.length; i++) {
        let number = Number(input[i]);
        sum += number;
    }

    console.log(`The sum of the digits is:${sum}`);
}

sumOfNumbers(["123"])

sumOfNumbers(["56789"])

sumOfNumbers(["1234"])