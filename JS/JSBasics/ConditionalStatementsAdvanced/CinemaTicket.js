function cinemaTicket(params) {
    let day = params[0];
    let outcome;
    switch (day) {
        case "Monday":
        case "Tuesday":
        case "Friday": outcome = 12; break;
        case "Wednesday":
        case "Thursday": outcome = 14; break;
        case "Saturday":
        case "Sunday": outcome = 16; break;
        default:
            break;
    }
    console.log(outcome);
}

cinemaTicket(["Monday"]);
cinemaTicket(["Sunday"])
cinemaTicket(["Wednesday"])
cinemaTicket(["Friday"])
cinemaTicket(["Tuesday"])
cinemaTicket(["Saturday"])
cinemaTicket(["Thursday"])