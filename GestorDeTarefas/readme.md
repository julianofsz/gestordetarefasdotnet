


### **## Gestão de Tarefas Simples com ASP.NET Core MVC, Scaffolding, MySQL e Entity Framework**

#### **1. Introdução**

Este projeto apresenta uma aplicação web simples para gerenciar tarefas, desenvolvida utilizando ASP.NET Core MVC, Scaffolding e MySQL. O Entity Framework Core foi utilizado para facilitar a interação com o banco de dados, proporcionando um mapeamento objeto-relacional eficiente. As principais funcionalidades incluem criação, edição, exclusão e listagem de tarefas.

#### **2. Pré-requisitos**

-   **.NET 8 SDK:** Instale o .NET 8 SDK em [https://dotnet.microsoft.com/download]
-   **MySQL 8.0.41:** Baixe e instale o MySQL em [https://dev.mysql.com/downloads/]
-   **Ambiente de desenvolvimento:** Visual Studio ou Visual Studio Code com as extensões necessárias para desenvolvimento ASP.NET Core.

#### **3. Instalação e Configuração**

1.  **Clone o repositório:** `git clone https://github.com/julianofsz/gestordetarefasdotnet.git`
2.  **Restaure os pacotes NuGet:** `dotnet restore`
3.  **Configure a string de conexão:** Edite o arquivo `appsettings.json` para configurar a conexão com o banco de dados MySQL.

<!-- end list -->

#### **4. Execução**

`dotnet run`

#### **5. Estrutura do Projeto**

-   **Models:** Representam as entidades do domínio (Tarefa, por exemplo) e são mapeadas para as tabelas do banco de dados através do Entity Framework Core.
-   **TarefaContexto:** Define o contexto do banco de dados, responsável por todas as operações de acesso aos dados, como consultas, inserções, atualizações e exclusões.
-   **Controllers:** Controlam as ações do usuário e interagem com o DbContext para realizar operações no banco de dados.
-   **Views:** Apresentam os dados ao usuário através de páginas HTML.



#### **6. Contribuições**

-   **Como contribuir:** Este projeto é de um iniciante na área, qualquer sugestão é 100% bem-vinda.

**## Muito obrigado pela sua atenção :D**