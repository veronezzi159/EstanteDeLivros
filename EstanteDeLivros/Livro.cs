using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstanteDeLivros
{
    public class Livro
    {
        public string titulo;

        public string autores;

        public DateOnly dataLancamento;

        public string editora;

        public string edicao;

        public int isbn;

        public int qtdPaginas;

        public Livro() 
        {
           
        }

        public void setTituloLivro(string t)
        {
            this.titulo = t;
        }

        public void setAutoresLivro()
        {
            string a;
            int q;
            do
            {
                Console.Write("Informe a quantidade de autor(es): ");
                q = int.Parse(Console.ReadLine());
                if (q > 0)
                {
                    if (q == 1)
                    {
                        Console.WriteLine("Informe o nome do autor: ");
                    }
                    else
                    {
                        Console.WriteLine("Informe os nomes dos autores: ");
                    }
                    a = Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("o Valor deve ser acima de 0");
                }
            } while (q < 1);
            

        }

        public void setDataLancamentoLivro(DateOnly date)
        {            
            this.dataLancamento = date;
        }

        public void setEditoraLivro( string d)
        {
            this.editora = d;
        }

        public void setEdicaoLivro(string ve)
        {
            this.edicao = ve;
        }

        public void setIsbn( int isbn)
        {
            this.isbn = isbn;
        }

        public void setQtdPaginas (int qtd)
        {
            this.qtdPaginas = qtd;
        }

        public void imprimirLivroDetalhado()
        {
            Console.WriteLine($"\nTitulo: {this.titulo}");
            Console.WriteLine($"Autor(es): {this.autores}");
            Console.WriteLine($"Data de Lançamento: {this.dataLancamento}");
            Console.WriteLine($"Editora: {this.editora}");
            Console.WriteLine($"Edição: {this.edicao}");
            Console.WriteLine($"ISBN: {this.isbn}");
            Console.WriteLine($"Quantidadde de Paginas: {this.qtdPaginas}");
        }

        public void imprimirLivro()
        {
            Console.WriteLine($"\nTitulo: {this.titulo}");
            Console.WriteLine($"ISBN: {this.isbn}");
            Console.WriteLine($"Autor(es): {this.autores}");
        }

    }
}
