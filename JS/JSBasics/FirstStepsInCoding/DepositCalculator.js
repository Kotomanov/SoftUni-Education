function depositCalculator(input) {
    let amount = Number(input[0]);
    let durationInMonths = Number(input[1]);
    let interestRate = Number(input[2]);
    let interestAmount = amount * interestRate / 100;
    let finalAmount = amount + interestAmount * durationInMonths / 12;
    console.log(`${finalAmount.toFixed(2)}`);
}
depositCalculator(["200", "3", "5.7"])

