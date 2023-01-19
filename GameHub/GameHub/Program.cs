using GameHub.Entity.CadastroUsuarioHub;

namespace GameHub
{
    class Program 
    {
        public static void Main(string[] args) 
        {
            // Caso usuário não queira fazer o cadastro inicial, programa encerra, caso contrário vai fazer um cadastro
            Cadastro.MostrarMenuCadastro();

        }
    }
}