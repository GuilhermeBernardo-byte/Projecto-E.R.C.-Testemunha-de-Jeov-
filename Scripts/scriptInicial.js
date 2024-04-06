//Timing no inicio
let textoloading = document.getElementById("textoloading")
let iniciar = document.getElementById("iniciar")
let circuloloading = document.getElementById("circuloloading")

//document.addEventListener("onload", function () {

//})

window.onload = function () {
    let i = 0;
    setInterval(function () {
        i++;

        if (i == 3) {
            textoloading.innerHTML = "Concluido"

            circuloloading.style.animationPlayState = "paused"
            circuloloading.style.border = "2.5vw solid #242849"

            iniciar.style.visibility = "visible"
            iniciar.style.transition = "1s"

        }
    }, 1000)

}