function evenPowersOf2(params) {
    let number = Number(params[0]);

    for (let i = 0; i <= number; i++) {
        if (i%2==0) {
            console.log(Math.pow(2,i));
        }
        
    }
}

evenPowersOf2(["3"]);

evenPowersOf2(["5"]);

evenPowersOf2(["6"]);

evenPowersOf2(["7"]);

