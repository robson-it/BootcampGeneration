interface Usuario{
    nome: string;
    sobrenome: string;
    dataNascimento: Date;
    email: string;
    apelido: string;
}

let usuario1: Usuario = {
    nome: 'Robson',
    sobrenome: 'Rocha',
    dataNascimento: new Date("12/10/1991"),
    email: 'robson_it@outlook.com',
    apelido: 'robson-94'
} 

let usuario02: Usuario = {
    nome: 'Sophia',
    sobrenome: 'Albuquerque',
    dataNascimento: new Date("1/1/1995"),
    email: 'sophia@gmail.com',
    apelido: 'sabesophia'
} 

console.log(usuario1)
console.log(usuario02)

