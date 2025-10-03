using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace BibliotecaDigital
{
    public static class Program
    {
        private static readonly HashSet<string> AutoresFamosos = new HashSet<string>
        {
            "J.K. Rowling", "George R.R. Martin", "J.R.R. Tolkien", "Agatha Christie"
        };

        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("=============================================");
                Console.WriteLine("==========   BIBLIOTECA DIGITAL   ==========");
                Console.WriteLine("=============================================");
                Console.WriteLine("Escolha um módulo:");
                Console.WriteLine("1. Verificador de ISBN");
                Console.WriteLine("2. Classificador de Gênero Literário");
                Console.WriteLine("3. Disponível para Empréstimo?");
                Console.WriteLine("4. Avaliador de Avaliações");
                Console.WriteLine("5. Reconhecedor de Autores Famosos");
                Console.WriteLine("0. Sair do Programa");
                Console.WriteLine("---------------------------------------------");
                Console.Write("Digite sua opção: ");

                string? entrada = Console.ReadLine();

                switch (entrada)
                {
                    case "1": ModuloVerificadorISBN(); break;
                    case "2": ModuloClassificadorGenero(); break;
                    case "3": ModuloDisponibilidade(); break;
                    case "4": ModuloAvaliador(); break;
                    case "5": ModuloReconhecedorAutores(); break;
                    case "0":
                        continuar = false;
                        Console.WriteLine("\nEncerrando o programa. Até breve!");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida. Pressione qualquer tecla para tentar novamente.");
                        Console.ReadKey();
                        break;
                }

                if (continuar)
                {
                    Console.WriteLine("\n---------------------------------------------");
                    Console.Write("Pressione qualquer tecla para voltar ao menu...");
                    Console.ReadKey();
                }
            }
        }

        #region Módulo 1: Verificador de ISBN
        private static void ModuloVerificadorISBN()
        {
            Console.Clear();
            Console.WriteLine("--- Módulo 1: Verificador de ISBN ---");
            Console.Write("Digite o código ISBN do livro: ");
            string isbn = Console.ReadLine()?.Trim() ?? string.Empty;

            if (isbn.Length == 13 && long.TryParse(isbn, out _))
                Console.WriteLine("SAÍDA: ISBN válido.");
            else
                Console.WriteLine("SAÍDA: ISBN inválido.");
        }
        #endregion

        #region Módulo 2: Classificador de Gênero
        private static void ModuloClassificadorGenero()
        {
            Console.Clear();
            Console.WriteLine("--- Módulo 2: Classificador de Gênero Literário ---");
            Console.Write("Digite o nome do livro: ");
            string livro = Console.ReadLine() ?? string.Empty;

            Console.Write("Digite o gênero (Ficção, Fantasia, Mistério, Biografia): ");
            string genero = Console.ReadLine()?.Trim() ?? string.Empty;

            Console.WriteLine($"SAÍDA: O livro '{livro}' foi classificado como '{genero}'.");
        }
        #endregion

        #region Módulo 3: Disponibilidade de Empréstimo
        private static void ModuloDisponibilidade()
        {
            Console.Clear();
            Console.WriteLine("--- Módulo 3: Disponível para Empréstimo? ---");
            Console.Write("Digite o título do livro: ");
            string livro = Console.ReadLine() ?? string.Empty;

            bool disponivel = LerValorBooleano("O livro está disponível? (true/false): ");
            Console.WriteLine($"SAÍDA: O livro '{livro}' {(disponivel ? "pode ser emprestado" : "não pode ser emprestado")}.");
        }
        #endregion

        #region Módulo 4: Avaliador de Avaliações
        private static void ModuloAvaliador()
        {
            Console.Clear();
            Console.WriteLine("--- Módulo 4: Avaliador de Avaliações ---");
            List<double> notas = new List<double>();

            for (int i = 1; i <= 3; i++)
            {
                Console.Write($"Digite a nota {i} do livro (0 a 10): ");
                if (double.TryParse(Console.ReadLine(), out double nota) && nota >= 0 && nota <= 10)
                    notas.Add(nota);
                else
                    Console.WriteLine("Nota inválida, ignorada.");
            }

            double media = notas.Count > 0 ? notas.Average() : 0;
            Console.WriteLine($"SAÍDA: Média das avaliações = {media:F2}");
        }
        #endregion

        #region Módulo 5: Reconhecedor de Autores Famosos
        private static void ModuloReconhecedorAutores()
        {
            Console.Clear();
            Console.WriteLine("--- Módulo 5: Reconhecedor de Autores Famosos ---");
            Console.Write("Digite o nome do autor: ");
            string autor = Console.ReadLine()?.Trim() ?? string.Empty;

            if (AutoresFamosos.Contains(autor))
                Console.WriteLine("SAÍDA: Autor famoso!");
            else
                Console.WriteLine("SAÍDA: Autor não listado como famoso.");
        }
        #endregion

        #region Funções Auxiliares
        private static bool LerValorBooleano(string mensagem)
        {
            while (true)
            {
                Console.Write(mensagem);
                string? input = Console.ReadLine()?.Trim().ToLower();
                if (input == "true" || input == "t" || input == "1") return true;
                if (input == "false" || input == "f" || input == "0") return false;
                Console.WriteLine("Entrada inválida. Digite 'true' ou 'false'.");
            }
        }
        #endregion
    }
}