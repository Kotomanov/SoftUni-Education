function fitnessCenter(params) {
    let peopleCount = Number(params[0]);
    let peopleTrainingCount = 0;
    let peopleBuyingProteinShake = 0;
    let peopleBuyingProteinBar = 0;
    let peopleTrainingBackCount = 0;
    let peopleTrainingChestCount = 0;
    let peopleTrainingAbsCount = 0;
    let peopleTrainingLegsCount = 0;
    let peopleBuyingProtein = 0;
    for (let i = 1; i <= peopleCount; i++) {
        if (params[i] == "Back") {
            peopleTrainingBackCount++;
            peopleTrainingCount++;
        }
        else if (params[i] == "Legs") {
            peopleTrainingLegsCount++;
            peopleTrainingCount++;
        }
        else if (params[i] == "Abs") {
            peopleTrainingAbsCount++;
            peopleTrainingCount++;
        }
        else if (params[i] == "Chest") {
            peopleTrainingChestCount++;
            peopleTrainingCount++;
        }
        else if (params[i] == "Protein shake") {
            peopleBuyingProteinShake++;
            peopleBuyingProtein++;
        }
        else if (params[i] == "Protein bar") {
            peopleBuyingProteinBar++;
            peopleBuyingProtein++;
        }

    }

    console.log(`${peopleTrainingBackCount} - back`);
    console.log(`${peopleTrainingChestCount} - chest`);
    console.log(`${peopleTrainingLegsCount} - legs`);
    console.log(`${peopleTrainingAbsCount} - abs`);
    console.log(`${peopleBuyingProteinShake} - protein shake`);
    console.log(`${peopleBuyingProteinBar} - protein bar`);
    console.log(`${((peopleTrainingCount/peopleCount)*100).toFixed(2)}% - work out`);
    console.log(`${((peopleBuyingProtein/peopleCount)*100).toFixed(2)}% - protein`);
}

fitnessCenter(["10", "Back", "Chest", "Legs", "Abs", "Protein shake", "Protein bar", "Protein shake", "Protein bar", "Legs", "Abs"]);


fitnessCenter(["7", "Chest", "Back", "Legs", "Legs", "Abs", "Protein shake", "Protein bar"]);