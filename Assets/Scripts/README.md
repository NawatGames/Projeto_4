# Padrões de escrita para o desenvolvimento do código

- O código deve ser desenvolvido inteiramente em inglês, tanto com nome de variáveis quanto o de arquivos

| Tipo                     | Padrão e exemplo      |
| -------------------------|-----------------------|
| `Classes`                | **Pascal Case**, ex: MyClass |
| `Variáveis públicas ou serializadas`                | **Camel Case**, ex: variableName |
| `Variáveis privadas`                | **Camel Case** com "_" de prefixo, ex: _variableName |
| `Métodos`                | **Pascal Case**, ex: MyFunction |
| `UnityEvent`                | **Camel Case** com "Event" de sufixo, ex: changedLifeEvent |
| `Função de conexão de eventos`                | **Pascal Case** com "On" de sufixo, ex: OnLifeChange |
| `Structs`                | **Pascal Case**, ex: MyStruct |
| `Enums`                | **Pascal Case**, ex: MyEnum |
| `Flags`                | **Pascal Case** com "Flag" de sufixo, ex: DamageEventFlag |
| `Courotines`                | **Pascal Case** com "Routine" de sufixo, ex: DelayRotine |
| `ScriptableObjects`                | **Pascal Case** com "SO" de sufixo, ex: NotebookSO |
| `MonoBehaviour - envolva e seja interface de outro componente`                | **Pascal Case** com "Controller" de sufixo, ex: PlayerMovementControler |
| `MonoBehaviour - que instancia outros GameObjects ou Prefabs`                | **Pascal Case** com "Generator" de sufixo, ex: BulletGenerator |

# Estrutura de Diretórios

A estrutura de diretórios dos Scripts segue o seguinte padrão:
`<Nome Sistema>/<Nome Subsistema>/`

Exemplos:
```
EventSystem/
StatemachineSystem/Animations
StatemachineSystem/Animations/GameManagerSystem/DeathScreen
```
