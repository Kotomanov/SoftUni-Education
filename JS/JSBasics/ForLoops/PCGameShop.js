function PCGameShop(params) {
    let gamesNumber = Number(params[0]);
    let hearthstoneCount = 0;
    let forniteCount = 0;
    let overwatchCount = 0;
    let othersCount = 0;
    for (let i = 1; i <= gamesNumber; i++) {
        if (params[i] == "Hearthstone") {
            hearthstoneCount++;
        } else if (params[i] == "Fornite") {
            forniteCount++;
        } else if (params[i] == "Overwatch") {
            overwatchCount++;
        } else {
            othersCount++;
        }

    }
    console.log(`Hearthstone - ${((hearthstoneCount / gamesNumber) * 100).toFixed(2)}%`);
    console.log(`Fornite - ${((forniteCount / gamesNumber) * 100).toFixed(2)}%`);
    console.log(`Overwatch - ${((overwatchCount / gamesNumber) * 100).toFixed(2)}%`);
    console.log(`Others - ${((othersCount / gamesNumber) * 100).toFixed(2)}%`);
}

PCGameShop(["4", "Hearthstone", "Fornite", "Overwatch", "Counter-Strike"]);

PCGameShop(["3", "Hearthstone", "Diablo 2", "Star Craft 2"]);

