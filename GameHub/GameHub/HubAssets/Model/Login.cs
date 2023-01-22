using GameHub.HubAssets.View;
using Newtonsoft.Json;

namespace GameHub.HubAssets.Model
{
    class Login
    {

        public static void FazerLogin()
        {
            MenuHub.EstilizarMenu("Já detectamos um acesso anterior, deseja fazer login?", ConsoleColor.DarkGray, ConsoleColor.Black);
            MenuHub.AdicionarTexto("\n                                            1 - Sim | 2 - Não");
            MenuHub.AdicionarTexto("\n\n                                              Digite aqui: ");
            short respostaUsuario = short.Parse(Console.ReadLine());

            StreamReader arquivoJson = new StreamReader("../../../Serializacao/objetosJogadores.json");
            // # Vai ler o arquivo json até o final
            var json = arquivoJson.ReadToEnd();

            // # Pegando os dados do json e colocando em um lista dinamica
            var data = JsonConvert.DeserializeObject<dynamic[]>(json);


            if (respostaUsuario == 1)
            {
                MenuHub.AdicionarTexto("\n\n                                        Digite o nome do usuário: ");
                string nomeUsuario = Console.ReadLine();

                MenuHub.AdicionarTexto("\n\n                                        Digite a senha do usuário: ");
                string senhaUsuario = Console.ReadLine();

                if(nomeUsuario == (string)data[0].nome && senhaUsuario == (string)data[0].senha)
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
