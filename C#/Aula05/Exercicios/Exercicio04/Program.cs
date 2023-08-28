namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[,] matrizDeNotas = new float[10, 4];
            float[] mediaPorAluno = new float[10];
            float mediaAuxiliar;

            for (int indiceLinha = 0; indiceLinha < matrizDeNotas.GetLength(0); indiceLinha++)
            {
                mediaAuxiliar = 0;
                Console.WriteLine($"Digite 4 notas para o {indiceLinha +1}° aluno: ");
                for (int indiceColuna = 0; indiceColuna < matrizDeNotas.GetLength(1); indiceColuna++)
                {
                    matrizDeNotas[indiceLinha, indiceColuna] = Convert.ToSingle(Console.ReadLine());
                    mediaAuxiliar += matrizDeNotas[indiceLinha, indiceColuna];
                }
                mediaPorAluno[indiceLinha] = mediaAuxiliar / matrizDeNotas.GetLength(1);
            }

            foreach (float notaAluno in mediaPorAluno) {
                Console.Write("{0:F1} /", notaAluno);
            }
        }
    }
}