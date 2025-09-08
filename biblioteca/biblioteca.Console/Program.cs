Tela tela = new Tela(80,25);

string opcao;
List<string> opcoes = new List<string>();
opcoes.Add("1 - Emprestimos");
opcoes.Add("2 - Livros     ");
opcoes.Add("3 - Alunos     ");
opcoes.Add("0 - Sair       ");

while (true)
{
    tela.PrepararTela();
    opcao = tela.MostrarMenu(opcoes, 2, 2);

    Console.ReadKey();
}
