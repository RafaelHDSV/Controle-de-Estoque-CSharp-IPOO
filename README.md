# Controle-de-Estoque-CSharp-IPOO

![C# language](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![Visual Studio 2022](https://img.shields.io/badge/Visual_Studio-5C2D91?style=for-the-badge&logo=visual%20studio&logoColor=white)
![GitHub language count](https://img.shields.io/github/languages/count/RafaelHDSV/Controle-de-Estoque-CSharp-IPOO?style=for-the-badge)
![GitHub repo size](https://img.shields.io/github/repo-size/RafaelHDSV/Controle-de-Estoque-CSharp-IPOO?style=for-the-badge)

![image](https://github.com/user-attachments/assets/65e62124-89b2-4ef5-ac33-e629db5cfa2f)

<p align="center">
    <a href="#about">Sobre |</a> 
    <a href="#started">Como inicializar</a> 
    <a href="#routes">| Rotas da aplicação</a> 
    <a href="#images">| Imagens</a> 
</p>

<h2 id="about">📌 Sobre</h2>

Esse projeto é um controle de estoque utilizando `C#` e `Windows Form`. Não existe nenhum banco de dados vinculado a aplicação, então os dados inseridos no sistema serão perdidos quando o sistema for fechado / reiniciado. É possível adicionar produtos, consultar todos os produtos cadastrados e controlar os produtos já cadastrados, ou seja, é possível adicionar ou remover uma quantidade definida em um produto já cadastrado anteriormente. 

<h2 id="started">🚀 Como inicializar</h2>

Para inicializar o projeto, é necessário clonar o repositório para ter acesso a todo o código e interfaces. Feito isso é necessário abrir o `Visual Studio 2022` e rodar a aplicação.

<h3>Clonando</h3>

```bash
git clone https://github.com/RafaelHDSV/Controle-de-Estoque-CSharp-IPOO.git
```

<h3>Iniciando</h3>

```bash
cd Controle-de-Estoque-CSharp-IPOO
```

<h2 id="routes">📍 Rotas da aplicação</h2>

Existem 4 principais rotas no sistema:
​
| arquivo | descrição  
|----------------------|-----------------------------------------------------
| <kbd>frmPrincipal</kbd> | Tela inicial (MDI Container)
| <kbd>frmConsulta</kbd> | Tela para consultar os produtos
| <kbd>frmCadastro</kbd> | Tela para cadastrar os produtos
| <kbd>frmControle</kbd> | Tela para controlar os produtos (adicionar e remover)

<!-- | <kbd>/movie</kbd> | page to get more detailed information about the selected film -->
<!-- | <kbd>/user</kbd> | page to select the user icon -->
<!-- | <kbd>/_error_</kbd> | page when the route does not exist or is not found -->

### <kbd>frmPrincipal</kbd>
Nessa tela existe um MdiContainer com um menuString com 3 opções (Cadastro de Produto, Controle de Produto e Consulta de Produto). Pelo fato de ser um MdiContainer as telas existentes são abertas dentro desse formulário principal.

### <kbd>frmConsulta</kbd>
Nessa tela existe uma tabela simples com todas os produtos já cadastrados, com as colunas: id, name, type, quantity e supplier. Essa tela não é muito complexo, mas é importante ressaltar que existe uma lógica de reenderização da tabela, para que quando seja cadastrado e / ou atualizado um produto, a tabela se atualize automaticamente.

### <kbd>frmCadastro</kbd>
Nessa tela existe um formulário para que seja possível o cadastro de um produto, com os inputs: nome, tipo, quantidade e fornecedor. O input de quantidade é um select com opções já predefinidas anteriormente, mas pode ser alterado a qualquer momento pelo código. Clicando no botão de cadastrar, ocorre o cadastro do produto, isso se não existir nenhuma incongruência nos valores.

### <kbd>frmControle</kbd>
Nessa tela existe dois formulários, um para entradas e outro para saídas. Neles existem 3 inputs: id, nome e quantidade. Com isso é possível adicionar ou remover uma quantidade determinada de um produto já cadastrado e para acessar esse produto pode ser pesquisado por id ou pelo nome do produto. Também existe uma lógica para que não haja nenhum valor incorreto ou algum erro nessa tela, como por exemplo decrementar um produto com a `quantidade <= 0`.

<h2 id="images">📷 Imagens</h2>

### arquivo: <kbd>frmPrincipal</kbd>

![image](https://github.com/user-attachments/assets/c8de49e0-82cb-4c25-9db6-da265b97bfc4)
![image](https://github.com/user-attachments/assets/65e62124-89b2-4ef5-ac33-e629db5cfa2f)

<hr/>

### arquivo: <kbd>frmConsulta</kbd>

![image](https://github.com/user-attachments/assets/664ff044-b47f-4287-9ebf-fa5320e0df15)

<hr/>

### arquivo: <kbd>frmCadastro</kbd>

![image](https://github.com/user-attachments/assets/77b37916-c468-4cf7-b359-9f3642558d23)

<hr/>

### arquivo: <kbd>frmCadastro (Opções do Select)</kbd>

![image](https://github.com/user-attachments/assets/161d0242-17da-41fb-bcb4-8de2ef1413f9)

<hr/>

### arquivo: <kbd>frmControle</kbd>

![image](https://github.com/user-attachments/assets/c8f3a088-a82b-49e0-ae89-f1a28f41bed9)
