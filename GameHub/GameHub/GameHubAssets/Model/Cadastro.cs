using Newtonsoft.Json;
using GameHub.HubAssets.View;

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
                    FazerCadastro();

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
        public static void FazerCadastro()
        {
            Console.Clear();
            MenuHub.EstilizarMenu("AREA CADASTRO", ConsoleColor.DarkRed);

            StreamReader arquivoJson = new StreamReader("../../../Serializacao/objetosJogadores.json");
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

        }
    }
}
