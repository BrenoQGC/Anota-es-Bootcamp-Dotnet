using System;

namespace DigitalInovationOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroDeVezes = 5;

            for (int i=0; i < numeroDeVezes; i++)
            {
                Console.WriteLine($"Bom vindo ao bla bla bla {i}");
            }
        }
    }
}
/* Comandos da CLI
 * "dotnet -help" -> Menu de opções
 *       "--list-sdks" -> versôes do SDK instaladas
 *       "new" -> criar novo projeto .net  (ex: "new console" = cria aplicação de console; "--list" exibe lista de modelos de projetos);
 *       "list" -> lista de projetos de referencia .net
 *      "restore" -> restaura os pacotes (arquivo".csproj"), referencias externas ?Nugets, API, lib externa?
 *      "build" -> restaura os pacotes + compila e gera os binários (gera DLL, .exe, .pdb (pontos de debug), arqivos de dependencia, etc).
 *      "run" -> executa o código
 *      
 * "code ." ->abre o conteudo da pasta no VSC
 * 
 * Comando terminal:
 *  "mkdir" nome do diretorio ->cria pasta
 *  CD
 *  CD .. 
 *  explorer . abre diretório no no explorer
 * 
 * */
