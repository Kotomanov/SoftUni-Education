function weddingSeats(params) {
    let lastSector = params[0].charCodeAt(0);;
    let firstSectorRowCount = Number(params[1]);
    let oddRowSeatCount = Number(params[2]);
    let outcome = "";
    //101 - 132
    for (let s = 101; s <= lastSector; s++) {
        for (let row = 0; row <= firstSectorRowCount; row++) {
            for (let seat = 0; seat <= oddRowSeatCount; seat++) {
                outcome += String.fromCharCode(s) + row.toString() + seat.toString();
                console.log(outcome);
                outcome = "";

            }
            //increase rows
        }

    }
}

weddingSeats(["B", "3", "2"]);

weddingSeats(["C", "4", "2"]);