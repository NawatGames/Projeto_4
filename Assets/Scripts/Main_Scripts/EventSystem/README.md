# Sistema de eventos

O sistema de eventos consiste em dois agentes: O emissor do evento e o recebedor. O canal entre os dois agentes é um scriptable object, que representa o evento em si.

## Resumo de como o sistema funciona na prática

### Gameobject receber um evento
Caso você deseja que um gameobject receba um evento e, com isso, chame uma função ou uma série de funções, basta adicionar à ele o script GameEventListener

![image](https://user-images.githubusercontent.com/46378322/201204407-7d8034d2-0f2e-45b3-98d8-b57b2b3d2dca.png)

Neste componente, como pode-se observar na foto, possui dois campos, um para o evento que o gameobject irá receber e o outro é um UnityEvent que dirá quais funções serão chamadas quando tal evento for disparado.

#### Exemplo
![image](https://user-images.githubusercontent.com/46378322/201204776-e7113d3a-fc1d-4c87-ab55-986a0c00b133.png)

Exemplo: Digamos que você queira que um gameobject em questão seja desativado quando o evento de morte do player for disparado. Então, você faria como a imagem acima

### Gameobject emitir um evento

Para emitir um evento, infelizmente não possuimos nenhuma maneira de fazer isso sem que o código fique acoplado ao sistema de eventos. Portanto para emitir um evento, é necessário criar um field que receba um SOGameEvent (um scriptable object que representa o evento) e com isso emitir o evento quando desejar.

#### Exemplo

Digamos que você tem um script responsável por manipular a vida de algo e você deseja emitir eventos conforme esse valor vai se alterando. Seria necessário fazer algo assim:

![image](https://user-images.githubusercontent.com/46378322/201206540-2a64f23c-9e62-478e-aea3-6e15e95087ca.png)
![image](https://user-images.githubusercontent.com/46378322/201206880-051cd093-5b33-40f1-bd97-e9e729bc9f93.png)

