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
Configurações necessárias para conexão com o DB:
> No arquivo appsettings.json:<br>

```
"ConnectionStrings": { "EmployeerDB": "Server=xxxxxx;User Id=sa;password=xxxxxx;Database=EmployeerDB;Trusted_Connection=True;"
  }
```
>No arquivo Startup.cs:<br>
```
services.AddDbContextPool<EmployeeContext>(
      options => options.UseSqlServer(Configuration.GetConnectionString("ConnectionStrings")));
services.AddScoped<IEmployeeService, EmployeeService>();
```

  

