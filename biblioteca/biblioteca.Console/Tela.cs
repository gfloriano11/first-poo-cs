public class Tela
{
    private int largura;
    private int altura;

    public Tela(int lar, int alt)
    {
        this.largura = lar;
        this.altura = alt;
    }

    public void prepararMoldura()
    {
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.Clear();
        this.montarMoldura(0, 0, this.largura, this.altura);
        this.Centralizar(0, this.largura, 1, "Sistema de Biblioteca");
    }

    public void Centralizar(int ci, int cf, int lin, string msg)
    {
        int col = (cf - ci - msg.Length) / 2;
        Console.SetCursorPosition(col, lin);
        Console.Write(msg);
    }

    public string mostrarMenu(List<string> ops, int ci, int li)
    {
        int cf, lf, linha;
        cf = ci + ops[0].Length + 1;
        lf = li + ops.Count + 2;
        this.montarMoldura(ci, li, cf, lf);
        linha = li + 1;
        for (int i = 0; i < ops.Count; i++)
        {
            Console.SetCursorPosition(ci + 1, linha);
            Console.Write(ops[i]);
            linha++;
        }
        Console.SetCursorPosition(ci + 1, linha);
        Console.Write("Opcao: ");
        string op = Console.ReadLine();
        return op;

    }

    public void montarMoldura(int li, int ci, int cf, int lf)
    {
        int col, lin;

        for (col = ci; col < cf; col++)
        {
            Console.SetCursorPosition(col, li);
            Console.Write("═");

            Console.SetCursorPosition(col, lf);
            Console.Write("═");
        }

        for (lin = li; lin < lf; lin++)
        {
            Console.SetCursorPosition(ci, lin);
            Console.Write("║");

            Console.SetCursorPosition(cf, lin);
            Console.Write("║");
        }

        Console.SetCursorPosition(ci, li);
        Console.Write("╔");

        Console.SetCursorPosition(cf, li);
        Console.Write("╗");

        Console.SetCursorPosition(ci, lin);
        Console.Write("╚");

        Console.SetCursorPosition(cf, lin);
        Console.Write("╝");
    }
}