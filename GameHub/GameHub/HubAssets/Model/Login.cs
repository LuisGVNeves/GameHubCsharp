using GameHub.HubAssets.View;


namespace GameHub.HubAssets.Model
{
    class Login
    {

        public static void FazerLogin()
        {
            MenuHub.EstilizarMenu("Já detectamos um acesso anterior, deseja fazer login?", ConsoleColor.DarkGreen);
        }

    }
}
