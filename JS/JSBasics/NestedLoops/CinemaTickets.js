function cinemaTickets(params) {
    let studentCount = 0;
    let kidCount = 0;
    let standardCount = 0;
    let seatsOcupied = 0;
    let helpCount = 0;

    for (let i = 0; i < params.length; i++) {

        if (params[i] === "Finish") {
            break;
        }

        else if (params[i] === "End") {
            studentCount = 0;
            kidCount = 0;
            standardCount = 0;
            seatsOcupied = 0;
            helpCount = 0;
        }

        while (params[i] !== "End") {
            if (helpCount == 0) {

            }

            else if(helpCount == 0){

            }
        }

    }



}

cinemaTickets(["Taxi", "10", "standard", "kid", "student", "student", "standard", "standard", "End", "Scary Movie", "6", "student", "student", "student", "student", "student", "student", "Finish"]);


cinemaTickets(["Taxi", "10", "standard", "kid", "student", "student", "standard", "standard", "End", "Scary Movie", "6", "student", "student", "student", "student", "student", "student", "Finish"]);


