using GameHub.HubAssets.View;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.HubAssets.Model
{
    class Usuario
    {
        private string Nome;
        private int Idade;
        private string Senha;
        private string CorPecaXadrez;
        private string LetraJogo;
        private int Pontuacao;

        public Usuario(string nome, int idade, string senha, string corPecaXadrez, string letraJogo, int pontuacao)
        {
            Nome = nome;
            Idade = idade;
            Senha = senha;
            CorPecaXadrez = corPecaXadrez;
            LetraJogo = letraJogo;
            Pontuacao = pontuacao;
        }



        public string getLetraJogo()
        {
            return LetraJogo;
        }
        public void setLetraJogo(string letra)
        {
            LetraJogo = letra;
        }


        public string getNome()
        {
            return Nome;
        }
        public void setNovoNome(string novoNome)
        {
            Nome = novoNome;
        }


        public void setNovaIdade(int novaIdade) { Idade = novaIdade; }
        public int getIdade() { return Idade; }


        public void setNovaSenha(string novaSenha)
        {
            Senha = novaSenha;
        }
        public string getSenha() { return Senha; }

        public void setCorPecaXadrez(string novaCor)
        {
            CorPecaXadrez = novaCor;
        }


        public int getPontuacaoJogador()
        {
            return Pontuacao;
        }
        public void setPontuacaoJogador(int novaPontuacao, int indiceJogador)
        {
            StreamReader arquivoJson = new StreamReader("../../../GameHubAssets/Data/objetosJogadores.json");

            // # Vai ler o arquivo json até o final
            var json = arquivoJson.ReadToEnd();

            // # Pegando os dados do json e colocando em um lista dinamica
            var data = JsonConvert.DeserializeObject<dynamic[]>(json);

            // Jogador 1 recebe os pontos, e altero no arquivo json também os pontos do 1 jogador
            if (indiceJogador == 1)
            {
                data[0].pontos = novaPontuacao;
            }

            // Jogador 2 recebe os pontos, e altero no arquivo json também os pontos do 2 jogador
            if (indiceJogador == 2)
            {
                data[1].pontos = novaPontuacao;
            }

            Pontuacao += novaPontuacao;
        }

    }
}
