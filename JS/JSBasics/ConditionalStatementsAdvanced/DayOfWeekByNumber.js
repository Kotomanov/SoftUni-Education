function dayofWeek(input) {
    let day = (input[0]);
    
    switch (day) {
        case "1": result ="Monday"; break;
        case "2": result = "Tuesday"; break;
        case "3": result = "Wednesday"; break;
        case "4": result = "Thursday"; break;
        case "5": result = "Friday"; break;
        case "6": result = "Saturday"; break;
        case "7": result = "Sunday"; break;
        default: result = "Error"; break;
    }
    console.log(result);
}
dayofWeek(["-1"])
dayofWeek(["1"])
dayofWeek(["2"])
dayofWeek(["3"])
dayofWeek(["4"])
dayofWeek(["5"])
dayofWeek(["6"])
dayofWeek(["7"])
dayofWeek(["8"])