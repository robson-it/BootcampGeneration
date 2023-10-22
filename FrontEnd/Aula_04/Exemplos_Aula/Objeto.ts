interface TurmaModelo {
    nome: string
    qtd: number
    materia: string
    p_instrutora: string
}

const Turma: TurmaModelo = {
    nome: "Turma .Net",
    qtd: 32,
    materia: "FullStack C#",
    p_instrutora: "Jacque"
}

console.log(Turma)

const Turma2: TurmaModelo = { 
    nome: "Turma JS",
    qtd: 28,
    p_instrutora: "Yuri",
    materia: "JS"
}

console.log(Turma2)