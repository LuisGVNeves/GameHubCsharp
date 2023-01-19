using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.Entity.Cadastro
{
    class Usuario
    {
        private string Nome;
        private int Idade;

        public Usuario(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }


        public void setNovoNome(string novoNome) { Nome = novoNome; }
        public void setNovaIdade(int novaIdade) { Idade = novaIdade; }
        public int getIdade() { return Idade; }
        public string getNome() { return Nome; }
    }
}
