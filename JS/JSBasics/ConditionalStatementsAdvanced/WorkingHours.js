function workingHours(params) {
    let hour = Number(params[0]);
    let day = params[1];
    let outcome;

    if (day == "Sunday") {
        outcome = "closed";
    } else {
        if (hour < 10 || hour > 18) {
            outcome = "closed";
        } else {
            outcome = "open";
        }
    }
    console.log(outcome);

}
workingHours(["11", "Monday"])
workingHours(["19", "Friday"])
workingHours(["11", "Sunday"])
workingHours(["11", "Wednesday"])