function weddingSeats(params) {
    let lastSector = params[0].charCodeAt(0);;
    let firstSectorRowCount = Number(params[1]);
    let oddRowSeatCount = Number(params[2]);
    let outcome = "";
    let counter = 0;
    //101 - 132
    for (let s = 65; s <= lastSector; s++) {

        for (let row = 1; row <= firstSectorRowCount; row++) {
            if (row % 2 == 0) {
                //seats+=2
                for (let seats = 97; seats <= 97 + oddRowSeatCount + 2; seats++) {
                    //convert to letter again
                    outcome += String.fromCharCode(s) + row.toString() + String.fromCharCode(seats);
                    counter++;
                    break;
                }
            } else {
                for (let seats = 97; seats <= 97 + oddRowSeatCount; seats++) {
                    outcome += String.fromCharCode(s) + row.toString() + String.fromCharCode(seats);
                    counter++;
                    break;
                }

            }
            console.log(outcome);
            outcome = "";


        }

        firstSectorRowCount++; // next sector has the rows ++; 



    }
    console.log(counter);
}

weddingSeats(["B", "3", "2"]);

//weddingSeats(["C", "4", "2"]);