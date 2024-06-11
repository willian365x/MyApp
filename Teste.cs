using System.Runtime.InteropServices;

class Teste
{
    const int QTD_LINHAS = 80;
    public Teste() { }

    public void VarNomeIdade()
    {
        Console.Clear();
        Linhas(QTD_LINHAS);

        const int IDADE = 25; // Constante idade minima
        var texto = "Carla";

        Console.WriteLine();
        Console.WriteLine($"Nome: {texto}");
        Console.WriteLine($"Idade: {IDADE}");

        Linhas(QTD_LINHAS);
        Console.ReadLine();
    }

    private void Linhas(int? numLinha = 20)
    {
        do
        {
            Console.Write("-");
            numLinha--;
        } while (numLinha > 0);
    }
}
