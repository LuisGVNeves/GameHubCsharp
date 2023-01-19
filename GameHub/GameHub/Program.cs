using GameHub.Entity;

namespace GameHub
{
    class Program
    {
        public static void Main(string[] args) 
        {

            do
            {
                MenuHub.MostrarMenuCadastro();
            } while (MenuHub.MostrarMenuCadastro() != 2);

        }
    }
}