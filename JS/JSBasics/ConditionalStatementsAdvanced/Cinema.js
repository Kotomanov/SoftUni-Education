function cinema(params) {
    let cinemaType = params[0];
    let rows = Number(params[1]);
    let cols = Number(params[2]);

    let hallCapacity = rows * cols;
    let totalIncome = 0;

    if (cinemaType == "Premiere") {
        totalIncome = hallCapacity * 12;
    } else if (cinemaType == "Normal") {
        totalIncome = hallCapacity * 7.5;
    }
    else if (cinemaType == "Discount") {
        totalIncome = hallCapacity * 5;
    }

console.log(`${totalIncome.toFixed(2)} leva`);

}

cinema(["Premiere", "10", "12"]);


cinema(["Normal", "21", "13"]);


cinema(["Discount", "12", "30"]);
