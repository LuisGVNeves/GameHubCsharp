using GameHub.HubAssets.View;
using Newtonsoft.Json;

namespace GameHub.HubAssets.Model
{
    class Login
    {

        public static void FazerLogin()
        {

            MenuHub.EstilizarMenu("      Login       ", ConsoleColor.DarkBlue);
            MenuHub.AdicionarTexto("\n\n╔══════════════════════ ", ConsoleColor.DarkBlue);
            MenuHub.AdicionarTexto("    Deseja fazer login?");
            MenuHub.AdicionarTexto("      ═════════════════════╗\n\n\n", ConsoleColor.DarkBlue);

            MenuHub.AdicionarTexto("\n                             1 - Sim | 2 - Não\n");
            MenuHub.AdicionarTexto("\n\n      ╚══════════════════════════════════════════════════════════╝", ConsoleColor.DarkBlue);
            MenuHub.AdicionarTexto("\n\n\n\n\n                              Digite aqui: ");
            short respostaUsuario = short.Parse(Console.ReadLine());

            StreamReader arquivoJson = new StreamReader("../../../GameHubAssets/Data/objetosJogadores.json");

            // # Vai ler o arquivo json até o final
            var json = arquivoJson.ReadToEnd();

            // # Pegando os dados do json e colocando em um lista dinamica
            var data = JsonConvert.DeserializeObject<dynamic[]>(json);


            if (respostaUsuario == 1)
            {
                Console.Clear();
                MenuHub.EstilizarMenu("Login", ConsoleColor.DarkRed);

                MenuHub.AdicionarTexto("\n                  Digite o nome do usuário: ");
                string nomeUsuario = Console.ReadLine().ToUpper();

                while (nomeUsuario != "ADMIN")
                {
                    MenuHub.AdicionarTexto("\n\nUsuário não encontrado no sistema, deseja tentar novamente?\n\n",ConsoleColor.DarkRed);
                    MenuHub.AdicionarTexto("                       1 - Sim | 2 - NÃO");

                    MenuHub.AdicionarTexto("\n\n\n                         Digite aqui: ");


                    short novaResposta = short.Parse(Console.ReadLine());

                    Console.Clear();
                    MenuHub.EstilizarMenu("Login", ConsoleColor.DarkRed);
                    if (novaResposta == 1)
                    {
                        MenuHub.AdicionarTexto("\n                  Digite o nome do usuário: ");
                        nomeUsuario = Console.ReadLine().ToUpper();
                    }
                    else
                    {
                        Console.Clear();
                        MenuHub.AdicionarTexto("\n\n                            Finalizando programa\n\n", ConsoleColor.DarkRed);
                        Thread.Sleep(2000);
                        System.Environment.Exit(0);
                    }

                }





                MenuHub.AdicionarTexto("\n\n                  Digite a senha do usuário: ");
                string senhaUsuario = Console.ReadLine();
                while (senhaUsuario != "12345")
                {
                    MenuHub.AdicionarTexto("\n\nUsuário não encontrado no sistema, deseja tentar novamente?\n\n", ConsoleColor.DarkRed);
                    MenuHub.AdicionarTexto("                       1 - Sim | 2 - NÃO");

                    MenuHub.AdicionarTexto("\n\n\n                         Digite aqui: ");

                    short novaResposta = short.Parse(Console.ReadLine());
                    if (novaResposta == 1)
                    {
                        MenuHub.AdicionarTexto("\n               Digite a senha do usuário: ");
                        senhaUsuario = Console.ReadLine().ToUpper();
                    }
                    else
                    {
                        MenuHub.AdicionarTexto("\n\n                    Finalizando programa\n\n", ConsoleColor.DarkRed);
                        Thread.Sleep(2000);
                        System.Environment.Exit(0);
                    }

                }


                if (nomeUsuario == (string)data[0].nome && senhaUsuario == (string)data[0].senha)
                {
                    // Após fazer o cadastro do primeiro usuário, vou iniciar o menu do hub
                    MenuHub.MenuInicialHub();
                }


            }
            else
            {
                System.Environment.Exit(0);
            }
        }

    }
}
