using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.Entity.UsuarioHub
{
    class Usuario
    {
        private static string Nome;
        private static int Idade;
        private static string Senha;

        public Usuario(string nome, int idade,string senha)
        {
            Nome = nome;
            Idade = idade;
            Senha = senha;
        }


        public void setNovoNome(string novoNome) { Nome = novoNome; }
        public void setNovaIdade(int novaIdade) { Idade = novaIdade; }
        public int getIdade() { return Idade; }
        public string getNome() { return Nome; }

        public void setNovaSenha(string novaSenha) { Senha = novaSenha; }
        public string getSenha() { return Senha; }
    }
}
