function cinemaTickets(params) {
    let studentTicketsCount = 0;
    let kidTicketsCount = 0;
    let standardTicketsCount = 0;
    let seatsOcupied = 0;
    let helpCount = 0;
    let totalTicketsCount = 0;

    for (let i = 0; i < params.length; i++) {

        if (params[i] === "Finish") {
            break;
        }
        else if (params[i] === "End") {
            // extract the movie name and % ocupancy
            //movie name
            // % formula
            seatsOcupied = 0;
            helpCount = 0;
            break; //?
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
            //moviename
        }
        else if (!isNaN(params[i])) {
            //seatsinhall
        }



        while (params[i] !== "End") {
            if (helpCount == 0) {
                //movieName
            } else if (helpCount == 1) {
                //seatsCount
            }
            helpCount++;
        }

    }

    //extract the total of each type of tickets 
    console.log(`Total tickets: ${totalTicketsCount}`);
    console.log(`${((studentTicketsCount/totalTicketsCount)*100).toFixed(2)}% student tickets.`);
    console.log(`${((standardTicketsCount/totalTicketsCount)*100).toFixed(2)}% standard tickets.`);
    console.log(`${((studentTicketsCount/totalTicketsCount)*100).toFixed(2)}% kids tickets.`);

}

cinemaTickets(["Taxi", "10", "standard", "kid", "student", "student", "standard", "standard", "End", "Scary Movie", "6", "student", "student", "student", "student", "student", "student", "Finish"]);


cinemaTickets(["Taxi", "10", "standard", "kid", "student", "student", "standard", "standard", "End", "Scary Movie", "6", "student", "student", "student", "student", "student", "student", "Finish"]);


