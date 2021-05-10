function factorial(params) {
    let number = Number(params[0]);
    let factorial = 1;

    for (let i = 2; i <= number; i++) {
        factorial *= i;
    }
    console.log(factorial);

}

factorial(["4"]);

factorial(["8"]);

factorial(["5"]);

factorial(["3"]);