function easterBake(params) {
    let maxQtySugar = -1;
    let maxQtyFlour = -1;
    let sugarPackQty = 0;
    let flourPackQty = 0;
    let totalSugarQty = 0;
    let totalFlourQty = 0;

    for (let b = 1; b < params.length; b++) {
        if (b % 2 !== 0) {
            totalSugarQty += Number(params[b]);
            if (maxQtySugar < Number(params[b])) {
                maxQtySugar = Number(params[b]);
            }
        } else {
            totalFlourQty += Number(params[b]);
            if (maxQtyFlour < Number(params[b])) {
                maxQtyFlour = Number(params[b]);
            }
        }
    }

    sugarPackQty = Math.ceil(totalSugarQty / 950);
    flourPackQty = Math.ceil(totalFlourQty / 750);

    console.log(`Sugar: ${sugarPackQty}`);
    console.log(`Flour: ${flourPackQty}`);
    console.log(`Max used flour is ${maxQtyFlour} grams, max used sugar is ${maxQtySugar} grams.`);
}

easterBake(["3", "400", "350", "250", "300", "450", "380"]);


easterBake(["4", "500", "350", "560", "430", "600", "345", "578", "543"]);
