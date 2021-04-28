function invalidNumber(params) {
    let input = Number(params[0]);
    
    if (!(input >= 100 && input <= 200 || input == 0)) {
        console.log("invalid");
    }
}

invalidNumber(["75"]);
invalidNumber(["0"]);
invalidNumber(["-75"])
invalidNumber(["175"])
invalidNumber(["160"]);