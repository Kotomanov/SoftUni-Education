function operationsBetweenNumbers(params) {
    let firstNumber = Number(params[0]);
    let secondNumber = Number(params[1]);
    let operator = params[2];
    let result = 0;
    let evenOrOdd;

    if (operator == "+" || operator == "-" || operator == "*") {

        if (operator == "+") {
            result = firstNumber + secondNumber;
        }

        else if (operator == "-") {
            result = firstNumber - secondNumber;
        }

        else if (operator == "*") {
            result = firstNumber * secondNumber;
        }

        if (result % 2 == 0) {
            evenOrOdd = "even";

        } else {
            evenOrOdd = "odd";
        }

        console.log(`${firstNumber} ${operator} ${secondNumber} = ${result} - ${evenOrOdd}`);

    }

    else if (operator == "/" || operator == "%") {
        if (secondNumber == 0) {
            console.log(`Cannot divide ${firstNumber} by zero`);
        } else {

            if (operator == "/") {
                result = (firstNumber / secondNumber).toFixed(2);
            }
            else {
                result = firstNumber % secondNumber;
            }
            console.log(`${firstNumber} ${operator} ${secondNumber} = ${result}`);
        }

    }

}

operationsBetweenNumbers(["10", "12", "+"]);


operationsBetweenNumbers(["10", "1", "-"]);


operationsBetweenNumbers(["7", "3", "*"]);


operationsBetweenNumbers(["123", "12", "/"]);


operationsBetweenNumbers(["10", "3", "%"]);


operationsBetweenNumbers(["112", "0", "/"]);


operationsBetweenNumbers(["10", "0", "%"]);

