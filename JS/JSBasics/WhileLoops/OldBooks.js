function oldBooks(params) {
    let bookName = params[0];
    let index = 1;
    let counter = 0;
    while (params[index] !== bookName) {
        if (params[index] == "No More Books") {
            console.log("The book you search is not here!");
            console.log(`You checked ${counter} books.`);
            return;
        }
        counter++;
        index++;
    }
    console.log(`You checked ${counter} books and found it.`);
}

oldBooks(["Troy", "Stronger", "Life Style", "Troy"]);


oldBooks(["The Spot", "Hunger Games", "Harry Potter", "Torronto", "Spotify", "No More Books"]);



oldBooks(["Bourne", "True Story", "Forever", "More Space", "The Girl", "Spaceship", "Strongest", "Profit", "Tripple", "Stella", "The Matrix", "Bourne"]);
