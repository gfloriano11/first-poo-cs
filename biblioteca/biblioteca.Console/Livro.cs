public class Livro
{
    public string nome;
    public string autor;
    public string ISBN;
    public int ano_publicacao;
    public int num_paginas;

    public Livro(string tit, string aut, string isbn, int ano_pub, int num_pag)
    {
        nome = tit;
        ISBN = isbn;
        autor = aut;
        ano_publicacao = ano_pub;
        num_paginas = num_pag;
    }
    public void MostrarDados()
    {
        Console.WriteLine("Dados do Livro:");
        Console.WriteLine($"Título    : {nome}");
        Console.WriteLine($"ISBN      : {ISBN}");
        Console.WriteLine($"Autor     : {autor}");
        Console.WriteLine($"Ano de Pub: {ano_publicacao}");
        Console.WriteLine($"Num de Pág: {num_paginas}");
        Console.WriteLine("");
    }

}