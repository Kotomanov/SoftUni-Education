function secretDoorLock(params) {
    let hundreds = Number(params[0]);
    let decimals = Number(params[1]);
    let units = Number(params[2]);


    for (let u = 1; u <= units; u++) {
        for (let d = 1; d <= decimals; d++) {
            for (let h = 1; h <= hundreds; h++) {
                if (u % 2 == 0 && h % 2 == 0) {
                    if (d == 2 || d == 3 || d % 2 != 0 || d % 3 != 0) {
                        console.log(`${u}${d}${h}`);
                    }
                }

            }

        }

    }





}

secretDoorLock(["3", "5", "5"]);
//secretDoorLock(["8", "2", "8"]);