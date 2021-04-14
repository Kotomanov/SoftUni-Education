function vacationBooksList(input) {
    let pagesCount = Number(input[0]);
    let pagesPerHour = Number(input[1]);
    let daysToReadaBook = Number(input[2]);

    let hoursToReadaBook = pagesCount / pagesPerHour;
    let hoursPerDaytoRead = hoursToReadaBook / daysToReadaBook;
    console.log(hoursPerDaytoRead);
}
vacationBooksList(["432", "15", "4"])
//vacationBooksList(["212","20","2"])
