public class LivroCRUD
{
    private List<Livro> livros;
    private Livro livro;
    private int id;
    private List<string> dados = new List<string>();
    private int larguraDados;
    private int colunaDados;
    private int linhaDados;

    public LivroCRUD()
    {
        this.livros = new List<Livro>();
        this.livro = new Livro();
        this.id = -1;

        dados.Add("ISBN     :");
        dados.Add("Título   :");
        dados.Add("Autor    :");
        dados.Add("Ano      :");
        dados.Add("Páginas  :");
    }

    public void ExecutarCRUD()
    {
        string resp;
        Tela tela = new Tela(46, 9, 15, 5);

        tela.PrepararTela("Cadastro de Livros");

        tela.MontarTela(dados, 16, 7);

        this.larguraDados = 44 - dados[0].Length;
        this.colunaDados = 16 + dados[0].Length;
        this.linhaDados = 7;

        this.EntrarDados(1);

        bool achou = this.ProcurarCodigo();

        if (!achou)
        {
            tela.MostrarMensagem(this.colunaDados, this.linhaDados + 5, "Livro não encontrado.");
            resp = tela.Perguntar(this.colunaDados, this.linhaDados + 6, "Deseja cadastrar esse livro? (S/N)");
            resp = resp.ToLower();

            if (resp == "s")
            {
                this.EntrarDados(2);
                resp = tela.Perguntar(this.colunaDados, this.linhaDados + 7, "Confirma cadastro? (S/N)");
                resp = resp.ToLower();

                if (resp == "s")
                {
                    Console.WriteLine("Entrou no if");
                    this.livros.Add(new Livro(this.livro.isbn, this.livro.titulo, this.livro.autor, this.livro.anoPublicacao, this.livro.paginas));

                }
            }

            // if (resp == "n")
            // {

            // }

            // if (resp != "s" && resp != "n") { }
            // {
            //     tela.MostrarMensagem(this.colunaDados, this.linhaDados + 5, "Opção inválida.");
            // }
        }
        else
        {
            Console.WriteLine("--- achei ---");
            Console.ReadKey();
        }
    }

    public void EntrarDados(int qual)
    {
        if (qual == 1)
        {
            Console.SetCursorPosition(this.colunaDados, this.linhaDados);
            this.livro.isbn = Console.ReadLine();
        }
        else
        {
            Console.SetCursorPosition(this.colunaDados, this.linhaDados + 1);
            this.livro.titulo = Console.ReadLine();

            Console.SetCursorPosition(this.colunaDados, this.linhaDados + 2);
            this.livro.autor = Console.ReadLine();

            Console.SetCursorPosition(this.colunaDados, this.linhaDados + 3);
            this.livro.anoPublicacao = int.Parse(Console.ReadLine());

            Console.SetCursorPosition(this.colunaDados, this.linhaDados + 4);
            this.livro.paginas = int.Parse(Console.ReadLine());

        }
    }

    public bool ProcurarCodigo()
    {
        bool encontrei = false;

        for (int i = 0; i < this.livros.Count; i++)
        {
            if (this.livro.isbn == this.livros[i].isbn)
            {
                encontrei = true;
                this.id = i;
                break;
            }
        }

        return encontrei;
    }
}