function moving(params) {
    let width = Number(params[0]);
    let length = Number(params[1]);
    let heigth = Number(params[2]);

    let spaceVolume = width * length * heigth;

    let index = 3;

    while (params[index] !== "Done") {
        let boxCount = Number(params[index]);
        spaceVolume -= boxCount;

        if (spaceVolume < 0) {
            console.log(`No more free space! You need ${Math.abs(spaceVolume)} Cubic meters more.`);
            break;
        }
        index++;
    }

    if (spaceVolume >= 0) {
        console.log(`${spaceVolume} Cubic meters left.`)
    }
}

moving(["10", "10", "2", "20", "20", "20", "20", "122"]);


moving(["10", "1", "2", "4", "6", "Done"])

