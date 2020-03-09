function getInfo() {

    var link = document.getElementById("link");
    var info = document.getElementById("info");

    lista.innerHTML =
        "ID:" + link.id + "<br>" +
        "Target" + link.target + "<br>" +
        "Type" + link.type + "<br>" +
        "href" + link.href + "<br>";

}

function changeColorToRed() {

    var titles = document.getElementsByClassName("titulo");

    for(let title of titles) {

        title.style.color = "red";

    }

function onClickOfCell(cell) {

    cell.innerText = prompt("Novo Valor:");
    cell.style.backgroundColor = "green";

}

function setClickCell() {

        var cells = document.getElementsByTagName("td");

        for(let cell of cells) {

            cell.onclick = function() {

                onClickOfCell(cell);

            }

        }

}

setClickCell();

}