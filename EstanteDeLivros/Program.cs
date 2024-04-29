using EstanteDeLivros;

int atribuirQtdLivros()
{
    int qtd = 0;

    do
    {
        Console.Write("Defina o tamanho da estante, de 1 até 10 livros: ");
        qtd = int.Parse(Console.ReadLine());

    } while (qtd < 1 || qtd > 10);

    return qtd;
}

Livro cadastrarLivro()
{
    Livro cadastro = new Livro();

    Console.WriteLine("Informe o titulo do livro: ");
    cadastro.setTituloLivro(Console.ReadLine());

    cadastro.setAutoresLivro();

    Console.WriteLine("Informe a data de lançamento do livro: ");
    cadastro.setDataLancamentoLivro(DateOnly.Parse(Console.ReadLine()));

    Console.WriteLine("Informe a Editora do livro: ");
    cadastro.setEditoraLivro(Console.ReadLine());

    Console.WriteLine("Informe a edição do livro: "); 
    cadastro.setEdicaoLivro(Console.ReadLine());

    Console.WriteLine("Informe o ISBN do livro: ");
    cadastro.setIsbn(int.Parse(Console.ReadLine()));

    Console.WriteLine("Informe a quantidade de paginas do livro");
    cadastro.setQtdPaginas(int.Parse(Console.ReadLine()));

    return cadastro;
}


int qtd_livros = atribuirQtdLivros();

Livro[] estante = new Livro[qtd_livros];

for (int i = 0; i < qtd_livros; i++)
{
    Console.WriteLine("Cadastrar Livro numero" + (i + 1));
    estante[i] = cadastrarLivro();
    Console.WriteLine($"Livro número {i + 1}, de titulo {estante[i].titulo} Cadastrado com sucesso!!");
}

Console.WriteLine("Titulos em estante: \n");
for (int livros = 0; livros < qtd_livros; livros++)
{
    Console.WriteLine($"Livro número {livros + 1}");
    estante[livros].imprimirLivro();
}

Console.WriteLine("\n Deseja imprimir um livro especifico detalhadamente(digite 1), todos detalhadamente(digite 2) ou não imprimir nenhum(digite quaisquer outro numero)?");
int imprimir = int.Parse(Console.ReadLine());   

switch (imprimir)
{
    case 1:
        Console.Write($"Digite o numero do livro que deseja imprimir( de 1 até {qtd_livros}): ");
        int l = int.Parse(Console.ReadLine());
        estante[l - 1].imprimirLivroDetalhado();
        break;
    case 2:
        Console.WriteLine("Aqui estão os dados detalhados de todos os livros");
        for (int livros = 0; livros < qtd_livros; livros++)
        {
            Console.WriteLine($"Livro número {livros + 1}: ");
            estante[livros].imprimirLivroDetalhado();
        }
        break;
    default:
        Console.WriteLine("Não será imprimido nenhum livro detalhado!");
    break;
}