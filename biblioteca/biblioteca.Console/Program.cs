Tela tela = new Tela(80,25);
LivroCRUD livroCRUD = new LivroCRUD();
string opcao;
List<string> opcoes = new List<string>();
opcoes.Add("1 - Emprestimos");
opcoes.Add("2 - Livros     ");
opcoes.Add("3 - Alunos     ");
opcoes.Add("0 - Sair       ");

while (true)
{
    tela.PrepararTela("Sistema de Biblioteca do prof Paulo, que incrivel!");
    opcao = tela.MostrarMenu(opcoes, 2, 2);

    Console.ReadKey();


    if (opcao == "0") break;
    if (opcao == "1") break;

    if (opcao == "2")
    {
        livroCRUD.ExecutarCRUD();
        // break;
    }
    ;
}
