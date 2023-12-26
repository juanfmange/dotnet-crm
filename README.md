# dotnet-crm

## Instrucciones

Para poder hacer el scaffold para el db first, ingresar el sigueinte comando

- dotnet ef dbcontext scaffold '[Conection String]' Microsoft.EntityFrameworkCore.SqlServer -o [ruta donde se hara la migracion]

Para cuando se agregue una nueva columna a la base de datos 

- dotnet ef dbcontext scaffold '[Conection string]' Microsoft.EntityFrameworkCore.SqlServer -o [ruta donde se hara la migracion] --force


