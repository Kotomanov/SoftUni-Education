function barcodeGenerator(params) {
    let firstNumber = Number(params[0]);
    let secondNumber = Number(params[1]);
    let counter = 0;
    for (let f = firstNumber; f <= secondNumber; f++) {
        let numberCheck = f.toString();
        for (let i = 0; i < numberCheck.length; i++) { //numberCheck.length
            let letterToNumber = Number(numberCheck[i]);
            if (letterToNumber % 2 !== 0) {
                counter++;
                if (counter==4) {
                    console.log(numberCheck);
                    counter = 0;
                }
            }
        }
    }
}

barcodeGenerator(["2345", "6789"]);

//barcodeGenerator(["3256", "6579"]);

//barcodeGenerator(["1365", "5877"]);