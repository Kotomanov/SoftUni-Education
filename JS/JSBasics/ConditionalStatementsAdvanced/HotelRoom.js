function hotelRoom(params) {
    let month = params[0];
    let daysCount = Number(params[1]);
    let apartmentBudget = 0;
    let studioBudget = 0;

    if (month == "May" || month == "October") {
        apartmentBudget = daysCount * 65;
        studioBudget = daysCount * 50;
        if (daysCount > 14) {
            studioBudget *= 0.70;
            apartmentBudget *= 0.90;
        } else if (daysCount > 7) {
            studioBudget *= 0.95;
        }

    } else if (month == "June" || month == "September") {
        apartmentBudget = daysCount * 68.70;
        studioBudget = daysCount * 75.20;
        if (daysCount > 14) {
            studioBudget *= 0.80;
            apartmentBudget *= 0.90;
        }
    }
    else if (month == "July" || month == "August") {
        apartmentBudget = daysCount * 77;
        studioBudget = daysCount * 76;
        if (daysCount > 14) {
            apartmentBudget *= 0.90;
        }
    }

    console.log(`Apartment: ${apartmentBudget.toFixed(2)} lv.`);
    console.log(`Studio: ${studioBudget.toFixed(2)} lv.`);

}

hotelRoom(["May", "15"]);


hotelRoom(["June", "14"]);


hotelRoom(["August", "20"]);


hotelRoom(["July", "120"]);
