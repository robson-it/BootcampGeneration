let nome = document.getElementById('nome')
let email = document.getElementById('email')    
let assunto = document.querySelector('#assunto')//.assunto class
let nomeOk = false
let emailOk = false
let assuntoOk = false
let mapa = document.querySelector('#mapa')

function verificarCampos (){

    if(nomeOk == true && emailOk == true && assuntoOk == true){
        alert('Formulário enviado com sucesso!')
       
    }else{
        alert('Preencha o formulário corretamente antes de enviar!')
        
    }
}

function validaNome(){
    let txt = document.querySelector('#txtNome')
    if(nome.value.length < 3){
        txt.style.color = 'red'
        txt.innerHTML = 'Nome Inválido!'
        nomeOk = false
        
    }else{
        txt.style.color = 'green'
        txt.innerHTML = 'Nome Válido!'
        nomeOk = true
        
    }
}


function validaEmail(){
    let txtEmail = document.querySelector('#txtEmail')

    if(email.value.indexOf('@') == -1 || email.value.indexOf('.') == -1){
        txtEmail.style.color = 'red'
        txtEmail.innerHTML = 'E-mail Inválido'
        emailOk = false
        
    }else{
        txtEmail.style.color = 'green'
        txtEmail.innerHTML = 'E-mail Válido!'
        emailOk = true
        
    }
}


function validaAssunto(){
    let txtAssunto = document.querySelector('#txtAssunto')

    if(assunto.value.length > 100  ){
        txtAssunto.style.color = 'red'
        txtAssunto.innerHTML = 'Você ultrapassou o limite de 100 caracteres. Texto Inválido!'
        txtAssunto.style.display  = 'block'
        assuntoOk = false
        
    }else{
        txtAssunto.style.display = 'none'
        assuntoOk = true
        
    }

}


function mapaZoom(){
    mapa.style.width = '550px'
    mapa.style.heght = '400px'
}

function mapaNormal(){
    mapa.style.width = '450px'
    mapa.style.heght = '360px'
}


