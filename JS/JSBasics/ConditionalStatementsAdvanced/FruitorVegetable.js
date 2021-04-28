function fruitOrVegetable(params) {
    let input = params[0];
    let output;
    switch (input) { //tomato, cucumber, pepper и carrot
        case "banana":
        case "apple":
        case "kiwi":
        case "cherry":
        case "lemon":
        case "grapes": output = "fruit"; break;
        case "tomato":
        case "cucumber":
        case "pepper":
        case "carrot": output = "vegetable"; break;
        default: output = "unknown"; break;
    }

    console.log(output);
}
fruitOrVegetable(["banana"])
fruitOrVegetable(["cucumber"])
fruitOrVegetable(["tomato"])
fruitOrVegetable(["baihoi"])
fruitOrVegetable(["apple"])