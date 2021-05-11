function divideWithoutRemainder(params) {
    let numbersCount = Number(params[0]);

    let divisibleByTwo = 0;
    let divisibleByThree = 0;
    let divisibleByFour = 0;

    for (let i = 1; i <= numbersCount; i++) {
        let number = Number(params[i]);
        if (number % 2 == 0) {
            divisibleByTwo++;
        }
        if (number % 3 == 0) {
            divisibleByThree++;
        }
        if (number % 4 == 0) {
            divisibleByFour++;
        }
    }

    divisibleByTwo = (divisibleByTwo / numbersCount * 100).toFixed(2);
    divisibleByThree = (divisibleByThree / numbersCount * 100).toFixed(2);
    divisibleByFour = (divisibleByFour / numbersCount * 100).toFixed(2);

    console.log(`${divisibleByTwo}%`);
    console.log(`${divisibleByThree}%`);
    console.log(`${divisibleByFour}%`);
}

divideWithoutRemainder(["10", "680", "2", "600", "200", "800", "799", "199", "46", "128", "65"]);


divideWithoutRemainder(["3", "3", "6", "9"]);

