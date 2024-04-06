//validacao dos campos da pagina de login

let formControl = document.querySelectorAll(".form-control")
let divalerta = document.querySelectorAll(".div-alerta")
let estado = false

function validarCamposLogin() {
    

    for (var i = 0; i < formControl.length; i++) {
        if (formControl[i].value === "") {
            formControl[i].classList.remove("input-valido")
            formControl[i].classList.add("class", "input-invalido")

            divalerta[i].style.display = "block"

        } else {
            formControl[i].classList.remove("input-invalido")
            formControl[i].classList.add("class", "input-valido")
            divalerta[i].style.display = "none"



        }
    }
}





//validacao dos campos da pagina de registro

function validarCamposRegistro() {
    let formControl = document.querySelectorAll(".form-control")
    let divalerta = document.querySelectorAll(".div-alerta")

    for (var i = 0; i < formControl.length; i++) {
        if (formControl[i].value === "") {
            formControl[i].classList.remove("input-valido")
            formControl[i].classList.add("class", "input-invalido")

            divalerta[i].style.display = "block"
            console.log(34)


        } else {
            formControl[i].classList.remove("input-invalido")
            formControl[i].classList.add("class", "input-valido")
            divalerta[i].style.display = "none"


        }
    }
}

document.onclick = function () {
    validarCamposLogin()

    validarCamposRegistro()
}



