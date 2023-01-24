<h1 align="center"> 
  GameHub
</h1>



<p align="center">
  Hub de jogos, contendo alguns jogos famosos como: <b>Jogo da velha<b> e <b>Jogo de Xadrez<b>, onde o usuário pode mover as peças do tabuleiro via terminal.
</p>


<h3 align="center"> 
  Status do Projeto ✅ <br>
	🚧 Em construção...  🚧
</h3>


### Como rodar o projeto
```bash
# Clone este repositório
$ git clone https://github.com/LuisGVNeves/GameHubCsharp.git

# Acesse a pasta do projeto no visual studio
$ GameHub

# Vá para o arquivo
$ GameHub.sln

# Executar o projeto
$ ctrl + f5
```




<p align="center">
  <b>Xadrez</b>
</p>

<p align="center">
  <img src="https://user-images.githubusercontent.com/99727468/214076666-1120bc22-8df6-424b-9525-aa7d790e3767.png" alt="Sublime's custom image"/>
</p>

<p align="center">
  O xadrez possui seis tipos de peças: Peão, Torre, Cavalo, Bispo, Rainha e Rei. Cada peça possui sua maneira única de se mover. Existem algumas semelhanças entre os movimentos de algumas peças. Todas as peças, exceto o cavalo, movem-se em linha reta - horizontalmente, verticalmente ou diagonalmente. Elas não podem se mover além do final do tabuleiro e retornarem no outro lado. O lado do tabuleiro é uma fronteira que não pode ser ultrapassada. 
</p>


<h3 align="center"> 
  Como jogar Xadrez:
</h3>


<p align="center">
  Link de uma documentação rápida com os principais movimentos do tabuleiro
  
  <a href="https://docs.kde.org/trunk5/pt_BR/knights/knights/piece-movement.html#:~:text=bispo%20da%20rainha.-,Torre,se%20encontra%20a%20pe%C3%A7a%20advers%C3%A1ria.">
  Como aprender a jogar Xadrez
  </a>
  
</p>





</br></br>

<h3 align="center"> 
  Informações iniciais do Login no Hub 
</h3>

</br>

<p align="center">
  Como é uma versão ainda alpha, o hub de jogos ainda não disponibiliza um banco de dados para cadastrar o usuário, então foi criado um arquivo JSON, já com o usuário ADMIN e senha 12345
  
  </br>
  <img src="https://user-images.githubusercontent.com/99727468/214079189-7e562f27-c2b3-4ae2-9add-0a1945fc36a8.png"/>
  
</p>

</br>

<p align="center">
  Após fazer Login com o Admin, será disponibilizado uma interface do hub de jogos para cadastrar o jogador 1 e o jogador 2 para ambos poderem jogar o que há de disponível no hub de jogos
  
  </br>
  <img src="https://user-images.githubusercontent.com/99727468/214080587-ff12e2b2-bcba-47bb-baaa-6cb3457f84c9.png"/>
  
</p>

</br></br>



<h3 align="center"> 
  Como movimentar as peças:
</h3>


</br>


<p align="center">
   Os jogadores devem realizar a movimentação escolhendo uma coluna e uma linha especifica para pegar a peça atual do tabuleiro, e tentar deslocar para casas próximas ao inimigo, fornecendo números no intervalo de [0-7]
  
  </br>
  <img src="https://user-images.githubusercontent.com/99727468/214081285-87fda56b-f1d8-4910-bf3d-f60deb558bb9.png"/>
  
</p>


</br></br>


<h3 align="center">
    Tecnologias utilizadas 🛠 <br>
<h3/>

<p align="center">
  <img src="https://user-images.githubusercontent.com/99727468/214086465-ea2c08c1-1ec9-409e-9a92-b316caa23549.png"/>
</p>


</br></br></br>

### Features ✅

- [x] Validação do input do ADMIN (usuario/senha)
- [x] As peças Peão, Torre, Cavalo, Bispo, Rainha e Rei se movem corretamente no tabuleiro
- [x] Movimento En Passant com os peões
- [x] Não deixar o usuário fazer inputs com intervalos acima de [0-7] ou [-0]
- [x] Não deixar o peão comer peças assim que se move pra frente
- [x] Não deixar o usuário pegar uma peça da cor diferente dele para jogar no turno atual (Jogar como se fosse o jogador adversário)
- [x] Mostrar pontuação dos jogadores em tempo real com as peças capturadas



### 🔴 Problemas atuais e Features incompletas
- [ ] As peças Peão,Torre, Cavalo, Bispo, Rainha e Rei se movem corretamente no tabuleiro, mas elas podem sair da matriz [0,0] e pular direto pra matriz do adeversário mesmo que os peões enfileirados estejam barrando o caminho".
- [ ] O movimento Promoção de peão ainda não foi testado
- [ ] O movimento En Passant pode ocorrer em qualquer casa, precisa definir um limite de casa na matriz pro movimento ocorrer
- [ ] As peças Torre, Cavalo, Rainha e Rei comem as peças simplesmente se a peça inimiga tiver na matriz, exemplo: se eu fizer o movimento de L do cavalo, e a peça inimiga tiver onde o cavalo vai ficar, automaticamente a peça inimiga é pega, porém, se a peça inimiga tivesse uma casa pra frente ou pra baixo, o cavalo ou qualquer outra peça não conseguiria pegar, então um dos problemas é que eu só estou conseguindo pegar a peça, se a coluna de destino e a linha de destino forem iguais a peça adversária
- [ ] Checkmate no rei só funciona nas peças Peão e Bispo que é onde eu foquei mais, por serem movimentos mais complexos
- [ ] Persistência dos dados poderia ser melhor
