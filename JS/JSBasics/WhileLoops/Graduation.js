function graduation(params) {
    let studentName = params[0];
    let index = 1;
    let averageGrade = 0;
    let gradeCount = 0;
    let badGradeCount = 0;
    let isNotSuspended = true;
    while (isNotSuspended) {
        let grade = Number(params[index]);
        averageGrade += grade;

        if (grade < 4) {
            badGradeCount++;
        }

        if (badGradeCount == 2) {
            console.log(`${studentName} has been excluded at ${gradeCount} grade`);
            isNotSuspended = false;
        }

        gradeCount++;

        if (gradeCount == 12) {
            averageGrade /= gradeCount;
            console.log(`${studentName} graduated. Average grade: ${averageGrade.toFixed(2)}`);
            break;
        }

        index++;
    }
}

graduation(["Gosho", "5", "5.5", "6", "5.43", "5.5", "6", "5.55", "5", "6", "6", "5.43", "5"]);


graduation(["Mimi", "5", "6", "5", "6", "5", "6", "6", "2", "3"]);

