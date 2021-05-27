function cinemaTickets(params) {
    let studentTicketsCount = 0;
    let kidTicketsCount = 0;
    let standardTicketsCount = 0;
    let seatsOcupied = 0;
    let seatCount = 0;
    let helpCount = 0;
    let totalTicketsCount = 0;
    let movieName = "";

    for (let i = 0; i < params.length; i++) {

        if (params[i] === "End" || params[i] === "Finish") {
            let hallOcupancy = ((seatsOcupied / seatCount) * 100).toFixed(2);
            console.log(`${movieName} - ${hallOcupancy}% full.`);
            seatsOcupied = 0;
            helpCount = 0;

        }
        else if (params[i] === "standard") {
            standardTicketsCount++;
            seatsOcupied++;
            totalTicketsCount++;
        }
        else if (params[i] === "student") {
            studentTicketsCount++;
            seatsOcupied++;
            totalTicketsCount++;
        }
        else if (params[i] === "kid") {
            kidTicketsCount++;
            seatsOcupied++;
            totalTicketsCount++;
        }
        else if (isNaN(params[i])) {
            movieName = params[i];
        }
        else if (!isNaN(params[i])) {
            seatCount = Number(params[i]);
        }

    }

    console.log(`Total tickets: ${totalTicketsCount}`);
    console.log(`${((studentTicketsCount / totalTicketsCount) * 100).toFixed(2)}% student tickets.`);
    console.log(`${((standardTicketsCount / totalTicketsCount) * 100).toFixed(2)}% standard tickets.`);
    console.log(`${((kidTicketsCount / totalTicketsCount) * 100).toFixed(2)}% kids tickets.`);

}

cinemaTickets(["Taxi", "10", "standard", "kid", "student", "student", "standard", "standard", "End", "Scary Movie", "6", "student", "student", "student", "student", "student", "student", "Finish"]);


cinemaTickets(["The Matrix","20","student","standard","kid","kid","student","student","standard","student","End","The Green Mile","17","student","standard","standard","student","standard","student","End","Amadeus","3","standard","standard","standard","Finish"]);


