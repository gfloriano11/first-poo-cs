List<Livro> livros = new List<Livro>();

Console.Clear();
Console.WriteLine("--- Sistema de Biblioteca: ---");
livros.Add(new Livro("O Senhor dos Anéis", "JRR Tolkien", "123", 2015, 1247));
livros.Add(new Livro("Ilíada", "Homero", "437", 2020, 421));
livros.Add(new Livro("A Faca", "Jo Nesbo", "675", 2020, 456));
livros.Add(new Livro("Uma História", "Johann Ruth", "1", 2026, 0));

for (int i = 0; i < livros.Count; i++) livros[i].MostrarDados();