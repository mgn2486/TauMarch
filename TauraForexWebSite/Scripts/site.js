var text = ["Welcome", "To", "Train to Trade"];
var counter = 0;
var elem = document.getElementById("motivationalText");
setInterval(change, 1000);

function change() {
    elem.innerHTML = text[counter];
    counter++;
    if (counter >= text.length) {
        counter = 0;
    }
}