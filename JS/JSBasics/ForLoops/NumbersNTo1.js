function NumbersNTo1(params) {
    let number = Number(params[0]);
    for (let i = number; i > 0; i--) {
        console.log(i);
    }
}

NumbersNTo1(["5"]);

NumbersNTo1(["3"])

NumbersNTo1(["2"])