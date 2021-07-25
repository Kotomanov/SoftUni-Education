function favoriteMovie(params) {
    let index = 0;
    let sumOfLetters = 0;
    let counter = 0;
    let bestMovie = "";
    let highestRating = 0;
    while (params[index] !== "STOP") {
        if (counter == 7) {
            console.log("The limit is reached.");
            break;
        }

        for (let i = 0; i < params[index].length; i++) {
            let letter = params[index][i].charCodeAt(0);
            sumOfLetters += letter;
            if (letter >= 97 && letter <= 122) {
                sumOfLetters -= 2 * (params[index].length);
            }
            else if (letter >= 65 && letter <= 90) {
                sumOfLetters -= params[index].length;
            }
        }

        if (sumOfLetters > highestRating) {
            highestRating = sumOfLetters;
            bestMovie = params[index];
        }

        sumOfLetters = 0;
        index++;
        counter++;
    }

    console.log(`The best movie for you is ${bestMovie} with ${highestRating} ASCII sum.`);

}

favoriteMovie(["Matrix", "Breaking bad", "Legend", "STOP"]);


favoriteMovie(["Wrong turn", "The maze", "Area 51", "Night Club", "Ice age", "Harry Potter", "Wizards"]);


favoriteMovie(["The maze", "School story 2", "Shrek 2", "Ice age", "STOP"]);


