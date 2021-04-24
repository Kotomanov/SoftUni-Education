function animalType(input) {
    let animal = input[0];
    let result;
    switch (animal) {
        case "dog": result = "mammal"; break;
        case "crocodile":
        case "tortoise":
        case "snake":
            result = "reptile"; break;
        default: result = "unknown"; break;
    }

    console.log(result);
}
animalType(["dog"])
animalType(["snake"])
animalType(["cat"])
animalType(["crocodile"])
animalType(["jujinka"])