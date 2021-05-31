function trainTheTrainers(params) {
    let trainersCount = Number(params[0]);
    let subject = "";
    let index = 1;
    let finalGrade = 0;
    let averageGrade = 0;
    let gradesCount = 0;
    while (params[index] !== "Finish") {
        if (isNaN(params[index])) {
            subject = params[index];
            averageGrade = 0;
            index++;
        } else {
            for (let i = 0; i < trainersCount; i++) {
                finalGrade += Number(params[index]);
                averageGrade += Number(params[index]);
                gradesCount++;
                index++;
            }

            console.log(`${subject} - ${(averageGrade/trainersCount).toFixed(2)}.`);
            averageGrade = 0;
        }
        
    }

    console.log(`Student's final assessment is ${(finalGrade/gradesCount).toFixed(2)}.`);
}

trainTheTrainers(["2", "While-Loop", "6.00", "5.50", "For-Loop", "5.84", "5.66", "Finish"]);


trainTheTrainers(["2", "Objects and Classes", "5.77", "4.23", "Dictionaries", "4.62", "5.02", "RegEx", "2.88", "3.42", "Finish"]);


trainTheTrainers(["3", "Arrays", "4.53", "5.23", "5.00", "Lists", "5.83", "6.00", "5.42", "Finish"]);
