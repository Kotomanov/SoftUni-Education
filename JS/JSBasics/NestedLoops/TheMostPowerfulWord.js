function theMostPowerfulWord(params) {
    let index = 0;
    let outcome = "";
    let wordPower = 0;
    let sumOfChars = 0;

    while (params[index] != "End of words") {
        for (let i = 0; i < params[index].length; i++) {
            sumOfChars += params[index][i].charCodeAt(0);
            if (params[index][0] == 'a' ||
                params[index][0] == 'e' ||
                params[index][0] == 'i' ||
                params[index][0] == 'o' ||
                params[index][0] == 'u' ||
                params[index][0] == 'A' ||
                params[index][0] == 'E' ||
                params[index][0] == 'I' ||
                params[index][0] == 'O' ||
                params[index][0] == 'U') {//'a', 'e', 'i', 'o', 'u', 'y'  or capital 
                sumOfChars *= params[index].length;
            }
            else {
                sumOfChars /= params[index].length;
                sumOfChars = Math.floor(sumOfChars);

            }
        }



        if (sumOfChars > wordPower) {
            wordPower = sumOfChars;
            outcome = params[index];
            sumOfChars = 0;
        }
        index++;

    }

    console.log(`The most powerful word is ${outcome} - ${wordPower}`);

}

theMostPowerfulWord(["The", "Most", "Powerful", "Word", "Is", "Experience", "End of words"]);

theMostPowerfulWord(["But", "Some", "People", "Say", "It's", "LOVE", "End of words"]);

