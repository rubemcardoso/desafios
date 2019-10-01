# TODO MEI Fácil

Neste desafio você precisará implementar um mini aplicativo de TODO List.

## ReactJS - Parte 1

Utilize o seguinte trecho de código para implementar um componente simples que funcione com a API que será desenvolvida.

*DICA:* Utilize o comando `create-react-app` para criar uma nova aplicação.

```js
// Faça a importação do React
import './App.css'
// Faça a importação do Botão
class App extends Component {
  state = {
    todo_text: '',
    todos : []
  }
  add = () => { /* adiciona um item na lista, chamando a api */ }
  removeItem = (item) => { /* remove um ítem da lista (passado por parametro) na api */ }
  loadItems = () => { /* obtém os itens de uma api */ }
  handleChange = (e) => { /* definição do método handleChange */ }
  componentDidMount(){ /* implementar */ }
  render(){
    return <>
        <h1>TODOS</h1>
        <ul><!-- imprima os elementos da lista --></ul>
        <input type="text" id="todo_text" value={this.state.todo_text} placeholder="digite o todo" onChange={this.handleChange}/>
        <MyButton value="Adicionar" onClick={this.add} />
      </>
  }
}
export default App
```

Lembre-se de implementar as seguintes regras:

- ligar a alteração `onCHange` do `input`com o atributo `state.todo_text`;
- antes de adicionar um novo elemento, verificar se existe algo preenchido em `state.todo_text`, e adicionar somente se existir um valor preenchido;
- ao adicionar/remover um novo elemento, invocar a dunção `loadItems()` para atualizar a lista de itens;
- ao mostrar cada elemento, lembrar de considerar uma forma de excluir o item em questão chamando a função `removeItem(item)`;
- note que `<MyButton>` é um componente que deve ser importado e também implementado;

# NodeJS - Parte 2

Crie uma API em NodeJS utilizando express para responder as chamadas implementadas na sessão anterior.

Resumidamente:

- `POST` em `http://localhost:888/todos` criar um novo item;
- `GET` em `http://localhost:888/todos` retorna os ítens cadastrados;
- `DELETE` em `http://localhost:888/todos/:id` exclui um ítem;

# Armazenamento

Utilize um banco de dados SQLServer para armazenar os dados.

# Bônus

Como desafio complementar:

- Criar um docker-compose.yml para subir uma instância do banco SQLServer;
- Criar categorias para os TODO's;

# Prazo

Temos 3 dias a partir do envio do teste.

# Entrega

Realize um PULL-REQUEST neste repositório com a sua solução.