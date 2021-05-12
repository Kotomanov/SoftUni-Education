function password(params) {
    let username = params[0];
    let password = params[1];
    let input = params[2];

    let index = 3;

    while (input !== password) {
        index++;
        input = params[index];
    }

    console.log(`Welcome ${username}!`);
}

password(["Nakov", "1234", "Pass", "1324", "1234"]);

password(["Gosho", "secret", "secret"]);

password(["Nakov", "1234", "Pass", "1324", "134"]);