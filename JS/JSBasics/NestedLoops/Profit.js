function profit(params) {
    let oneLevCointCount = Number(params[0]);
    let twoLevCointCount = Number(params[1]);
    let fiveLevCointCount = Number(params[2]);
    let sum = Number(params[3]);


    for (let o = 0; o <= oneLevCointCount; o++) {
        for (let t = 0; t <= twoLevCointCount; t++) {
            for (let f = 0; f <= fiveLevCointCount; f++) {
                if (o * 1 + t * 2 + f * 5 === sum) {
                    console.log(`${o} * 1 lv. + ${t} * 2 lv. + ${f} * 5 lv. = ${sum} lv.`);
                }

            }

        }

    }

}

profit(["3", "2", "3", "10"]);

profit(["5", "3", "1", "7"]);