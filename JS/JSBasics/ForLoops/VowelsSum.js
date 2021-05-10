function vowelsSum(params) {
    let input = params[0];
    let sumOfVowels = 0;

    for (let i = 0; i < input.length; i++) {
        switch (input[i]) {
            case "a": sumOfVowels++; break;
            case "e": sumOfVowels += 2; break;
            case "o": sumOfVowels += 4; break;
            case "u": sumOfVowels += 5; break;
            case "i": sumOfVowels += 3; break;

            default:
                break;
        }

    }
    console.log(sumOfVowels);

}

vowelsSum(["hello"]);

vowelsSum(["bamboo"]);

vowelsSum(["beer"])

vowelsSum(["hi"])