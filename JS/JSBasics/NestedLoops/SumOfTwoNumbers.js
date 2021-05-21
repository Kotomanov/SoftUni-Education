function SumOfTwoNumbers(params) {
    let firstNumber = Number(params[0]);
    let secondNumber = Number(params[1]);
    let magicalNumber = Number(params[2]);
    let totalCount = 0;
    let magicalNumberCount = 0;

    for (let i = firstNumber; i <= secondNumber; i++) {
        for (let j = firstNumber; j <= secondNumber; j++) {
            totalCount++;
            if (i + j === magicalNumber) {
                magicalNumberCount++;
                console.log(`Combination N:${totalCount} (${i} + ${j} = ${magicalNumber})`);
                return;
            }
        }
    }

    if (magicalNumberCount == 0) {
        console.log(`${totalCount} combinations - neither equals ${magicalNumber}`);
    }
}
SumOfTwoNumbers(["1", "10", "5"]);


SumOfTwoNumbers(["23", "24", "20"]);


SumOfTwoNumbers(["88", "888", "1000"]);

SumOfTwoNumbers(["88", "888", "2000"]);
