function numberInRange(params) {
    let number = Number(params[0]);
    let outPut;

    if (number == 0) {
        outPut = "No"
    }
    else if (number >= -100 && number <= 100) {
        outPut = "Yes"
    } 
    else {
        outPut = "No"
    }

    console.log(outPut);
}
numberInRange(["-25"])
numberInRange(["0"])
numberInRange(["25"])
numberInRange(["125"])