using GameHub.JogoDeXadrez.View;
using Newtonsoft.Json;
using GameHub.HubAssets.Model;

namespace GameHub
{
    class Program 
    {
        public static void Main(string[] args) 
        {
            
            //if(Cadastro.listaUsuarios.Count() < 0)
            {
                // Caso usuário não queira fazer o cadastro inicial, programa encerra, caso contrário vai fazer um cadastro
                Cadastro.MostrarMenuCadastro();
            }
            //else
            {
                //Login.FazerLogin();
            }

        }
    }
}