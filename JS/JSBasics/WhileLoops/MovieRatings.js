function movieRatings(params) {
    let movieCount = Number(params[0]);
    let index = 1;
    let highestRating = -1;
    let lowestRating = 11;
    let bestMovieTitle = "";
    let lastMovieTitle = "";
    let totalRating = 0;
    let averageRating = 0;
    while (index <= movieCount * 2) {
        if (index % 2 == 0) {
            if (Number(params[index]) > highestRating) {
                highestRating = Number(params[index]);
                bestMovieTitle = params[index - 1];
            }
            if (Number(params[index]) < highestRating) {
                lowestRating = Number(params[index]);
                lastMovieTitle = params[index - 1];
            }

            totalRating += Number(params[index]);
        }
        index++;
    }
    averageRating = totalRating / movieCount
    console.log(`${bestMovieTitle} is with highest rating: ${highestRating.toFixed(1)}`);
    console.log(`${lastMovieTitle} is with lowest rating: ${lowestRating.toFixed(1)}`);
    console.log(`Average rating: ${averageRating.toFixed(1)}`);
}

movieRatings(["5", "A Star is Born", "7.8", "Creed 2", "7.3", "Mary Poppins", "7.2", "Vice", "7.2", "Captain Marvel", "7.1"]);

movieRatings(["3", "Interstellar", "8.5", "Dangal", "8.3", "Green Book", "8.2"]);
