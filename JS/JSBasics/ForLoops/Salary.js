function salary(params) {
    let tabsOpenCount = Number(params[0]);
    let salary = Number(params[1]);

    for (let i = 2; i <= tabsOpenCount + 1; i++) {
        let pageOpen = params[i];

        if (pageOpen == "Facebook") {
            salary -= 150;

        } else if (pageOpen == "Instagram") {
            salary -= 100;


        } else if (pageOpen == "Reddit") {
            salary -= 50;

        }
        if (salary <= 0) {
            break;
        }

    }

    if (salary > 0) {
        console.log(salary);
    } else {
        console.log("You have lost your salary.");
    }

}

salary(["3", "500", "Stackoverflow.com", "softuni.bg", "Facebook"])

salary(["10", "750", "Facebook", "Dev.bg", "Instagram", "Facebook", "Reddit", "Facebook", "Facebook"]);


salary(["3", "500", "Facebook", "Stackoverflow.com", "softuni.bg"])


salary(["3", "500", "Github.com", "Stackoverflow.com", "softuni.bg"]);
