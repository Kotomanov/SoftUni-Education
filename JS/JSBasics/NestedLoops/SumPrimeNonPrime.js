function sumPrimeNonPrime(params) {
    let index = 0;
    let primeSum = 0;
    let nonPrimeSum = 0;
    while (params[index] !== "stop") {
        let number = Number(params[index]);
        if (number < 0) {
            console.log("Number is negative.");
        } 
        else if (number == 2 || number == 3) {
            primeSum += Number(params[index]);
        } 
        else if (number % 2 == 0 || number % 3 == 0) {
            nonPrimeSum += Number(params[index]);
        } 
        else {
            primeSum += Number(params[index]);
        }
        index++;
    }

    console.log(`Sum of all prime numbers is: ${primeSum}`);
    console.log(`Sum of all non prime numbers is: ${nonPrimeSum}`);


}

sumPrimeNonPrime(["3", "9", "0", "7", "19", "4", "stop"]);


sumPrimeNonPrime(["0", "-9", "0", "stop"]);


sumPrimeNonPrime(["30", "83", "33", "-1", "20", "stop"]);

