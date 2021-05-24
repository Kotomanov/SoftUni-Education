function building(params) {
    let floorsCount = Number(params[0]);
    let roomsCount = Number(params[1]);

    for (let floor = floorsCount; floor > 0; floor--) {
        let output = "";
        for (let room = 0; room < roomsCount; room++) {
            if (floor == floorsCount) {
                output += "L" + floor + room + " ";
            } else if (floor % 2 == 0) {
                output += "O" + floor + room + " ";
            } else {
                output += "A" + floor + room + " ";
            }
        }
        console.log(output)
    }
}

building(["6", "4"]);

building(["4", "4"]);

building(["9", "5"]);