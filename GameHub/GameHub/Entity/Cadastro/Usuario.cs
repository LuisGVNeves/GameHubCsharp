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
        private string CorPecaXadrez;
        private string LetraJogo;


        public Usuario(string nome, int idade,string senha, string corPecaXadrez, string letraJogo)
        {
            Nome = nome;
            Idade = idade;
            Senha = senha;
            CorPecaXadrez = corPecaXadrez;
            LetraJogo = letraJogo;
        }

        public static Usuario usuario1 = new Usuario("", 0, "","","");
        public static Usuario usuario2 = new Usuario("", 0, "","","");

        public string getLetraJogo()
        {
            return LetraJogo;
        }
        public void setLetraJogo(string letra)
        {
            LetraJogo = letra;
        }


        public string getNome() {
            return Nome; 
        }
        public void setNovoNome(string novoNome) 
        {
            Nome = novoNome; 
        }


        public void setNovaIdade(int novaIdade) { Idade = novaIdade; }
        public int getIdade() { return Idade; }


        public void setNovaSenha(string novaSenha) {
            Senha = novaSenha; 
        }
        public string getSenha() { return Senha; }

        public void setCorPecaXadrez(string novaCor)
        {
            CorPecaXadrez = novaCor;
        }

    }
}
