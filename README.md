# CleanArchitecture Project

This project implements the Clean Architecture principles to create a flexible, testable, and maintainable application. The project is structured into several layers, ensuring independence and modularity.

## Project Structure

- **CleanArchitecture.Application**
  - Contains business logic and application services.
  - Packages: MediatR, AutoMapper, FluentValidation

- **CleanArchitecture.Domain**
  - Contains core entities and domain services.

- **CleanArchitecture.Identity**
  - Handles authentication and authorization.
  - Integrates with Keycloak for OpenID Connect.
  - Packages: Microsoft.AspNetCore.Authentication.OpenIdConnect, Microsoft.AspNetCore.OpenApi, Microsoft.IdentityModel.Protocols.OpenIdConnect, Swashbuckle.AspNetCore

- **CleanArchitecture.Infrastructure**
  - Contains infrastructure services.

- **CleanArchitecture.Persistence**
  - Manages database operations and Entity Framework Core configurations.
  - Uses MySQL database.
  - Packages: Microsoft.EntityFrameworkCore.Design, MySql.EntityFrameworkCore

- **CleanArchitecture.Shared**
  - Contains shared code and utilities.

- **CleanArchitecture.WebAPI**
  - Provides the API layer of the application.
  - Supports Swagger documentation.
  - Packages: MediatR, Microsoft.AspNetCore.Authentication.JwtBearer, Swashbuckle.AspNetCore

## How to Run

1. **Clone the Project and Restore Dependencies**
    ```sh
    git clone https://github.com/caner-aras/CleanArchitecture.git
    cd CleanArchitecture
    dotnet restore
    ```

2. **Set Up the Database with Migrations**
    ```sh
    cd CleanArchitecture.Persistence
    dotnet ef migrations add InitialCommitApplication --context ApplicationDbContext -o Migrations/Application --startup-project ../CleanArchitecture.WebAPI
    dotnet ef database update --context ApplicationDbContext --startup-project ../CleanArchitecture.WebAPI
    ```

3. **Run the Application**
    - Run each project in separate terminals:
        ```sh
        dotnet run --project CleanArchitecture.WebAPI     
        dotnet run --project CleanArchitecture.Identity    
        ```

4. **Access Swagger UI**
    - Web API: `http://localhost:5079/swagger`
    - Identity API: `http://localhost:5095/swagger`

By following these steps, you can run and develop the CleanArchitecture project effectively.
