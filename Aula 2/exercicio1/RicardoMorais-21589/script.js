function readInput() {

    var texto = document.getElementById("numero").value;

    if(!texto.length) {

        alert("Caixa de texto vazia, insira algo...");

    }

    document.getElementById("texto").innerText = texto;

}