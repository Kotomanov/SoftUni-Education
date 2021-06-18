function A2Z() {
    for (let l = 97; l <= 122; l++) {

        //console.log(String.fromCharCode(l));
    }

    let letter = 'a';

    // let firstLetter = params[0].charCodeAt(0); // from char to number 
    let count = 0;
    for (let a = 1; a <= 3; a++) {
        for (let b = 1; b <= 3; b++) {
            for (let c = 1; c <= 3; c++) {
                for (let d = 1; d <= 3; d++) {
                    let outcome = a.toString() + b.toString() + c.toString() + d.toString();
                    console.log(outcome);
                    count++;

                    break;
                }
               break;
            }
            //break;
        }
        //break;
    }
    console.log(count);
}
A2Z()