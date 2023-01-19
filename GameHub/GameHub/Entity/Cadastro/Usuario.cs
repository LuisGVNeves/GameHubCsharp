using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.Entity.UsuarioHub
{
    class Usuario
    {
        private string Nome;
        private int Idade;
        private string Senha;

        public Usuario(string nome, int idade,string senha)
        {
            Nome = nome;
            Idade = idade;
            Senha = senha;
        }

        public static Usuario usuario1 = new Usuario("", 0, "");
        public static Usuario usuario2 = new Usuario("", 0, "");

        public void setNovoNome(string novoNome) 
        {
            Nome = novoNome; 
        }
        public void setNovaIdade(int novaIdade) { Idade = novaIdade; }
        public int getIdade() { return Idade; }

        public string getNome() {
            return Nome; 
        }

        public void setNovaSenha(string novaSenha) {
            Senha = novaSenha; 
        }
        public string getSenha() { return Senha; }
    }
}
