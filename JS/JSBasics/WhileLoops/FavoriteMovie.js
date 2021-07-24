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
            if (params[index][i] >= 97 && params[index][i] <= 122) { //97 - 122 lower case 
                sumOfLetters+= params[index][i].toCharCode(0);
            }
            else if (params[index][i] >= 65 && params[index][i] <= 90) { //65 - 90 upper case 
                sumOfLetters
            }
            if (sumOfLetters>highestRating) {
                highestRating = sumOfLetters;
                bestMovie = params[index];
            }

        }
        index++;
        counter++;
    }

    console.log(`The best movie for you is ${bestMovie} with ${highestRating} ASCII sum.`);

}

favoriteMovie(["Matrix", "Breaking bad", "Legend", "STOP"]);


favoriteMovie(["Wrong turn", "The maze", "Area 51", "Night Club", "Ice age", "Harry Potter", "Wizards"]);
