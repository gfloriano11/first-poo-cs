using System.ComponentModel;
using System.Security.Cryptography;

public class Tela
{
    //
    // propriedades
    //
    private int largura;
    private int altura;

    //
    // métodos
    //
    public Tela(int largura, int altura)
    {
        this.largura = largura;
        this.altura = altura;
    }


    public void PrepararTela()
    {
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Clear();
        this.MontarMoldura(0, 0, this.largura, this.altura);
        this.Centralizar(0, this.largura, 1, "Sistema de Biblioteca do prof Paulo, que incrivel!");
    }


    public string MostrarMenu(List<string> ops, int ci, int li)
    {
        int cf, lf, linha;
        cf = ci + ops[0].Length + 1;
        lf = li + ops.Count + 2;
        this.MontarMoldura(ci, li, cf, lf);
        linha = li + 1;
        for (int i = 0; i < ops.Count; i++)
        {
            Console.SetCursorPosition(ci + 1, linha);
            Console.Write(ops[i]);
            linha++;
        }
        Console.SetCursorPosition(ci + 1, linha);
        Console.Write("Opção : ");
        string op = Console.ReadLine();
        return op;
    }


    public void Centralizar(int ci, int cf, int lin, string msg)
    {
        int col = (cf - ci - msg.Length) / 2;
        Console.SetCursorPosition(col, lin);
        Console.Write(msg);
    }


    public void MontarMoldura(int ci, int li, int cf, int lf)
    {
        int col, lin;
        // desenha as linhas horizontais
        for (col = ci; col < cf; col++)
        {
            // linha horizontal superior
            Console.SetCursorPosition(col, li);
            Console.Write("═");
            // linha horizontal inferior
            Console.SetCursorPosition(col, lf);
            Console.Write("═");
        }

        // desenha as linhas verticais
        for (lin = li; lin < lf; lin++)
        {
            // desenha a linha vertical esquerda
            Console.SetCursorPosition(ci, lin);
            Console.Write("║");
            // desenha a linha vertical direita
            Console.SetCursorPosition(cf, lin);
            Console.Write("║");
        }

        // desenha os cantos
        Console.SetCursorPosition(ci, li);
        Console.Write("╔");

        Console.SetCursorPosition(ci, lf);
        Console.Write("╚");

        Console.SetCursorPosition(cf, li);
        Console.Write("╗");

        Console.SetCursorPosition(cf, lf);
        Console.Write("╝");
    }
}