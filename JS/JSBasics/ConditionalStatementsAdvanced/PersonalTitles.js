function personalTitles(input) {
    let age = Number(input[0]);
    let gender = input[1];
    let output;


    if (age >= 16) {
        if (gender == "m") {
            output = "Mr."
        } else if (gender == "f") {
            output = "Ms."
        }
    } else {
        if (gender == "m") {
            output = "Master"
        } else if (gender == "f") {
            output = "Miss"
        }
    }

    console.log(output);
}
personalTitles(["12", "f"])
personalTitles(["17", "m"])
personalTitles(["25", "f"])
personalTitles(["13.5", "m"])
