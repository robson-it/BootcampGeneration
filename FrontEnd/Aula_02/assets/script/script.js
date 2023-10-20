let nome = document.getElementById('nome')
let email = document.getElementById('email')    
let assunto = document.querySelector('#assunto')//.assunto class

function verificarCampos (){

    if(nome.value == "" || email.value == "" || assunto.value == ""){
        alert('O nome deve ser preenchido!')
    }else{
        alert('Dados enviados com sucesso!')
    }
}

