function sequence2K1(params) {
    let number = Number(params[0]);
    let sum = 1;

    while (sum <= number) {
        console.log(sum);
        sum = 2 * sum + 1;
    }
}

sequence2K1(["3"]);

sequence2K1(["31"]);

sequence2K1(["17"]);

sequence2K1(["8"]);