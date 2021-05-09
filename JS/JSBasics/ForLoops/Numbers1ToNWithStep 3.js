function Numbers1toNwithStep3(params) {
    let number = Number(params[0]);
    for (let i = 1; i <= number; i += 3) {
        console.log(i);
    }
}

Numbers1toNwithStep3(["10"]);

Numbers1toNwithStep3(["15"]);

Numbers1toNwithStep3(["7"]);