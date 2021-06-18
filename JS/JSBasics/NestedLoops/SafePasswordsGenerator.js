function safePasswordsGenerator(params) {
    let firstNumber = Number(params[0]); //35-55
    let secondNumber = Number(params[1]); //64-96
    let maxCount = Number(params[2]);
    let outcome = "";

    for (let a = 1; a <= firstNumber; a++) {
        for (let b = 1; b <= secondNumber; b++) {
            for (let i = 35; i <= 55; i++) {
                for (let j = 64; j <= 96; j++) {
                    outcome += String.fromCharCode(i) + String.fromCharCode(j) + a + b + String.fromCharCode(j) + String.fromCharCode(i) + "|";
                    maxCount--;
                    if (maxCount <= 0) {
                        return;
                    }

                    if (j == 96) {
                        j = 64;
                        break;
                    }
                   
                    break;
                }

                if (i == 55) {
                    i = 35;
                    break;
                }
                
                break;
            }

        }

    }

    console.log(outcome)
}

safePasswordsGenerator(["2", "3", "10"]);
safePasswordsGenerator(["20", "50", "10"]);