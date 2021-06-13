function safePasswordsGenerator(params) {
    let firstNumber = Number(params[0]); //35-55
    let secondNumber = Number(params[1]); //64-96
    let maxCount = Number(params[2]);
    let outcome = "";
    //ABxyBA x=1 to a , y = 1 to b 
    for (let a = 35; a <= 55; a++) {
            

        for (let b = 64; b <= 96; b++) {
            

                for (let i = 1; i <= firstNumber; i++) {
                    for (let j = 1; j < secondNumber; j++) {
                       outcome += String.fromCharCode(a) +  String.fromCharCode(b) + i + j +  String.fromCharCode(b) + String.fromCharCode(a) + "|"; 
                       maxCount--;
                    }
                    
                }
            
                if (b == 96) {
                b = 64;}
            }
        
        if (maxCount <= 0) {
            return;
        }
        if (a == 55) {
            a = 35;
            //break;
        }  
        
    }

   

    console.log(outcome)
}

safePasswordsGenerator(["2", "3", "10"]);
//safePasswordsGenerator(["20", "50", "10"]);