function theMostPowerfulWord(params) {
    let index = 0;
    let outcome = "";
    let wordPower = 0;
    while (params[index] != "End of words") {
        for (let i = 0; i < params[index].length; i++) {
            console.log(params[index][i]);

        }

        index++;
    }

    console.log(`The most powerful word is ${outcome} - ${wordPower}`);

}

theMostPowerfulWord(["The", "Most", "Powerful", "Word", "Is", "Experience", "End of words"]);

theMostPowerfulWord(["But", "Some", "People", "Say", "It's", "LOVE", "End of words"]);

