List<Livro> livros = new List<Livro>();

Console.Clear();
Console.WriteLine("--- Sistema de Biblioteca: ---");
livros.Add(new Livro("O Senhor dos Anéis", "JRR Tolkien", "123", 2015, 1247));
livros.Add(new Livro("Ilíada", "Homero", "437", 2020, 421));
for (int i = 0; i < livros.Count; i++)
{
    livros[i].MostrarDados();
}