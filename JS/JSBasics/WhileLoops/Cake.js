function cake(params) {
    let width = Number(params[0]);
    let length = Number(params[1]);
    let cakeArea = width * length;
    let index = 2;
    let IsCakeOver = false;

    while (index < params.length) {
        if (params[index] == "STOP") {
            break;
        }
        cakeArea -= Number(params[index]);

        if (cakeArea <= 0) {
            IsCakeOver = true;
            break;
        }
        index++;
    }

    if (IsCakeOver == true) {
        console.log(`No more cake left! You need ${Math.abs(cakeArea)} pieces more.`);
    } else {
        console.log(`${cakeArea} pieces are left.`)
    }
}

cake(["10", "10", "20", "20", "20", "20", "21"]);


cake(["10", "2", "2", "4", "6", "STOP"]);
