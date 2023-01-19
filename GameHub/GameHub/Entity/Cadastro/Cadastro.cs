using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameHub.Entity.UsuarioHub;

namespace GameHub.Entity.CadastroUsuarioHub
{
    class Cadastro
    {
        public static List<Usuario> listaUsuarios = new List<Usuario>();

        // Método para fazer o cadastro do usuario
        public static void FazerCadastro(int indiceUsuario)
        {
            using (StreamReader arquivoJson = new StreamReader("../../../Entity/Serializacao/jogadores.json"))
            {
                // # Vai ler o arquivo json até o final
                var json = arquivoJson.ReadToEnd();

                // # Pegando os dados do json e colocando em um lista dinamica
                var data = JsonConvert.DeserializeObject<dynamic[]>(json);

                Console.Write("\n                                   Digite seu nome: ");
                data[indiceUsuario].nome = Console.ReadLine();

                Console.Write("\n                                   Digite sua senha: ");
                data[indiceUsuario].senha = Console.ReadLine();


                listaUsuarios.Add(new Usuario((string)data[0].nome, 0, (string)data[0].senha));


                Console.WriteLine("\n                               Cadastro criado com sucesso !\n\n");
                Thread.Sleep(1000);
                Console.Clear();
            }

        }
    }
}
