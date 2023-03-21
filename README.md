# Projeto_3

# Descrição Geral do Projeto

Este projeto consiste no desenvolvimento de um jogo bullet hell destinado primariamente à plataforma PC. O objetivo é desenvolver um jogo que, ao mesmo tempo que possa ser jogado casualmente, possa ser jogado competitivamente e ofereça uma mecânica divertida na qual os jogadores podem explorar uma grande variedade de formas de se defender e derrotar seus inimigos.

![Capa do jogo](./docs/images/capa-game.jpg)

# Sobre o Jogo

O jogador se encontrará na base de uma torre que ele deve subir invocando suas plataformas elementais, uma opção multijogador permitirá que até 3 jogadores se enfrentem enquanto sobem a torre. O objetivo é sobreviver e chegar ao final da torre, no modo multiplayer o último jogador restante vence mas ele ainda poderá tentar chegar ao final da torre para garantir uma pontuação extra.

O mapa e os inimigos serão desenvolvidos de modo a permitir jogadas estratégicas para os jogadores ao defender e atacar seus inimigos, em algumas fases uma combinação errada de elementos poderá custar a vida dos jogadores proporcionando-lhes um desafio para balancear tanto maestria quanto táticas.

![Gameplay 1](./docs/images/gameplay1.png)
![Gameplay 2](./docs/images/gameplay2.png)

---

## Visão geral da arquitetura

![Comunicação entre sistemas](docs/images/Comunicacao_Sistemas.drawio.png)

O Projeto irá utilizar-se de sistemas como componentes de GameObjects na plataforma Unity. Esses sistemas se comunicarão entre si seguindo o esquema acima por meio de eventos direcionados.

# Relacionamento de branches

- **Branch main**
A main será a versão mais estável e funcional do projeto.

- **Branch develop**
Esta branch irá aglomerar todas as modificações realizadas durante o desenvolvimento de novas tarefas e features, ela deve ser organizada antes de seu conteúdo ser enviado à **main**.

- **Branches criadas a partir da develop**
Branches de trabalho, onde os desenvolvedores irão realizar commits. Quando um trabalho for finalizado, seu conteúdo deve ser enviado à branch **develop**.

# Construíndo e desenvolvendo o projeto

### Desenvolvimento de tarefas
1. Criar uma **branch** nova a partir da **develop**.
2. Nomear a branch de acordo com a tarefa que será desenvolvida.
3. Desenvolver a tarefa em sua branch com diversos commits pequenos e bem definidos.
4. Ao finalizar o desenvolvimento, criar um **Pull Request (PR)** da branch para a **develop**.
5. Espere a aprovação do PR e verifique se suas mudanças foram aplicadas à branch **develop**.
6. Delete sua branch local.

### Atualização da branch desatualizada
Acesse a pasta raiz do seu repositório local na branch que deseja-se atualizar. Para uma branch qualquer {branch} na qual a sua está desatualizada em relação, execute o comando:
```git
git fetch
git rebase origin/{branch}
git push
```

# Estrutura de diretórios

O repositório deste projeto está estruturado como o modelo a seguir:

| Arquivo / Diretório                    | Conteúdos                                                                           |
| -------------------------------------- | ---------------------------------------------------------------------------------- |
| `Assets/`                              | Recursos gerais do jogo incluindo scripts, arte e sons |
| `docs/`                                | Documentos como diagramas e imagens |
| `Packages/`                            | Contém o arquivo manifest utilizado para manter os links de dependência entre pacotes, além de um arquivo listando pacotes individuais instalados no projeto |
| `ProjectSettings/`                     | Armazena todas as configurações do projeto |
| `README.md`                            | Este arquivo |
