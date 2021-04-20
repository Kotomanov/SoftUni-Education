function metricConverter(input) {
    let number = Number(input[0]);
    let inputMetric = input[1];
    let outputMetric = input[2];
    let inMeters = 0.0;
    let outputResult = 0.0;

    if (inputMetric == "m") {
        inMeters = number;
    } else if (inputMetric == "cm") {
        inMeters = number / 100;
    } else if (inputMetric == "mm") {
        inMeters = number / 1000;
    }


    if (outputMetric == "m") {
        outputResult = inMeters;
    } else if (outputMetric == "cm") {
        outputResult = inMeters * 100;
    } else if (outputMetric == "mm") {
        outputResult = inMeters * 1000;
    }

    console.log(outputResult.toFixed(3));

}

metricConverter(["12", "mm", "m"])
metricConverter(["150", "m", "cm"])
metricConverter(["45", "cm", "mm"])
