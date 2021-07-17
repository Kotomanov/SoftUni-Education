function weddingSeats(params) {
    let lastSector = params[0].charCodeAt(0);
    let firstSectorRowCount = Number(params[1]);
    let oddRowSeatCount = Number(params[2]);
    let outcome = "";
    let counter = 0;

    for (let s = 65; s <= lastSector; s++) {
        for (let row = 1; row <= firstSectorRowCount; row++) {
            if (row % 2 == 0) {

                for (let seats = 97; seats < 97 + oddRowSeatCount + 2; seats++) {
                    outcome += String.fromCharCode(s) + row.toString() + String.fromCharCode(seats);
                    counter++;
                    console.log(outcome);
                    outcome = "";
                }
            } else {
                for (let seats = 97; seats < 97 + oddRowSeatCount; seats++) {
                    outcome += String.fromCharCode(s) + row.toString() + String.fromCharCode(seats);
                    counter++;
                    console.log(outcome);
                    outcome = "";
                }
            }

        }
        firstSectorRowCount++;
    }
    console.log(counter);
}

weddingSeats(["B", "3", "2"]);

weddingSeats(["C", "4", "2"]);