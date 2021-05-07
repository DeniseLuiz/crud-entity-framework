#CRUD Operation with Entity Framework Core

> .NET Core 3.1<br>
> Web API Application.<br>

## 💻 Conceitos :
<br>

- [x] SQL; 
- [X] DbContecxt;
- [X] System.ComponentModel.DataAnnotations;
- [X] lambda;
- [X] config appsettings.json;
- [X] config startup;

___________________________________________________________________________________________________________________________________________
  ## 💻 SQL:<br>
 ```
 CREATE TABLE [Employees](
[Id] [int] IDENTITY(1,1) NOT NULL,
[FistName] [varchar](50) NOT NULL,
[LastName] [varchar](50) NOT NULL,
[Email] [varchar](50) NOT NULL,
[City] [varchar](50) NOT NULL,
[Salary] [decimal] NOT NULL,

PRIMARY KEY CLUSTERED([Id] ASC)
)
```
  

