function lettersCombinations(params) {
    let firstLetter = params.charCodeAt(0);
    let secondLetter = '\n'.charCodeAt(params[1]);
    let thirdLetter = '\n'.charCodeAt(params[2]);;
    let result = "";
    let counter = 0;

    for (let f = firstLetter; f <= secondLetter; f++) {
        for (let s = firstLetter; s <= secondLetter; s++) {
            for (let t = firstLetter; t <= secondLetter; t++) {
                if (f !== thirdLetter && s !== thirdLetter && t !== thirdLetter) {
                    result += f + " " + s + " " + t + " ";
                    counter++;
                }

            }

        }

    }
    result+= counter;
    console.log(result);

}

lettersCombinations(["a", "c", "b"]);

//lettersCombinations(["f", "k", "h"]);

//lettersCombinations(["a", "c", "z"]);