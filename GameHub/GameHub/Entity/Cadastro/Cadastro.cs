﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameHub.Entity.UsuarioHub;
using GameHub.Entity.Menu;

namespace GameHub.Entity.CadastroUsuarioHub
{
    class Cadastro
    {
        public static List<Usuario> listaUsuarios = new List<Usuario>();

        // Método para fazer o cadastro do usuario
        public static void FazerCadastro(int indiceUsuario)
        {
            Console.Clear();
            MenuHub.EstilizarMenu("AREA CADASTRO", ConsoleColor.DarkRed);
            using (StreamReader arquivoJson = new StreamReader("../../../Entity/Serializacao/jogadores.json"))
            {
                // # Vai ler o arquivo json até o final
                var json = arquivoJson.ReadToEnd();

                // # Pegando os dados do json e colocando em um lista dinamica
                var data = JsonConvert.DeserializeObject<dynamic[]>(json);

                Console.Write("\n                           Digite seu nome: ");
                data[indiceUsuario].nome = Console.ReadLine();

                Console.Write("\n                           Digite sua senha: ");
                data[indiceUsuario].senha = Console.ReadLine();


                listaUsuarios.Add(new Usuario((string)data[0].nome, 0, (string)data[0].senha));


                Console.WriteLine("\n                       Cadastro criado com sucesso !\n\n");
                Thread.Sleep(1000);
                Console.Clear();
            }

        }


        // Método para mostrar o menu de cadastro
        public static void MostrarMenuCadastro()
        {
            MenuHub.EstilizarMenu("HubJogos SharpCoders", ConsoleColor.DarkRed);
            MenuHub.AdicionarTexto("            Olá seja bem-vindo ao hub de jogos da Sharp Coders !\n\n");
            MenuHub.AdicionarTexto("                        Deseja realizar um cadastro ?\n\n                             1 - Sim   2 - Não");
            MenuHub.AdicionarTexto("\n\n                                Digite aqui: ");
            short respostaUsuario = short.Parse(Console.ReadLine());

            switch (respostaUsuario)
            {
                case 1:

                    // Fazer cadastro do usuário que está na posição[0] do arquivo json
                    Cadastro.FazerCadastro(0);

                    MenuHub.MenuInicialHub();
                    break;
                case 2:
                    Environment.Exit(0);
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
