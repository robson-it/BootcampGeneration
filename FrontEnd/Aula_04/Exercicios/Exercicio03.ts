interface Produto{
    nome: string;
    fabricante: string;
    paraMaioresDeDezoito: boolean
}

let produto1: Produto = {
    nome: 'Chocolate Baton',
    fabricante: 'Garoto',
    paraMaioresDeDezoito: false
}

let produto2: Produto = {
    nome: 'Chocolate BIS',
    fabricante: 'Lacta',
    paraMaioresDeDezoito: false
}

let produto3: Produto = {
    nome: 'Vinho XYz',
    fabricante: 'UvasDoSul',
    paraMaioresDeDezoito: true
}


const produtos = [produto1, produto2, produto3]



function listarProdutos (nome:  string, fabricante: string, paraMaioresDeDezoito: boolean){
    return {
        nome,
        fabricante,
        paraMaioresDeDezoito
    };
}

const tupla: [string, string, boolean] = [produto1.nome.valueOf(), produto1.fabricante.valueOf(), produto1.paraMaioresDeDezoito.valueOf()]

const resultado = listarProdutos(tupla[0], tupla[1], tupla[2])
console.log(resultado)
console.log(produtos)