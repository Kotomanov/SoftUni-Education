function building(params) {
    let floorsCount = Number(params[0]);
    let roomsCount = Number(params[1]);

    for (let floor = floorsCount; floor > 0 ; floor--) {
        for (let room = 0; room < roomsCount; room++) {
            console.log(floor);
            console.log(room);
            
        }
        
    }

}

building(["6", "4"]);

building(["4", "4"]);

building(["9", "5"]);