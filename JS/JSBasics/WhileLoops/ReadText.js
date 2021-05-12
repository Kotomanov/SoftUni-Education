function readText(params) {
    let index = 0;
    let input = params[0];
    while (input !== "Stop") {
        index++;
        console.log(input);
        input = params[index];
    }
}

readText(["Nakov", "SoftUni", "Sofia", "Bulgaria", "SomeText", "Stop", "AfterStop", "Europe", "HelloWorld"]);


readText(["Sofia", "Berlin", "Moscow", "Athens", "Madrid", "London", "Paris", "Stop", "AfterStop"]);
