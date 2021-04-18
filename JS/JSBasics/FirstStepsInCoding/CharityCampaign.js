function charityCampaign(input) {
    let duration = Number(input[0]);
    let bakersCount = Number(input[1]);
    let cakesCount = Number(input[2]);
    let wafflesCount = Number(input[3]);
    let pancakesCount = Number(input[4]);

    let cakesTotalAmount = cakesCount * 45;
    let wafflesTotalAmount = wafflesCount * 5.80;
    let pancakesTotalAmount = pancakesCount * 3.20;

    let dailyAmount = (cakesTotalAmount + wafflesTotalAmount + pancakesTotalAmount) * bakersCount;
    let totalAmount = dailyAmount * duration - (dailyAmount * duration) / 8;
    console.log(totalAmount);


}
charityCampaign(["131", "5", "9", "33", "46"])

