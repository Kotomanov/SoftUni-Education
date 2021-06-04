function lettersCombinations(params) {
    let firstLetter = params[0].charCodeAt(0);
    let secondLetter = params[1].charCodeAt(0);
    let thirdLetter = params[2].charCodeAt(0);
    let result = "";
    let counter = 0;

    for (let f = firstLetter; f <= secondLetter; f++) {
        for (let s = firstLetter; s <= secondLetter; s++) {
            for (let t = firstLetter; t <= secondLetter; t++) {
                if (f !== thirdLetter && s !== thirdLetter && t !== thirdLetter) {
                    result += String.fromCharCode(f) + String.fromCharCode(s) + String.fromCharCode(t) + " ";
                    counter++;
                }
            }
        }

    }
    result += counter;
    console.log(result);

}

lettersCombinations(["a", "c", "b"]);

lettersCombinations(["f", "k", "h"]);

lettersCombinations(["a", "c", "z"]);