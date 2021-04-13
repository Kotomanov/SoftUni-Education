function yardGreening(input) {
    let yardArea = Number(input[0]);
    let initialPrice = yardArea * 7.61;
    let finalPrice = initialPrice * 0.82;
    let discount = initialPrice * 0.18;
    console.log(`The final price is: ${finalPrice.toFixed(2)} lv.`);
    console.log(`The discount is: ${discount.toFixed(2)} lv.`);
}
yardGreening(["150"])