function barcodeGenerator(params) {
    let firstNumber = params[0];
    let secondNumber = params[1];
    let output = "";
    let firstStart = Number(firstNumber[0]);
    let firstEnd = Number(secondNumber[0]);
    let secondStart = Number(firstNumber[1]);
    let secondEnd = Number(secondNumber[1]);;
    let thirdStart = Number(firstNumber[2]);
    let thirdEnd = Number(secondNumber[2]);;
    let fourthStart = Number(firstNumber[3]);
    let fourthEnd = Number(secondNumber[3]);;


    for (let f = firstStart; f <= firstEnd; f++) {
        for (let s = secondStart; s <= secondEnd; s++) {
            for (let t = thirdStart; t <= thirdEnd; t++) {
                for (let l = fourthStart; l <= fourthEnd; l++) {
                    if (f % 2 !== 0 && s % 2 !== 0 && t % 2 !== 0 && l % 2 !== 0) {
                        output += `${f}${s}${t}${l} `;
                    }
                }
            }
        }
    }

    console.log(output);
}

barcodeGenerator(["2345", "6789"]);

barcodeGenerator(["3256", "6579"]);

barcodeGenerator(["1365", "5877"]);