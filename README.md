# KonnyWebApi
inicio de proyecto


# parte 0

git clone https://github.com/konnylisethalucematorresCAMPUS/KonnyWebApi.git

# parte 1

   - dotnet new sln   

   - dotnet new classlib -o Dominio  

   - dotnet new classlib -o Persistencia  

   - dotnet new classlib -o Aplicacion  

   - dotnet new webapi -o ApiIncidencias  

   - dir  

# parte 2

    
   - dotnet sln add Dominio  

   - dotnet sln add Persistencia 

   - dotnet sln add Aplicacion 

   - dotnet sln add ApiIncidencias  

   - dir  

# parte 3

   - cd Aplicacion  

	   - dotnet add reference ../Dominio/  

	   - dotnet add reference ../Persistencia/  

   - cd ..  

   - cd ApiIncidencias  
   
	   - dotnet add reference ../Aplicacion/  

   - cd ..  

   - cd Persistencia  

	   - dotnet add reference ../Dominio/  

   - cd ..   
# parte 4


# herramientas 

# esto va en la carpeta Dominio

   - **EntityFrameworkCore =>**  
    - cd Dominio  
    - dotnet add package Microsoft.EntityFrameworkCore --version 7.0.10  

   - **FluentValidation.AspNetCore**  
    - dotnet add package FluentValidation.AspNetCore --version 11.3.0  

   - **itext7.pdfhtml**  
     - dotnet add package itext7.pdfhtml --version 5.0.1  

   - cd ..  

# esto va en la carpeta Persistencia  

   - **EntityFrameworkCore**  
    - cd Persistencia  
    - dotnet add package Microsoft.EntityFrameworkCore --version 7.0.10   

    - **Pomelo.EntityFrameworkCore.MySql**  
    - dotnet add package Pomelo.EntityFrameworkCore.MySql --version 7.0.0  

   - cd ..  

# esto va en la carpeta DinoApi  

   - **Microsoft.AspNetCore.Authentication.JwtBearer**  
    - cd ApiIncidencias  
    - dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer --version 7.0.10  


