### Pasos para crear su proyecto

## 1. Crear Proyecto

dotnet new mvc --auth Individual

## 2. Git init

git init

## 3. add .ignore

obj/
bin/

## 4. git config

git config user.name "SU NOMBRE"
git config user.email "SU CORREO"

## 5. dotnet EF

dotnet tool install --global dotnet-ef

## 6. Indicando donde va la migracion

dotnet ef migrations add <PASO DE MIGRACION> --context <applicativo>.Data.ApplicationDbContext -o "<RUTA DEL APLICATIVO>\Data\Migrations"

eg.

dotnet ef migrations add MigracionInicial --context app2game.Data.ApplicationDbContext -o "C:\opt\code\net\app2game\Data\Migrations"

dotnet ef database update

## opcional para rollback

dotnet ef migrations remove

## migraciones con portgress

dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL --version 8.0.4

## opcional

dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 8.0.8


## como editar las paginas del framework (login, registrar, forgot password)

csproj

<PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="8.0.8" />
<PackageReference Include="Microsoft.VisualStudio.Web.CodeGeneration.Design" Version="8.0.5" />

dotnet restore

dotnet tool install --global dotnet-aspnet-codegenerator --version 8.0.5

dotnet aspnet-codegenerator identity -dc <APPLICATION>.Data.ApplicationDbContext --files "Account.Register;Account.Login"

eg.
dotnet aspnet-codegenerator identity -dc app2game.Data.ApplicationDbContext --files "Account.Register;Account.Login"

dotnet aspnet-codegenerator identity -dc app2game.Data.ApplicationDbContext --files "Account.ForgotPassword;Account.ConfirmEmail"

Account.ForgotPassword: Página para solicitar un correo de recuperación de contraseña.
Account.ResetPassword: Página para restablecer la contraseña usando el enlace enviado al correo.
Account.ConfirmEmail: Página para confirmar la dirección de correo electrónico después del registro.
Account.AccessDenied: Página que muestra cuando un usuario intenta acceder a un recurso restringido.
Account.ExternalLogin: Página para manejar logins externos, como Google, Facebook, etc.
Account.Manage: Página para que los usuarios administren su cuenta (cambiar contraseña, etc.).
Account.Logout: Acción para cerrar sesión.
Account.Lockout: Página que muestra cuando una cuenta ha sido bloqueada.