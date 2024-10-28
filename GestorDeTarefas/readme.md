


### **## Gest�o de Tarefas Simples com ASP.NET Core MVC, Scaffolding, MySQL e Entity Framework**

#### **1. Introdu��o**

Este projeto apresenta uma aplica��o web simples para gerenciar tarefas, desenvolvida utilizando ASP.NET Core MVC, Scaffolding e MySQL. O Entity Framework Core foi utilizado para facilitar a intera��o com o banco de dados, proporcionando um mapeamento objeto-relacional eficiente. As principais funcionalidades incluem cria��o, edi��o, exclus�o e listagem de tarefas.

#### **2. Pr�-requisitos**

-   **.NET 8 SDK:** Instale o .NET 8 SDK em [https://dotnet.microsoft.com/download]
-   **MySQL 8.0.41:** Baixe e instale o MySQL em [https://dev.mysql.com/downloads/]
-   **Ambiente de desenvolvimento:** Visual Studio ou Visual Studio Code com as extens�es necess�rias para desenvolvimento ASP.NET Core.

#### **3. Instala��o e Configura��o**

1.  **Clone o reposit�rio:** `git clone https://github.com/julianofsz/gestordetarefasdotnet.git`
2.  **Restaure os pacotes NuGet:** `dotnet restore`
3.  **Configure a string de conex�o:** Edite o arquivo `appsettings.json` para configurar a conex�o com o banco de dados MySQL.

<!-- end list -->

#### **4. Execu��o**

`dotnet run`

#### **5. Estrutura do Projeto**

-   **Models:** Representam as entidades do dom�nio (Tarefa, por exemplo) e s�o mapeadas para as tabelas do banco de dados atrav�s do Entity Framework Core.
-   **TarefaContexto:** Define o contexto do banco de dados, respons�vel por todas as opera��es de acesso aos dados, como consultas, inser��es, atualiza��es e exclus�es.
-   **Controllers:** Controlam as a��es do usu�rio e interagem com o DbContext para realizar opera��es no banco de dados.
-   **Views:** Apresentam os dados ao usu�rio atrav�s de p�ginas HTML.



#### **6. Contribui��es**

-   **Como contribuir:** Este projeto � de um iniciante na �rea, qualquer sugest�o � 100% bem-vinda.

**## Muito obrigado pela sua aten��o :D**