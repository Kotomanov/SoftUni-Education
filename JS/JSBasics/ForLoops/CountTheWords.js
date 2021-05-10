function countTheWords(params) {
    let input = params;
    let counter = 0;
    for (let i = 0; i < input.length; i++) {
        counter = input[i].split(" ").length;

    }

    if (counter <= 10) {
        console.log("The message was sent successfully!");
    } else {
        console.log(`The message is too long to be send! Has ${counter} words.`);
    }

}

countTheWords(["This message has exactly eleven words. One more as it's allowed!"]);

countTheWords(["This message has ten words and you can send it!"]);