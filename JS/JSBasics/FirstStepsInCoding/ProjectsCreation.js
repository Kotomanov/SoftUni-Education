function projectsCreation(inputData) {
    let architectName = inputData[0];
    let projectsCount = Number(inputData[1]);
    let hoursCount = projectsCount * 3;
    console.log(`The architect ${architectName} will need ${hoursCount} hours to complete ${projectsCount} project/s.`);
}
projectsCreation(["Potyo", "5"])