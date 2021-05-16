function examPreparation(params) {
    let poorGradeCount = Number(params[0]);
    let index = 1;
    let badGradesCount = 0;
    let averageScore = 0;
    let gradesCount = 0;
    let lastProblemName;


    while (params[index] !== "Enough") {
        if (index % 2 == 0) {
            let grade = Number(params[index]);
            if (grade <= 4) {
                badGradesCount++;
            }

            averageScore += grade;
            gradesCount++;
        } else {
            let problemName = params[index];
            lastProblemName = problemName
        }

        if (badGradesCount >= poorGradeCount) {
            console.log(`You need a break, ${badGradesCount} poor grades.`);
            return;
        }

        index++;
    }


    if (badGradesCount < poorGradeCount) {
        console.log(`Average score: ${(averageScore / gradesCount).toFixed(2)}`);
        console.log(`Number of problems: ${gradesCount}`) //??
        console.log(`Last problem: ${lastProblemName}`);

    }

}

examPreparation(["3", "Money", "6", "Story", "4", "Spring Time", "5", "Bus", "6", "Enough"]);


examPreparation(["2", "Income", "3", "Game Info", "6", "Best Player", "4"]);

