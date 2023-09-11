namespace TriAtleta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TriAtleta atleta01 = new TriAtleta("Robson Alves Rocha");

            atleta01.Aquecer();
            atleta01.Correr();
            atleta01.Nadar();
            atleta01.Pedalar();
            atleta01.Cansou();
        }
    }
}