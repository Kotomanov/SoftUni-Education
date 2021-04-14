function USDtoBGN(input) {
    let bgnAmount = Number(input[0]);
    let usdAmount = bgnAmount * 1.79549;
    console.log(`${usdAmount}`);
}

USDtoBGN(["100"])