# ReactRicardo
Implementação de um controle de tarefas simples utilizando React + Asp.Net MVC + Entity Framework

O repositório em questão possui uma Solution do Microsoft Visual Studio 2017 com 4 projetos:

ReactDemo.Comum - Projeto que contém enumeradores utilizados nos demais projetos e o gerenciador do repositório de dlls.
ReactDemo.Negocios.Componentes - Projeto que contém o gerenciamento da fábrica de instâncias e as classes de fluxo, que são responsáveis pelos métodos que comunicam com o projeto ReactDemo.Negocios.Entidades para buscar os dados do banco.
ReactDemo.Negocios.Entidades - Projeto que contém as classes de entidade e o mapeamento para utilização o Entity Framework.
ReactDemo - Contém a interface do projeto, o código React.

Para execução do projeto são necessários os seguintes softwares: 
  Microsoft Visual Studio 2015 / 2017 com o MVC instalado.
  Microsoft Sql Server 2014.
  
Tendo os softwares supracitados instalados e o projeto armazenado em um repositório local, os passos seguintes são:

1 - Restaurando banco de dados
  1.1 - Navegue até o repositório local no qual encontra-se o projeto e obtenha o arquivo script.bak. Este arquivo deve ser restaurado em um banco de dados sql server para a criação da base de dados BDTarefas.
  
2 - Abrindo o projeto no Microsoft Visual Studio
  2.1 - Navegue até o repositório local no qual encontra-se o projeto.
  1.1 - Abra a pasta ReactDemo e execute o arquivo ReactDemo.sln. Será aberta a solução no visual studio.
  
3 - Defina o projeto ReactDemo como Projeto de inicialização.

4 - Execute o programa.

O programa será executado e será aberta tela contendo as tarefas em aberto e as tarefas finalizadas.
Junto com o parte de tarefas em aberto, existe a possibilidade de inserção de novas tarefas. Basta digitar o nome da mesma e clicar em post.
Para que uma tarefa sejá finalizada, basta marcá-la e clicar em finalizar.
