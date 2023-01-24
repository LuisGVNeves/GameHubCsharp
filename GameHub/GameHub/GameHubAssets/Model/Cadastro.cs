using Newtonsoft.Json;
using GameHub.HubAssets.View;
using System.Text.Json;

namespace GameHub.HubAssets.Model
{
    class Cadastro
    {
        public static List<Usuario> listaUsuarios = new List<Usuario>();

        public static Usuario usuario1 = new Usuario("", 0, "", "", "", 0);
        public static Usuario usuario2 = new Usuario("", 0, "", "", "", 0);


        // Método para mostrar o menu de cadastro
        public static int MostrarMenuCadastro()
        {

            MenuHub.EstilizarMenu("HubJogos SharpCoders", ConsoleColor.DarkRed);
            MenuHub.AdicionarTexto("            Olá seja bem-vindo ao hub de jogos da Sharp Coders !\n\n");
            MenuHub.AdicionarTexto("                        Deseja realizar um cadastro ?\n\n                             1 - Sim   2 - Não");
            MenuHub.AdicionarTexto("\n\n                                Digite aqui: ");
            short respostaUsuario = short.Parse(Console.ReadLine());

            switch (respostaUsuario)
            {
                case 1:
                    FazerCadastroXadrez();

                    // Após fazer o cadastro do primeiro usuário, vou iniciar o menu do hub
                    MenuHub.MenuInicialHub();
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }
            return 2;
        }


        // Método para fazer o cadastro do usuario, pego indice no parâmetro que vai servir para acessar os objetos na minha lista de objetos no json, e com isso instancio um novo usuario da classe usuario e já jogos os dados no json
        public static void FazerCadastroXadrez()
        {
            Console.Clear();
            MenuHub.EstilizarMenu("AREA CADASTRO", ConsoleColor.DarkRed);

            StreamReader arquivoJson = new StreamReader("../../../GameHubAssets/Data/objetosJogadores.json");


            // # Vai ler o arquivo json até o final
            var json = arquivoJson.ReadToEnd();

            // # Pegando os dados do json e colocando em um lista dinamica
            var data = JsonConvert.DeserializeObject<dynamic[]>(json);

            Console.Write("\n                           Digite seu nome: ");
            usuario1.setNovoNome(Console.ReadLine());
            data[1].nome = usuario1.getNome();


            Console.Write("\n                           Digite sua senha: ");
            usuario1.setNovaSenha(Console.ReadLine());
            data[1].senha = usuario1.getSenha();


            listaUsuarios.Add(usuario1);

            Console.WriteLine("\n                       Usuario criado com sucesso !\n\n");

            Thread.Sleep(1000);
            Console.Clear();


            MenuHub.EstilizarMenu($"Quem vai jogar com o jogador {usuario1.getNome()}", ConsoleColor.DarkRed);
            MenuHub.AdicionarTexto("Para jogar xadrez, precisamos de mais um usuário no sistema, então cadastre mais um usuário\n\n");
            MenuHub.AdicionarTexto("Aperte alguma tecla para prosseguir com o cadastro: \n\n");
            Console.ReadKey();
            Console.Clear();

            // @ Cadastro jogador2
            MenuHub.EstilizarMenu("AREA CADASTRO", ConsoleColor.DarkRed);

            Console.Write("\n                          Digite seu nome: ");
            usuario2.setNovoNome(Console.ReadLine());
            data[2].nome = usuario2.getNome();


            Console.Write("\n                          Digite sua senha: ");
            usuario2.setNovaSenha(Console.ReadLine());
            data[2].senha = usuario2.getSenha();


            listaUsuarios.Add(usuario2);

            Console.WriteLine("\n                       Usuario criado com sucesso !\n\n");
            Thread.Sleep(1000);
            Console.Clear();

            MenuHub.EstilizarMenu("Xadrez", ConsoleColor.DarkRed);
            Console.WriteLine($"\n        Jogador {usuario1.getNome()} vai jogar com as peças escuras !");
            usuario1.setCorPecaXadrez("red");

            Console.WriteLine($"\n        Jogador {usuario2.getNome()} vai jogar com as peças claras !");
            usuario2.setCorPecaXadrez("white");

            Thread.Sleep(2500);
            Console.Clear();





        }


        public static void FazerCadastroJogoDaVelha()
        {

            Console.Clear();
            MenuHub.EstilizarMenu("AREA CADASTRO", ConsoleColor.DarkRed);

            StreamReader arquivoJson = new StreamReader("../../../GameHubAssets/Data/objetosJogadores.json");
            // # Vai ler o arquivo json até o final
            var json = arquivoJson.ReadToEnd();

            // # Pegando os dados do json e colocando em um lista dinamica
            var data = JsonConvert.DeserializeObject<dynamic[]>(json);

            Console.Write("\n                           Digite seu nome: ");
            Cadastro.usuario1.setNovoNome(Console.ReadLine());
            data[1].nome = Cadastro.usuario1.getNome();


            Console.Write("\n                           Digite sua senha: ");
            Cadastro.usuario1.setNovaSenha(Console.ReadLine());
            data[1].senha = Cadastro.usuario1.getSenha();


            Cadastro.listaUsuarios.Add(Cadastro.usuario1);
            Console.WriteLine("\n                       Usuario criado com sucesso !\n\n");

            Thread.Sleep(1000);
            Console.Clear();
            MenuHub.EstilizarMenu($"Quem vai jogar com o {Cadastro.usuario1.getNome()} ?", ConsoleColor.DarkRed);


            // @ Cadastro segundo jogador
            Console.Write("\n                           Digite seu nome: ");
            Cadastro.usuario2.setNovoNome(Console.ReadLine());
            data[2].nome = Cadastro.usuario1.getNome();


            Console.Write("\n                           Digite sua senha: ");
            Cadastro.usuario1.setNovaSenha(Console.ReadLine());
            data[2].senha = Cadastro.usuario1.getSenha();


            Cadastro.listaUsuarios.Add(Cadastro.usuario1);
            Console.WriteLine("\n                       Usuario criado com sucesso !\n\n");

            Thread.Sleep(1000);
            Console.Clear();

            Console.Write($"\nJogador 1 {Cadastro.usuario1.getNome()} qual você quer ser? letra X ou O: ");
            Cadastro.usuario1.setLetraJogo(Console.ReadLine().ToUpper());
            if (Cadastro.usuario1.getLetraJogo() == "X")
            {
                Cadastro.usuario2.setLetraJogo("O");
            }
            else
            {
                Cadastro.usuario2.setLetraJogo("X");
            }


            MenuHub.AdicionarTexto("\n------------------------------------------------------------", ConsoleColor.Red);

            Console.WriteLine($"\n\nJogador {Cadastro.usuario1.getNome()} começa com: {Cadastro.usuario1.getLetraJogo()}");
            Console.WriteLine($"\nJogador {Cadastro.usuario2.getNome()} começa com: {Cadastro.usuario2.getLetraJogo()}");

            MenuHub.AdicionarTexto("\n------------------------------------------------------------", ConsoleColor.Red);

            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}
