function histogram(params) {
    let numbersCount = Number(params[0]);
    let countUnder200 = 0;
    let countUnder400 = 0;
    let countUnder600 = 0;
    let countUnder800 = 0;
    let countAbove800 = 0;

    for (let i = 1; i <= numbersCount; i++) {
        let number = Number(params[i]);
        if (number >= 800) {
            countAbove800++;
        } else if (number >= 600) {
            countUnder800++;
        } else if (number >= 400) {
            countUnder600++;
        } else if (number >= 200) {
            countUnder400++;
        } else {
            countUnder200++;
        }

    }

    countUnder200 = (countUnder200 / numbersCount * 100).toFixed(2);
    countUnder400 = (countUnder400 / numbersCount * 100).toFixed(2);
    countUnder600 = (countUnder600 / numbersCount * 100).toFixed(2);
    countUnder800 = (countUnder800 / numbersCount * 100).toFixed(2);
    countAbove800 = (countAbove800 / numbersCount * 100).toFixed(2);

    console.log(`${countUnder200}%`);
    console.log(`${countUnder400}%`);
    console.log(`${countUnder600}%`);
    console.log(`${countUnder800}%`);
    console.log(`${countAbove800}%`);
}

histogram(["3", "1", "2", "999"]);

histogram(["7", "800", "801", "250", "199", "399", "599", "799"]);

histogram(["9", "367", "99", "200", "799", "999", "333", "555", "111", "9"]);

histogram(["14", "53", "7", "56", "180", "450", "920", "12", "7", "150", "250", "680", "2", "600", "200"]);
