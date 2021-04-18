function fishTank(input) {
    let length = Number(input[0]);
    let width = Number(input[1]);
    let heigth = Number(input[2]);
    let percentage = Number(input[3]);

    let aquariumVolume = (length * width * heigth) / 1000;
    let netVolume = aquariumVolume * (1 - percentage / 100);
    console.log(netVolume);

}
fishTank(["105", "77", "89", "18.5"])
//fishTank(["85","75","47","17"])

