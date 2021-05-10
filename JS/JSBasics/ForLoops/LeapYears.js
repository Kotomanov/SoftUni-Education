function leapYears(params) {
    let leapYear = Number(params[0]);
    let finalYear = Number(params[1]);

    for (let i = leapYear; i <= finalYear; i += 4) {
        console.log(i);
    }
}

leapYears(["1908", "1919"]);

leapYears(["2000", "2011"]);


leapYears(["1584", "1597"]);


leapYears(["2020", "2032"]);
